using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel2:MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

    }

    void onTriggerEnter(Collider other)
    {
        if (other.tag == "next")
        {
            SceneManager.LoadScene(3);
        }
    }
}
