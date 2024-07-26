using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
[CreateAssetMenu(fileName = "QuestionMenu", menuName = "QuestionMenu/QuestionElement")]

public class QuestionElement : ScriptableObject
{
    public string Question;
    public string Answer1;
    public string Answer2;
    public string Answer3;
    public string Answer4;
    public int QuestionCorrect;
}
