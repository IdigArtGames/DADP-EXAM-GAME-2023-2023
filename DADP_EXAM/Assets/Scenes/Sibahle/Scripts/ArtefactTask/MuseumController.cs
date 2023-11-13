using UnityEngine;
using UnityEngine.UI;
public class MuseumController : MonoBehaviour
{
    public int totalMissingObjects = 1;
    public int foundObjects = 0;
    private int score = 0;

    public Text scoreText;

    public void ObjectFound()
    {
        foundObjects++;

        
        scoreText.text = "Score: " + score;

        
        if (foundObjects >= totalMissingObjects)
        {
           
            score += 20;
            scoreText.text = "Score: " + score;

            
        }
    }

}
