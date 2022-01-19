

using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float jumForce = 10f;
    public Rigidbody2D rb;
    public string currentColor;
    public SpriteRenderer sprite;
    
 

    //

    //


    ///Player switching .... 
    ///
    public Sprite magentaSprite;
    public Sprite redSprite;
    public Sprite blueSprite;
    public Sprite greenSprite;
    public Sprite yellowSprite;


    public AudioClip colorChange;
    public AudioClip finish;
    public AudioClip tista3;
    //Start ..
    private void Start()
    {
        SetRandomColor();   
    }
    //Update//
    void Update()
    {
       
  

     if (Input.GetButtonDown("Jump") ) 
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumForce;

        }  
     
    }

    //OntriggerEnter

    void endGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != currentColor && collision.tag != "ChangeColor" && collision.tag != "finish")
        {
            GetComponent<AudioSource>().PlayOneShot(tista3, 3f);

            Debug.Log("Game Over ! ");
           //Invoke("endGame", 0.5f);


        }
        
            if (collision.tag == "ChangeColor")
        {
             GetComponent<AudioSource>().PlayOneShot(colorChange, 3f);
              SetRandomColor();
                Destroy(collision.gameObject);
                return;
            }

      
        if (collision.tag == "finish")
        {
            
            GetComponent<AudioSource>().PlayOneShot(finish, 3f);
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


            return;
        }

     

    }

    //RandomColors
    void SetRandomColor() {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0: currentColor ="blue";
                sprite.sprite = blueSprite;
                   break;
            case 1: currentColor ="red";
                    sprite.sprite = redSprite; 
                break;
            case 2: currentColor ="green";
                    sprite.sprite = greenSprite; 
                break;
            case 3: currentColor = "yellow";
                    sprite.sprite = yellowSprite; 
                break;
        }
    }

}
