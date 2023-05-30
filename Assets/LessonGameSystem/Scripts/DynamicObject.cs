using GameElements;
using UnityEngine;

namespace LessonGameSystem.Scripts
{
    public sealed class DynamicObject : MonoBehaviour, 
        IGameStartElement,
        IGameFinishElement
    {
        void IGameStartElement.StartGame(IGameSystem system)
        {
            Debug.Log("START GAME");
        }

        void IGameFinishElement.FinishGame(IGameSystem system)
        {
            Debug.Log("FINISH GAME");
        }
    }
}