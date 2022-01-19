using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaze : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 moveVector;  
    public  float playerSpeed= 6f ;

    public bool isMazeStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        GetComponent<AudioSource>().Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (isMazeStarted == false)
        {

            return;
        }
        else { 
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");


            moveVector = new Vector3(moveX, 0, moveZ).normalized;
            if (moveVector.magnitude >= 0.1f)
        {
            float targetangle = Mathf.Atan2(moveVector.x, moveVector.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetangle, 0f);
            controller.Move(moveVector * playerSpeed * Time.deltaTime);
        }
     
    
            
        }






    }


}


