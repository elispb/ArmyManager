using ArmyManager.Classes;

namespace ArmyManager.Data
{
    public class UnitTypes
    {
        public enum UnitType
        {
            Flying,
            Archers,
            Cavalry,
            Levies,
            Infantry,
            Seige
        }
        public static void AddTypeBonus(Unit unitToModify)
        {
            switch (unitToModify.Type)
            {
                case UnitType.Flying:
                    unitToModify.Morale += 3;
                    break;
                case UnitType.Archers:
                    unitToModify.Power += 1;
                    unitToModify.Morale += 1;
                    break;
                case UnitType.Cavalry:
                    unitToModify.Attack += 1;
                    unitToModify.Power += 1;
                    unitToModify.Morale += 2;
                    break;
                case UnitType.Levies:
                    unitToModify.Morale -= 1;
                    break;
                case UnitType.Infantry:
                    unitToModify.Defence += 1;
                    unitToModify.Toughness += 1;
                    break;
                case UnitType.Seige:
                    unitToModify.Attack += 1;
                    unitToModify.Power += 1;
                    unitToModify.Toughness += 1;
                    break;
            }
        }
    }
}