//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//namespace TouchEevent
//{
    
//    public class TouchPhasePlay : MonoBehaviour
//    {
       
//        [SerializeField] Text phaseDisplayText;
//        private Touch theTouch;
//        private float timeTouchEnded;
//        private float displayTime = 0.5f;
//        [SerializeField]  private PlayerControl _player;

//        // Update is called once per frame
//        void Update()
//        {
//            if (Input.touchCount > 0)
//            {
//                theTouch = Input.GetTouch(0);
//                if (theTouch.phase == TouchPhase.Ended)
//                {
//                    _player.dirRight = true;
//                    timeTouchEnded = Time.time;
//                }
//                else if (Time.time - timeTouchEnded > displayTime)
//                {
//                    _player.dirRight = true;
//                    timeTouchEnded = Time.time;

//                }
//            }
//            else if (Time.time - timeTouchEnded > displayTime)
//            {
//                phaseDisplayText.text = "";
//            }

//        }
//    }
//}


