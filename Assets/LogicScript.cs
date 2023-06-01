using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;
    public GameObject MainPage;
    public GameObject Bird;
   


    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();

    }

    
    public void StartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

       

    }

    public void restartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void QuitGame()
    {

        Application.Quit();

     }




    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }

  
    

}
