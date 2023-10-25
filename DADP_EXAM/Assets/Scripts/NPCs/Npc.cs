using UnityEngine;

public class Npc : MonoBehaviour
{
    public void Interact()
    {
        print("Hey, There");
        FindObjectOfType<DialogueTrigger>().StartDialogue();
    }
}
