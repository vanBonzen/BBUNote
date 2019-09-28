namespace BBUNote.Calculator
{
    public class LernfeldBuilderDirector : LernfeldNotenBuilder<LernfeldBuilderDirector>
    {
        public static LernfeldBuilderDirector NeuesLernfeld => new LernfeldBuilderDirector();
    }
}