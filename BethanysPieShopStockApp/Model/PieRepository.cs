using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BethanysPieShopStockApp.Model
{
  public class PieRepository
  {
    public ObservableCollection<Pie> Collection { get; set; }
    string imageUrl = "https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg";

    public PieRepository()
    {
      SetupRepository();
    }

    private void SetupRepository()
    {
      if (Collection == null)
      {
        Collection = new ObservableCollection<Pie>()
        {
          new Pie
          {
            PieName = "Apple Pie",
            Price = 12.95,
            Description = "Blah, blah, blah",
            ImageUrl = imageUrl,
            AvailableFromDate = new DateTime(2018, 12, 1),
            InStock = false,
          },
          new Pie
          {
            PieName = "Strawberry Cheese Cake",
            Price = 18.95,
            Description = "Blah, blah, blah",
            ImageUrl = imageUrl,
            AvailableFromDate = new DateTime(2018, 12, 1),
            InStock = false,
          },
          new Pie
          {
            PieName = "Strawberry Pie",
            Price = 15.95,
            Description = "Blah, blah, blah",
            ImageUrl = imageUrl,
            AvailableFromDate = new DateTime(2018, 12, 1),
            InStock = true,
          },
          new Pie
          {
            PieName = "Rhubarb Pie",
            Price = 15.95,
            Description = "Blah, blah, blah",
            ImageUrl = imageUrl,
            AvailableFromDate = new DateTime(2018, 12, 1),
            InStock = true,
          },
          new Pie
          {
            PieName = "Blueberry Cheese Cake",
            Price = 18.95,
            Description = "Blah, blah, blah",
            ImageUrl = imageUrl,
            AvailableFromDate = new DateTime(2018, 12, 1),
            InStock = false,
          },
          new Pie
          {
            PieName = "Cheese Cake",
            Price = 18.95,
            Description = "Blah, blah, blah",
            ImageUrl = imageUrl,
            AvailableFromDate = new DateTime(2018, 12, 1),
            InStock = true,
          },
          new Pie
          {
            PieName = "Cherry Pie",
            Price = 15.95,
            Description = "Blah, blah, blah",
            ImageUrl = imageUrl,
            AvailableFromDate = new DateTime(2018, 12, 1),
            InStock = true,
          },
          new Pie
          {
            PieName = "Peach Pie",
            Price = 15.95,
            Description = "Blah, blah, blah",
            ImageUrl = imageUrl,
            AvailableFromDate = new DateTime(2018, 12, 1),
            InStock = false,
          },
        };
      }
    }
  }
}
