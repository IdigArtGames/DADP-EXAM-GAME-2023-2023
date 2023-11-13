using UnityEngine;

public class ObjectInteraction : Interactable
{
    //public GameObject uiPanel;

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hitInfo;

    //        if (Physics.Raycast(ray, out hitInfo))
    //        {
    //            if (hitInfo.collider.gameObject == gameObject)
    //            {

    //                uiPanel.SetActive(true);
    //            }
    //        }
    //    }
    //}

    public GameObject uiPanel;
    bool isOpen;

    protected  override void Interact()
    {
        isOpen = !isOpen;
        uiPanel.SetActive(isOpen);
    }

    private void Update()
    {
        //if(uiPanel.activeSelf)
        //{
        //    Time.timeScale = 0; 
        //}
        //else
        //{
        //    Time.timeScale = 1;
        //}
    }
}
