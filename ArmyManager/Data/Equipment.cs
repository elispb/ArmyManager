
using ArmyManager.Classes;

namespace ArmyManager.Data
{
    public class Equipment
    {
        public enum EquipmentLevel
        {
            Light,
            Medium,
            Heavy,
            SuperHeavy
        }
        public static void AddEquipmentBonus(Unit unitToModify)
        {
            switch ((EquipmentLevel)unitToModify.Equipment)
            {
                case EquipmentLevel.Light:
                    unitToModify.Power += 1;
                    unitToModify.Defense += 1;
                    break;
                case EquipmentLevel.Medium:
                    unitToModify.Power += 2;
                    unitToModify.Defense += 2;
                    break;
                case EquipmentLevel.Heavy:
                    unitToModify.Power += 4;
                    unitToModify.Defense += 4;
                    break;
                case EquipmentLevel.SuperHeavy:
                    unitToModify.Power += 6;
                    unitToModify.Defense += 6;
                    break;
            }
        }
    }
}