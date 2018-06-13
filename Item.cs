using System;

namespace ZuulCS
{

    class Item
    {
        private string _itemName;
        private string description;
        private float weight;

        public string itemName
        {
            get { return this._itemName; }
        }



	    public Item()
        {
            _itemName = "Undefined";
            description = "Undefined";
            weight  = 0;
	    }
    }
}
