using NUnit.Framework;
using UnitTest_PracticalTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace UnitTest_PracticalTask.Tests
{
    [TestFixture()]
    public class PracticalTaskTests
    {
        // MaxConsecutiveDistinctCharacters

        [Test]
        public void MaxConsecutiveDistinctCharacters_EmptyString_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => PracticalTask.MaxConsecutiveDistinctCharacters(""));
        }

        [Test]
        public void MaxConsecutiveDistinctCharacters_SingleCharacter_ReturnsOne()
        {
            var actual = PracticalTask.MaxConsecutiveDistinctCharacters("a");
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void MaxConsecutiveDistinctCharacters_TwoIdenticalLetters_ReturnsTwo()
        {
            var actual = PracticalTask.MaxConsecutiveDistinctCharacters("ab");
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void MaxConsecutiveDistinctCharacters_AllDistinct_ReturnsLength()
        {
            var actual = PracticalTask.MaxConsecutiveDistinctCharacters("abcdef");
            Assert.AreEqual(6, actual);
        }

        [Test]
        public void MaxConsecutiveDistinctCharacters_SomeRepeats_ReturnsCorrectLength()
        {
            var actual = PracticalTask.MaxConsecutiveDistinctCharacters("abecaddlo");
            Assert.AreEqual(6, actual);
        }

        // MaxConsecutiveIdenticalLetters

        [Test]
        public void MaxConsecutiveIdenticalLetters_EmptyString_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => PracticalTask.MaxConsecutiveIdenticalLetters(""));
        }

        [Test]
        public void MaxConsecutiveIdenticalLetters_SingleLetter_ReturnsOne()
        {
            var actual = PracticalTask.MaxConsecutiveIdenticalLetters("a");
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void MaxConsecutiveIdenticalLetters_TwoIdenticalLetters_ReturnsTwo()
        {
            var actual = PracticalTask.MaxConsecutiveIdenticalLetters("aa");
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void MaxConsecutiveIdenticalLetters_NoIdenticalLetters_ReturnsOne()
        {
            var actual = PracticalTask.MaxConsecutiveIdenticalLetters("abcdefg");
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void MaxConsecutiveIdenticalLetters_MultipleIdenticalGroups_ReturnsMaxGroupLength()
        {
            var actual = PracticalTask.MaxConsecutiveIdenticalLetters("aaabbbccc");
            Assert.AreEqual(3, actual);
        }

        // MaxConsecutiveIdenticalDigits

        [Test]
        public void MaxConsecutiveIdenticalDigits_EmptyString_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => PracticalTask.MaxConsecutiveIdenticalDigits(""));
        }

        [Test]
        public void MaxConsecutiveIdenticalDigits_SingleDigit_ReturnsOne()
        {
            var actual = PracticalTask.MaxConsecutiveIdenticalDigits("1");
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void MaxConsecutiveIdenticalDigits_TwoIdenticalDigits_ReturnsTwo()
        {
            var actual = PracticalTask.MaxConsecutiveIdenticalDigits("11");
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void MaxConsecutiveIdenticalDigits_NoDigits_ReturnsZero()
        {
            var actual = PracticalTask.MaxConsecutiveIdenticalDigits("abcdef");
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void MaxConsecutiveIdenticalDigits_MultipleIdenticalDigits_ReturnsMaxGroupLength()
        {
            var actual = PracticalTask.MaxConsecutiveIdenticalDigits("111222");
            Assert.AreEqual(3, actual);
        }
    }
}