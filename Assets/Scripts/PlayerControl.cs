using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 namespace TouchEevent
{
   
    public class PlayerControl : MonoBehaviour
    {
        public bool dirRight = true;
        [SerializeField] float speed = 2.0f;
        private Touch theTouch;

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

