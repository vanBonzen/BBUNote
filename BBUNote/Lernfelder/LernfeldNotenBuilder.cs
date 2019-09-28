namespace BBUNote.Calculator
{
    public class LernfeldNotenBuilder<T> : LernfeldAnzahlStundenBuilder<LernfeldNotenBuilder<T>> where T : LernfeldNotenBuilder<T>
    {
        public T MitSchulnote(int note)
        {
            lernfeld.Note = note;
            return (T) this;
        }
    }
}