using GameEngine.TakeDamage;
using UnityEngine;

namespace LessonEntities.Scripts.Variant1
{
    public sealed class TakeDamageComponent : MonoBehaviour, ITakeDamageComponent
    {
        [SerializeField]
        private TakeDamageMechanics controller;

        public void TakeDamage(int damage)
        {
            this.controller.TakeDamage(damage);
        }
    }
}