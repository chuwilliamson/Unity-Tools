using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
public enum JobState
{
ACROBAT = 54644675,    
MERCENARY = 913225611,
MAGICIAN = 1346017622,
ASSIST = 590960297,
        
}
public class JobSelection : StateBehaviour {
    
    void OnEnable()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            blackboard.SendEvent((int)JobState.ACROBAT);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            blackboard.SendEvent((int)JobState.MERCENARY);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            blackboard.SendEvent((int)JobState.MAGICIAN);
        if (Input.GetKeyDown(KeyCode.Alpha4))
            blackboard.SendEvent((int)JobState.ASSIST);
    }
    void OnDisable()
    {

    }
}
