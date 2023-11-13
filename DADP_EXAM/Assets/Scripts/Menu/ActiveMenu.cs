using UnityEngine;

public class ActiveMenu : MonoBehaviour
{
    public GameObject menu;
    void Update()
    {
        if(menu.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
