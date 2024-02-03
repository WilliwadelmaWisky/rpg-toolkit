using System.Collections.Generic;

namespace WWWisky.inventory.core
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICrafter : IEnumerable<IRecipe>
    {
        void Learn(IRecipe recipe);

        bool CanCraft(IRecipe recipe, int amount);
        bool Craft(IRecipe recipe, int amount);
    }
}
