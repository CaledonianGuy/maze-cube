using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //bool isLeft = true;

        //if (isLeft == true)
        //{
        //    transform.Translate(Vector3.down * 1 * Time.deltaTime);
        //    if (transform.position.x >= 3.5)
        //    {
        //        isLeft = false;
        //    }
        //}
        //else if (isLeft != true)
        //{
        //    transform.Translate(Vector3.up * 1 * Time.deltaTime);
        //    if (transform.position.x <= 1.5)
        //    {
        //        isLeft = true;
        //    }
        //}

        do 
        {
            transform.Translate(Vector3.down * 0.1f * Time.deltaTime);
        } while (transform.position.x <= 5.0f);

        //while (transform.position.x <= 3.5)
        //{

        //}
    }
}
