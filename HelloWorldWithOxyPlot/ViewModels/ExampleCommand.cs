using System;
using System.Windows.Input;
using System.Collections.Generic;
using OxyPlot;


//namespace HelloWorldWithOxyPlot.ViewModels
namespace HelloWorldWithOxyPlot
{
   public class AddPointsCommand : ICommand
   {
      private MainWindowViewModel      ViewModel;
      private IList<DataPoint>         Points;
      private string                   WhichPoints;
      public AddPointsCommand(MainWindowViewModel vm, IList<DataPoint> points, string whichPoints)
      {
         ViewModel   = vm;
         Points      = points;
         WhichPoints = whichPoints;
      }
      public event EventHandler CanExecuteChanged;

      public bool CanExecute(object parameter)
      {
         //throw new NotImplementedException();
         return true;
      }

      public void Execute(object parameter)
      {
         //throw new NotImplementedException();
         if (ViewModel == null ) return;

         ViewModel.AddPoints(Points, WhichPoints);
      }
   }
}
