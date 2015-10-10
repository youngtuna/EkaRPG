using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] { "Common", "Great", "Ass", "Insane" };

	// Use this for initialization
	void Start () {
        CreateEquipment();
        Debug.Log("Item name: " + newEquipment.ItemName);
        Debug.Log("Item ID: " + newEquipment.ItemID.ToString());
        Debug.Log("Item type: " + newEquipment.ItemType);
        Debug.Log("Equipment type: " + newEquipment.EquipmentType);
    }

    // creates a random equipment
    private void CreateEquipment()
    {
        newEquipment = new BaseEquipment();
        newEquipment.ItemName = itemNames[Random.Range(0,3)] + " item yo.";
        newEquipment.ItemID = Random.Range(1,101);
        newEquipment.ItemType = BaseItem.ItemTypes.EQUIPMENT;
        ChooseEquipmentType();
    }

    private void ChooseEquipmentType()
    {
        int randomTemp = Random.Range(1,3);
        if (randomTemp == 1)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
        } else if (randomTemp == 2)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
        }
        else if (randomTemp == 3)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.TORSO;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
