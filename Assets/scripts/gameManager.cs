
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public float delay = 2f;
    bool gameHasEnded = false;
    public GameObject levelWonUI;
    public GameObject GameOverUI;
    
 public void levelWon()
    {
        levelWonUI.SetActive(true);
       
    }
public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            GameOverUI.SetActive(true);
            
        }
    }

    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void back()
    {
        SceneManager.LoadScene("MENU");
    }

}
