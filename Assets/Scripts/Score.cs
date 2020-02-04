using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    
    public static int scoreValue = 0;
    static Text score;
    
    // Start is called before the first frame update
    void Start()
    {
        //som
       
        //texto
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //score.text = "Score: " +scoreValue;
    }

    public void ScoreUp()
    {
        scoreValue++;
        score.text = "Score: " + scoreValue;

        if (scoreValue == 312)
        {
            SceneManager.LoadScene("Lvl1");
        }
    }
}
