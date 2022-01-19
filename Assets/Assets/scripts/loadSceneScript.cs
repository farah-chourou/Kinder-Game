
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneScript : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
