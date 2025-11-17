using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public int enemyHealth = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= -5.5f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.GetComponent<scriptplayer>().TakeDamage();
            Debug.Log("Hit: " + collision);
        }
        /*if (collision.tag == "Laser")
        {
            Destroy(gameObject);
        }*/
    }
    public void TakeDamage()
    {
        enemyHealth--;
        Debug.Log("enemyHealth: " +  enemyHealth);
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
} 

