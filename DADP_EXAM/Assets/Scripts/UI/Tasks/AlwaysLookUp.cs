using UnityEngine;

public class AlwaysLookUp : MonoBehaviour
{
    public Transform icons;

    void Update()
    {
        transform.rotation = icons.transform.rotation;
    }
}
