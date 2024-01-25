using System.Collections.Generic;

namespace WWWisky.quests.core
{
    /// <summary>
    /// 
    /// </summary>
    public interface IQuestJournal : IEnumerable<IQuest>
    {
        int QuestCount { get; }
    }
}
