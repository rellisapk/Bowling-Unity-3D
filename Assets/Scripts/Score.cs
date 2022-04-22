using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public ScoreKeeper _ScoreKeeper;
    public Text frame;
    public Text ball;
    public Text score;
    public Text down;

    void Update()
    {
        frame.text = "Frame: " + _ScoreKeeper._Frame.ToString();
        ball.text = "Ball: " + _ScoreKeeper._FrameBall.ToString();
        score.text = "Score: " + _ScoreKeeper._Score.ToString();
        down.text = "Score " + _ScoreKeeper._Down.ToString();
    }
}
