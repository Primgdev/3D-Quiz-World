using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    float speed = 3;
    float tile = 50;
    Vector3 startpos;


    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position; //starting position of the cloud
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = transform.localPosition + -transform.forward * speed * Time.deltaTime; //declaring the local position of the cloud
        float newPos = Mathf.Repeat(Time.time * speed, tile); //setting the speed and time variation of the cloud movement
        transform.position = startpos + Vector3.right * newPos;
    }
}
