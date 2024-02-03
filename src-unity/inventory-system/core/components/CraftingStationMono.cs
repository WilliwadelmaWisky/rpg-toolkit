using UnityEngine;
using WWWisky.inventory.core;

namespace WWWisky.inventory.unity
{
    /// <summary>
    /// 
    /// </summary>
    public class CraftingStationMono : MonoBehaviour
    {
        [SerializeField] protected string Name;
        [SerializeField] protected RecipeType RecipeType;

        public ICraftingStation CraftingStation { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        protected virtual void Awake()
        {
            CraftingStation = Create();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual ICraftingStation Create() => new CraftingStation(Name, RecipeType);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="crafter"></param>
        public void Access(ICrafter crafter)
        {
            CraftingStation.Access(crafter);
        }
    }
}
