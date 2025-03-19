using FoodManagmentApp.Model;
using FoodManagmentApp.Service;

namespace FoodManagmentApp.View;

public partial class EditPage : ContentPage
{
    public Dish SelectedDish { get; set; }

    public EditPage(Dish dish)
	{
		InitializeComponent();
		BindingContext = dish;
        SelectedDish = dish;

    }
  
    public async void SaveEditDish(object sender, EventArgs e)
    {
        SelectedDish.SaveData(SelectedDish.Name, SelectedDish.Type, SelectedDish.Description, SelectedDish.Price, SelectedDish.Ingredients);
    }

    private void AddIngredient(object sender, EventArgs e)
    {
        SelectedDish.AddIngredients(Ing.Text);
    }
}