using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    interface IProduct
    {
        string Seats { get; set; }
        string Engine { get; set; }
        string TripComputer { get; set; }
        string GPS { get; set; }
    }
}
