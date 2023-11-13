using UnityEngine;

public class CookingPoint : MonoBehaviour
{
    public GameObject cookingMiniGame;
    //Get 
    InventoryItemManager inventory;
    Herb herb;

    ShopSO shop;
    public GameObject loseScreen;
    private void Awake()
    {
         inventory = FindObjectOfType<InventoryItemManager>();
        herb = FindObjectOfType<Herb>();
        shop = FindObjectOfType<ShopSO>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (herb.item.noOfItems >= 3 && inventory.Item.noOfItems[0] >= 2 && inventory.Item.noOfItems[3] > 0)
            {
                cookingMiniGame.gameObject.SetActive(true);
            }
            else
            {
                print("Missing Required Objects");
            }
            loseScreen.SetActive(false);
        }
    }

    public void ResetAmount()
    {
        herb.item.noOfItems = 0;
        inventory.Item.noOfItems[0] = 0;
        inventory.Item.noOfItems[3] = 0;
    }
}
