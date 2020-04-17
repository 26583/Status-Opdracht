using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitAnimation : MonoBehaviour
{
    private bool hit = false;

    private void OnCollisionStay(Collision collision)
    {
        if (!hit)
        {
            GettingHit();
            hit = true;
        }
    }

    public void GettingHit()
    {
        Debug.Log("Hit.");
        StartCoroutine("HitCoroutine");
    }

    IEnumerator HitCoroutine()
    {
        yield return new WaitForSeconds(3.0f);
        Debug.Log("Stop.");
        hit = false;
    }
}
