using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletspeed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Destroy(gameObject, 5); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletspeed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
