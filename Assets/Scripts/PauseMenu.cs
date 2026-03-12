using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string LvltoLoad = "Menu";

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
