using System;

namespace Greed
{
    class MenuItem
    {
        public string Value { get; set; }

        public bool IsSelected { get; set; }

        public MenuItem(string value, bool isSelected)
        {
            this.Value = value;
            this.IsSelected = isSelected;
        }
    }
}

