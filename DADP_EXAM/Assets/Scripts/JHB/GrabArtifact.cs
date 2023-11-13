using UnityEngine;

public class GrabArtifact : Interactable
{
    public GameObject artifact;
    protected override void Interact()
    {
        artifact.SetActive(true);
    }
}
