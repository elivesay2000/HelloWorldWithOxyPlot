using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using System.Windows.Input;
using System.ComponentModel;

//namespace HelloWorldWithOxyPlot.ViewModels
namespace HelloWorldWithOxyPlot
{
   public class MainWindowViewModel : INotifyPropertyChanged
   {
      public string           Title { get; private set; }
      public IList<DataPoint> Points_1 { get; private set; }
      public IList<DataPoint> Points_2 { get; private set; }

      private ExampleCommand  exampleCommand;

      public event PropertyChangedEventHandler PropertyChanged;
      public void OnPropertyChanged(string propertyName)
      {
         if( PropertyChanged != null)
         {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
         }
      }

      public ICommand DoExampleCommand
      {
         get
         {
            return exampleCommand;
         }
      }

      public MainWindowViewModel()
      {
         exampleCommand = new ExampleCommand(this);

         this.Title = "This is the title";
         this.Points_1 = new List<DataPoint>
         {
            new DataPoint( 0, 4),
            new DataPoint(10,13),
            new DataPoint(20,15),
            new DataPoint(30,16),
            new DataPoint(40,12),
            new DataPoint(50,12),
         };
         this.Points_2 = new List<DataPoint>
         {
            new DataPoint(- 5, 2),
            new DataPoint(  0, 1),
            new DataPoint( 10, 2),
            new DataPoint( 20, 3),
            new DataPoint( 30, 4),
            new DataPoint( 40, 5),
            new DataPoint( 50, 6),
            new DataPoint( 60, 8),
            new DataPoint( 70,12),
         };
      }
      public void       AddPoints_to_1()
      {
         DataPoint p = this.Points_1.Last();
         this.Points_1.Add(new DataPoint(p.X + 10, p.Y + 2));

         OnPropertyChanged("Points_1");
      }

   }
   public class ExampleCommand : ICommand
   {
      private MainWindowViewModel      ViewModel;
      public ExampleCommand(MainWindowViewModel vm)
      {
         ViewModel = vm;
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

         ViewModel.AddPoints_to_1();
      }
   }
}
