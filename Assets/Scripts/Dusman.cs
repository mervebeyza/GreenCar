using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    public float Damage;

    bool ArabaCollider = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onTriggerEnter(Collider other)
    {
        if (other.tag == "araba" && !ArabaCollider)
        {
            ArabaCollider = true;
            other.GetComponent<Araba>().getDamage(Damage);
        }
    }

    private void onTriggerExit(Collider collision)
    {
        if (collision.tag == "araba")
        {
            ArabaCollider = false;
        }
    }
}
