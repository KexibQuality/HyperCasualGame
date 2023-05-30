using System;

namespace LessonEntities.Scripts
{
    public interface IHealthComponent
    {
        event Action<int> OnHealthChanged; 

        int Health { get; }
    }
}