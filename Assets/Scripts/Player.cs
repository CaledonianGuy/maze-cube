using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnEnable()
    {
        Main.onTurn += Pivot;
        Main.onSpin += Spin;
    }

    public void Pivot(float angle)
    {
        transform.RotateAround(new Vector3(0, 4.5f, 5.0f), Vector3.back, angle);
        transform.RotateAround(transform.position, Vector3.forward, angle);
    }

    public void Spin(float angle)
    {
        transform.RotateAround(new Vector3(0.0f, 4.5f, 5.0f), Vector3.up, angle);
        transform.RotateAround(transform.position, Vector3.down, angle);
    }

    private void OnDisable()
    {
        Main.onTurn -= Pivot;
        Main.onSpin -= Spin;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
