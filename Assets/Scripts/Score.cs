using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RedEnemy")
        {
            score++;
            Destroy(collision.gameObject);
            // SceneManager.LoadScene("GameOver");
            Debug.Log(score);

        }
    }
}
