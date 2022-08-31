
using UnityEngine;
using UnityEngine.SceneManagement;

public class mENU : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("level 01");
    }

    public void quit()
    {
        Application.Quit();
    }
}
