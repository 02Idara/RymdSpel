using UnityEngine;
using TMPro;

public class bullet : MonoBehaviour
{
    public float bulletspeed = 5f;
    public GameObject score;
    public GameObject spawn;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn = GameObject.Find("spawnScript");
        score = GameObject.Find("score");
        Destroy(gameObject, 5); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletspeed * Time.deltaTime);

    }    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {            
            spawn.GetComponent<enemyspawner>().enemyCounter--;
            score.GetComponent<bildgrejs>().Score++;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }        
    }
}
