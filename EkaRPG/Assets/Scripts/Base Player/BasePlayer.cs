using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {

    private string playerName;
    private int playerLevel;
    private BaseClass playerClass;

    private int strength;
    private int speed;
    private int endurance;
    private int intellect;

    public int PlayerLevel {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public string PlayerName {
        get { return playerName; }
        set { playerName = value; }
    }

    public BaseClass PlayerClass {
        get { return playerClass; }
        set { playerClass = value; }
    }

    public int Strength {
        get { return strength; }
        set { strength = value; }
    }

    public int Speed {
        get { return speed; }
        set { speed = value; }

    }

    public int Endurance {
        get { return endurance; }
        set { endurance = value; }
    }

    public int Intellect {
        get { return intellect; }
        set { intellect = value; }
    }
}
