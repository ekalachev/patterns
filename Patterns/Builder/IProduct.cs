using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Builder
{
    interface IProduct
    {
        string Seats { get; set; }
        string Engine { get; set; }
        string TripComputer { get; set; }
        string GPS { get; set; }
    }
}
