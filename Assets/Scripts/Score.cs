using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Score
{
    [CreateAssetMenu (menuName ="Assets/Scripts/Score")]

    public class Score : MonoBehaviour
    {
        private int score = 0;
        public int highScore = 0;
        [SerializeField] Text scoreText;
        [SerializeField] Text highScoreText;



        private void Start()
        {
            highScore = PlayerPrefs.GetInt("highScore", highScore);
            //highScoreText.text = "" + highScore.ToString();
        }

        private void Update()
        {

            if (score > highScore)
                highScore = score;
            PlayerPrefs.SetInt("highScore", highScore);
        }

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

        private void OnDestroy()
        {
            PlayerPrefs.SetInt("highScore", highScore);
            PlayerPrefs.Save();
        }
    }
}

