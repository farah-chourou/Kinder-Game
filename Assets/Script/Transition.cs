using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator transition;

    void Start()
    {

        StartCoroutine(Loadlevel());
    }

 
   

   


    IEnumerator Loadlevel()
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(1);

    }
}
