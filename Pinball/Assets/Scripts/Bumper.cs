using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SgLib;

public class Bumper : MonoBehaviour {
   
    public float bumperForce = 100;
    // Use this for initialization
    void Start ()
    {
       

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        foreach ( ContactPoint2D contact in collision.contacts)
        {
            Vector2 vector2 = new Vector2();
            vector2 = contact.otherCollider.GetComponent<Rigidbody2D>().velocity;
            vector2.Normalize();

            Vector2 vector1 = new Vector2();
            vector1 = Vector3.Reflect(vector2, contact.normal);
            vector1.Normalize();

            contact.otherCollider.GetComponent<Rigidbody2D>().AddForce(-1 * vector1 * bumperForce,  ForceMode2D.Impulse);
            ScoreManager.Instance.AddScore(100);
            ScoreManager.Instance.print();

        }
        

       
    }
}
