using Blazored.LocalStorage;
using BlazorTest.Models;
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
            //User user = (User)JsonConvert.DeserializeObject(tokenInLocalStorage);
            User user = new User();
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Name ?? ""),
                new Claim(ClaimTypes.Role, user.Role ?? "")
            };

            //httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", tokenInLocalStorage);

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(claims, "user")));
        }

        public void NotifyUserAuthentication(string json)
        {
            
            User user = JsonConvert.DeserializeObject<User>(json);

            if ("admin".Equals(user.Account))
            {
                user.Role = "Admin";
            }
            else
            {
                user.Role = "Role";
            }
            var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.Name ?? string.Empty),
                    new Claim(ClaimTypes.Role, user.Role ?? string.Empty)
                };
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
