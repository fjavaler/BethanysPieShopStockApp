using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BethanysPieShopStockApp.Model;
using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

      //Pie pie = new Pie();
      //pie.Id = 1;
      //pie.PieName = "Cherry pie";
      //pie.Price = 20;

      //Binding pieNameBinding = new Binding();
      //pieNameBinding.Source = pie;
      //pieNameBinding.Path = "PieName";
      //NameEntry.SetBinding(Entry.TextProperty, pieNameBinding);

      //Binding piePriceBinding = new Binding();
      //piePriceBinding.Source = pie;
      //piePriceBinding.Path = "Price";
      //PriceEntry.SetBinding(Entry.TextProperty, piePriceBinding);
    }
  }
}