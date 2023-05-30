namespace LessonGameSystem.Game
{
    public interface IGameInitComponent
    {
        void OnInitGame(IGameSystem system);
    }
    
    public interface IGameStartComponent
    {
        void OnStartGame();
    }

    public interface IGameFinishComponent
    {
        void OnFinishGame();
    }

    public interface IGamePauseComponent
    {
        void OnPauseGame();
    }

    public interface IGameResumeComponent
    {
        void OnResumeGame();
    }
}