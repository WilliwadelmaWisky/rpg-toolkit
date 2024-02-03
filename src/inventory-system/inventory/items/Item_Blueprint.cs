using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWWisky.inventory.core
{
    /// <summary>
    /// 
    /// </summary>
    public class Item_Blueprint : Item
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Item_Blueprint(string id, string name) : base(id, name, ItemType.Consumable)
        {
        }
    }
}
