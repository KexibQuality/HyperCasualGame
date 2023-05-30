using System;
using UnityEngine;

namespace LessonGameSystem.Game
{
    public sealed class GameSystem : MonoBehaviour, IGameSystem
    {
        [SerializeField]
        private MonoBehaviour[] components;

        public void InitGame()
        {
            foreach (var component in this.components)
            {
                if (component is IGameInitComponent initComponent)
                {
                    initComponent.OnInitGame(this);
                }
            }
        }

        public void StartGame()
        {
            foreach (var component in this.components)
            {
                if (component is IGameStartComponent startComponent)
                {
                    startComponent.OnStartGame();
                }
            }
        }

        public void PauseGame()
        {
            foreach (var component in this.components)
            {
                if (component is IGamePauseComponent pauseComponent)
                {
                    pauseComponent.OnPauseGame();
                }
            }
        }

        public void ResumeGame()
        {
            foreach (var component in this.components)
            {
                if (component is IGameResumeComponent resumeComponent)
                {
                    resumeComponent.OnResumeGame();
                }
            }
        }

        public void FinishGame()
        {
            foreach (var component in this.components)
            {
                if (component is IGameFinishComponent finishComponent)
                {
                    finishComponent.OnFinishGame();
                }
            }
        }

        public T GetService<T>()
        {
            foreach (var component in this.components)
            {
                if (component is T tComponent)
                {
                    return tComponent;
                }
            }

            throw new Exception($"Component {typeof(T).Name} is not found!");
        }
    }
}