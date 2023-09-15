using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvaljanje4DdrugiZad3
{
    internal class Program
    {
        class Vozilo
        {
            bool jeLiLeti, jeLiPlovi;

            public bool JeLiLeti { get => jeLiLeti; set => jeLiLeti = value; }
            public bool JeLiPlovi { get => jeLiPlovi; set => jeLiPlovi = value; }

            public string KudaVozi()
            {
                string txt="vozilo vozi ";
                if (JeLiLeti == true&& JeLiPlovi == true)
                {
                    txt = "u zraku i vodi";
                }
                else if(JeLiLeti==true)
                {
                    txt += "u zraku";
                }
                else if (JeLiPlovi==true)
                {
                    txt += "u vodi";
                }
                return txt;
            }
        }
        class Brod : Vozilo
        {
            public Brod() { 
                JeLiPlovi = true;
                JeLiLeti = false;
            }
        }
        class Zrakoplov : Vozilo
        {
            public Zrakoplov()
            {
                JeLiLeti = true;
                JeLiPlovi = false;
            }
        }
        static void Main(string[] args)
        {
            Brod brod = new Brod();
            Zrakoplov zrakoplov = new Zrakoplov();
            Console.WriteLine("Zrakoplov " + zrakoplov.KudaVozi() + ", a brod " + brod.KudaVozi() + ".");
            Console.ReadLine();
        }
    }
}
