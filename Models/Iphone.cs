namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone" - TODO implementado!
    public class Iphone : Smartphone
    {
        public Iphone (string numero, string modelo, string imei, int memoria, List<Contato> contatos) : base (numero, modelo, imei, memoria, contatos)
        {

        }

        public Iphone (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu Iphone!");
        }
        // Sobrescrever o método "InstalarAplicativo"  - TODO implementado!
    }
}