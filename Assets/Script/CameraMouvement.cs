using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouvement : MonoBehaviour
{
    public Transform lookAt; 

    private Vector3 offset; 
    public bool TestPosition = false;
    private bool ok = false;

    private float transition= 0.0f;
    private float animationDuration = 2.0f;
    private Vector3 annimationOffset = new Vector3(0,5,5);
    private bool startTest;
    private bool changeOffset;


    void Start()
    {
       lookAt= GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - lookAt.position;


    }

    // Update is called once per frame
    void Update()
    {
        startTest = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().isGameStarted;
        Animator a = gameObject.GetComponent<Animator>();
        changeOffset = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().changeCameraOffset;

    
       
        if (transition < 1f && startTest==true)
        {
            a.enabled = false;
            transform.position = Vector3.Lerp(lookAt.position + offset + annimationOffset, lookAt.position + offset, transition);
            transition += Time.deltaTime * 1 / animationDuration;

        }
        else if (changeOffset==true)
        {
            if (ok == false)
            {

                offset = (transform.position + new Vector3(0, 0, 5)) - lookAt.position;

                ok = true;


            }
            transform.position = lookAt.position + offset;

        }
        else
        {
           
            transform.position = lookAt.position + offset;

        }


        if  (TestPosition == true)
        {
            if (ok == false)
            {
                transform.Rotate(16, 186, 4);
                offset = (transform.position + new Vector3(0, 0, 14)) - lookAt.position ;

                ok = true;


            }

            transform.position = lookAt.position  +offset ;

        }
    }

}
