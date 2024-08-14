using ConsoleApp9;

Veicoli veicoli = new Veicoli();

veicoli.Targa = "FF120TW";
veicoli.Marca = "Fiat";
veicoli.Modello = "Punto";
veicoli.numeroposti = 3; 

Console.WriteLine("Targa : " + veicoli.Targa);
Console.WriteLine("Marca :" + veicoli.Marca);
Console.WriteLine("Modello : " + veicoli.Modello);
Console.WriteLine("NumeroPosti : " + veicoli.numeroposti);

veicoli.Targa = "DD503TD";
veicoli.Marca = "Scania";
veicoli.Modello = "Twist";
veicoli.qcapacita = 300;
Console.WriteLine("Targa : " + veicoli.Targa);
Console.WriteLine("Marca : " + veicoli.Marca);
Console.WriteLine("Modello : " + veicoli.Modello);
Console.WriteLine("Capacita massima di carico in quintali : " + veicoli.qcapacita);

