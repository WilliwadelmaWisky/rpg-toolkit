namespace WWWisky.achievements.core.achievements
{
    /// <summary>
    /// 
    /// </summary>
    public class Achievement_TargetID : Achievement
    {
        public string TargetID { get; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="targetID"></param>
        public Achievement_TargetID(string id, string name, string targetID) : base(id, name)
        {
            TargetID = targetID;
        }


        /// <summary>
		/// 
		/// </summary>
		/// <param name="targetID"></param>
		/// <returns></returns>
		public bool IsMatch(string targetID) => TargetID.Equals(targetID);
    }
}
