using UnityEngine;

public class RestaurantDoor : Interactable
{
    public GameObject doubleDoor;
    bool isOpen;
    protected override void Interact()
    {
        isOpen = !isOpen;
        doubleDoor.GetComponent<Animator>().SetBool("isOpen", isOpen);
    }
}
