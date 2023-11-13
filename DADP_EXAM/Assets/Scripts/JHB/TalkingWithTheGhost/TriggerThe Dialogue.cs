using UnityEngine;

public class TriggerTheDialogue : MonoBehaviour
{
    public GameObject talkWithGhost;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            talkWithGhost.SetActive(true);
            Destroy(gameObject);
        }
    }
}
