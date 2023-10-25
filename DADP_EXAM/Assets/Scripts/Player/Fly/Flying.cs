using UnityEngine;

public class Flying : MonoBehaviour
{
    [SerializeField] Transform knzHelipad;

    public Transform mainPlayer;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           mainPlayer.position = knzHelipad.position;
        }
    }

}
