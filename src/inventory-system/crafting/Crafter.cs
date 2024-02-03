using System.Collections;
using System.Collections.Generic;

namespace WWWisky.inventory.core
{
    /// <summary>
    /// 
    /// </summary>
    public class Crafter : ICrafter
    {
        private readonly List<IRecipe> _learnedRecipeList;
        private readonly HashSet<string> _learnedRecipeIDSet;


        /// <summary>
        /// 
        /// </summary>
        public Crafter()
        {
            _learnedRecipeList = new List<IRecipe>();
            _learnedRecipeIDSet = new HashSet<string>();
        }


        public IEnumerator<IRecipe> GetEnumerator() => _learnedRecipeList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipe"></param>
        public void Learn(IRecipe recipe)
        {
            if (_learnedRecipeIDSet.Contains(recipe.ID))
                return;

            _learnedRecipeList.Add(recipe);
            _learnedRecipeIDSet.Add(recipe.ID);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipe"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Craft(IRecipe recipe, int amount)
        {
            if (!CanCraft(recipe, amount))
                return false;

            foreach (IRequirement requirement in recipe)
                requirement.Use(this);

            CraftResult result = recipe.Craft();
            if (!result.Success)
                return false;

            //Add(result.Craftable, result.Quantity);
            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipe"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool CanCraft(IRecipe recipe, int amount)
        {
            foreach (IRequirement requirement in recipe)
            {
                if (!requirement.OK(this))
                    return false;
            }

            return true;
        }
    }
}
