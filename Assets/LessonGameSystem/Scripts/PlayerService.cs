using Entities;
using UnityEngine;

namespace LessonGameSystem.Scripts
{
    public sealed class PlayerService : MonoBehaviour
    {
        public IEntity Player
        {
            get { return this.player; }
        }

        [SerializeField]
        private MonoEntity player;
    }
}