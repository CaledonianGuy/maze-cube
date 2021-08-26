using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void OnEnable()
    {
        Main.onTurn += Pivot;
        Main.onSpin += Spin;
    }

    public void Pivot(float angle)
    {
        transform.RotateAround(new Vector3(0.0f, 4.5f, 5.0f), Vector3.back, angle);
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
