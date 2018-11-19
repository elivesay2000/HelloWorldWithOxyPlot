using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

//namespace HelloWorldWithOxyPlot.ViewModels
namespace HelloWorldWithOxyPlot
{
   public class MainWindowViewModel
   {
      public string Title { get; private set; }
      public IList<DataPoint> Points_1 { get; private set; }
      public IList<DataPoint> Points_2 { get; private set; }

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


      }

   }
}
