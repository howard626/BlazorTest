using Blazored.LocalStorage;
using BlazorTest.Models;
using BlazorTest.Utility;
using BlazorTestShared;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorTest.Auth
{
    public class TestAuthStateProvider : AuthenticationStateProvider
    {
        //public override Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
        //    //var claims = new List<Claim>()
        //    //{
        //    //    new Claim(ClaimTypes.Name,"Nick Fury"),
        //    //    new Claim(ClaimTypes.Role, "normal")
        //    //};

        //    //var anonymous = new ClaimsIdentity(claims, "testAuthType");
        //    var anonymous = new ClaimsIdentity();
        //    return Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
        //}

        private readonly ILocalStorageService localStorageService;
        private readonly HttpClient httpClient;

        private AuthenticationState anonymous = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

        public TestAuthStateProvider(ILocalStorageService localStorageService, HttpClient httpClient)
        {
            anonymous = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            this.localStorageService = localStorageService;
            this.httpClient = httpClient;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //確認localstorage裡面是否有token
            string tokenInLocalStorage = await localStorageService.GetItemAsStringAsync("authToken");
            if (string.IsNullOrEmpty(tokenInLocalStorage))
            {
                //沒有的話，回傳匿名使用者
                return anonymous;
            }
            //將token取出轉為claim
            var claims = JwtParser.ParseClaimsFromJwt(tokenInLocalStorage);

            //在每次request的header中帶入bearer token
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", tokenInLocalStorage);

            //回傳帶有user claim的AuthenticationState物件
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(claims, "user")));
        }

        public void NotifyUserAuthentication(string json)
        {
            var claims = JwtParser.ParseClaimsFromJwt(json);
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(claims, "user"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public void NotifyUserLogOut()
        {
            var authState = Task.FromResult(anonymous);
            NotifyAuthenticationStateChanged(authState);
        }

    }
}
