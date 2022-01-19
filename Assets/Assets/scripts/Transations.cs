using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transations : MonoBehaviour
{
    private float timeRemaining;
    public float realTimeRemaining;
    public float speed = 10f;


    private void Start()
    {
        timeRemaining = realTimeRemaining;


    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);

   
       
            if (timeRemaining >= 0.1)
            {

                
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                speed *= -1;
                
                timeRemaining = realTimeRemaining;
                
            }
        
    }
}