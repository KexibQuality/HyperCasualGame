using System;
using UnityEngine;
using UnityEngine.Events;

namespace GameEngine.TakeDamage
{
    [AddComponentMenu("Mechanics/Take Damage Mechanics")]
    public sealed class TakeDamageMechanics : MonoBehaviour
    {
        public event Action<int> OnTakeDamage;

        [SerializeField]
        private UnityEvent<int> onTakeDamage;

        public void TakeDamage(int damage)
        {
            this.onTakeDamage?.Invoke(damage);
            this.OnTakeDamage?.Invoke(damage);
        }
    }
}