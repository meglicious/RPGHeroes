using System;
using System.Collections.Generic;

namespace Application
{
	public class Armor
	{
        public string Name { get; private set; }
        public int RequiredLevel { get; private set; }
        public int Slot { get; private set; }
        public ArmorType Type { get; private set; }

        public Armor()
        {
        }

        private static Dictionary<ArmorType, Armor> s_armor = new Dictionary<ArmorType, Armor>
  {
    { ArmorType.Cloth, new Armor { Type = ArmorType.Cloth, Description = "Armor needed for the hero", Advanced = false, PointsToLearn = 1, } },
    { ArmorType.Leather, new Armor { Type = ArmorType.Leather, Description = "Armor needed for the hero", Advanced = false, PointsToLearn = 2, } },
    { ArmorType.Mail, new Armor { Type = ArmorType.Mail, Description = "Armor needed for the hero", Advanced = false, PointsToLearn = 3, } },
    { ArmorType.Plate, new Armor { Type = ArmorType.Plate, Description = "Armor needed for the hero", Advanced = false, PointsToLearn = 1, } },
  };

        public static Armor Factory(ArmorType type)
        {
            return s_armor[type];
        }
    }

    public enum ArmorType //encapsulate these in a ArmorType enumerator
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }
  
	}
}

