using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OnlineForms.Client.ViewModels
{
    public enum FormFieldType
    {
        InputField,
        TextField,
        OptionField
    }

    public abstract class FormField
    {
        public int Id { get; set; }
        public string? Prompt { get; set; }
        public string? Description { get; set; }
        public bool IsRequired { get; set; }

        public abstract string ToJsonString();
        public abstract string ToMarkupString();
    }

    public class InputField : FormField
    {
        public override string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }

        public override string ToMarkupString()
        {
            return FieldMarkup.InputFieldMarkup(this);
        }
    }

    public class TextField : FormField
    {
        public override string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }

        public override string ToMarkupString()
        {
            return FieldMarkup.TextFieldMarkup(this);
        }
    }

    public abstract class OptionField : FormField
    {
        public OptionType OptionType { get; set; } = OptionType.Dropdown;
        public KeyValuePair<string, string>[]? Options { get; set; }
    }

    public enum OptionType
    {
        Checkbox,
        Dropdown,
        RadioButton
    }

    public class ChooseOneField : OptionField
    {
        
        public override string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }

        public override string ToMarkupString()
        {

            throw new NotImplementedException();
        }
    }

    public class ChooseMultipleField : OptionField
    {
        public int MinSelections { get; set; }
        public int MaxSelections { get; set; }
        public override string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }

        public override string ToMarkupString()
        {
            throw new NotImplementedException();
        }
    }

}
