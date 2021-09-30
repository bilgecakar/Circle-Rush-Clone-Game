using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    [SerializeField] float rotation = 50f;
    [SerializeField] GameObject enemy;
    private int enemyCount=0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("onSpawn", 1f, 7f);
      
    }

    // Update is called once per frame
    void Update()
    {     
        transform.Rotate(0, 0, Time.deltaTime * rotation);
        Debug.Log(enemyCount);

        if (Input.GetKeyDown("space"))
        {
            CancelInvoke("onSpawn");
        }

    }

    void onSpawn()
    {
        var position = new Vector2(Random.Range(-5.0f, 5.0f), Random.Range(12.0f, 13.0f));
        Instantiate(enemy, position, Quaternion.identity);
        enemyCount++;
    }
}
