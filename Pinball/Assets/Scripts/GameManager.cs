using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SgLib;
using UnityEngine.UI;
using Life;



public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject ballPrefab2;
    public GameObject ballPoint;
    public GameObject ballPoint2;
    public Text gameoverText;
    public GameObject ball;
    public int counter=0;
    public GameObject leftflipper;
    public GameObject rightflipper;
    private bool vida = false;

    // Use this for initialization
    void Start ()
    {
        CreateBall();
        ball = GameObject.FindWithTag("Player");
        leftflipper = GameObject.FindWithTag("flipperL");
        rightflipper = GameObject.FindWithTag("flipperR");
        LifeManager.Instance.AddLifes(4);
        ScoreManager.Instance.Reset();
        ScoreManager.Instance.print();
      
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        if (LifeManager.Instance.Lifes-1 > 0 && ball == null)
        {
            CreateBall();
            ball = GameObject.FindWithTag("Player");
            LifeManager.Instance.MinusLifes(1);
        }
        else if( ball == null)
        {
            Destroy(leftflipper);
            Destroy(rightflipper);
            gameoverText.text = "Game over!";
        }
        if(ScoreManager.Instance.Score==100 && vida==false)
        {
            LifeManager.Instance.AddLifes(1);
            vida = true;
        }
       
     
    }
    public void CreateBall()
    {
        GameObject ball = Instantiate(ballPrefab, ballPoint.transform.position, Quaternion.identity) as GameObject;
        GameObject ball2= Instantiate(ballPrefab2, ballPoint.transform.position, Quaternion.identity) as GameObject;
    }
}
