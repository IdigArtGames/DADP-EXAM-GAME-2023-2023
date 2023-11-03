using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bread : MonoBehaviour
{
    [Header("Bread")]
    
    public Items item;
    [SerializeField] GameObject bread;
    [SerializeField] Image itemIcon;
    [SerializeField] TMP_Text noOfItems;

    private void Start()
    {
        item.noOfItems = 0;
        itemIcon.sprite = item.itemSprite;
    }

    void Update()
    {
        //Should Update Everytime
        noOfItems.text = item.noOfItems.ToString();

        if (item.noOfItems <= 0)
        {
            bread.SetActive(false);
        }

        else
            bread.SetActive(true);
    }
}
