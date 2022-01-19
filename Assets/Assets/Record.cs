
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Record : MonoBehaviour
{
    // Start is called before the first frame updat
    public  static int score ;

    public Text ScoreText;
    private float restartDelay;

    void Start()
    {
       score =150*60;
       
}

    // Update is called once per frame
    void Update()
    {
        score --;
        ScoreText.text = " "+score/60;
        if(score<0)
        {

            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Invoke("endGame", 0f);
        }

        
    }
    void endGame()
    {  
        SceneManager.LoadScene("GameOver2");
    }
}
