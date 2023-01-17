using System;
using System.Collections.Generic;
using System.Linq;
namespace RPGHeroes
{
	public class MyHeroes
	{
		public int Level;
		public string Name;
		public string LevelAttributes;
		public string Equipment;
		public string ValidWeaponTypes;
		public string ValidArmorTypes;
		
        public List<string> Details;

    

        public MyHeroes()
		{
		}

        public MyHeroes(List<string> details)
        {
            Details = details;
        }

        public MyHeroes(int level, string name, string levelAttributes, string equipment, string validWeaponTypes, string validArmorTypes)
        {
            Level = level;
            Name = name;
            LevelAttributes = levelAttributes;
            Equipment = equipment;
            ValidWeaponTypes = validWeaponTypes;
            ValidArmorTypes = validArmorTypes;
            
            
        }
    }
}

