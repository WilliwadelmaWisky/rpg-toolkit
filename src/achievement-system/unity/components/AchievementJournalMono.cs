using UnityEngine;
using WWWisky.achievements.core.achievements;
using WWWisky.achievements.core.components;
using WWWisky.achievements.unity.achievements;

namespace WWWisky.achievements.unity.components
{
    /// <summary>
    /// 
    /// </summary>
    public class AchievementJournalMono : MonoBehaviour
    {
        [SerializeField] private AchievementSO[] Achievements;

        private AchievementJournal _journal;


        void Awake()
        {
            _journal = new AchievementJournal();

            foreach (AchievementSO achievementSO in Achievements)
            {
                IAchievement achievement = achievementSO.Create();
                _journal.Add(achievement);
            }    
        }
    }
}
