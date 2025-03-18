using FoodManagmentApp.Model;
using FoodManagmentApp.Service;

namespace FoodManagmentApp.View;

public partial class EditPage : ContentPage
{
    public Dish SelectedDish { get; set; }
    public Command SaveCmd { get; }

    public EditPage(Dish dish)
	{
		InitializeComponent();
		BindingContext = dish;
        SelectedDish = dish;
        SaveCmd = new Command(SaveEditDish);

    }
  
    public async void SaveEditDish()
    {
        SelectedDish.SaveData(SelectedDish.Name, SelectedDish.Type, SelectedDish.Description, SelectedDish.Price, SelectedDish.Ingredients);
    }

    private void AddIngredient(object sender, EventArgs e)
    {
        SelectedDish.AddIngredients(Ing.Text);
    }
}