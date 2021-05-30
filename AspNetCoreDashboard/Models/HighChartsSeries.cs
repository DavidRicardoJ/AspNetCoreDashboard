using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace AspNetCoreDashboard.Models
{
    public class HighChartsSeries
    {
        public string Name { get; set; }
        public double Y { get; set; }
        public bool Sliced { get; set; }
        public bool Selected { get; set; } 

        public HighChartsSeries()
        {            
        }

        public HighChartsSeries(string name, double y, bool sliced, bool selected)
        {
            this.Name = name;
            this.Y = y;
            this.Sliced = sliced;
            this.Selected = selected;
        }

        public List<HighChartsSeries> GetDataChart()
        {
            List<HighChartsSeries> list = new();
            list.Add(new HighChartsSeries("Internet Explorer", 11.84, true, true));
            list.Add(new HighChartsSeries("Firefox", 10.85, false, false));
            list.Add(new HighChartsSeries("Edge", 4.67, false, false));
            list.Add(new HighChartsSeries("Safari", 4.18, false, false));
            list.Add(new HighChartsSeries("Other", 7.05, false, false));

            return list;
        }
    }
}
