using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Score : MonoBehaviour
{
    public int scoreTotal;
    public Text scoreField;
    public PinFall[] pin;
    public List<PinFall> standingPins = new List<PinFall>();

    public GameObject pinContainer;

    void Start() {
        scoreTotal = 0;
        pin = pinContainer.GetComponentsInChildren<PinFall>();
    }

    public void ScoreAkhir() {
        int score = 0;
        
        if (standingPins.Count > 0){
            foreach (var item in standingPins)
            {
                if (item.fall){
                Debug.Log(item.fall);
                score++;
                }
            }
        }else {
            foreach (var item in pin)
            {
                if (item.fall){
                    Debug.Log(item.fall);
                    score++;
                }else {
                    standingPins.Add(item);
                }
            }
        }

        if (score == 10 ) {
            score *= 2;
        }

        scoreTotal += score;
        scoreField.text = "Score : " + scoreTotal.ToString();

    }

    public void ResetStanding(){
        foreach (var item in pin)
        {
            if(item.fall){
                item.gameObject.SetActive(false);
            }else {
                item.ResetPin();
            }
        }
    }
    public void ResetAll() {
        standingPins.Clear();
        foreach (var item in pin)
        {
            item.gameObject.SetActive(true);
            item.ResetPin();
        }
    }
}
