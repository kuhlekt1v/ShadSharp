using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqActors
{
    class Actor
    {
        public string Name { get; set; }
        public decimal TotalGross { get; set; }
        public int MovieCount { get; set; }
        public decimal AveragePerMovie { get; set; }
        public string TopMovie { get; set; }
        public decimal TopMovieGross { get; set; }

        public override string ToString()
        {
            return "Name: " + Name +
                (TotalGross != 0 ? " Total Gross: " + TotalGross : null) +
                (MovieCount != 0 ? " Movie Count: " + MovieCount : null) +
                (AveragePerMovie != 0 ? " Average Per Movie: " + AveragePerMovie : null) +
                (TopMovie != null ? " Top Movie: " + TopMovie : null) +
                (TopMovieGross != 0 ? " Top Movie Gross: " + TopMovieGross : null);
        }
    }
}
