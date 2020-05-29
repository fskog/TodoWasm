using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Blawasm.Models;
using Blazored.LocalStorage;



namespace Blawasm
{
    public class AppState 
    {



        //public Lazy<List<TodoItemModel>> TodoList = new Lazy<List<TodoItemModel>>(
        //    () => return new List<TodoItemModel>(()));


        public List<TodoItemModel> TodoList = new List<TodoItemModel>();

        public bool TodoListInitialized = false;

        public List<Tuple<string, DateTime>> ChangeLog = new List<Tuple<string, DateTime>>()
        {
           //new (string, DateTime){"First version launched!", DateTime.Now}
           new Tuple<string, DateTime>("First version launched!", new DateTime(2020, 05,27, 18,00,00)),
           new Tuple<string, DateTime>("Added local saving of list.", new DateTime(2020, 05,27, 21,00,00)),
           new Tuple<string, DateTime>("PWA support: App can now be installed and run as stanadlone app!", new DateTime(2020, 05,28, 10,30,00)),
           new Tuple<string, DateTime>("Added ChangeLog page to view changes to the app.", new DateTime(2020, 05,28, 11,40,00)),
           new Tuple<string, DateTime>("Remove button: It's now possible to remove Todo items!", new DateTime(2020, 05,28, 12,17,00)),
           new Tuple<string, DateTime>("Added Settings page with features to force load from localstorage and to add example todo data for testing.", new DateTime(2020, 05,28, 17,15,00)),
           new Tuple<string, DateTime>("Added feature to edit title and description.", new DateTime(2020, 05,29, 11,15,00)),
           new Tuple<string, DateTime>("Improved styling for Todo list.", new DateTime(2020, 05,29, 11,45,00))

        };



        //{
        //    get
        //    {
        //        if (_todoList == null)
        //        {
        //            _todoList = LoadLocalStorage();
        //        }

        //        return _todoList;
        //    }
        //}

        //private List<TodoItemModel> _todoList;


        //public List<TodoItemModel> TodoList = new List<TodoItemModel>
        //{
        //    new TodoItemModel() {Title = "Call John C", Description = "John wants to chat a bit. Nr 070 9324283."},
        //    new TodoItemModel() {Title = "Prepare food", Description = "Prepare food before making dinner."},
        //    new TodoItemModel() {Title = "Cook dinner", Description = "Make dinner for 2."},
        //    new TodoItemModel() {Title = "Eat dinner", Description = "Make sure to drink the new wine."},
        //    new TodoItemModel() {Title = "Clean plates and wash up", Description = "Listen to some music while you clean!"},
        //    new TodoItemModel() {Title = "Watch TV", Description = "Watch some TV shows before bed."},
        //};

        //public void SaveLocalStorage(ILocalStorageService localStorageService)
        //{
        //    localStorageService.SetItemAsync("TodoList", TodoList);
        //}

        //public static List<TodoItemModel> LoadLocalStorage(ILocalStorageService localStorageService)
        //{
        //    return localStorageService.GetItemAsync<List<TodoItemModel>>("TodoList").Result;
        //}


    }
}
