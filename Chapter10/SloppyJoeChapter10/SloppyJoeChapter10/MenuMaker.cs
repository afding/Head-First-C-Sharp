using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SloppyJoeChapter10
{
    class MenuMaker
    {
        private Random random = new Random();
        private List<String> meats = new List<String>()
        {
            "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami"
        };
        private List<String> condiments = new List<String>()
        {
            "brown mustard", "honey mustard", "mayo", "relish", "french dressing"
        };
        private List<String> breads = new List<String>()
        {
            "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll"
        };

        // Data binding will be used to display data from these properties on
        // the page. Two-way binding will be used to update NumberOfItems.
        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; private set; }
        public int NumberOfItems { get; set; }
        
        public MenuMaker()
        {
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }

        // The CreateMenuItem() method returns MenuItem obejcts, not just
        // strings. That will make it easier to change the way items are
        // displayed if we want.
        private MenuItem CreateMenuItem()
        {
            string randomMeat = meats[random.Next(meats.Count)];
            string randomCondiment = condiments[random.Next(condiments.Count)];
            string randomBread = breads[random.Next(breads.Count)];
            return new MenuItem(randomMeat, randomCondiment, randomBread);
        }

        public void UpdateMenu()
        {
            // We never actually create the new MenuItem collection. It updates
            // the current one by clearing it and adding new items.
            Menu.Clear();
            for (int i = 0; i < NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;
        }
    }
}
