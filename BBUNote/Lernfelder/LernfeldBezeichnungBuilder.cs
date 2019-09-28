namespace BBUNote.Calculator
{
    public class LernfeldBezeichnungBuilder<T> : LernfeldKurzbezeichnungBuilder<LernfeldBezeichnungBuilder<T>> where T : LernfeldBezeichnungBuilder<T>
    {
        public T MitBezeichnung(string bezeichnung)
        {
            lernfeld.Bezeichnung = bezeichnung;
            return (T) this;
        }
    }
}