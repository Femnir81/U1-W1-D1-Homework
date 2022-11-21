using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D1_Homework
{
    internal class Veicolo
    {
		private string _tipo;

		public string Tipo
		{
			get { return _tipo; }
			set { _tipo = value; }
		}

		private double _ruote;

		public double Ruote
		{
			get { return _ruote; }
			set { _ruote = value; }
		}

		public void TiBucoLaRuota()
		{
			if ( _ruote > 0 )
			{
				_ruote -= 1;
				Console.WriteLine($"Il tuo mezzo ha {_ruote} ruote ancora gonfie");
			}
			else
			{
                Console.WriteLine($"Hai poco da bucare, non ci sono più ruote da sgonfiare!");
            }
		}

	}
}
