using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeGenerate : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "level1")
        {
            Debug.Log("level1");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (hit.transform.tag == "level2")
        {
            Debug.Log("level2");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        }


    }
}
