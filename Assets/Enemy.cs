using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 0;
    public GameObject deathPrefab;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health++;
            Destroy(collision.gameObject);

            if (health >= 5)
            {
                Instantiate(deathPrefab, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
