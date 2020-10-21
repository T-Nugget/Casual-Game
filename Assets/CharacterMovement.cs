using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Catastrophe
{

    public class CharacterMovement : MonoBehaviour
    {
        public float Speed;

        // Update is called once per frame
        void Update()
        {
            // Do nothing if both inputs are pressed
            if (VirtualInputManager.Instance.MoveRight && VirtualInputManager.Instance.MoveLeft)
            {
                return;
            }

            // Move to the right
            if (VirtualInputManager.Instance.MoveRight)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }

            // Move to the left
            if (VirtualInputManager.Instance.MoveLeft)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, -180f, 0f);
            }
        }
    }

}

