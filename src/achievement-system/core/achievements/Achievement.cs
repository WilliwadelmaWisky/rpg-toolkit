using System;

namespace WWWisky.achievements.core.achievements
{
    /// <summary>
    /// 
    /// </summary>
    public class Achievement : IAchievement
    {
        public event Action OnUpdated;

        public string ID { get; }
        public string Name { get; }
        public bool IsCompleted { get; private set; }

        private Action _onCompleted;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Achievement(string id, string name)
        {
            ID = id;
            Name = name;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="onCompleted"></param>
        public void Start(Action onCompleted)
        {
            _onCompleted = onCompleted;
            IsCompleted = false;
        }


        /// <summary>
        /// 
        /// </summary>
        public void Complete()
        {
            IsCompleted = true;
            _onCompleted?.Invoke();
            OnUpdated?.Invoke();
        }


        /// <summary>
        /// 
        /// </summary>
        protected void UpdateCallback() => OnUpdated?.Invoke();
    }
}
