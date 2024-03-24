using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highScore : MonoBehaviour
{

    public static int highscore;

    // Start is called before the first frame update
    void Start()
    {

        highscore = PlayerPrefs.GetInt("highscore", highscore);

        GetComponent<UnityEngine.UI.Text>().text = "High Score: " + highscore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

      
   
}