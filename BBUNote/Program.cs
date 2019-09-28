using System;
using System.Collections.Generic;
using BBUNote.Berechnung;
using BBUNote.Calculator;

namespace BBUNote
{
    internal static class Program
    {
        static List<Lernfeld> lernfelder = new List<Lernfeld>();
        
        private static void Main(string[] args)
        {
            Program.InitialisiereLernfelder();
            
            foreach (var lernfeld in lernfelder)
            {
                lernfeld.Anzeigen();
            }
            Console.WriteLine("{0} {1:N2}", "gewichtete Empfehlung der BBU Note: ",  Rechnung.Berechne(lernfelder));
        }

        private static void InitialisiereLernfelder()
        {
            var lernfeld1 = LernfeldBuilderDirector
                .NeuesLernfeld
                .MitKurzbezeichnung("LF 1")
                .MitBezeichnung("Der Betrieb und sein Umfeld")
                .MitAnzahlStunden(16)
                .MitSchulnote(1)
                .Erstelen();
            
            var lernfeld2 = LernfeldBuilderDirector
                .NeuesLernfeld
                .MitKurzbezeichnung("LF 2")
                .MitBezeichnung("Geschäftsprozesse und betriebliche Organisation")
                .MitAnzahlStunden(10)
                .MitSchulnote(2)
                .Erstelen();
            
            var lernfeld3 = LernfeldBuilderDirector
                .NeuesLernfeld
                .MitKurzbezeichnung("LF 3")
                .MitBezeichnung("Informationsquellen und Arbeitsmethoden")
                .MitAnzahlStunden(10)
                .MitSchulnote(2)
                .Erstelen();
            
            var lernfeld4 = LernfeldBuilderDirector
                .NeuesLernfeld
                .MitKurzbezeichnung("LF 4")
                .MitBezeichnung("Einfache IT-Systeme")
                .MitAnzahlStunden(10)
                .MitSchulnote(2)
                .Erstelen();
            
            lernfelder.Add(lernfeld1);
            lernfelder.Add(lernfeld2);
            lernfelder.Add(lernfeld3);
            lernfelder.Add(lernfeld4);

        }
    }
}