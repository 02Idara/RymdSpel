using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject hålltext;
    public float speed;
    public int enemyHealth = 1;
    public GameObject spawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner = GameObject.Find("spawnScript");

        hålltext = GameObject.Find("bild");
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
            hålltext.GetComponent<bildgrejs>().Score += 1;
            spawner.GetComponent<enemyspawner>().enemyCounter -= 1;
            Destroy(gameObject);
        }
    }
} 

