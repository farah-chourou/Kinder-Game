
using UnityEngine;

public class eggsCrush : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject destroyVersion;



    void OnMouseDown()
    {

        Instantiate(destroyVersion, transform.position, transform.rotation);
        Destroy(gameObject);

    }
}
