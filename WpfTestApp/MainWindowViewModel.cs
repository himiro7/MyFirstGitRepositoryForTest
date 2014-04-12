using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Collections.ObjectModel;

using MicroMvvm;

namespace WpfTestApp
{
  public class MainWindowViewModel : ObservableObject
  {
    public MainWindowViewModel()
    {
      Texts = new List<TextSetModel>() {
            new TextSetModel() { text01="AAAA", text02="111"},
            new TextSetModel() { text01="BBBB", text02="222"}
          };
    }

    public List<TextSetModel> Texts { get; set; }

  }
}
