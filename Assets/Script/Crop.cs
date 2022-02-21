using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crop : MonoBehaviour
{

    public Text tomatoCount;
    public Text cabbageCount;
    public int tomato;
    public int cabbage;
    public AudioSource pick;
 
    

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {

        //mouse button to click on the object
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Tomato") //if the collided object is "tomato"
                {
                    Destroy(hit.collider.gameObject); //destory the object
                    tomato += 1; //count the tomato
                    tomatoCount.text = "x " + tomato.ToString(); //print count in the UI 
                    pick.Play(); //play the sound
                }
                if (hit.collider.gameObject.tag == "Cabbage")//if the collided object is "cabbage"
                {
                    Destroy(hit.collider.gameObject);//destory the object
                    cabbage += 1;//count the cabbage
                    cabbageCount.text = "x " + cabbage.ToString();//print count in the UI 
                    pick.Play();//play the sound
                }
            }
        }

    }


}
