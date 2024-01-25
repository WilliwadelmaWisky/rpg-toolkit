using System;

namespace WWWisky.achievements.core.achievements
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAchievement
    {
        string ID { get; }
        string Name { get; }
        bool IsCompleted { get; }

        void Start(Action onCompleted);
        void Complete();
    }
}
