using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
   



    void Start()
    {
 
   
    }
   public void Answer()
    {
        if (isCorrect) //check if the answer is correct or not
        {
            print("correct"); //text output in console
            quizManager.correct(); //to check answer is correct and send to QUIZMANAGER
           
            
        }
        else
        {
            print("wrong");//text output in console
            quizManager.generateQuestion(); // to generate new question 
        }
    }
}
