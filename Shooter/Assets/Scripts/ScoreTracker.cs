using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{

    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = ("Score \n" + Enemy.player_score.ToString());
    }
}