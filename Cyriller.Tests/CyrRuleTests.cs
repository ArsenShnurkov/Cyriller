using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Cyriller.Tests
{
    public class CyrRuleTests
    {
        #region apply rule.
        [Fact]
        public void UnavailableRulelIsCorrectlyApplied()
        {
            CyrRule rule = new CyrRule("*");
            string a = "text";
            string b = rule.Apply(a);

            Assert.Equal(string.Empty, b);
        }

        [Fact]
        public void EmptyRuleIsCorrectlyApplied()
        {
            CyrRule rule = new CyrRule(string.Empty);
            string a = "text";
            string b = rule.Apply(a);

            Assert.Equal(a, b);
        }

        [Fact]
        public void CutRuleIsCorrectlyApplied()
        {
            CyrRule rule = new CyrRule("2");
            string a = "text";
            string b = rule.Apply(a);

            Assert.Equal("te", b);
        }

        [Fact]
        public void AddRuleIsCorrectlyApplied()
        {
            CyrRule rule = new CyrRule("add");
            string a = "text";
            string b = rule.Apply(a);

            Assert.Equal("textadd", b);
        }

        [Fact]
        public void AddCutRuleIsCorrectlyApplied()
        {
            CyrRule rule = new CyrRule("add2");
            string a = "text";
            string b = rule.Apply(a);

            Assert.Equal("teadd", b);
        }
        #endregion

        #region revert rule.

        [Fact]
        public void UnavailableRulelIsCorrectlyReverted()
        {
            CyrRule rule = new CyrRule("*");
            string original = "text";
            string current = "pext";
            string reverted = rule.Revert(original, current);

            Assert.Equal(current, reverted);
        }

        [Fact]
        public void EmptyRuleIsCorrectlyReverted()
        {
            CyrRule rule = new CyrRule(string.Empty);
            string original = "text";
            string current = "pext";
            string reverted = rule.Revert(original, current);

            Assert.Equal(current, reverted);
        }

        [Fact]
        public void CutRuleIsCorrectlyReverted()
        {
            CyrRule rule = new CyrRule("2");
            string original = "text";
            string current = "pe";
            string reverted = rule.Revert(original, current);

            Assert.Equal("pext", reverted);
        }

        [Fact]
        public void AddRuleIsCorrectlyReverted()
        {
            CyrRule rule = new CyrRule("add");
            string original = "text";
            string current = "pextadd";
            string reverted = rule.Revert(original, current);

            Assert.Equal("pext", reverted);
        }

        [Fact]
        public void AddCutRuleIsCorrectlyReverted()
        {
            CyrRule rule = new CyrRule("add2");
            string original = "text";
            string current = "peadd";
            string reverted = rule.Revert(original, current);

            Assert.Equal("pext", reverted);
        }
        #endregion
    }
}
