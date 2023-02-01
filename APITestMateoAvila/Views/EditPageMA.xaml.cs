namespace APITestMateoAvila.Views;
using APITestMateoAvila.Models;
using APITestMateoAvila.ViewModels;

public partial class EditPageMA : ContentPage
{
    private UsersMA user;
    private SQLiteMA _userDB;

    public EditPageMA(UsersMA user)
    {
        InitializeComponent();
        BindingContext = this.user = user;
        _userDB = new SQLiteMA("datauser.db");

    }

    private async void Save_Clicked(object sender, EventArgs e)
    {
        user.FirstName = firstNameEntry.Text;
        user.LastName = lastNameEntry.Text;
        user.Email = emailEntry.Text;
        _userDB.Update(user);
        await Navigation.PopAsync();
    }
}
