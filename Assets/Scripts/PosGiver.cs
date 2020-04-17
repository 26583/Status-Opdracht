using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosGiver : MonoBehaviour
{
    [SerializeField]
    private EntityDistanceChecker check;

    void Start()
    {
        check.GetAllPlayers(gameObject);
    }
}
