using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToJHB : MonoBehaviour
{
    public GameObject confirmationScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            confirmationScreen.SetActive(true);
        }
    }
}
