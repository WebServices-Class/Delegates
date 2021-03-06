﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.Objects
{
    class Pyramid:Shape
    {
        private string color;
        private int height,basewidth;
        private bool status;

        public Pyramid(string c,int h,int b)
        {
            color = c;
            height = h;
            basewidth = b;
            status = false;
        }

        public void Fill()
        {
            status = !status;
        }

        public override string Status()
        {
            return string.Format("The Pyramid is {0} ", (status ? "full" : " empty"));
        }

        public override string Color()
        {
            return string.Format("The pyramids's color is {0} ", color);
        }

        public override string Volume()
        {
            return string.Format("The pyramids's volume is {0} ", Math.Pow(basewidth, 2) * height / 3);
        }
    }
}
