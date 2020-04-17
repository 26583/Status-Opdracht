using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private EntityDistanceChecker check;

    private Vector3 target;
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
       else if (behavior == Behavior.States.IDLE)
       {
            Patrouilleren();
       }
    }

    void Chase()
    {
        //Debug.Log("AAAAAA!!");
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
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

    void SetTarget(GameObject obj)
    {
        target = obj.transform.position;
    }

    void KeepIdle()
    {
        behavior = Behavior.States.IDLE;
    }

    void Patrouilleren()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, (speed / 3) * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            float randX = Random.Range(transform.position.x - 2.0f, transform.position.x + 2.0f);
            float randZ = Random.Range(transform.position.z - 2.0f, transform.position.z + 2.0f);

            target = new Vector3(randX, transform.position.y, randZ);
        }
    }

    void Attack()
    {

    }
}
