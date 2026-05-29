using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float move = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -14)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.left* move) * Time.deltaTime;
    }
}
