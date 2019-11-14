using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BethanysPieShopStockApp.Model;
using BethanysPieShopStockApp.ViewModels;
using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
  /// <summary>
  /// Class.
  /// </summary>
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class MainPage : ContentPage
  {
    // Properties
    public Pie Pie { get; set; }
    public MainPageViewModel MainPageViewModel { get; set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    public MainPage()
    {
      InitializeComponent();

      MainPageViewModel = new MainPageViewModel()
      {
        Pie = new Pie
        {
          Id = 1,
          Description = "Blah blah blah",
          ImageUrl = "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwjgsJSZhuHlAhUGvJ4KHZaICFMQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.foodnetwork.com%2Frecipes%2Ffood-network-kitchen%2Fapple-pie-recipe-2011423&psig=AOvVaw1sQaERtaDfUGAI_LSU-R-W&ust=1573523543344626",
          InStock = true,
          AvailableFromDate = new DateTime(1981, 03, 14),
          PieName = "Apple Pie",
          Price = 20.95,
        },
        UserName = "Fred"
      };

      this.BindingContext = this;

      //CherryPie = new Pie();
      //CherryPie.Id = 1;
      //CherryPie.PieName = "Cherry pie";
      //CherryPie.Price = 20;

      //this.BindingContext = CherryPie;

      //Binding pieNameBinding = new Binding();
      //pieNameBinding.Source = pie;
      //pieNameBinding.Path = "PieName";
      //NameEntry.SetBinding(Entry.TextProperty, pieNameBinding);

      //Binding piePriceBinding = new Binding();
      //piePriceBinding.Source = pie;
      //piePriceBinding.Path = "Price";
      //PriceEntry.SetBinding(Entry.TextProperty, piePriceBinding);
    }

    //private void Button_Clicked(object sender, EventArgs eventArgs)
    //{
    //  CherryPie.Price++;
    //}

    private async void SavePieButton_ClickedAsync(object sender, EventArgs eventArgs)
    {
      await DisplayAlert("Success", "Pie saved", "Done");
    }
  }
}