namespace BBUNote.Calculator
{
    public class LernfeldBuilder
    {
        protected Lernfeld lernfeld;

        public LernfeldBuilder()
        {
            lernfeld = new Lernfeld();
        }

        public Lernfeld Erstelen() => lernfeld;
    }
}