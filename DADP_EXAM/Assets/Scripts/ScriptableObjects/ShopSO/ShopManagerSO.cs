using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManagerSO : MonoBehaviour
{
    public ShopSO shopSO;
    public Image[] itemIcon;
    public TMP_Text[] itemNameTxt;

    void Start()
    {
        for(int i = 0; i< itemIcon.Length && i< shopSO.icon.Length; i++)
        {
            itemIcon[i].sprite = shopSO.icon[i];
        }

        for(int i = 0; i< itemNameTxt.Length && i< shopSO.itemName.Length; i++)
        {
            itemNameTxt[i].text = shopSO.itemName[i];
        }
    }
}
