namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"  - TODO implementado!
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria, List<Contato> contatos) : base (numero, modelo, imei, memoria, contatos)
        {

        }

        public Nokia (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu Nokia!");
        }
        // Sobrescrever o método "InstalarAplicativo" - TODO implementado!
    }
}