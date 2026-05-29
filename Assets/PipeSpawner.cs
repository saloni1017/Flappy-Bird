using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    private float spawnTime = 2;
    private float timer = 0;
    private float height = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer= 0;
        }
    }

    void SpawnPipe()
    {
        float low = transform.position.y - height;
        float high = transform.position.y + height;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(low,high), 0f), transform.rotation);

    }
}
