using UnityEngine;

public class HerbItem : MonoBehaviour
{
    Herb herb;

    private void Awake()
    {
        herb = FindObjectOfType<Herb>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            
            herb.item.noOfItems++;
            Destroy(gameObject, 1f);
        }
    }
}
