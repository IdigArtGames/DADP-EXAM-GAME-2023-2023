using UnityEngine;

public class ChefGhost : Interactable
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

    protected override void Interact()
    {
        TalkWithTheGhostChef();
    }
}
