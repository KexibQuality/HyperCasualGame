using System;
using LessonEntities.Scripts.Mechanics;
using UnityEngine;

namespace LessonEntities.Scripts.Variant1
{
    public sealed class HealthComponent : MonoBehaviour, IHealthComponent
    {
        public event Action<int> OnHealthChanged
        {
            add { this.mechanics.OnHealthChanged += value; }
            remove { this.mechanics.OnHealthChanged -= value; }
        }
        
        public int Health
        {
            get { return this.mechanics.Health; }
        }

        [SerializeField]
        private HealthMechanics mechanics;
    }
}