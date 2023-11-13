using UnityEngine;

public class WhenActive : MonoBehaviour
{
    public GameObject Letter;
    public GameObject flyingPanel;
    void Start()
    {
        
    }


    void Update()
    {
        if(Letter.activeSelf || flyingPanel.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
