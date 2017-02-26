using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SgLib;
using Life;


public class Ball : MonoBehaviour
{
    
	// Use this for initialization
	void Start ()
    {
        

    }

    // Update is called once per frame
    void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Dead")
        {
            Destroy(gameObject);
       
           
          
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gold") )
        {
            ScoreManager.Instance.AddScore(100);
            ScoreManager.Instance.print();
            Destroy(other.gameObject);
          
        }
    }
}
