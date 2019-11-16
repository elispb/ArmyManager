using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArmyManager.Data
{
    public class Races
    {
        public enum Race
        {
            Bugbear,
            Dragonborn,
            Dwarf,
            Elf,
            [Display(Name = "Winged Elf")]
            ElfWinged,
            Ghoul,
            Gnoll,
            Gnome,
            Halfling,
            Hobgoblin,
            Human,
            Kobold,
            Lizardfolk,
            Oger,
            Orc,
            Skeleton,
            Treant,
            Zombie
        }
    }
}