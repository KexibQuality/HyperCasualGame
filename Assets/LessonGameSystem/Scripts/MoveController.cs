using GameElements;
using LessonEntities.Scripts;
using LessonGameSystem.Game;
using LessonGameSystem.Scripts;
using UnityEngine;

namespace LessonEntities.Game
{
    public sealed class MoveController : MonoBehaviour,
       IGameReadyElement,
       IGameFinishElement
    {
        private PlayerService playerService;

        private InputManager inputManager;
        
        void IGameReadyElement.ReadyGame(GameElements.IGameSystem system)
        {
            this.playerService = system.GetService<PlayerService>();
            this.inputManager = system.GetService<InputManager>();
            this.inputManager.OnInput += this.OnInputEvent;
        }


        void IGameFinishElement.FinishGame(GameElements.IGameSystem system)
        {
            this.inputManager.OnInput -= this.OnInputEvent;
        }
        
        private void OnInputEvent(Vector3 direction)
        {
            this.playerService.Player.Element<IMoveComponent>().Move(direction);
        }
    }
}