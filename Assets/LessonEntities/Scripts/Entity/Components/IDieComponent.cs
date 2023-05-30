using System;

namespace LessonEntities.Scripts
{
    public interface IDieComponent
    {
        event Action OnDied;

        void Die();
    }
}