using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SgLib;



public class BumperGroup : MonoBehaviour {
    public GameObject[] toggle;
    public SpriteRenderer toggle1;
    public SpriteRenderer toggle2;
    public SpriteRenderer toggle3;

    public  int encendido=0;

    // Use this for initialization
    void Start ()
    {
        toggle = GameObject.FindGameObjectsWithTag("Toggle");

        

    }
	
	// Update is called once per frame
	void Update ()
    {
      
            if (toggle1.color == new Color(0, 1, 0, 1)&& toggle2.color == new Color(0, 1, 0, 1) && toggle3.color == new Color(0, 1, 0, 1))
            {
                encendido++;
            if(encendido==3)
            {
                encendido = 0;
                toggle1.color = new Color(0, 0, 1, 1);
                toggle2.color = new Color(0, 0, 1, 1);
                toggle3.color = new Color(0, 0, 1, 1);
                Debug.Log("los apague");
                ScoreManager.Instance.AddScore(1000);
                ScoreManager.Instance.print();

            }
            }
        
        
    
        
	}
}
