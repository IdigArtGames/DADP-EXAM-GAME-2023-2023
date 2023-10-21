using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    bool isUp;


    void Awake()
    {
        if(pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(false);
        }   
    }
    void Update()
    {
        isUp = !isUp;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(isUp);
            
        }
        
        if(pauseMenu.activeSelf)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
            
    }
}
