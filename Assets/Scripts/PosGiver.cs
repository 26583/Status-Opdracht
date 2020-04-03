using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosGiver : MonoBehaviour
{
    [SerializeField]
    EntityDistanceChecker check;
    // Start is called before the first frame update
    void Start()
    {
        check.GetAllPlayers(gameObject);
    }
}
