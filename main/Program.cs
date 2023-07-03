using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitMergeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // {    2023.07.03.   Add user Input / 2
            string userInput = string.Empty;
            Console.WriteLine("This program convert cm to Inch");
            Console.WriteLine("Input cm value : ");
            userInput = Console.ReadLine();
            
            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(10);
            //  }    2023.07.03.   Add user Input / 2
            ruler.Run();
        }
    }

    public class Ruler
    {
        private const float ONE_INCH = 2.54F;

        public int Centimeter { get; set; } = 0;

        public float Inch
        {
            get { return Centimeter * ONE_INCH; }

            // { 2023. 07. 03.      Add private _SetInch function / 3
            private set { this._SetInch(value); }
        }

        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }

        private void _SetInch(float inchValue) { Centimeter = (int)(inchValue * ONE_INCH); }
            // } 2023. 07. 03.      Add private _SetInch function / 3


    }
}
