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

    ///// <summary>
    ///// This method is executed when the AddPieButton is clicked.
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //private void AddPieButton_Clicked(object sender, EventArgs e)
    //{
    //  var newPie = new Pie
    //  {
    //    PieName = "Pumpkin Pie",
    //    Price = 12.95,
    //    Description = "Blah, blah, blah",
    //    ImageUrl = imageUrl,
    //    InStock = true,
    //  };

    //  Pies.Add(newPie);
    //}

    //private async void PiesListView_ItemTappedAsync(object sender, ItemTappedEventArgs e)
    //{
    //  await this.Navigation.PushAsync(new MainPage(e.Item as Pie));
    //}
  }
}
