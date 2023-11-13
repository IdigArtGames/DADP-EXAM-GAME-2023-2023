using UnityEngine;

public class WhenActive : MonoBehaviour
{
    public GameObject Letter;
    public GameObject flyingPanel;

    public GameObject miniNarratives;
    bool isActive = false;

    private void Awake()
    {
        miniNarratives.SetActive(true);
    }
    void Start()
    {
        
    }


    void Update()
    {
        if(Letter.activeSelf || flyingPanel.activeSelf || miniNarratives.activeSelf)
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
            miniNarratives.SetActive(isActive);
        }
    }
}
