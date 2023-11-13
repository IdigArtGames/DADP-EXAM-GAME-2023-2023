using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MusicInventoryManager : MonoBehaviour
{
    public MusicInventory inventory;
    public Image musicSheet;
    public TMP_Text noOfSheetTxt;
    public GameObject musicNoteOnMap;
    public GameObject inventoryHolder;

    public GameObject pianoTrigger;

    void Start()
    {
        musicSheet.sprite = inventory.musicSheet;
        inventory.noOfSheet = 0;
    }

    void Update()
    {
        noOfSheetTxt.text = inventory.noOfSheet.ToString();
        if(inventory.noOfSheet <= 0 )
        {
            inventoryHolder.gameObject.SetActive( false );
            musicSheet.gameObject.SetActive( false );
        }
        else
        {
            inventoryHolder.gameObject.SetActive( true );
            musicSheet.gameObject.SetActive(true);
        }

        if( inventory.noOfSheet >= 3 )
        {
            pianoTrigger.gameObject.SetActive(true);
            musicNoteOnMap.gameObject.SetActive(false);
        }
    }
}
