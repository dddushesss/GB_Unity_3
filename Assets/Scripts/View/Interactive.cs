using System.Collections;
using System.Collections.Generic;
using Model;
using UnityEngine;

namespace View
{
    enum Type
    {
        Pickable,
        Openable
    }
    public abstract class Interactive : MonoBehaviour
    {
        private Type _type;
        private Inventory _inventory;

        public abstract void Interact();
    
    }
}