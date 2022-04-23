using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araba : MonoBehaviour
{
    public float hiz;
    public float Health;
    public bool Dead = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(hiz * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, hiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, hiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(hiz * Time.deltaTime, 0, 0);
        }

    }

    public void getDamage(float Damage)
    {
        if (Health - Damage == 0)
        {
            Health -= Damage;
        }
        else
        {
            Health = 0;
        }
        amIDead();
    }

    void amIDead()
    {
        if (Health == 0)
        {
            Dead = true;
        }
    }
}
