using UnityEngine;
using System.Collections;

public class BaseClass {

    // base stats
    private string className;
    private string classDescription;

    private int strength;
    private int speed;
    private int endurance;
    private int intellect;

    //getters and setters
    public string ClassName
    {
        get { return className; }
        set { className = value; }
    }

    public string ClassDescription
    {
        get { return classDescription; }
        set { classDescription = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }

    }

    public int Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }

    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }
}
