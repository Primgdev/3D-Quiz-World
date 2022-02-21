using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    int speed = 5;
    public CharacterController controller;
    public Slider slider;
    //public Text timeText;
    public float timeRemaining;
    bool timer;
    public AudioSource music;
    public AudioSource timeUp;
    public Image handle;
    

    // Start is called before the first frame update
    void Start()
    {
        timer = true; //declare timer is true
        slider.maxValue = timeRemaining; //max value is equals to time remaining    
        slider.value = timeRemaining; //current time value is equals to  time remaining
        music.Play(); //play music
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        controller.Move(move * speed * Time.deltaTime);

        //Timer
        float time = timeRemaining - Time.time;

        int minute = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minute * 60f);

        string timeText = string.Format("{0:0}:{1:00}", minute, seconds);

        if(time <=0) //if timer is less than or equals to 0
        {
            timer = false;
            timeUp.Play();
            music.Stop();
        }

       

        if(timer = true) //still timer is true
        {
            slider.value = time;
            
        }

       if(time < 10) //if the timer is less than 10 seconds
        {
            Color color = new Color(233f / 255f, 79f / 255f, 55f / 255f); //change the color
            slider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
            handle.GetComponent<Image>().color = new Color(233f / 255f, 79f / 255f, 55f / 255f);
        }
      
    }

   

}
