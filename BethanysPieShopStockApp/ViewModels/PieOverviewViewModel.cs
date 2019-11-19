using BethanysPieShopStockApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace BethanysPieShopStockApp.ViewModels
{
  class PieOverviewViewModel : INotifyPropertyChanged
  {
    // Fields.
    private readonly PieRepository pieRepository;
    public event PropertyChangedEventHandler PropertyChanged;
    public ObservableCollection<Pie> Pies { get; set; }

    public PieOverviewViewModel()
    {
      pieRepository = new PieRepository();
      Pies = pieRepository.Collection;
    }

    public void RaisePropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
