using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouvMaze : MonoBehaviour
{
   
    public Transform lookAt;

    private Vector3 offset;



    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - lookAt.position;


    }

    // Update is called once per frame
    void Update()
    {
  

    
            transform.position = lookAt.position + offset;

       


       

         
    }
}
