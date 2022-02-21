using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QandA> qna;
    public GameObject[] options;
    public int currentQuestion;
    public Text question;
    public Text answerCount;
    public int correctAnswer;
    public GameObject gameoverPanel;


    // Start is called before the first frame update
    private void Start()
    {
        generateQuestion();
        gameoverPanel.SetActive(false);
    }

    public void correct()
    {
        generateQuestion(); //execute 
        qna.RemoveAt(currentQuestion);
        correctAnswer += 1;
        answerCount.text = "x " + correctAnswer.ToString();
    }


    void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = qna[currentQuestion].Answer[i];


            if (qna[currentQuestion].correctAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;


            }
        }
    }

    // Update is called once per frame
    public void generateQuestion()
    {
        if (qna.Count > 0) // if the number of question is greater than 0
        {
            print("working");
            currentQuestion = Random.Range(0, qna.Count); //generate random question from 0 to the no of questions
            question.text = qna[currentQuestion].Question;
            SetAnswer();
        }
        else
        {
            print("you cleared this level........... hurray!!!!!! :)");
            gameoverPanel.SetActive(true);
        }
    }
}
