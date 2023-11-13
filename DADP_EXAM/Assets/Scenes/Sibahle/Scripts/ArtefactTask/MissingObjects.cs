using UnityEngine;

public class MissingObjects : Interactable
{
    public Transform destinationPoint;

    private MuseumController museumController;

    private void Start()
    {
        museumController = FindObjectOfType<MuseumController>();
    }

    //private void OnMouseDown()
    //{

    //    museumController.ObjectFound();


    //    gameObject.SetActive(false);


    //    transform.position = destinationPoint.position;
    //    gameObject.SetActive(true);
    //}

    //protected override void Interact()
    //{

    //    museumController.ObjectFound();


    //    gameObject.SetActive(false);


    //    transform.position = destinationPoint.position;
    //    gameObject.SetActive(true);
    //}
}
