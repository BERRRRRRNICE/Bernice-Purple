using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject enemyPrefab;

    public float xSpace;
    public float xOffset;
    // Update is called once per frame
    void Update()
    {
         for (int x = 0; x < 10; x++)
        {
            Instantiate(enemyPrefab, new Vector2(x * xSpace + xOffset, 3), Quaternion.identity);
            Instantiate(enemyPrefab, new Vector2(x * xSpace + xOffset, 3.75f), Quaternion.identity);
            Instantiate(enemyPrefab, new Vector2(x * xSpace + xOffset, 4.5f), Quaternion.identity);
        }
    }
}
