using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField] Text scoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RedEnemy")
        {
            score++;
            Destroy(collision.gameObject);
            // SceneManager.LoadScene("GameOver");
            scoreText.text = score.ToString();

        }
    }
}
