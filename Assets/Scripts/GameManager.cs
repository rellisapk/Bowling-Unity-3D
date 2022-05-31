using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int ronde;

    public Ball bola;
    public Score score;

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
        if (bola.bolaLempar && bola.rb.velocity.sqrMagnitude <= 0.1){
            NextRound();
        }
    }
}