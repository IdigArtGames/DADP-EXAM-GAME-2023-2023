using UnityEngine;

public class BuyIngredients : MonoBehaviour
{
    public GameObject shopPanel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            shopPanel.SetActive(true);
        }
    }
}
