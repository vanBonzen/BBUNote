using System;

namespace BBUNote.Calculator
{
    public class Lernfeld
    {
        public string Kurzbezeichnung { get; set; }
        public string Bezeichnung { get; set; }
        public int AnzahlStunden { get; set; }
        public int Note { get; set; }
        
        public void Anzeigen()
        {
            Console.WriteLine("{0:3} {1:12} {2:1}", (this.Kurzbezeichnung + ", "), this.Bezeichnung + " <" + this.AnzahlStunden + "Std.>:", this.Note); 
        }
    }
}