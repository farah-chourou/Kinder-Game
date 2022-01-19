
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController controller;
    private Animator animator;
    private Vector3 moveVector;

    public float speed = 6.0f;
    private float VerticalVelocity = 0.0f;
    private float gravity = 12.0f;
    public float jumpForce = 1.5f;
    private int number_death = 0;
    private bool isDead = false;

    public bool isGameStarted ;
    public GameObject startingText;

    private bool isChangeDirection;
    private bool isRotate;
    public bool changeCameraOffset=false;

    public bool winner = false;



    private bool isaudioPlayOne=false;

    private bool energyEnd;
    public AudioClip aayat;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        isGameStarted = false;
        isChangeDirection = false;
        isRotate = false;

    }

    // Update is called once per frame
    void Update()
    {
        energyEnd = controller.GetComponent<Score>().isEnergyEnd;


        if (Input.GetKeyDown("space"))
        {
            isGameStarted = true;
            Destroy(startingText);
            if (isaudioPlayOne == false)
            {
                GetComponent<AudioSource>().Play();
                isaudioPlayOne = true;

            }

        }
        if (isGameStarted == false)
        {
            return;
        }

        if (isDead)
        {
          return;
        }

        if (energyEnd == true)
        {
            DeathWithEnergy();
        }

        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            VerticalVelocity = -0.5f;
            jump();
        }
        else
        {
            VerticalVelocity -= gravity * Time.deltaTime;
            animator.SetBool("jump", false);


        }
        if (isChangeDirection == false)
        {
            Run();
        }
        else
        {
            RunDirection();
        }
      

        controller.Move(moveVector * Time.deltaTime);
    }

    void Run()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal") * -speed;
        moveVector.z = -speed;
        moveVector.y = VerticalVelocity;


    }
    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            VerticalVelocity = Mathf.Sqrt(jumpForce * gravity);
            moveVector.y = VerticalVelocity;
            animator.SetBool("jump", true);


        }




    }

  
     private void OnControllerColliderHit(ControllerColliderHit hit)
    {
       if ( hit.transform.tag == "obstacle" )
        {
                Death();
        }
       if (hit.transform.tag == "point")
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMouvement>().TestPosition = true;

        }
        if (hit.transform.tag == "changeJump2")
        {
            jumpForce = 4f;
            speed = 17f;

        }

        if (hit.transform.tag == "finish")
        {
            Debug.Log("winner");
            winner = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        if (hit.transform.tag == "jump")
        {
            
            jumpForce = 100f;
            GetComponent<AudioSource>().PlayOneShot(aayat, 3f);



        }



    }
    private void DeathWithEnergy()
    {

        

        animator.SetTrigger("death");
        SceneManager.LoadScene("GameOver3");
        isDead = true;

    }
    private void Death()
    {

        Debug.Log("game over");
        
        animator.SetTrigger("death");
        Invoke("endGame", 3f);
        isDead = true;

    }
    void endGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }
    void RunDirection()
    {
        if (isRotate == false)
        {
            controller.transform.Rotate(0, 80, 0);
            isRotate = true;
            changeCameraOffset = true;

        }
        
        moveVector.x =  -speed;
      //  moveVector.z = Input.GetAxisRaw("Horizontal") * -speed;
        moveVector.y = VerticalVelocity;


    }



}
