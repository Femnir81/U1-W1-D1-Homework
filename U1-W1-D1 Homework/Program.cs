using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D1_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta1 = new Atleta();
            atleta1.Name = "Speedy";
            atleta1.Surname = "Gonzales";
            atleta1.Age = 27;
            atleta1.Height = 30;
            atleta1.Weight = 20;
            atleta1.GetAnagrafica();
            atleta1.SetPanettoniNatalizi(5);
            Console.WriteLine(atleta1.Weight);
            atleta1.GetAnagrafica();

            Animale animale1 = new Animale();
            animale1.Name = "Strano Animalo";
            animale1.Age = 12;
            animale1.GetAnagrafica();
            animale1.SetInvecchiamentoPrecoce(5);
            animale1.GetAnagrafica();

            Veicolo veicolo1 = new Veicolo();
            veicolo1.Tipo = "Macchina";
            veicolo1.Ruote = 4;
            Console.WriteLine(veicolo1.Ruote);
            veicolo1.TiBucoLaRuota();
            Console.WriteLine(veicolo1.Ruote);
        }
    }
}
