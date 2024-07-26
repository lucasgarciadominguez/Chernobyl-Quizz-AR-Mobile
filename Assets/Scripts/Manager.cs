using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public ManagerUI managerUI;
    [SerializeField]
    public QuestionElement[] questions;
    QuestionElement actualQuestion;
    public int actualLevel=0;
    public int countAnswersCorrect=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeLevel()
    {
        if (actualLevel!= questions.Length)
        {
            actualQuestion = questions[actualLevel];
            actualLevel += 1;
            managerUI.ChangeUI(actualQuestion.Question, actualQuestion.Answer1, actualQuestion.Answer2, actualQuestion.Answer3, actualQuestion.Answer4, countAnswersCorrect);
        }
        else
        {
            managerUI.ExitGameUI();
        }
 

        
    }
    private void OnBeforeTransformParentChanged()
    {
        
    }
    public void ExitApplication()
    {
        Application.Quit();
    }
    public void CheckAnswer(int i)
    {
        if (actualQuestion.QuestionCorrect==i)
        {
            IncreaseCounter();
        }
        ChangeLevel();

    }
    public void IncreaseCounter()
    {
        countAnswersCorrect++;
    }
}
