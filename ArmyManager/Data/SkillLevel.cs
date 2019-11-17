using ArmyManager.SaveableObjects;
using System.ComponentModel.DataAnnotations;

namespace ArmyManager.Data
{
    public class SkillLevel
    {
        public enum Level
        {
            Green,
            Regular,
            Seasoned,
            Veteran,
            Elite,
            [Display(Name = "Super Elite")]
            SuperElite
        }

        public static void AddSkillBonus(Unit unitToModify)
        {
            switch (unitToModify.Expireince)
            {
                case Level.Green:
                    break;
                case Level.Regular:
                    unitToModify.Attack += 1;
                    unitToModify.Toughness += 1;
                    unitToModify.Morale += 1;
                    break;
                case Level.Seasoned:
                    unitToModify.Attack += 1;
                    unitToModify.Toughness += 1;
                    unitToModify.Morale += 2;
                    break;
                case Level.Veteran:
                    unitToModify.Attack += 1;
                    unitToModify.Toughness += 1;
                    unitToModify.Morale += 3;
                    break;
                case Level.Elite:
                    unitToModify.Attack += 2;
                    unitToModify.Toughness += 2;
                    unitToModify.Morale += 4;
                    break;
                case Level.SuperElite:
                    unitToModify.Attack += 2;
                    unitToModify.Toughness += 2;
                    unitToModify.Morale += 5;
                    break;
            }
        }
    }
}