using System;
using UnityEngine;
using UnityEngine.Events;

namespace LessonEntities.Scripts.Mechanics.Move
{
    public sealed class MoveMechanics : MonoBehaviour
    {
        public event Action OnStartMove;

        public event Action OnFinishMove;

        public bool IsMoving
        {
            get { return this.isMoving; }
        }

        public Vector3 Direction
        {
            get { return this.direction; }
        }
        
        private bool isMoving;

        private bool finishMove;

        private Vector3 direction;

        [Header("Events")]
        [SerializeField]
        private UnityEvent onStartMove;

        [SerializeField]
        private UnityEvent onFinishMove;
        

        public void Move(Vector3 direction)
        {
            this.direction = direction;
            this.finishMove = false;

            if (!this.isMoving)
            {
                this.isMoving = true;
                this.onStartMove?.Invoke();
                this.OnStartMove?.Invoke();
            }
        }

        private void FixedUpdate()
        {
            if (!this.isMoving)
            {
                return;
            }

            if (this.finishMove)
            {
                this.isMoving = false;
                this.onFinishMove?.Invoke();
                this.OnFinishMove?.Invoke();
            }

            this.finishMove = true;
        }
    }
}