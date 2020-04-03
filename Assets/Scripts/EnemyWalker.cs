using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    Behavior.States behavior = Behavior.States.IDLE;
    [SerializeField]
    EntityDistanceChecker check;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(behavior);
        behavior = Behavior.States.CHASE;
        check.ChangeBehave += ChangeBehave;
    }

    // Update is called once per frame
    void Update()
    {
       if(behavior == Behavior.States.CHASE)
        {
            Chase();
        }
    }
    void Chase()
    {
        Debug.Log("AAAAAA!!");
    }
    void ChangeBehave()
    {
        if(behavior == Behavior.States.CHASE)
        {
            behavior = Behavior.States.EVADE;
            Debug.Log(behavior);
        } else if(behavior == Behavior.States.EVADE)
        {
            behavior = Behavior.States.CHASE;
            Debug.Log(behavior);
        }
    }
}
