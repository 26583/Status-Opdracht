using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class EntityDistanceChecker : MonoBehaviour
{
    List<GameObject> entitys = new List<GameObject>();
    public event Action ChangeBehave;
    void Update()
    {
        if(Vector3.Distance(entitys[0].transform.position,
            entitys[1].transform.position) <2)
        {
            ChangeBehave();
        }
    }
    public void GetAllPlayers(GameObject player)
    {
        Debug.Log(player.name);
        entitys.Add(player);
    }
}
