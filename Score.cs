using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject player;
    public TMPro.TMP_Text scoreText;
    public int playerScore;
    public int currentScore;


    void IncreaseScore(){
        currentScore ++;
        scoreText.text = "Score: "+ currentScore;
    }

    void DecreaseScore(){
        currentScore = currentScore - 2;
        scoreText.text = "Score: "+ currentScore;
    }
}
