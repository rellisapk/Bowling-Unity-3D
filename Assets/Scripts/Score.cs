using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public int scoreTotal;
    public Text scoreField;
    public PinFall[] pin;

    public GameObject pinContainer;

    void Start() {
        scoreTotal = 0;
        pin = pinContainer.GetComponentsInChildren<PinFall>();
    }

    public void ScoreAkhir() {
        int score = 0;
        
        foreach (var item in pin)
        {
            if (item.PinJatuh()){
                score++;
            }
        }

        if (score == 10 ) {
            score *= 2;
        }

        scoreTotal += score;

        scoreField.text = scoreTotal.ToString();

    }

    public void ResetPinScore() {
        foreach (var item in pin)
        {
            item.ResetPin();
        }
    }
}
