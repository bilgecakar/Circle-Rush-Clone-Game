using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private bool dirRight = true;
    [SerializeField] float speed = 2.0f;
    int sayi = 0;


   

    private void Start()
    {
     
    }
    void Update()
    {
      
        if (dirRight )
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 3.91f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -3.4f)
        {
            dirRight = true;
        }
    }
}
