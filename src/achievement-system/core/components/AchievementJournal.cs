using System;
using System.Collections.Generic;
using WWWisky.achievements.core.achievements;

namespace WWWisky.achievements.core.components
{
    /// <summary>
    /// 
    /// </summary>
    public class AchievementJournal
    {
        private readonly List<IAchievement> _achievementList;
        private readonly HashSet<string> _achievementIDSet;

        public int AchievementCount => _achievementList.Count;


        /// <summary>
        /// 
        /// </summary>
        public AchievementJournal()
        {
            _achievementList = new List<IAchievement>();
            _achievementIDSet = new HashSet<string>();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="achievement"></param>
        /// <returns></returns>
        public bool Contains(IAchievement achievement) => _achievementIDSet.Contains(achievement.ID);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="onLoop"></param>
        public void ForEach(Action<IAchievement, int> onLoop)
        {
            for (int i = 0; i < AchievementCount; i++)
                onLoop(_achievementList[i], i);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="achievement"></param>
        public void Add(IAchievement achievement)
        {
            if (achievement == null || Contains(achievement))
                return;

            achievement.Start(OnAchievementCompleted);
            _achievementList.Add(achievement);
            _achievementIDSet.Add(achievement.ID);
        }


        /// <summary>
        /// 
        /// </summary>
        private void OnAchievementCompleted()
        {
            
        }
    }
}
