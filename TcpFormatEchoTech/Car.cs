using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpFormatEchoTech
{
    public class Car
    {
        /// <summary>
        /// Private instansfelter med tilhørende metoder get; set;.
        /// </summary>
        private string model;
        private string color;
        private string regNo;

        /// <summary>
        /// Get; set; property for hver af instans felterne.
        /// </summary>
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string RegNo { get => regNo; set => regNo = value; }


        /// <summary>
        /// Default konstruktor nedarver sig selv?
        /// </summary>
        public Car() : this("dummyModel", "dummyColor", "dummyRegNo")
        {
        }

        /// <summary>
        /// Overloaded konstruktør med 3 lokale parametre.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="regNo"></param>
        public Car(string model, string color, string regNo)
        {
            this.Model = model;
            this.Color = color;
            this.RegNo = regNo;
        }

        public override string ToString()
        {
            return $"{nameof(Model)}: {model}, {nameof(Color)}: {color}, {nameof(RegNo)}: {regNo}";
        }
    }
}
