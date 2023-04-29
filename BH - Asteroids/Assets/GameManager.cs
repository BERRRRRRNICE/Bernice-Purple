using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject rockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRocks", 0f, 10f);
    }

    private void SpawnRocks()
    {
        //Starts at 0 and stops whwen it reaches 4, so 4 loops in total
        for (int i = 0; i < 4; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8), 0f);
            Instantiate(rockPrefab, randomPosition, Quaternion.identity);
        }
    }
}
