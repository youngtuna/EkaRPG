using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

    public enum BattleStates {
        START,
        PLAYERCHOICE,
        // PLAYERANIMATE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;

	void Start () {
        currentState = BattleStates.START;
	}

	void Update () {
        Debug.Log(currentState);
	    switch (currentState) {
            case (BattleStates.START):
                //SETUP BATTLE FUNCTION
                break;
            case (BattleStates.PLAYERCHOICE):

                break;
            case (BattleStates.ENEMYCHOICE):

                break;
            case (BattleStates.LOSE):

                break;
            case (BattleStates.WIN):

                break;
        }
	}

    void OnGUI() {
        if(GUILayout.Button("NEXT STATE")) {
            if(currentState == BattleStates.START) {
                currentState = BattleStates.PLAYERCHOICE; 
            } else if (currentState == BattleStates.PLAYERCHOICE) {
                currentState = BattleStates.ENEMYCHOICE;
            } else if (currentState == BattleStates.START) {
                currentState = BattleStates.PLAYERCHOICE;
            } else if (currentState == BattleStates.START) {
                currentState = BattleStates.PLAYERCHOICE;
            } else if (currentState == BattleStates.START) {
                currentState = BattleStates.PLAYERCHOICE;
            }
        }
    }
}
