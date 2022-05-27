using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int ronde;

    public Ball bola;
    public Score score;
    public int scoringDelay = 2;
    public float waktuTerlewati = 0;

    void NextRound() {
        if (ronde == 10){
           return;
        }

        ronde++;

        bola.ResetBola();

        score.ScoreAkhir();
        score.ResetPinScore();

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
}