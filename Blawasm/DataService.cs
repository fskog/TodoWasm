using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blawasm.Models;
using Blazored.LocalStorage;

namespace Blawasm
{
    public class DataService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly AppState _appState;

        public DataService(ILocalStorageService localStorageService, AppState appState)
        {
            _localStorageService = localStorageService;
            _appState = appState;

            //if (_appState.TodoList == null)
            //{
            //    LoadLocalStorage();
            //}
        }


        public void SaveLocalStorage()
        {
            _localStorageService.SetItemAsync("TodoList", _appState.TodoList);
        }

        public async void LoadLocalStorage()
        {
            _appState.TodoList = _localStorageService.GetItemAsync<List<TodoItemModel>>("TodoList").Result;
        }
    }
}
