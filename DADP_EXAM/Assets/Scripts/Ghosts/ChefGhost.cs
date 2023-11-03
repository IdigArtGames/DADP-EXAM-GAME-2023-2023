using UnityEngine;

public class ChefGhost : MonoBehaviour
{
    [SerializeField] GameObject dialoguePanel;
    void Start()
    {
        
    }
    public void TalkWithTheGhostChef()
    {
        print("Ghost Chef Located"); 
        dialoguePanel.SetActive(true);
    }
}
