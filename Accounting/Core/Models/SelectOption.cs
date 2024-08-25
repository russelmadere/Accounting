namespace Accounting.Core
{
    public class SelectOption
    {
        public String Text { get; set; } // Option text
        public bool Disabled { get; set; } // Option is disabled
        public String Label { get; set; } // Option shortened label
        public bool Selected { get; set; } // Option is selected
        public String Value { get; set; } // Option value on submit

        public SelectOption() : this(String.Empty, false, String.Empty, false, String.Empty)
        { }

        public SelectOption(String text, bool selected, String value) : this(text, false, String.Empty, selected, value)
        { }

        public SelectOption(String text, bool disabled, String label, bool selected, String value)
        {
            Text = text;
            Disabled = disabled;
            Label = label;
            Selected = selected;
            Value = value;
        }
    }
}
