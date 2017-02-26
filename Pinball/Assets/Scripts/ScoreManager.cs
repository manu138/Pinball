using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;


namespace SgLib
{
   
    public class ScoreManager : MonoBehaviour
    {
        public Text scoreText;
        public static ScoreManager Instance { get; private set; }

        public int Score { get; private set; }

            

       
     


        void Awake()
        {
            if (Instance)
            {
                DestroyImmediate(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        void Start()
        {
            Reset();
        }
      
        public void Reset()
        {
            // Initialize score
            Score = 0;

        
        }

        public void AddScore(int amount)
        {
            Score += amount;

            // Fire event
       

           
        }
        public void print()
        {
            
            scoreText.text = "Score:"+Score;
        }

     
    }
}
