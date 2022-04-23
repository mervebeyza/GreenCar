using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float Hiz;
    public Transform Point;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;


    public float startTime;
    private float waitTime;
    
    void Start()
    {
        Point.position = new Vector3(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY),
            Random.Range(minZ, maxZ)
            );
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            Point.position,
            Hiz*Time.deltaTime
            );

        if (Vector3.Distance(transform.position, Point.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                Point.position = new Vector3(
                Random.Range(minX, maxX),
                Random.Range(minY, maxY),
                Random.Range(minZ, maxZ)
                );
                waitTime = startTime;
            }     
            else
            {
                waitTime -= Time.deltaTime;           
            }
        }
    }
}
