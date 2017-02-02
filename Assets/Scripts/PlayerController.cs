﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using UnityEngine.Events;
 

public class PlayerController : MonoBehaviour
{    
    public Blackboard blackboard;
    // Use this for initialization
    void Awake()
    {
        blackboard = GetComponentInChildren<Blackboard>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {            
            blackboard.SendEvent(1870230623);
        }
    }

    
}
