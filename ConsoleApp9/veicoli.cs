using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Veicoli
    {
        public string Targa;
        public string Marca;
        public string Modello;
        public int numeroposti;
        public int qcapacita;
        public Veicoli()
        {
            Targa = string.Empty;
            Marca = string.Empty;
            Modello = string.Empty;
        }

        public class Autocarri : Veicoli 
        {
            
            public Autocarri()
            {
                qcapacita = 0;
            }
        }
        public class Autoveicoli : Veicoli
        {
            public Autoveicoli()
            {
                base.numeroposti = 0;
            }
        }



    }
}
