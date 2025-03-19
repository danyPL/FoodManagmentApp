using FoodManagmentApp.Model;
using FoodManagmentApp.Service;
using FoodManagmentApp.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace FoodManagmentApp.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Dish> Dishes { get; set; }
        public Command ShowDetailedCmd { get; }

        private readonly INavigation _navigation;
        private readonly DataService _dataService;
        public MainViewModel(DataService dataService, INavigation navigation)
        {
            _navigation = navigation;
            _dataService = dataService;

            Dishes = _dataService.Dishes;

            ShowDetailedCmd = new Command<Dish>(ShowDetails);
        }

        
        private async void ShowDetails(Dish dish)
        {
            if (dish != null)
                await _navigation.PushAsync(new EditPage(dish, _navigation));
        }
    }
}
