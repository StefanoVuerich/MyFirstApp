// See https://aka.ms/new-console-template for more information
using MyFirstApp;

Persona persona = new Persona();

Console.WriteLine("Inserisci nome");
persona.Nome = Console.ReadLine();

Console.WriteLine("Inserisci cognome");
persona.Cognome = Console.ReadLine();

Console.WriteLine("Inserisci età");
persona.Eta = Convert.ToInt32(Console.ReadLine());

persona.StampaInformazioni();

Console.ReadKey();