using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Catastrophe
{
    public class VirtualInputManager : MonoBehaviour
    {
        public static VirtualInputManager Instance = null;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else if (Instance != null)
            {
                Destroy(this.gameObject);
            }
        }

        public bool MoveRight;
        public bool MoveLeft;
    }
}
