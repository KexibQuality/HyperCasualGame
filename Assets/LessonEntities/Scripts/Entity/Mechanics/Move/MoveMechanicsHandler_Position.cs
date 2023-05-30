using UnityEngine;

namespace LessonEntities.Scripts.Mechanics.Move
{
    public sealed class MoveMechanicsHandler_Position : MonoBehaviour
    {
        [SerializeField]
        private Transform root;

        [SerializeField]
        private float speed = 2;
        private float _oldMousePositionX;
        private float _eulerY;

        [Space]
        [SerializeField]
        private MoveMechanics controller;

        private void FixedUpdate()
        {
            if (this.controller.IsMoving)
            {
                Vector3 newPosition = this.root.position + transform.forward * (Time.deltaTime * speed);
                newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
                root.position = newPosition;

                float deltaX = controller.Direction.x - _oldMousePositionX;
                _oldMousePositionX = controller.Direction.x;

                _eulerY += deltaX;
                _eulerY = Mathf.Clamp(_eulerY, -70f, 70f);
                root.transform.eulerAngles = new Vector3(0, _eulerY, 0);
            }
        }
    }
   
               // var velocity = this.speed * Time.fixedDeltaTime * this.controller.Direction;
               //this.root.position += velocity;
               
               
               
               // Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;
               //newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
               //transform.position = newPosition;
               //
               //float deltaX = Input.mousePosition.x - _oldMousePositionX;
               //_oldMousePositionX = Input.mousePosition.x;
               //
               //_eulerY += deltaX;
               //_eulerY = Mathf.Clamp(_eulerY, -70f, 70f);
               //transform.eulerAngles = new Vector3(0, _eulerY, 0);
}