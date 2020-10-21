using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Catastrophe
{
    public class KeyboardInput : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            // Move right when D is pressed
            if (Input.GetKey(KeyCode.D))
            {
                VirtualInputManager.Instance.MoveRight = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveRight = false;
            }

            // Move left when A is pressed
            if (Input.GetKey(KeyCode.A))
            {
                VirtualInputManager.Instance.MoveLeft = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveLeft = false;
            }
        }
    }
}
