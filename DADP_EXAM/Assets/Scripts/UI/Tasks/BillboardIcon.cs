using UnityEngine;

public class BillboardIcon : MonoBehaviour
{
    public Transform Cam;

    void Update()
    {
        transform.rotation = Cam.transform.rotation;
    }
}
