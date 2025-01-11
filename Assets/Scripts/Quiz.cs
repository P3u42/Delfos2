using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [SerializeField]QuestionSO questionSo;
    [SerializeField]TextMeshProUGUI questionText;
    [SerializeField]GameObject[] answerButtons;
    int correctAnswerIndex;
     [SerializeField]Sprite defaultAnswerSprite;
     [SerializeField]Sprite corretAnswerSprite;

    // Start is called before the first frame update
    void Start()
    {
            //DisplayQuestion();


        GetNextQuestion();

    }

    public void OnAnswerSelected(int index)
    {
         Image buttonImage;
        if(index == questionSo.GetCorretAnswerIndex())
        {
            questionText.text = "Correct!";
             buttonImage = answerButtons[index].GetComponent<Image>();

            buttonImage.sprite = corretAnswerSprite;

        }

        else
        {
            correctAnswerIndex = questionSo.GetCorretAnswerIndex();
            string correctAnswer = questionSo.GetAnswer(correctAnswerIndex);
            questionText.text = "Sorry, the correct answer ;\n" + correctAnswer;
            buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = corretAnswerSprite;



        }

        SetButtonState(false);

    }
    void DisplayQuestion()
    {



            questionText.text = questionSo.GetQuestion();
                

                
                
            for(int i = 0; i <answerButtons.Length ; i++) {
                TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
                buttonText.text = questionSo.GetAnswer(i);


            }




    }


    void SetButtonState(bool state){



        for(int i = 0; i < answerButtons.Length; i++) {


            Button button = answerButtons[i].GetComponent<Button>();
            button.interactable = state;
            
        }


    }

    

    void GetNextQuestion(){

        SetButtonState(true);
        DisplayQuestion();
    }


void SetDefaultButtonSprites(){

    for(int i = 0; i <answerButtons.Length ; i++) { 


            Image buttonImage = answerButtons[i].GetComponent<Image>();

            buttonImage.sprite = defaultAnswerSprite;
        
    }



}

    // Update is called once per frame
    void Update()
    {
        
        
   

    }
}
