using UnityEngine;

public class DoorScript : Interactable
{
    public GameObject Door;
    bool isOpen;
    protected override void Interact()
    {
        isOpen = !isOpen;
        Door.GetComponent<Animator>().SetBool("isOpen", isOpen);
    }
}
