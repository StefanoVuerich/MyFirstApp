namespace MyFirstApp
{
    using System;

    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        internal void StampaInformazioni()
        {
            Console.WriteLine($"{this.Nome}, {this.Cognome}, {this.Eta}");
        }
    }
}
