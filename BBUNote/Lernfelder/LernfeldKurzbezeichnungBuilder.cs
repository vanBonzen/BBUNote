namespace BBUNote.Calculator
{
    public class LernfeldKurzbezeichnungBuilder<T> : LernfeldBuilder where T : LernfeldKurzbezeichnungBuilder<T>
    {
        public T MitKurzbezeichnung(string kurzbezeichnung)
        {
            lernfeld.Kurzbezeichnung = kurzbezeichnung;
            return (T) this;
        }
    }
}