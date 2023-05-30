using System;
using Unity.VisualScripting;
using UnityEngine;

namespace LessonGameSystem.Scripts
{
    public class InputManager : MonoBehaviour
    {
        public event Action<Vector3> OnInput;

        private void Awake()
        {
            this.enabled = false;
        }

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                this.OnInput?.Invoke(Input.mousePosition);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.OnInput?.Invoke(Vector3.left);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                this.OnInput?.Invoke(Vector3.right);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                this.OnInput?.Invoke(Vector3.forward);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                this.OnInput?.Invoke(Vector3.back);
            }
        }
    }
}