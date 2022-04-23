using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket1 : MonoBehaviour
{
    public float Hiz;
    public Transform Point2;
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
        Point2.position = new Vector3(
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
            Point2.position,
            Hiz * Time.deltaTime
            );

        if (Vector3.Distance(transform.position, Point2.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                Point2.position = new Vector3(
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
