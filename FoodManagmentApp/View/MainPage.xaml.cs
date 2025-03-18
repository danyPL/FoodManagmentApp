using FoodManagmentApp.ViewModel;
namespace FoodManagmentApp.View
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(new Service.DataService(), Navigation);

        }


    }

}
