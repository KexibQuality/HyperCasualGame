using System;
using UnityEngine;
using UnityEngine.Events;

namespace LessonEntities.Scripts.Mechanics
{
    public sealed class DieMechanics : MonoBehaviour
    {
        public event Action OnDied;

        [SerializeField]
        private UnityEvent onDie;

        public void Die()
        {
            this.onDie?.Invoke();
            this.OnDied?.Invoke();
        }
    }
}