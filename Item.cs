using System;

namespace ZuulCS
{

    class Item
    {
        protected string _itemName;
        protected string description;
        protected float _weight;

        public string itemName
        {
            get { return this._itemName; }
        }
        public float weight
        {
            get { return this._weight; }
        }

	    public Item()
        {
            _itemName = "Undefined";
            description = "Undefined";
            _weight  = 0;
	    }
        public virtual void Use()
        {

        }
        public string ItemDescription()
        {
            return description;
        }
    }
}
