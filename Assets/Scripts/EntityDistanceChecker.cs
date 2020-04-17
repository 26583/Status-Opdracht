using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class EntityDistanceChecker : MonoBehaviour
{
    [SerializeField]
    private float magnitude;

    List<GameObject> entities = new List<GameObject>();

    public event Action<GameObject> SetTarget;
    public event Action ChangeBehave;
    public event Action KeepIdle;

    void Update()
    {
        if(Vector3.Distance(entities[0].transform.position,
            entities[1].transform.position) < magnitude)
        {
            SetTarget(entities[1]);
            ChangeBehave();
        }
        else
        {
            KeepIdle();
        }
    }

    public void GetAllPlayers(GameObject player)
    {
        entities.Add(player);
    }
}
