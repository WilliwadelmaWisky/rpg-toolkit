using UnityEngine;
using WWWisky.achievements.core.achievements;

namespace WWWisky.achievements.unity.achievements
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AchievementSO : ScriptableObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract IAchievement Create();
    }
}
