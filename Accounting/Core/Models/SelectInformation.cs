namespace Accounting.Core
{
    /// <summary>
    /// This class is used by Razor to 
    /// </summary>
    public class SelectInformation
    {
        public bool AutoFocus { get; set; }
        public bool Disabled { get; set; }
        public String Form { get; set; }
        public String Id { get; set; }
        public bool Multiple { get; set; }
        public String Name { get; set; }
        public bool Required { get; set; }
        public int Size { get; set; }
        public String Label { get; set; }
        public String Class { get; set; }
        public String Style { get; set; }

        public List<SelectOption> Options { get; set; }

        public String SizeAsString
        {
            get
            {
                return Size.ToString();
            }
        }

        public SelectInformation(bool autofocus, bool disabled, String form, String id, bool multiple, String name, bool required, int size, String label, List<SelectOption> options)
        {
            AutoFocus = autofocus;
            Disabled = disabled;
            Form = form;
            Id = id;
            Multiple = multiple;
            Name = name;
            Required = required;
            Size = size;
            Label = label;

            Class = String.Empty;
            Style = String.Empty;

            Options = options;
        }

        public SelectInformation(bool disabled, String id, bool multiple, String name, bool required, int size, String label) : this(false, disabled, String.Empty, id, multiple, name, required, size, label, new List<SelectOption>())
        { }

        public SelectInformation(String id, String name, bool required, String label) : this(false, false, String.Empty, id, false, name, required, -1, label, new List<SelectOption>())
        { }
    }
}
