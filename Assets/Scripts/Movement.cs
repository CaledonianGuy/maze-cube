using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private LayerMask groundLayerMask;
    private Collider _thisCollider;

    private void Start()
    {
        _thisCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded() == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * _jumpSpeed);
        }

    }

    private bool IsGrounded()
    {
        float extraHeight = 0.1f;
        bool raycastHit = Physics.Raycast(_thisCollider.bounds.center, Vector3.down, _thisCollider.bounds.extents.y + extraHeight, groundLayerMask);
        Debug.Log(raycastHit); //
        return raycastHit != false;
    }
}
