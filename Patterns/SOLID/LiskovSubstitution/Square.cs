using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.LiskovSubstitution
{
    public class SquareWithViolatingLiskovSubstitutionPrinciple : RectangleWithViolatingLiskovSubstitutionPrinciple
    {
        // This commented code will violate the Liskov substitution principle
        public new int Width
        {
            set { base.Width = base.Height = value; }
        }

        public new int Height
        {
            set { base.Width = base.Height = value; }
        }
    }

    public class Square : Rectangle
    {
        // This commented code will violate the Liskov substitution principle
        //public new int Width
        //{
        //  set { base.Width = base.Height = value; }
        //}

        //public new int Height
        //{ 
        //  set { base.Width = base.Height = value; }
        //}

        public override int Width // nasty side effects
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
