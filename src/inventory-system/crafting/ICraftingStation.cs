﻿using System.Collections.Generic;

namespace WWWisky.inventory.core
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICraftingStation : IEnumerable<IRecipe>
    {
        string Name { get; }

        void Add(IRecipe recipe);
        void Craft(IRecipe recipe, int amount);
        void Access(ICrafter crafter);
    }
}
