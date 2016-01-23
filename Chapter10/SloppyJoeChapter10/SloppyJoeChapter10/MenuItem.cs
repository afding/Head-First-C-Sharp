namespace SloppyJoeChapter10
{
    class MenuItem
    {
        // The three strings that make up the item are passed into the
        // constructorand held in read-only automatic properties.
        public string Meat { get; private set; }
        public string Condiment { get; private set; }
        public string Bread { get; private set; }

        public MenuItem(string meat, string condiment, string bread)
        {
            Meat = meat;
            Condiment = condiment;
            Bread = bread;
        }

        // Override the ToString() method so the MenuItem knows how to display
        // itself.
        public override string ToString()
        {
            return Meat + " with " + Condiment + " on " + Bread;
        }
    }
}
