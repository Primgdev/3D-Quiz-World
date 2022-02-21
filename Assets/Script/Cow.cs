
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cow : MonoBehaviour
{

    
   
    public AudioSource moo;

    private Vector3 pos1;
    private Vector3 pos2;
    float speed = 0.2f;

    public Transform pointa;
    public Transform pointb;
    public Transform parent;

    

    float move;
    public int movement;

    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        //use mouse right click
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) )
            {
                
                if (hit.collider.gameObject.tag == "Cow")
                {
               
                    
                    
                   
                    moo.Play();
                   // active = true;
                }
               
            }
        }


        if (active)
        {
            //parent.position = Vector3.Lerp(pointa.position, pointb.position, Mathf.PingPong(mytime * speed, 1.0f));
            transform.position = Vector3.MoveTowards(pointb.position, pointa.position, move); //to move cow from one position to another
            move += Time.deltaTime;
           


        }
    }
}
