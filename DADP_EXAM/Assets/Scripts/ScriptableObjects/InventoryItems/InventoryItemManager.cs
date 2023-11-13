using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemManager : MonoBehaviour
{
    public InventoryItemSO Item;
    public Image[] icon;
    public TMP_Text[] noOfItems;
    public GameObject[] items;

    void Start()
    {
        for(int i = 0; i< icon.Length && i< Item.icon.Length; i++ )
        {
            icon[i].sprite = Item.icon[i];
        }

        for( int i = 0;i< Item.noOfItems.Length; i++ )
        {
            Item.noOfItems[i] = 0;
        }
    }


    void Update()
    {
        for(int i = 0; i< noOfItems.Length && i< Item.noOfItems.Length; i++ )
        {
            noOfItems[i].text = Item.noOfItems[i].ToString();
            if (Item.noOfItems[i]<= 0)
            {
                items[i].SetActive(false);
            }
            else
            {
                items[i].SetActive(true);
            }
        }
    }

    public void Buy(int index)
    {
        if(index>= 0&& index< Item.noOfItems.Length)
        {
            Item.noOfItems[index]++;
        }
    }
}
