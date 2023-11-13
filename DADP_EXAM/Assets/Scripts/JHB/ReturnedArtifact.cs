using UnityEngine;

public class ReturnedArtifact : MonoBehaviour
{
    public GameObject hornArtifact;
    public GameObject QuestCompletePanel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Artifact")
        {
            gameObject.SetActive(false);
            hornArtifact.GetComponent<GrabbableObject>().enabled = false;
            hornArtifact.GetComponent<Rigidbody>().useGravity = false ;
            hornArtifact.GetComponent<Rigidbody>().freezeRotation = true;
            hornArtifact.GetComponent<MeshCollider>().isTrigger = true;
            QuestCompletePanel.SetActive(true);
        }
    }
}
