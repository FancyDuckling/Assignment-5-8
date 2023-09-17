using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int scorePlayer;
    public ScoreTextCirclePink scoreText;

    public void AddPoint()
    {
        scorePlayer++;
        scoreText.SetScore(scorePlayer);
    }

    // id identify wich score zone was hit
}
