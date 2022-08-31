using System;

public class Item
{
    public string Name;
    public string Value;
    public Item(string name, string value)
    {
        Name = name; Value = value;
    }
    public override string ToString()
    {
        // Generates the text shown in the combo box
        return Name;
    }
}
