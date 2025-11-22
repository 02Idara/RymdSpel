using UnityEngine;

public class enemy : MonoBehaviour
{
    private GameObject hålltext;
    public float speed = 3f;
    public int enemyHealth = 1;
    private GameObject spawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner = GameObject.Find("spawnScript");

        hålltext = GameObject.Find("score");
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
    }
}    
    /*public void TakeDamage()
    {

        enemyHealth--;
        Debug.Log("enemyHealth: " +  enemyHealth);

        if (enemyHealth <= 0)
        {
            hålltext.GetComponent<bildgrejs>().Score += 1;
            spawner.GetComponent<enemyspawner>().enemyCounter -= 1;
            Destroy(gameObject);
        }
    }*/