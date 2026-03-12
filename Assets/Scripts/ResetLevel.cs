using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    public string currentLevel = "LevelOne";

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Shark") 
        {
            SceneManager.LoadScene(currentLevel);
        }
        if(other.tag == "TheVoid") 
        {
            SceneManager.LoadScene(currentLevel);
        }
    }
}
