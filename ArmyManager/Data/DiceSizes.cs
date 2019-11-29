using System;

namespace ArmyManager.Data
{
    public class DiceSizes
    {
        public enum Dice
        {
            d4 = 4,
            d6 = 6,
            d8 = 8,
            d10 = 10,
            d12 = 12
        }

        public static int ConvertToD6Cost(int cost, Dice currentSize)
        {
            switch (currentSize)
            {
                case Dice.d4:
                    return (int)Math.Round(Convert.ToDouble(cost) * 1.5);
                case Dice.d6:
                    return cost;
                case Dice.d8:
                    return (int)Math.Round(Convert.ToDouble(cost) * 0.75);
                case Dice.d10:
                    return (int)Math.Round(Convert.ToDouble(cost) * 0.66666);
                case Dice.d12:
                    return (int)Math.Round(Convert.ToDouble(cost) * 0.5);
                default:
                    return -1;
            }
        }

        public static int ApplyDiceSizeCoustMultiplier(int cost, Dice size)
        {
            switch (size)
            {
                case Dice.d4:
                    return (int)Math.Round(Convert.ToDouble(cost) * .66);
                case Dice.d6:
                    return cost;
                case Dice.d8:
                    return (int)Math.Round(Convert.ToDouble(cost) * 1.33);
                case Dice.d10:
                    return (int)Math.Round(Convert.ToDouble(cost) * 1.66);
                case Dice.d12:
                    return (int)Math.Round(Convert.ToDouble(cost) * 2);
                default:
                    return -1;
            }
        }
    }
}