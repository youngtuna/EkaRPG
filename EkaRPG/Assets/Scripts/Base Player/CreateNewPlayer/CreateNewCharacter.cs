using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {

    private BasePlayer newPlayer;
    private bool isRogueClass;
    private bool isWarriorClass;

	// Use this for initialization
	void Start () {
        newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnGUI() {
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        isRogueClass = GUILayout.Toggle(isRogueClass, "Rogue Class");

        if (GUILayout.Button("Create")) {

            if(isWarriorClass) {
                newPlayer.PlayerClass = new BaseWarriorClass();
            } else if (isRogueClass) {
                newPlayer.PlayerClass = new BaseRogueClass();
            }

            newPlayer.PlayerLevel = 1;
            newPlayer.PlayerName = "Homonaama";
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            newPlayer.Speed = newPlayer.PlayerClass.Speed;
            newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
            newPlayer.Endurance = newPlayer.PlayerClass.Endurance;

            Debug.Log("Player Class: " + newPlayer.PlayerClass.ClassName);
            Debug.Log("Player Level: " + newPlayer.PlayerLevel);
            Debug.Log("Player Name: " + newPlayer.PlayerName);
            Debug.Log("Player Str: " + newPlayer.Strength);
            Debug.Log("Player Spd: " + newPlayer.Speed);
            Debug.Log("Player Int: " + newPlayer.Intellect);
            Debug.Log("Player End: " + newPlayer.Endurance);
        }
    }
}
