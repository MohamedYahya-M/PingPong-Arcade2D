using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;


    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public int goalToWin = 5;

    private void Start()
    {
        
    }
    void Update()
    {
      

        if(scorePlayer1 >= goalToWin)
        {
            Debug.Log("PLAYER 1 WINS");
            SceneManager.LoadScene("Player1WinScene");
            

        }
        if(scorePlayer2 >= goalToWin) 
        {
            Debug.Log("PLAYER 2 WINS");
            SceneManager.LoadScene("Player2WinScene");

        }
    }

    private void FixedUpdate()
    {
        TextMeshProUGUI scoreOfPlayer1 = scoreTextPlayer1.gameObject.GetComponent<TextMeshProUGUI>();
        scoreOfPlayer1.text = scorePlayer1.ToString();


        TextMeshProUGUI scoreOfPlayer2 = scoreTextPlayer2.gameObject.GetComponent<TextMeshProUGUI>();
        scoreOfPlayer2.text = scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        scorePlayer1++;
    }
    
    public void GoalPlayer2()
    {
        scorePlayer2++;
    }

  
}
