using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using CSharp7Examples.PatternMatching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp7Examples.Test.PatternMatching
{
    [TestClass]
    public class PatternMatchingTests
    {
        [TestMethod]
        public void EachSportHasCorrectAmountOfPlayer()
        {
            IList<Sport> sports = new List<Sport>
            {
                new Baseball(),
                new GridIron(),
                new Rugby()
            };

            foreach (var sport in sports)
            {
                switch (sport)
                {
                    case Baseball baseball:
                        Assert.AreEqual(9, baseball.NumberOfPlayersOnTeam);
                        break;
                    case GridIron gridIron:
                        Assert.AreEqual(11, gridIron.NumberOfPlayersOnTeam);
                        break;
                    case Rugby rugby:
                        Assert.AreEqual(15, rugby.NumberOfPlayersOnTeam);
                        break;
                    
                }
            }
        }
    }        
    
}
