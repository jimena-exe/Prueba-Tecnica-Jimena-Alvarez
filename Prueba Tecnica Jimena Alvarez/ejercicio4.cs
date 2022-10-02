using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    public class Car
    {
        public string Branch { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }


        public Car(string Branch, int Model, string Color)
        {
            this.Branch = Branch;
            this.Model = Model;
            this.Color = Color;

        }

    }
}
