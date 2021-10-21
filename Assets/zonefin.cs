using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zonefin : MonoBehaviour
{
    // Start is called before the first frame update
    void onTriggerStart(Collider other)
    {
        if(other.tag == "balle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
