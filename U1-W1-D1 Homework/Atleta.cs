using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D1_Homework
{
    internal class Atleta
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private double _age;

        public double Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public void GetAnagrafica()
        {
            Console.WriteLine($"L'atleta si chiama {_name} {_surname}, ha {_age} anni, è alto {_height}cm e pesa {_weight}kg");
        }

        public double SetPanettoniNatalizi(double number) {
            return _weight += number;
        }
    }
}
