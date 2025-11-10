using UnityEngine;

public class scriptplayer : MonoBehaviour
{
    [SerializeField] private float playerspeed = 3;
    public float horizontalMovement;

    public GameObject laserRed;
    private int playerHealth = 3;
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, -3.5f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)) 
        { 
            transform.Translate(Vector3.left * playerspeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserRed, this.transform.position, this.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }







    }
}
