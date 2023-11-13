using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject ghostInstructions;
    public GameObject ghostQuest;
    public GameObject ShopPanel;
    public GameObject cookingQuest;
    public GameObject confirmationScreen;
    void Awake()
    {
        if(pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(false);
        }   
    }
    void Update()
    {      
        if(pauseMenu.activeSelf || ghostInstructions.activeSelf || ghostQuest.activeSelf || ShopPanel.activeSelf || cookingQuest.activeSelf || confirmationScreen.activeSelf) 
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
            
    }
}
