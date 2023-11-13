using UnityEngine;

public class LostArtifact : MonoBehaviour
{
    public GameObject questInfo;
    public GameObject []areaMarkedGreen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            foreach(var area  in areaMarkedGreen)
            {
                area.SetActive(true);
            }
            
            questInfo.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
