using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject page0;
    public GameObject button0;


    public GameObject page1;
    public GameObject button1;

    public GameObject page2;
    public GameObject button2;

    public GameObject page3;
    public GameObject button3;


  

    public void pageBuonoCategorie()
    {

      
        button0.SetActive(false);
        page0.SetActive(false);

        page1.SetActive(true);
        button1.SetActive(true);


    }

    public  void pageBuono()
    {
   
        page1.SetActive(false);
        button1.SetActive(false);

        page2.SetActive(true);
        button2.SetActive(true);

    }


    public void pageBuonoIngredients()
    {

        page2.SetActive(false);
        button2.SetActive(false);

        page3.SetActive(true);
        button3.SetActive(true);
    }

    public void pageSurpriseIngredients()
    {

        page2.SetActive(false);
        button2.SetActive(false);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMaze>().isMazeStarted = true;

    }

    public void pageBuonoNutrion()
    {

        page3.SetActive(false);
        button3.SetActive(false);
    
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMaze>().isMazeStarted = true;

    }
}
