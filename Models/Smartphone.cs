using System.Collections;
using System.ComponentModel;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        private List<Contato> ListaDeContatos { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria, List<Contato> listaDeContatos)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            ListaDeContatos = listaDeContatos;

        }

         public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            ListaDeContatos = new List<Contato>();

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void AdicionarContato(Contato contato)
        {
            bool contatoEValido = ValidarNumero(contato._numeroContato);
            if(contatoEValido == true)
            {
                ListaDeContatos.Add(contato);             
                Console.WriteLine("Contato Adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Número do contato já existe!");
            }

        }

        public void RemoverContato(string numero)
        {
            var contatos = ListaDeContatos.Where (x => string.Equals(x._numeroContato, numero)).ToList();
            if(contatos.Count > 0)
            {
                ListaDeContatos.Remove(contatos[0]);             
                Console.WriteLine("Contato removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Número do contato não existe!");
            }
        }

        public void ListarContatos()
        {
          if(ListaDeContatos.Count == 0)
          {
            Console.WriteLine("Lista de contatos vazia.");

          } 
          else
          {
          for (int i = 0; i < ListaDeContatos.Count; i++)
          {
            Console.WriteLine(ListaDeContatos[i]._nomeContato);
            Console.WriteLine(ListaDeContatos[i]._numeroContato);
          }
          }
          
        }

        public bool ValidarNumero(string numero)
         {
            var contatos = ListaDeContatos.Where (x => string.Equals(x._numeroContato, numero)).ToList();
             if(contatos.Count > 0)
             {
                 return false;
             }

            return true;
         }

    }
}