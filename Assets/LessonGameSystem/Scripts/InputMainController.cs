using GameElements;
using LessonGameSystem.Game;
using UnityEngine;
using IGameSystem = GameElements.IGameSystem;

namespace LessonGameSystem.Scripts
{
    public sealed class InputMainController : MonoBehaviour,
        IGameStartElement,
        IGameFinishElement
    {
        private InputManager inputManager;

        void IGameStartElement.StartGame(IGameSystem system)
        {
            this.inputManager = system.GetService<InputManager>();
            this.inputManager.enabled = true;
        }

        void IGameFinishElement.FinishGame(IGameSystem system)
        {
            this.inputManager.enabled = false;
        }
    }
}