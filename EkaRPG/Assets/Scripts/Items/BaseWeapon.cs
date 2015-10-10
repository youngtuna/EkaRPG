using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseItem {

    private int weaponAttack;
     
	public enum WeaponTypes
    {
        SWORD,
        CLUB,
        DAGGER,
        STICK,
        SPEAR
    }

    private WeaponTypes weaponType;

    public int WeaponAttack
    {
        get { return weaponAttack; }
        set { weaponAttack = value; }
    }

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }
}
