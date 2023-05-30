using LessonEntities.Scripts.Mechanics.Move;
using UnityEngine;

namespace LessonEntities.Scripts.Variant1
{
    public sealed class MoveComponent : MonoBehaviour, IMoveComponent
    {
        [SerializeField]
        private MoveMechanics moveMechanics;
        
        public void Move(Vector3 direction)
        {
            this.moveMechanics.Move(direction);
    
        }
    }
}