using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int ronde;
    public int tries = 0;

    public Ball bola;
    public TextMeshProUGUI scoreAkhir;
    public Score score;
    public int scoringDelay = 2;
    public float waktuTerlewati = 0;

    void NextRound() {
        if (ronde == 10){
            GameOver();
           return;
        }

        ronde++;

        bola.ResetBola();
        score.ScoreAkhir();

        if (score.standingPins.Count > 0 && tries < 1){
            tries++;
            score.ResetStanding();
        }else {
            tries = 0;
            ronde++;
            score.ResetAll();
        }
        
        waktuTerlewati = 0;

    }

    void FixedUpdate() {
        if (bola.bolaLempar && bola.rb.velocity.sqrMagnitude <= 0.1 && waktuTerlewati > scoringDelay){
            NextRound();
        }
    }

    void Update()
    {
        if (bola.bolaLempar && waktuTerlewati <= scoringDelay)
        {
            waktuTerlewati += Time.deltaTime;
        }
    }

    [SerializeField] GameObject gameOver;

    public void GameOver()
    {
        scoreAkhir.text = "Final Score : " + score.scoreTotal.ToString();
        gameOver.SetActive(true);
        Time.timeScale = 0f;
    }
}