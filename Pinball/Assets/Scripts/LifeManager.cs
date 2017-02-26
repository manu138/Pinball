using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Life
{
    public class LifeManager : MonoBehaviour
{

        public static LifeManager Instance { get; private set; }

        public int Lifes { get; private set; }







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
           Lifes = 0;


        }

        public void AddLifes(int amount)
        {
            Lifes += amount;

            // Fire event



        }
        public void MinusLifes(int amount)
        {
            Lifes -= amount;

            // Fire event



        }

        public void print()
        {

            
        }


    }
}
