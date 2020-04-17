using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody rb;

    private float pHorizontal, pVertical;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        pHorizontal = Input.GetAxis("Horizontal");
        pVertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(pHorizontal * speed,  0.0f, pVertical * speed);
    }
}
