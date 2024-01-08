using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Contato
    {
        public Contato(string nomeContato, string numeroContato)
        {
            NomeContato = nomeContato;
            NumeroContato = numeroContato;
        }

        public Contato()
        {
            
        }

        private string NomeContato { get; set; }
        private string NumeroContato { get; set; }

        public string _nomeContato
        {
            get {return NomeContato; }
            set {NomeContato = value;}

        }

        public string _numeroContato
        {
            get {return NumeroContato; }
            set { NumeroContato = value; }
        }


    }
}