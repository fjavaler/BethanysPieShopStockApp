using BethanysPieShopStockApp.Model;
using BethanysPieShopStockApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
  public partial class PieOverviewPage : ContentPage
  {
    public PieOverviewPage()
    {
      InitializeComponent();
    }

    private async void PiesListView_ItemTappedAsync(object sender, ItemTappedEventArgs e)
    {
      MainPage pieDetailPage = new MainPage(e.Item as Pie);
      MainPageViewModel pieDetailViewModel = new MainPageViewModel();
      pieDetailPage.BindingContext = pieDetailViewModel;

      await this.Navigation.PushAsync(pieDetailPage);
    }
  }
}
