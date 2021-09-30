using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private bool dirRight = true;
    [SerializeField] float speed = 2.0f;

    void Update()
    {
        if (dirRight)
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
