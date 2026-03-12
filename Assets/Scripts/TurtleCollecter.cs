using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TurtleCollecter : MonoBehaviour
{
    public TMP_Text TurtleText;
    public int NumTurtsInLvl = 5;
    public string LvltoLoad = "Menu";

    private int TurtlesCollected = 0;


    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Turtle")
       {
            TurtlesCollected += 1;
            TurtleText.text = "Turtles Collected: " + TurtlesCollected;
            Destroy(other.gameObject);

            if(TurtlesCollected == NumTurtsInLvl)
            {
                SceneManager.LoadScene("Menu");
            }
       } 
    }
}
