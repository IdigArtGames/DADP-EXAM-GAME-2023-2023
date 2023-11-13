using UnityEngine;

public class ScrollNotes : MonoBehaviour
{
    private float speed = 1000f;

    void Update()
    {
        transform.Translate (Vector3.down * Time.deltaTime * speed);

        if(transform.position.y <= -700f)
        {
            Destroy (gameObject);
        }
    }
}
