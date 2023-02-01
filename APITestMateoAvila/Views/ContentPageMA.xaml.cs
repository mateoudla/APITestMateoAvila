using APITestMateoAvila.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITestMateoAvila.ViewModels;

namespace APITestMateoAvila.Views;

public partial class ContentPageMA : ContentPage
{
    private SQLiteMA _userDB;
    public ContentPageMA()
    {
        InitializeComponent();
        LoadData();
        _userDB = new SQLiteMA("datauser.db");
    }

    private void LoadData()
    {
        List<UsersMA> users = _userDB.GetAll();
        userListView.ItemsSource = users;
    }


    private async void DeleteUser(object sender, EventArgs e)
    {
        var button = sender as Button;
        var user = button.BindingContext as UsersMA;

        bool result = await DisplayAlert("Confirm Delete", "Are you sure you want to delete this user?", "Yes", "No");

        if (result)
        {
            _userDB.Delete(user);
            LoadData();
        }
    }
}
