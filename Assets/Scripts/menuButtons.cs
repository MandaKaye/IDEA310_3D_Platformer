using UnityEngine;
using UnityEngine.SceneManagement;

public class menuButtons : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("LevelOne");

    }
    
    public void QuitButton()
    {
        Application.Quit();
    }
}
