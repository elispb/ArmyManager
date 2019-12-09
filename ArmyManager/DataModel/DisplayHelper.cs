using ArmyManager.SaveableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ArmyManager.DataModel
{
    public class DisplayHelper
    {
        public static string UnitToHtml(Unit unitToConvert)
        {
            var traitStringBuilder = new StringBuilder();
            if (unitToConvert.Traits != null)
            {
                foreach (var trait in unitToConvert.Traits)
                {
                    traitStringBuilder.Append($"<p>{trait.Name}: {trait.Description}</p>");
                }
            }

            var htmlUnit = $"<div class=\"Unit\">" +
                $"<h3>{unitToConvert.Name}</h3>" +
                $"<p>{unitToConvert.Species?.Name} {unitToConvert.Expireince}," +
                $" {unitToConvert.Equipment} {unitToConvert.Type}</p>" +
                $"<table>" +
                $"<tr><td>Attack: {unitToConvert.Attack}</td><td>Defense: {unitToConvert.Defense}</td></tr>" +
                $"<tr><td>Power: {unitToConvert.Power}</td><td>Toughness: {unitToConvert.Toughness}</td></tr>" +
                $"<tr><td>Morale: {unitToConvert.Morale}</td><td>Size: {unitToConvert.UnitSize}/{unitToConvert.DiceSize}</td></tr>" +
                $"</table>" +
                traitStringBuilder?.ToString() +
                $"</div>";
            return htmlUnit;
        }
    }
}