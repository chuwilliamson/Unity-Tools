using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
public class JobSelection : StateBehaviour {
    
    void OnEnable()
    {
        
    }
    void Process()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
            blackboard.SendEvent(54644675);
        if (Input.GetKeyDown(KeyCode.Alpha1))
            blackboard.SendEvent(913225611);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            blackboard.SendEvent(1346017622);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            blackboard.SendEvent(590960297);
    }
    void OnDisable()
    {

    }
}
