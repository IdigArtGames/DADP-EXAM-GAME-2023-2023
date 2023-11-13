using UnityEngine;

public class HerbItem : Interactable
{
    Herb herb;

    private void Awake()
    {
        herb = FindObjectOfType<Herb>();
    }
    protected override void Interact()
    {
        herb.item.noOfItems++;
        Destroy(gameObject);
    }
}
