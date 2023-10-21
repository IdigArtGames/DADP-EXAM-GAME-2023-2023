using UnityEngine;

public class AlwaysLookUp : MonoBehaviour
{
    public Transform Cam;

    void Update()
    {
        transform.rotation = Cam.transform.rotation;
    }
}
