using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.InputBinging.Sample
{
  [PropertyChanged.AddINotifyPropertyChangedInterface]
  public class ItemViewModel
  {
    public ItemViewModel()
    {
      Children = new List<ItemViewModel>();
      ChangeVisualCommand = new ChangeEditMode();
    }

    public string LabelString { get; set; }
    public bool EditMode { get; set; }
    public List<ItemViewModel> Children { get; set; }
    public ICommand ChangeVisualCommand { get; }

  }

  public class ChangeEditMode : ICommand
  {
    public event EventHandler CanExecuteChanged
    {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }

    public bool CanExecute(object parameter)
    {
      return true;
    }

    public void Execute(object parameter)
    {
      if (parameter is ItemViewModel vm)
      {
        vm.EditMode = !vm.EditMode;
      }
    }
  }
}
