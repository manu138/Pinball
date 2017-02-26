using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ToggleBumper : Bumper
{
   
    public bool active = false;
    public SpriteRenderer sr;
 
   
    // Use this for initialization
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(0, 1, 0, 1);

    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter2D(Collider2D dmg)
    {
       
                
            if (active == false)
            {
                sr.color = new Color(0, 0, 1, 1);
                active = true;
           
         
        }


           else  if (active == true )
            {
            
            sr.color = new Color(0, 1, 0, 1);
            active = false;
           
        }

        



    }
   
    IEnumerator Tpfix()
    {

        yield return new WaitForSeconds(0.1f);
       

    }
}

