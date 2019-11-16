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
            switch (unitToModify.Equipment)
            {
                case EquipmentLevel.Light:
                    unitToModify.Power += 1;
                    unitToModify.Defence += 1;
                    break;
                case EquipmentLevel.Medium:
                    unitToModify.Power += 2;
                    unitToModify.Defence += 2;
                    break;
                case EquipmentLevel.Heavy:
                    unitToModify.Power += 4;
                    unitToModify.Defence += 4;
                    break;
                case EquipmentLevel.SuperHeavy:
                    unitToModify.Power += 6;
                    unitToModify.Defence += 6;
                    break;
            }
        }
    }
}