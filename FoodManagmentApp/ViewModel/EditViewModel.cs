using FoodManagmentApp.Model;
using FoodManagmentApp.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagmentApp.ViewModel
{
    class EditViewModel
    {
        public Dish SelectedDish { get; set; }
        public Command AddIngredientCmd { get; }

        private readonly INavigation _navigation;
        private readonly DataService _dataService;
        public EditViewModel(DataService dataService)
        {
            _dataService = dataService;

            SelectedDish = _dataService.SelectedDish;

            AddIngredientCmd = new Command<string>(AddIngredient);
        }


        private async void AddIngredient(string ingredient)
        {
            SelectedDish.AddIngredients(ingredient);
        }
    }
}
