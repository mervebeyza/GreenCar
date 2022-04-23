using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
       
    }

    void onTriggerEnter(Collider other)
    {
        if (other.tag == "araba")
        {
            SceneManager.LoadScene(1);              
        }
    }
}
