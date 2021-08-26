using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VicCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("You won the game, well done!");
        }
    }

    private void OnEnable()
    {
        Main.onTurn += Pivot;
        Main.onSpin += Spin;
    }

    public void Pivot(float angle)
    {
        transform.RotateAround(new Vector3(0, 4.5f, 5.0f), Vector3.back, angle);
    }

    public void Spin(float angle)
    {
        transform.RotateAround(new Vector3(0.0f, 4.5f, 5.0f), Vector3.up, angle);
    }

    private void OnDisable()
    {
        Main.onTurn -= Pivot;
        Main.onSpin -= Spin;
    }
}
