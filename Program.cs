using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone  - TODO implementado!

Console.WriteLine("---------- Testes Smartphone Nokia ---------- \n");
Smartphone nokia = new Nokia("(99)99999-9999", "Nokia 3310", "999999999999999", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n\n");

Console.WriteLine("---------- Testes Smartphone iPhone ---------- \n");
Smartphone iphone = new Iphone("(77)77777-7777", "iPhone 3GS", "777777777777777", 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

