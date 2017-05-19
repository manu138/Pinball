using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    private Rigidbody2D rb;
    ConstantForce2D _gravityOffset;
    GameObject currentSurface;
    public float jumpForce = 5f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Jumpp();
        }
    }

    void Jumpp()
    {

        rb.AddForce(Vector2.up * jumpForce);


    }
}
