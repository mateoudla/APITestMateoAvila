using APITestMateoAvila.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITestMateoAvila.ViewModels;

namespace APITestMateoAvila.Views;

public partial class ListViewMA : ContentPage
{
    private SQLiteMA _userDB;
    public ListViewMA()
	{
		InitializeComponent();
        LoadData();
        _userDB = new SQLiteMA("datauser.db");

    }

    private async void LoadData()
    {
        List<UsersMA> users = await APIClientMA.GetUsers();
        userListView.ItemsSource = users;
    }

    private void userListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var selectedUser = e.Item as UsersMA;
        _userDB.Insert(selectedUser);
    }
}
