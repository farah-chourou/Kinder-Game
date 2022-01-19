
using UnityEngine;

public class Rotater : MonoBehaviour
{

    public float speedRotation = 100f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, speedRotation * Time.deltaTime);
        
    }
    void OnTriggerEnter(Collider col)

    {
        Debug.Log("Trigger ! //");

    }
}
