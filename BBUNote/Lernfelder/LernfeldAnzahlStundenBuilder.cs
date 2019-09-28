namespace BBUNote.Calculator
{
    public class LernfeldAnzahlStundenBuilder<T> : LernfeldBezeichnungBuilder<LernfeldAnzahlStundenBuilder<T>>
        where T : LernfeldAnzahlStundenBuilder<T>

    {
        public T MitAnzahlStunden(int stunden)
        {
            lernfeld.AnzahlStunden = stunden;
            return (T) this;
        }
    }
}