﻿using UnityEngine;
using WWWisky.inventory.core;

namespace WWWisky.inventory.unity
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ItemSO : ScriptableObject
    {
        [SerializeField] private string ID;
        [SerializeField] private string Name;
        [SerializeField] private Sprite Icon;


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IItem Create()
        {
            IconRegistry.Current.Register(ID, Icon);
            return OnCreate(ID, Name);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        protected abstract IItem OnCreate(string id, string name);
    }
}
