using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
public class PlayerController : MonoBehaviour
{
    public Blackboard blackboard;
    // Use this for initialization
    void Start()
    {
        blackboard = GetComponentInChildren<Blackboard>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha4))
            blackboard.SendEvent(54644675);
        if(Input.GetKeyDown(KeyCode.Alpha1))
            blackboard.SendEvent(913225611);
        if(Input.GetKeyDown(KeyCode.Alpha2))
            blackboard.SendEvent(1346017622);
        if(Input.GetKeyDown(KeyCode.Alpha3))
            blackboard.SendEvent(590960297);
    }
}
