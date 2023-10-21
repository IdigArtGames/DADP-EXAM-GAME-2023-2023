using UnityEngine;

public class DoorScript : Interactable
{
    bool isOpen;

    protected override void Interact()
    {
        isOpen = !isOpen;
        gameObject.GetComponent<Animator>().SetBool("isOpen", isOpen);
    }
}
