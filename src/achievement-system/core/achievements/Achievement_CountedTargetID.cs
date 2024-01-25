using System;
using WWWisky.achievements.core.util;

namespace WWWisky.achievements.core.achievements
{
    /// <summary>
    /// 
    /// </summary>
    public class Achievement_CountedTargetID : Achievement_TargetID, ICountable
    {
        public int Current { get; private set; }
        public int Total { get; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="targetID"></param>
        /// <param name="amount"></param>
        public Achievement_CountedTargetID(string id, string name, string targetID, int amount) : base(id, name, targetID)
        {
            Total = Math.Max(amount, 1);
            Current = 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public void Increase(int amount)
        {
            if (IsCompleted || amount <= 0)
                return;

            Current += Math.Min(amount, Total - Current);

            if (Current >= Total)
            {
                Complete();
                return;
            }

            UpdateCallback();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void Decrease(int amount)
        {
            if (IsCompleted || amount <= 0)
                return;

            Current -= Math.Min(amount, Current);
            UpdateCallback();
        }
    }
}
