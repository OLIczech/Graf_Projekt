using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Graf_Projekt
{
    public class Graf
    {
        public PlotModel GrafModel { get; set; }
        public Graf() 
        {
            GrafModel = new PlotModel { Title = "Vývoj množství alkoholu v krvi" }; //<-- nápis ned grafem, možno měnit dle potřeby 

            GrafModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Čas (hodiny)", //<-- text popisku
                FontSize = 18,     //velikost textu popisku
                
            });

            GrafModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Hladina alkoholu (‰)",
                FontSize = 18,
                

            });

            var lineSeries = new LineSeries
            {
                StrokeThickness = 4, //tloušťka čáry
                Color = OxyColors.Green //barva čáry
            };

            lineSeries.Points.Add(new DataPoint(0, 0)); //<-- body v grafu normálně [X,Y]
            lineSeries.Points.Add(new DataPoint(1, 2));
            lineSeries.Points.Add(new DataPoint(2, 3));
            lineSeries.Points.Add(new DataPoint(3, 1));

            GrafModel.Series.Add(lineSeries);
        }
    }
}
