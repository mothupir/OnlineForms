namespace OnlineForms.Client.ViewModels
{
    public static class FieldMarkup
    {
        public static string InputFieldMarkup(InputField field)
        {
            var text = "<div class='row'>";
            text += "<div class='col-11'>";
            text += $"<input id='{field.Id}' class='form-control' placeholder='{field.Prompt}' />";
            text += "</div>";
            if (field.IsRequired)
            {
                text += "<div class='col-1'>";
                text += "<span class='text-danger'>*</span>";
                text += "</div>";
            }
            text += "</div>";

            return text;
        }

        public static string TextFieldMarkup(TextField field)
        {
            var text = "<div class='row'>";
            text += "<div class='col-11'>";
            text += $"<textarea id='{field.Id}' class='form-control' rows='5' style='resize: none;' placeholder='{field.Prompt}'></textarea>";
            text += "</div>";
            if (field.IsRequired)
            {
                text += "<div class='col-1'>";
                text += "<span class='text-danger'>*</span>";
                text += "</div>";
            }
            text += "</div>";

            return text;
        }

        public static string OptionFieldMarkup(OptionField field)
        {
            var text = "";

            return text;
        }
    }
}