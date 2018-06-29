using System;

namespace ZuulCS
{

    class Item
    {
        private string _itemName;
        private string description;
        private float _weight;

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
        public void use()
        {

        }
        public string ItemDescription()
        {
            string description = "A generic item";
            return description;
        }
    }
}
