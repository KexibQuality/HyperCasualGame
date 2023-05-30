using System;
using LessonEntities.Scripts.Mechanics;
using UnityEngine;

namespace LessonEntities.Scripts.Variant1
{
    public sealed class DieComponent : MonoBehaviour, IDieComponent
    {
        public event Action OnDied
        {
            add { this.controller.OnDied += value; }
            remove { this.controller.OnDied -= value; }
        }

        [SerializeField]
        private DieMechanics controller;

        public void Die()
        {
            this.controller.Die();
        }
    }
}