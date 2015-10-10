using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseItem {

    private int equipmentDefense;

    public enum EquipmentTypes
    {
        HEAD,
        TORSO,
        LEGS
    }

    private EquipmentTypes equipmentType;

    public int EquipmentDefense
    {
        get { return equipmentDefense; }
        set { equipmentDefense = value; }
    }

    public EquipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }
}
