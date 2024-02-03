using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WWWisky.inventory.core
{
    /// <summary>
    /// 
    /// </summary>
    public class CraftingStation : ICraftingStation
	{
        public string Name { get; }
        public RecipeType RecipeType { get; }
        protected ICrafter CurrentCrafter { get; private set; }

		private readonly List<IRecipe> _recipeList;

		public int RecipeCount => _recipeList.Count;
		
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
        /// <param name="recipeType"></param>
		public CraftingStation(string name, RecipeType recipeType)
		{
            Name = name;
            RecipeType = recipeType;
            CurrentCrafter = null;
			_recipeList = new List<IRecipe>();
		}


        public IEnumerator<IRecipe> GetEnumerator() => _recipeList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="recipe"></param>
		/// <param name="amount"></param>
		/// <param name="crafter"></param>
		public virtual void Craft(IRecipe recipe, int amount)
		{
			if (CurrentCrafter == null)
				return;

            CurrentCrafter.Craft(recipe, amount);
		}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="crafter"></param>
        public void Access(ICrafter crafter)
        {
            CurrentCrafter = crafter;

            _recipeList.Clear();
            _recipeList.AddRange(CurrentCrafter.Where(recipe => recipe.Type == RecipeType));

            IEvent e = new Event_CraftingStationAccess(this, CurrentCrafter);
            EventSystem.Current.Broadcast(e);
        }
    }
}