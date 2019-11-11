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
    private string _description;
    private double _price;
    private string _imageUrl;
    private bool _inStock;
    private DateTime _availableFromDate;

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
    /// The description property.
    /// </summary>
    public String Description
    {
      get => _description;
      set
      {
        _description = value;
        OnPropertyChanged(nameof(Description));
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
    /// The image URL property.
    /// </summary>
    public String ImageUrl
    {
      get => _imageUrl;
      set
      {
        _imageUrl = value;
        OnPropertyChanged(nameof(ImageUrl));
      }
    }

    /// <summary>
    /// The in stock property.
    /// </summary>
    public bool InStock
    {
      get => _inStock;
      set
      {
        _inStock = value;
        OnPropertyChanged(nameof(InStock));
      }
    }

    /// <summary>
    /// The available from property.
    /// </summary>
    public DateTime AvailableFromDate
    {
      get => _availableFromDate;
      set
      {
        _availableFromDate = value;
        OnPropertyChanged(nameof(AvailableFromDate));
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