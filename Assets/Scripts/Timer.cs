using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]float questionTime = 30f;
    [SerializeField]float answerTime = 10f;
    float timer;

    public  bool isAnsweringQuestion = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerUpdate();
    }



    void TimerUpdate()
    {

        timer -= Time.deltaTime;
        // x -= y =  x = x -y;

        if(timer <= 0)
        {

            timer = questionTime;


        }

        Debug.Log(timer);

    }
}
