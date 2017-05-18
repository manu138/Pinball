using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticBall : MonoBehaviour {
    private Rigidbody2D rb;
    ConstantForce2D _gravityOffset;
    GameObject currentSurface;
    public float jumpForce = 5f;

    private void Awake()
    {
       rb=GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(Input.GetButton("Jump"))
        {
            Jump();
        }
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        currentSurface = c.gameObject;
        ContactPoint2D contactPoint = c.contacts[0];
        //set new gravity along the normal of contact point
        gravityOffset.force = (-1f * Physics2D.gravity) + (-1f * contactPoint.normal);
        rb.gravityScale = 0.0f;
    }
    private void OnCollisionStay2D(Collision2D c)
    {
        if (c.gameObject == currentSurface)
        {
            //get contact point
            ContactPoint2D contactPoint = c.contacts[0];
            //set new gravity along the normal of contact point
            gravityOffset.force = (-4f * Physics2D.gravity) + (-4f * contactPoint.normal);
        }

    }
    void OnCollisionExit2D(Collision2D c)
    {
        if (c.gameObject == currentSurface)
        {
            currentSurface = null;
            gravityOffset.force = Vector3.zero;
        }

    }
    ConstantForce2D gravityOffset
    {
        get
        {
            if (_gravityOffset == null)
            {
                _gravityOffset = gameObject.AddComponent<ConstantForce2D>();
            }

            return _gravityOffset;
        }

        set { _gravityOffset = value; }
    }
    void Jump()
    {
        //don't jump if not on a surface
        if (currentSurface == null) return;

        //add jump force away from current surface
        rb.AddForce(-1f * gravityOffset.force * jumpForce);

        //return to normal gravity
        gravityOffset.force = Vector3.zero;
    }
}
