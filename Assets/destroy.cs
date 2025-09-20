using UnityEngine;

public class destroy : MonoBehaviour
{
    void Start()
    {
        Invoke(nameof(Explode), 1.5f);
    }
    
    void Explode()
    {
        Destroy(gameObject);
    }
}
