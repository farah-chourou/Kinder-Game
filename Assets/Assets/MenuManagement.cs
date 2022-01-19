
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
    

    public void Quite()
    {
        Application.Quit();
    }
    public void Replay()
    {
        SceneManager.LoadScene("Level 1");
    }
   
}
