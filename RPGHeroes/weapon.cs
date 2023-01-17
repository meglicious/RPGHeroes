using System;
using System.Collections.Generic;

namespace Application
{
    public string Name { get; private set; }
    public int RequiredLevel { get; private set; }
    public int Slot { get; private set; }
    public WeaponType Type { get; private set; }

   

    private static Dictionary<WeaponType, weapon> s_weapon = new Dictionary<WeaponType, weapon>
  {
    { WeaponType.Axes, new weapon { Type = WeaponType.Axes, Description = "Weapon needed for the use of Axes", Advanced = false, PointsToLearn = 1, } },
    { WeaponType.Bows, new weapon { Type = WeaponType.Bows, Description = "Weapon needed for use of Bows", Advanced = false, PointsToLearn = 2, } },
    { WeaponType.Daggers, new weapon { Type = WeaponType.Daggers, Description = "Weapon needed for use of Daggers", Advanced = false, PointsToLearn = 3, } },
    { WeaponType.Hammers, new weapon { Type = WeaponType.Hammers, Description = "Weapon needed to use of Hammers", Advanced = false, PointsToLearn = 1, } },
    { WeaponType.Swords, new weapon { Type = WeaponType.Swords, Description = "Weapon needed to use of Swords", Advanced = false, PointsToLearn = 1, } },
    { WeaponType.Staffs, new weapon { Type = WeaponType.Staffs, Description = "Weapon needed to use of Staffs", Advanced = true, PointsToLearn = 0, } },{ WeaponType.Hammers, new Skill { Type = WeaponType.Hammers, Description = "Weapon needed to use of Hammers", Advanced = false, PointsToLearn = 1, } },
    { WeaponType.Wands, new weapon { Type = WeaponType.Wands, Description = "Weapon needed to use of Wands", Advanced = true, PointsToLearn = 0, } },{ WeaponType.Staffs, new Skill { Type = WeaponType.Staffs, Description = "Weapon needed to use of Staffs", Advanced = true, PointsToLearn = 0, } },
  };

    public static weapon Factory(WeaponType type)
    {
        return s_weapon[type];
    }
}

public enum WeaponType //encapsulate these in a WeaponType enumerator
{
    Axes,
    Bows,
    Daggers,
    Hammers,
    Staffs,
    Swords,
    Wands
}

public class weapon
    {
        {
        protected int damage; // this is our actual property to store the damage
        import attribute int Damage; // this is our attribute
        import int GetDamage();
        import void SetDamage(int);
    };
    int Weapon::GetDamage()
    {
        return this.damage;
    }

    void Weapon::SetDamage(int damage)
    {
        this.damage = damage;
    }
    public weapon()
		{
        void Weapon::SetDamage(int damage)
{
            if (damage < 0) damage = 0;
            this.damage = damage;
        }
    }
	}
}

