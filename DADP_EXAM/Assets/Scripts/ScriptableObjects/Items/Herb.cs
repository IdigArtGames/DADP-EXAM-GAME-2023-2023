using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Herb : MonoBehaviour
{
    [Header("Herb")]
    public Items item;
    [SerializeField] GameObject herb;
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
        if(item.noOfItems <= 0)
        {
            herb.SetActive(false);
        }

        else
            herb.SetActive(true);
    }
}
