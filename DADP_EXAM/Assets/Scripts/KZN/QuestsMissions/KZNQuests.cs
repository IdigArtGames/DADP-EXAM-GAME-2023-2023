using UnityEngine;

public class KZNQuests : MonoBehaviour
{
    [SerializeField] GameObject[] RestaurantQuest;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            print(other.transform.name);
            foreach (var item in RestaurantQuest)
            {
                item.SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
}