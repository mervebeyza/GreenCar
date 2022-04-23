using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isim2 : MonoBehaviour
{
    public float Hiz;
    public Transform pointisim;
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
        pointisim.position = new Vector3(
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
            pointisim.position,
            Hiz * Time.deltaTime
            );

        if (Vector3.Distance(transform.position, pointisim.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                pointisim.position = new Vector3(
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
