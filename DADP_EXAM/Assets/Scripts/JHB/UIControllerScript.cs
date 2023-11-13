using UnityEngine;

public class UIControllerScript : MonoBehaviour
{
    public GameObject referenceImage;
    public GameObject lostArtifactQuestPanel;
    public GameObject questComplete;
    public GameObject mapView;
    

    //
    public GameObject musicMinigame;
    public GameObject theGame;
    public GameObject talkWithGhost;

    void Update()
    {
        if(referenceImage.activeSelf || lostArtifactQuestPanel.activeSelf || questComplete.activeSelf || mapView.activeSelf || talkWithGhost.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else 
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }

        if(musicMinigame.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;

            if(theGame.activeSelf)
            {
                Time.timeScale = 1f;
            }
        }
    }
}
