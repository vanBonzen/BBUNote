using System.Collections.Generic;
using BBUNote.Calculator;

namespace BBUNote.Berechnung
{
    public static class Rechnung
    {
        public static decimal Berechne(IEnumerable<Lernfeld> lernfelder)
        {
            decimal gesamtstunden = 0;
            decimal noten = 0;

            foreach (var lernfeld in lernfelder)
            {
                gesamtstunden += lernfeld.AnzahlStunden;
                noten += (lernfeld.AnzahlStunden * lernfeld.Note);
            }
            return (noten / gesamtstunden);
        }
    }
}