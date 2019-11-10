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
  /// <summary>
  /// Class.
  /// </summary>
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class MainPage : ContentPage
  {
    // Fields
    public Pie CherryPie { get; set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    public MainPage()
    {
      InitializeComponent();

      CherryPie = new Pie();
      CherryPie.Id = 1;
      CherryPie.PieName = "Cherry pie";
      CherryPie.Price = 20;

      this.BindingContext = CherryPie;

      //Binding pieNameBinding = new Binding();
      //pieNameBinding.Source = pie;
      //pieNameBinding.Path = "PieName";
      //NameEntry.SetBinding(Entry.TextProperty, pieNameBinding);

      //Binding piePriceBinding = new Binding();
      //piePriceBinding.Source = pie;
      //piePriceBinding.Path = "Price";
      //PriceEntry.SetBinding(Entry.TextProperty, piePriceBinding);
    }

    private void Button_Clicked(object sender, EventArgs eventArgs)
    {
      CherryPie.Price++;
    }
  }
}