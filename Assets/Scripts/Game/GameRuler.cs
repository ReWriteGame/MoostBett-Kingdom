using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private int numberOfStart = 5;
    [SerializeField] private Text inputUser;

    public UnityEvent winEvent;
    public UnityEvent loseEvent;



    public void StartGame()
    {
      
     
    }

    public void StopGame()
    {

        if(arrow1.collidedObject.GetComponent<Cell>().Value > 0)
            scoreCounter.Add(arrow1.collidedObject.GetComponent<Cell>().Value * GetValueUser());
        else scoreCounter.TakeAway(Mathf.Abs(arrow1.collidedObject.GetComponent<Cell>().Value) * GetValueUser());

    }

    public float GetValueUser()
    {
        float value = string.IsNullOrEmpty(inputUser.text) ? 0 : float.Parse(inputUser.text);

        value = value < 0 ? 0 : value;
        value = value > scoreCounter.Score ? scoreCounter.Score : value;
        
        return value;
    }
}
