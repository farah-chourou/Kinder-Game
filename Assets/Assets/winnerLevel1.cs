using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class winnerLevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text record;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        record.text = "Record:" +Record.score/60;
    }
}
