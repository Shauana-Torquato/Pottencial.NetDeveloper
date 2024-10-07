using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO LINHAS 6 ATÉ 22

Console.WriteLine("Smartphone Iphone: ");

Smartphone iphone   = new Iphone ("32165498", "3 mega", 55555555, 88);

iphone.Ligar();
iphone.InstalarAplicativo("Telegram");


Console.WriteLine("\n");


Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia ("894556123", "nokia imperia", 88888888, 100);

nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
