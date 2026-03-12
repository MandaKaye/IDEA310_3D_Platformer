using UnityEngine;
using TMPro;

public class TurtleCollecter : MonoBehaviour
{
    public TMP_Text TurtleText;
    private int TurtlesCollected = 0;

    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Turtle")
       {
            TurtlesCollected += 1;
            TurtleText.text = "Turtles Collected: " + TurtlesCollected;
            Destroy(other.gameObject);
       } 
    }
}
