using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }
}