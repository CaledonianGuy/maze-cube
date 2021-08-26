using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotCube : MonoBehaviour
{
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Debug.Log("You won the game, well done!");
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint hitPos in collision.contacts)
        {
            Debug.Log(hitPos.normal);
        }
    }

    private void OnEnable()
    {
        Main.onTurn += Pivot;
    }

    public void Pivot(float angle)
    {
        transform.RotateAround(new Vector3(0, 4.5f, 5.0f), Vector3.back, angle);
    }

    private void OnDisable()
    {
        Main.onTurn -= Pivot;
    }
}
