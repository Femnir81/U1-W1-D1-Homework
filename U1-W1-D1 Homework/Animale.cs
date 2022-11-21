using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D1_Homework
{
    internal class Animale
    {
        private string _name;
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }

        private double _age;
        public double Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void GetAnagrafica()
        {
            Console.WriteLine($"{_name} ha {_age} anni");
        }

        public double SetInvecchiamentoPrecoce(double number)
        {
            return _age += number;
        }
    }
}
