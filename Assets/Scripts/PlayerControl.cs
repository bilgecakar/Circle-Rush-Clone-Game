using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 namespace TouchEevent
{
    [CreateAssetMenu(menuName = "Assets/Scripts/PlayerController")]
    public class PlayerControl : MonoBehaviour
    {
        public bool dirRight = true;
        [SerializeField] float speed = 2.0f;
        int sayi = 0;
        private Touch theTouch;
        private float timeTouchEnded;
        private float displayTime = 0.5f;
        private void Start()
        {

        }
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

            if (Input.touchCount > 0)
            {
                theTouch = Input.GetTouch(0);

                if (theTouch.phase == TouchPhase.Began && dirRight == true)
                    dirRight = false;
                else if(theTouch.phase == TouchPhase.Began && dirRight == false)
                    dirRight = true;

            }
         
        }
    }
}

