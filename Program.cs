using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new("98765432", "Nokia K1", "159753", 64);
Iphone phone = new("98765432", "Iphone 11", "753951", 128);

nokia.Ligar();
phone.Ligar();

phone.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Gmail");
