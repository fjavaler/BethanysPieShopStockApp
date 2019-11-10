using System;
using System.ComponentModel;
using System.Text;

namespace BethanysPieShopStockApp.Model
{
  /// <summary>
  /// This class represents a pie object.
  /// </summary>
  public class Pie: INotifyPropertyChanged
  {
    /// <summary>
    /// Backing fields. All methods in this class work with the backing fields.
    /// </summary>
    private int _id;
    private string _pieName;
    private double _price;

    /// <summary>
    /// The Id property.
    /// </summary>
    public int Id
    {
      get => _id;
      set
      {
        _id = value;
        OnPropertyChanged(nameof(Id));
      }
    }

    /// <summary>
    /// The pie name property.
    /// </summary>
    public String PieName
    {
      get => _pieName;
      set
      {
        _pieName = value;
        OnPropertyChanged(nameof(PieName));
      }
    }

    /// <summary>
    /// The price property.
    /// </summary>
    public double Price
    {
      get => _price;
      set
      {
        _price = value;
        OnPropertyChanged(nameof(Price));
      }
    }

    /// <summary>
    /// The property changed event.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// This method executes any time the Id property is changed.
    /// </summary>
    /// <param name="propertyName">The property's name.</param>
    private void OnPropertyChanged(string propertyName)
    {
      // ? = If PropertyChanged is not null, perform invoke. Else, stop.
      // I.e. if (PropertyChanged != null).
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


  }
}