using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text ScoreText;
    public Text ScoreStars;


    public  static int kinderBuenoScore=0;
    public  static int kinderCountryScore=0; 
    public  static int kinderMaxiScore=0;

    public static int ScoreNumberStars;

    public AudioClip chocolateSound;

    public energyBar energy;

 
    public int currentEnergy;
    private float  timeBetweenDecrease=4f;
    private float timeBetween;
    public bool isEnergyEnd = false;

    // Start is called before the first frame update

   
    void Start()
    {

    
     
        timeBetween = timeBetweenDecrease;
        currentEnergy = 19;
        energy.SetHealth(currentEnergy);
        // energy.SetMaxHealth(MaxEnergy);


       
        
        ScoreNumberStars = 0;
        ScoreStars.text = ScoreNumberStars + "";



    }

    private void OnTriggerEnter(Collider Collision)
    {
        if (Collision.tag == "kinderCountry" )
        {

            GetComponent<AudioSource>().PlayOneShot(chocolateSound,3f);
            kinderCountryScore += 1;
            Destroy(Collision.gameObject);
            currentEnergy = currentEnergy + 2;
            energy.SetHealth(currentEnergy);
   

        }
        else if (Collision.tag == "kinderBueno")
        {

            GetComponent<AudioSource>().PlayOneShot(chocolateSound, 3f);
            kinderBuenoScore += 1;
            Destroy(Collision.gameObject);
            currentEnergy = currentEnergy + 2;
            energy.SetHealth(currentEnergy);
        

        }
        else if (Collision.tag == "kinderMaxi")
        {

            GetComponent<AudioSource>().PlayOneShot(chocolateSound, 3f);
            kinderMaxiScore += 1;
            Destroy(Collision.gameObject);
            currentEnergy = currentEnergy + 2;
            energy.SetHealth(currentEnergy);
          

        }
        else if (Collision.tag == "star")
        {
         

            ScoreNumberStars += 1;
            Destroy(Collision.gameObject);
            ScoreStars.text = ScoreNumberStars + "";
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        if (timeBetween > 0.1)
        {
            timeBetween -= Time.deltaTime;
        }
        else
        {
            currentEnergy -= 1;
            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().winner == false)
            {
                energy.SetHealth(currentEnergy);

            }
            timeBetween = timeBetweenDecrease;
        }

        if (currentEnergy <= 0)
        {
            isEnergyEnd = true;
        }
    }
}
