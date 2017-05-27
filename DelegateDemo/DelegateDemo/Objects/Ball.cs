 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.Objects
{
    class Ball : Shape
    {
        private string color;
        private int diameter;
        private bool status;

        public Ball(string c,int d)
        {
            color = c;
            diameter = d;
            status = false;
        }

        public void Inflate()
        {
            status = !status;
        }

        public override string Status()
        {
            return string.Format("The ball is {0} ", (status ? "inflated" : " deflated"));
        }

        public override string Color()
        {
            return string.Format("The ball's color is {0} ", color);
        }

        public override string Volume()
        {
            return string.Format("The ball's volume is {0} ", 4 * Math.PI * Math.Pow(diameter / 2.0, 3) / 3);
        }
    }
}
