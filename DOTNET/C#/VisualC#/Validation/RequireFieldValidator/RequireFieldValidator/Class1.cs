using System;
using System.Collections.Generic;

using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;



namespace CustomValidationSample
{
    [ToolboxBitmap(
     typeof(RequiredFieldValidator),"RequiredFieldValidator.ico")]
    class RequiredFieldValidator : Component
    {
        ErrorProvider _errorProvider = new ErrorProvider();
        //string ControlToValidate { get; set; }
        Icon _icon;

        [Category("Appearance")]
        [Description("Gets or sets the Icon to display ErrorMessage.")]
        public Icon icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        string _initialValue;
        string _errorMessage;
        [Category("Appearance")]
        [Description("Gets or sets the text for the error message.")]

        public string ErrorMessage { get { return _errorMessage; } set { _errorMessage = value; } }


        public string InitialValue { get { return _initialValue; } set { _initialValue = value; } }
        bool _isValid;

        [Category("Apperance")]
        [Description("Gets or sets the text for the isvalue.")]
        public bool IsValid { get { return _isValid; } set { _isValid = value; } }

        Control _controlToValidate;
        [Category("Behaviour")]
        [Description("Gets or sets the control to validate.")]
        Control ControlToValidate
        {
            get { return _controlToValidate; }
            set
            {
                _controlToValidate = value;
                // Hook up ControlToValidate's Validating event
                // at run-time ie not from VS.NET
                if ((_controlToValidate != null) && (!DesignMode))
                {
                    _controlToValidate.Validating += new CancelEventHandler(_controlToValidate_Validating);
                }

            }
        }

        void _controlToValidate_Validating(object sender, CancelEventArgs e)
        {
            Validate();
        }
        void Validate()
        {
            // Is valid if different than initial value,
            // which is not necessarily an empty string
            string controlValue = ControlToValidate.Text.Trim();
            string initialValue;
            if (_initialValue == null) initialValue = "";
            else initialValue = _initialValue.Trim();
            _isValid = (controlValue != initialValue);
            // Display an error if ControlToValidate is invalid
            string errorMessage = "";
            if (!_isValid)
            {
                errorMessage = _errorMessage;
                _errorProvider.Icon = _icon;
            }
            _errorProvider.SetError(_controlToValidate, errorMessage);
        }

    }
}


