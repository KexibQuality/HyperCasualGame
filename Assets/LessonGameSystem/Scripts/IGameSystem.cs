namespace LessonGameSystem.Game
{
    public interface IGameSystem
    {
        void InitGame();

        void StartGame();

        void PauseGame();

        void ResumeGame();

        void FinishGame();
        
        T GetService<T>();
    }



    public sealed class A
    {
        private IGameSystem gameSystem;

        private void Test()
        {
            this.gameSystem.InitGame();
            this.gameSystem.StartGame();
            this.gameSystem.PauseGame();
            this.gameSystem.FinishGame();
        }
    }
}