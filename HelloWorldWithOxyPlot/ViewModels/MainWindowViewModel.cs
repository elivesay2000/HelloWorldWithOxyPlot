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

      public int              TotalNumberOfPoints
      {
         get
         {
            return Points_1.Count + Points_2.Count;
         }
      }

      public event PropertyChangedEventHandler PropertyChanged;
      public void OnPropertyChanged(string propertyName)
      {
         if( PropertyChanged != null)
         {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
         }
      }

      private AddPointsCommand addCommandForPoints_1;
      public ICommand AddCommandForPoints_1
      {
         get
         {
            return addCommandForPoints_1;
         }
      }
      private AddPointsCommand addCommandForPoints_2;
      public ICommand AddCommandForPoints_2
      {
         get
         {
            return addCommandForPoints_2;
         }
      }

      public MainWindowViewModel()
      {
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

         // Commands
         addCommandForPoints_1 = new AddPointsCommand(this, Points_1, "Points_1");
         addCommandForPoints_2 = new AddPointsCommand(this, Points_2, "Points_2");

      }
      public void       AddPoints(IList<DataPoint> points, string whichPoints)
      {
         if (points == null) return;

         DataPoint p = points.Last();
         points.Add(new DataPoint(p.X + 3, p.Y + 1));

         OnPropertyChanged(whichPoints);
         OnPropertyChanged("TotalNumberOfPoints");
      }

   }
}
