using UnityEngine;

namespace GameEngine.TakeDamage
{
    public sealed class ObserverAnimation : MonoBehaviour
    {
        [SerializeField]
        private TakeDamageMechanics takeDamageController;

        [SerializeField]
        private Animator animator;
        
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
            this.animator.Play("TakeDamage", -1, 0);
        }
    }
}