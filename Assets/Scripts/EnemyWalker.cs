using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private EntityDistanceChecker check;

    private GameObject target;
    private Behavior.States behavior;

    void Start()
    {
        KeepIdle();

        check.SetTarget += SetTarget;
        check.ChangeBehave += ChangeBehave;
        check.KeepIdle += KeepIdle;
    }
    
    void Update()
    {
       if (behavior == Behavior.States.CHASE)
       {
            Chase();
       }
    }

    void Chase()
    {
        //Debug.Log("AAAAAA!!");
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    void ChangeBehave()
    {
        if (gameObject.name == "Player")
        {
            behavior = Behavior.States.EVADE;
        }
        else if (gameObject.name == "Enemy")
        {
            behavior = Behavior.States.CHASE;
        }
    }

    private void SetTarget(GameObject obj)
    {
        target = obj;
    }

    void KeepIdle()
    {
        behavior = Behavior.States.IDLE;
    }
}
