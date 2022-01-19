using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreWinnerLevel2 : MonoBehaviour
{
    // Start is called before the first frame update

    public Text kinderBuenoScoreText;
    public Text kinderCountryScoreText;
    public Text kinderMaxiScoreText;
    public Text scoreStars;


  

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

     
      
        kinderCountryScoreText.text = Score.kinderBuenoScore+ "";
        kinderBuenoScoreText.text = Score.kinderCountryScore + "";
        kinderMaxiScoreText.text = Score.kinderMaxiScore + "";

        scoreStars.text = Score.ScoreNumberStars + "";

    }
}
