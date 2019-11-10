using System;
using System.ComponentModel;

namespace BethanysPieShopStockApp.Model
{
  public class Pie: INotifyPropertyChanged
  {
    public int Id { get; set; }

    public String PieName { get; set; }

    public double Price { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}