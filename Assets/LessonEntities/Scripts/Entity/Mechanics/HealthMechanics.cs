using System;
using UnityEngine;
using UnityEngine.Events;

namespace LessonEntities.Scripts.Mechanics
{
    public sealed class HealthMechanics : MonoBehaviour
    {
        public event Action<int> OnHealthChanged;

        public int Health
        {
            get { return this.health; }
        }

        [Range(0, 100)]
        [SerializeField]
        private int health;

        [Space]
        [SerializeField]
        private UnityEvent<int> onChangeHealth;

        [SerializeField]
        private UnityEvent onHealthZero;
        
        public void IncrementHealth(int range)
        {
            this.health += range;
            this.onChangeHealth?.Invoke(this.health);
            this.OnHealthChanged?.Invoke(this.health);
        }

        public void DecrementHealth(int range)
        {
            this.health = Math.Max(this.health -= range, 0);
            this.onChangeHealth?.Invoke(this.health);
            this.OnHealthChanged?.Invoke(this.health);
            this.CheckHealthZero();
        }

        public void ChangeHealth(int newHeath)
        {
            this.health = Math.Max(newHeath, 0);
            this.onChangeHealth?.Invoke(this.health);
            this.OnHealthChanged?.Invoke(this.health);
            this.CheckHealthZero();
        }

        private void CheckHealthZero()
        {
            if (this.health <= 0)
            {
                this.onHealthZero?.Invoke();
            }
        }
    }
}