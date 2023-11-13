using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject map;
    bool isUp;
    void Update()
    {
        isUp = !isUp;
        if (Input.GetKeyDown(KeyCode.M))
        {
            map.SetActive(isUp);

        }
    }
}
