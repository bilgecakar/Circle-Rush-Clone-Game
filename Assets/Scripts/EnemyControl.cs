using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    [SerializeField] float rotation = 50f;
    [SerializeField] GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("onSpawn", 3f, 3f);
      
    }

    // Update is called once per frame
    void Update()
    {     
        transform.Rotate(0, 0, Time.deltaTime * rotation);
        
    }

    void onSpawn()
    {
        var position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(9.0f, 15.0f), 0);
        Instantiate(enemy, position, Quaternion.identity);
    }
}
