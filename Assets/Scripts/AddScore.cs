using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

     

        Score.score++;

        SoundManager.PlaySound("score");

        if (Score.score > highScore.highscore)
        {
            highScore.highscore = Score.score;


        }

    }

  

    void OnDestroy()
    {
        PlayerPrefs.SetInt("highscore", highScore.highscore);
        PlayerPrefs.Save();
    }

    
}
