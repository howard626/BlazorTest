using Blazored.LocalStorage;
using BlazorTest.Auth;
using BlazorTest.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.Service
{
    public class AuthService : IAuthService
    {
        private readonly ILocalStorageService localStorageService;
        private readonly HttpClient httpClient;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AuthService(ILocalStorageService localStorageService, HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider)
        {
            this.localStorageService = localStorageService;
            this.httpClient = httpClient;
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> LoginAsync(User userInfo)
        {
            bool result = false;
            bool 資料庫有資料 = true;
            if (string.IsNullOrWhiteSpace(userInfo.Account) || String.IsNullOrWhiteSpace(userInfo.Password))
                資料庫有資料 = false;

            if (資料庫有資料)
            {
                var json = JsonConvert.SerializeObject(userInfo);
                await localStorageService.SetItemAsync<string>("authToken", json);

                ((TestAuthStateProvider)authenticationStateProvider).NotifyUserAuthentication(json);

                result = true;
            }

            return result;
        }

        public async Task LogoutAsync()
        {
            await localStorageService.RemoveItemAsync("authToken");
            ((TestAuthStateProvider)authenticationStateProvider).NotifyUserLogOut();
            httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}
