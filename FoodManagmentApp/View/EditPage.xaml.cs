using FoodManagmentApp.Model;
using FoodManagmentApp.Service;

namespace FoodManagmentApp.View;

public partial class EditPage : ContentPage
{
    public Dish SelectedDish { get; set; }
    private readonly INavigation _navigation;

    public EditPage(Dish dish, INavigation navigation)
	{
		InitializeComponent();
		BindingContext = dish;
        SelectedDish = dish;
        _navigation = navigation;

    }
  
    public async void SaveEditDish(object sender, EventArgs e)
    {
        SelectedDish.SaveData(SelectedDish.Name, SelectedDish.Type, SelectedDish.Description, SelectedDish.Price, SelectedDish.Ingredients);
        await _navigation.PushAsync(new MainPage());

    }

    private async void AddIngredient(object sender, EventArgs e)
    {
        SelectedDish.AddIngredients(Ing.Text);
    }
}