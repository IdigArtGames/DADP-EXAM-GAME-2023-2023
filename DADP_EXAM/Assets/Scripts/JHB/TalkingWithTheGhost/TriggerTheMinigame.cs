using UnityEngine;

public class TriggerTheMinigame : MonoBehaviour
{
    private MusicInventoryManager InventoryManager;
    public GameObject minigame;

    private void Awake()
    {
        InventoryManager = FindObjectOfType<MusicInventoryManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            InventoryManager.inventory.noOfSheet = 0;
            minigame.SetActive(true);
            Destroy(gameObject);
        }
    }
}
