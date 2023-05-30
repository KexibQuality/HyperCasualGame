using LessonEntities.Scripts.Mechanics;
using UnityEngine;

namespace GameEngine.TakeDamage
{
    [AddComponentMenu("Mechanics/TakeDamage/Observer \"Decrement Hit Points\"")]
    public sealed class ObserverDecrementHitPoints : MonoBehaviour
    {
        [SerializeField]
        private TakeDamageMechanics takeDamageController;

        [SerializeField]
        private HealthMechanics heathController;

        private void OnEnable()
        {
            this.takeDamageController.OnTakeDamage += this.OnTakeDamage;
        }
        
        private void OnDisable()
        {
            this.takeDamageController.OnTakeDamage -= this.OnTakeDamage;
        }

        private void OnTakeDamage(int damage)
        {
            this.heathController.DecrementHealth(damage);
        }
    }
}