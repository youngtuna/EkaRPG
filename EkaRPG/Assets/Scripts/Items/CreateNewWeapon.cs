using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;
    private string[] weaponNames = new string[4] { "Common", "Great", "Ass", "Insane" };

    void Start()
    {
        CreateWeapon();
        Debug.Log("Weapon name: " + newWeapon.ItemName);
        Debug.Log("Weapon ID: " + newWeapon.ItemID.ToString());
        Debug.Log("Item Type: " + newWeapon.ItemType);
        Debug.Log("Weapon Type: " + newWeapon.WeaponType);
    }

    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();
        newWeapon.ItemName = weaponNames[Random.Range(0,3)] + " weapon.";
        newWeapon.ItemDescription = "Hieno ase.";
        newWeapon.ItemID = Random.Range(0,101);
        ChooseWeaponType();
    }

    private void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1,6);
        if (randomTemp == 1)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.CLUB;
        }
        else if (randomTemp == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
        }
        else if (randomTemp == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SPEAR;
        }
        else if (randomTemp == 4)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STICK;
        }
        else if (randomTemp == 5)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
