using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemyspawner : MonoBehaviour
{
    public GameObject Enemy;
    private int enemyCounter;
    private GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EnemySpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator EnemySpawner()
    {
        while (true)
        {
            if (enemyCounter < 3 && GameObject.Find("player")  != null)
            {
                Instantiate(Enemy, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);
                enemyCounter++;

                yield return new WaitForSeconds(5);
            }
            else yield return null;

        }
    }
}
