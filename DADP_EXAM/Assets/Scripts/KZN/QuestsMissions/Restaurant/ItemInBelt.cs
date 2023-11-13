using UnityEngine;

[System.Serializable]
public class ItemInBelt : MonoBehaviour
{
    public float speed = 400;
    void Start()
    {
        
    }

    void Update()
    {
        speed.ToString();
        transform.Translate(Vector3.down * speed * Time.unscaledDeltaTime);

        if(transform.position.y <= -700f)
        {
            Destroy(gameObject);
        }
    }
}
