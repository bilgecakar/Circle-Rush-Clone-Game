using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    [SerializeField] float rotation = 50f;
    [SerializeField] GameObject enemy;
    [SerializeField] float repeatTime = 5f;
    GameObject player;
        // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("onSpawn", 1f, repeatTime);
  


    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Rotate(0, 0, Time.deltaTime * rotation);

        
     

    }

    void onSpawn()
    {
        player = GameObject.FindWithTag("Player");
        var position = new Vector2(Random.Range(-4.0f, 4.0f), Random.Range(12.0f, 13.0f));
        Instantiate(enemy, position, Quaternion.identity);
        transform.Translate(-player.transform.position.x * Time.deltaTime, -player.transform.position.y * Time.deltaTime, 0);

    }
}
