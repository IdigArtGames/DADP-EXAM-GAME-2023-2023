using UnityEngine;

public class CollectMusicSheet : Interactable
{
    MusicInventoryManager music;
    void Start()
    {
        music = FindObjectOfType<MusicInventoryManager>();
    }

    protected override void Interact()
    {
        music.inventory.noOfSheet++;
        Destroy(gameObject);
    }
}
