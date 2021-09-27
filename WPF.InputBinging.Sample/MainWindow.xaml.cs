using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.InputBinging.Sample
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      LoadDataContext();
    }

    private void LoadDataContext() //just add some testdata
    {
      var dc = new List<ItemViewModel>();
      var item1 = new ItemViewModel() { LabelString = "Item 1" };
      var item2 = new ItemViewModel() { LabelString = "Item 2" };

      item1.Children.Add(new ItemViewModel() { LabelString = "Item 1-1" });
      item1.Children.Add(new ItemViewModel() { LabelString = "Item 1-2" });
      item1.Children.Last().Children.Add(new ItemViewModel() { LabelString = " Item 1-2-1" });
      item1.Children.Last().Children.Add(new ItemViewModel() { LabelString = "Item 1-2-2" });
      item1.Children.Add(new ItemViewModel() { LabelString = "Item 1-3" });

      item2.Children.Add(new ItemViewModel() { LabelString = "Item 2-1" });
      item2.Children.Add(new ItemViewModel() { LabelString = "Item 2-2" });
      item2.Children.Add(new ItemViewModel() { LabelString = "Item 2-3" });
      item2.Children.Last().Children.Add(new ItemViewModel() { LabelString = "Item 2-3-1" });
      item2.Children.Last().Children.Add(new ItemViewModel() { LabelString = "Item 2-3-2" });

      dc.Add(item1);
      dc.Add(item2);

      DataContext = dc;
    }
  }
}
