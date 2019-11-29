using ArmyManager.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArmyManagerTests.Data
{
    [TestClass]
    public class DiceSizesTests
    {
        [TestMethod]
        public void SixtySixTo99()
        {
            Assert.AreEqual(99, DiceSizes.ConvertToD6Cost(66, DiceSizes.Dice.d4));
        }

        [TestMethod]
        public void OneHundredTo100()
        {
            Assert.AreEqual(100, DiceSizes.ConvertToD6Cost(100, DiceSizes.Dice.d6));
        }

        [TestMethod]
        public void OneHundred33To100()
        {
            Assert.AreEqual(100, DiceSizes.ConvertToD6Cost(133, DiceSizes.Dice.d8));
        }

        [TestMethod]
        public void OneHundred50To100()
        {
            Assert.AreEqual(100, DiceSizes.ConvertToD6Cost(150, DiceSizes.Dice.d10));
        }

        [TestMethod]
        public void TwoHundredTo100()
        {
            Assert.AreEqual(100, DiceSizes.ConvertToD6Cost(200, DiceSizes.Dice.d12));
        }

        // Test Multiplier

        [TestMethod]
        public void OneHundredTo66()
        {
            Assert.AreEqual(66, DiceSizes.ApplyDiceSizeCoustMultiplier(
                100, DiceSizes.Dice.d4));
        }

        [TestMethod]
        public void OneHundredUpTo100()
        {
            Assert.AreEqual(100, DiceSizes.ApplyDiceSizeCoustMultiplier(
                100, DiceSizes.Dice.d6));
        }

        [TestMethod]
        public void OneHundredTo133()
        {
            Assert.AreEqual(133, DiceSizes.ApplyDiceSizeCoustMultiplier(
                100, DiceSizes.Dice.d8));
        }

        [TestMethod]
        public void OneHundredTo166()
        {
            Assert.AreEqual(166, DiceSizes.ApplyDiceSizeCoustMultiplier(
                100, DiceSizes.Dice.d10));
        }

        [TestMethod]
        public void OneHundredTo200()
        {
            Assert.AreEqual(200, DiceSizes.ApplyDiceSizeCoustMultiplier(
                100, DiceSizes.Dice.d12));
        }
    }
}
