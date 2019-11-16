using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
    }
}