using UnityEngine;
using WWWisky.inventory.core;

namespace WWWisky.inventory.unity
{
    /// <summary>
    /// 
    /// </summary>
    [RequireComponent(typeof(InventoryMono))]
    public class CrafterMono : MonoBehaviour
    {
        [SerializeField] private RecipeSO[] Recipes;

        public ICrafter Crafter { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        void Awake()
        {
            Crafter = new Crafter();
            foreach (RecipeSO recipeSO in Recipes)
                Crafter.Learn(recipeSO.Create());
        }
    }
}
