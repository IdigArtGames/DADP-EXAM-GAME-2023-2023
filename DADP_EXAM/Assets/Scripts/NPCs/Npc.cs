using UnityEngine;

public class Npc : MonoBehaviour
{ 
    public void Interact()
    {
        FindObjectOfType<DialogueTrigger>().StartDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && DialogueManager.isActive == true)
        {
            FindObjectOfType<DialogueManager>().NextMessage();
        }
    }
}
