using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Life;

using System.Collections.Generic;


public class Flipper : MonoBehaviour {
    public GameObject leftFlipper;
    public GameObject rightFlipper;
    Rigidbody2D leftFlipperRigid;
    Rigidbody2D rightFlipperRigid;

    public float torqueForce;

    // Use this for initialization
    void Start ()
    {
        leftFlipperRigid = leftFlipper.GetComponent<Rigidbody2D>();
        rightFlipperRigid = rightFlipper.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
           
            Vector3 mouseInput = Input.mousePosition;
            //Flipping right
            if (mouseInput.x >= Screen.width / 2f)
            {
               AddTorque(rightFlipperRigid ,- torqueForce);
            }

            //Flipping left
            if (mouseInput.x < Screen.width / 2f)
            {
              AddTorque(leftFlipperRigid,torqueForce);
            }
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 mouseHolding = Input.mousePosition;

            //Holding right
            if (mouseHolding.x >= Screen.width / 2f)
            {
              AddTorque(rightFlipperRigid ,- torqueForce);
            }

            //Holdding left
            if (mouseHolding.x < Screen.width / 2f)
            {
               AddTorque(leftFlipperRigid,torqueForce);
            }
        }
      
    }
    void AddTorque(Rigidbody2D rigid, float force)
    {
        rigid.AddTorque(force);
    }
}
