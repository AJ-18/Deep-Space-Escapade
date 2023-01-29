using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    //Gives the ability to run the function within Unity itself (for testing)
    [ContextMenu("Increase Score")]
    
    //'public' function because it needs to run from other scripts.
    //Add 1 to the player score - scoreToAdd is futureproofing so you can change the value of points to the score if needed
    //Change the number in the UI to be this new number
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        //SceneManager.LoadScene wants the name of the scene, but you can use GetActiveScene to get the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        //Makes the screen visible
        gameOverScreen.SetActive(true);
    }
}
