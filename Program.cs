using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone  - TODO implementado!

Console.WriteLine("---------- Testes Smartphone Nokia ---------- \n");
Smartphone nokia = new Nokia("(99)99999-9999", "Nokia 3310", "999999999999999", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

//Instânciando a classe contato e chamando os métodos adicionar e listar contato.
Contato contato = new Contato("teste", "99999999");
nokia.AdicionarContato(contato);
nokia.ListarContatos();

//Caso o contato já exista apresentará um erro.
nokia.AdicionarContato(contato);

//Instânciando um novo contato e chamando os métodos adicionar e listar contato
contato = new Contato("teste2", "888888888");
nokia.AdicionarContato(contato);
nokia.ListarContatos();

//Chamadas dos métodos remover e listar contato.
nokia.RemoverContato("99999999");
nokia.ListarContatos();

Console.WriteLine("\n\n");

 Console.WriteLine("---------- Testes Smartphone iPhone ---------- \n");
 Smartphone iphone = new Iphone("(77)77777-7777", "iPhone 3GS", "777777777777777", 32);
 iphone.Ligar();
 iphone.ReceberLigacao();
 iphone.InstalarAplicativo("Telegram");

//Instânciando a classe contato e chamando os métodos adicionar e listar contato.
contato = new Contato("teste3", "77777777");
iphone.AdicionarContato(contato);
iphone.ListarContatos();

//Caso o contato já exista apresentará um erro.
iphone.AdicionarContato(contato);

//Instânciando um novo contato e chamando os métodos adicionar e listar contato
contato = new Contato("teste4", "55555555");
iphone.AdicionarContato(contato);
iphone.ListarContatos();

//Chamadas dos métodos remover e listar contato.
iphone.RemoverContato("55555555");
iphone.ListarContatos();


