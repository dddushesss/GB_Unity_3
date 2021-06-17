using Model;
using UnityEngine;

namespace View
{
    public abstract class Unit : MonoBehaviour
    {
        private int _hp;
        private string _name;
        private Inventory _inventory;

        public abstract void Move();
        public abstract void Hit();
    }
}
