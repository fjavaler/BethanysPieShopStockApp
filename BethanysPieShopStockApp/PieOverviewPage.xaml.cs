using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
  public partial class PieOverviewPage : ContentPage
  {
    public List<string> Pies { get; set; }

    public PieOverviewPage()
    {
      InitializeComponent();

      Pies = new List<string>()
      {
        "Apple Pie",
        "Strawberry Cheese Cake",
        "Strawberry Pie",
        "Rhubarb Pie",
        "Blueberry Cheese Cake",
        "Cheese Cake",
        "Cherry Pie",
        "Christmas Apple Pie",
        "Cranberry Pie",
        "Peach Pie",
        "Pumpkin Pie",
      };

      PiesListView.ItemsSource = Pies;
    }
  }
}
