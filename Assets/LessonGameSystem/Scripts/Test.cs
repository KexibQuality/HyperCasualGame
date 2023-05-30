using System;
using GameElements;
using Unity.VisualScripting;
using UnityEngine;
using GameSystem = LessonGameSystem.Game.GameSystem;

namespace LessonGameSystem.Scripts
{
    public sealed class Test : MonoBehaviour,
        IGameReferenceElement
    {
        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                this.GameSystem.FinishGame();
            }
        }

        public IGameSystem GameSystem { get; set; }
    }
}