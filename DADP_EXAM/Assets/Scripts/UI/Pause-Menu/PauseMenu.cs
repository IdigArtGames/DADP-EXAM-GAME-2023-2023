using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject ghostInstructions;
    public GameObject ghostQuest;
    public GameObject ShopPanel;
    public GameObject cookingQuest;
    public GameObject confirmationScreen;

    bool isActive = false;


    public GameObject miniNarrative;
    void Awake()
    {
        miniNarrative.SetActive(true);
        if(pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(false);
        }   
    }
    void Update()
    {      
        if(pauseMenu.activeSelf || ghostInstructions.activeSelf || ghostQuest.activeSelf || ShopPanel.activeSelf || cookingQuest.activeSelf || confirmationScreen.activeSelf || miniNarrative.activeSelf) 
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isActive = !isActive;
            miniNarrative.SetActive(isActive);
        }
    }
}
