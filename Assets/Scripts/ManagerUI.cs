using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textDescription;
    [SerializeField] TextMeshProUGUI textAnswer1;
    [SerializeField] TextMeshProUGUI textAnswer2;
    [SerializeField] TextMeshProUGUI textAnswer3;
    [SerializeField] TextMeshProUGUI textAnswer4;
    [SerializeField] TextMeshProUGUI counter;
    [SerializeField] GameObject exitGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeUI(string description,string answer1,string answer2,string answer3, string answer4,int count)
    {
        textDescription.text = description;
        textAnswer1.text = answer1;
        textAnswer2.text = answer2;
        textAnswer3.text = answer3;
        textAnswer4.text = answer4;
        counter.text = count.ToString();

    }
    public void ExitGameUI()
    {
        exitGame.SetActive(true);
    }
}
