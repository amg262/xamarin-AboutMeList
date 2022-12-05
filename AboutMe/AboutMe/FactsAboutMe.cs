using System;
using System.Collections.Generic;
using System.Text;

namespace AboutMe
{
    public class FactsAboutMe
    {
        public FactsAboutMe()
        { }

        public static IEnumerable<FactsAboutMe> Facts { private set; get; }

        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string Image { get; set; }

        static FactsAboutMe()
        {
            List<FactsAboutMe> facts = new List<FactsAboutMe>();
            facts.Add(new FactsAboutMe() { TheFact = "I am 6 feet 4 inches tall", ShortFact = "One", Image = "a.jpg"});
            facts.Add(new FactsAboutMe() { TheFact = "I love sports", ShortFact = "Two", Image = "b.png" });
            facts.Add(new FactsAboutMe() { TheFact = "I have a girlfriend named Peyton", ShortFact = "Three", Image = "c.jpg" });
            facts.Add(new FactsAboutMe() { TheFact = "I am starting to hate cold weather.", ShortFact = "Four", Image = "d.jpg" });
            facts.Add(new FactsAboutMe() { TheFact = "I am an Aries", ShortFact = "Five", Image = "e.jpg" });

            Facts = facts;
        }

    }
}
