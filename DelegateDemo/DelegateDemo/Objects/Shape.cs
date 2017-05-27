using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.Objects
{
    public abstract class Shape
    {
        /// <summary>
        /// get a string that specify status of sphere
        /// </summary>
        /// <returns></returns>
        public abstract string Status();

        /// <summary>
        /// returns a string that specify the color of the sphere
        /// </summary>
        /// <returns></returns>
        public abstract string Color();

        /// <summary>
        /// returning the volume of the sphere in a string with name
        /// </summary>
        /// <returns></returns>
        public abstract string Volume();
    }
}
