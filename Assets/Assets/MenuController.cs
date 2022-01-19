using UnityEngine.SceneManagement;

using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }

    public void Help()
    {


        panel1.SetActive(true);
     
    }

    public void BeforeArrow()
    {


        panel1.SetActive(false);

    }
   
    public void BeforeArrow2()
    {

        panel2.SetActive(false);
        panel1.SetActive(true);

    }
    public void NextArrow()
    {
        panel1.SetActive(false);

        panel2.SetActive(true);

    }
    public void before1()
    {
        SceneManager.LoadScene("Maze1");

    }
    public void before2()
    {
        SceneManager.LoadScene("Maze2");

    }

    public void Quite()
    {
        Application.Quit();
    }
    public void  Play() 
    {
        SceneManager.LoadScene("Maze1");
    }

    public void GoMaze()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Golevel2()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void GoInstruc1()
    {
        SceneManager.LoadScene("Level1Expla");
    }

}
