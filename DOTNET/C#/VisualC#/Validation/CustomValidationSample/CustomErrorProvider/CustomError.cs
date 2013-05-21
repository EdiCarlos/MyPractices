using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Reflection;
namespace CustomErrorProvider
{
    [ToolboxBitmap(typeof(CustomError), "CustomError.ico")]
    public class CustomError : Component
    {
        ErrorProvider _errorProvider = new ErrorProvider();
        Control _controlToValidate;
        Control[] _controlsToValidate;
        bool checkIfEmpty;
        bool checkWithRegex;
        string regexValue;
        Regex regex;
        bool cancel = true;
        [Browsable(false)]
        public bool Cancel
        {
            get { return cancel; }
            set { cancel = value; }
        }
        public string RegexValue
        {
            get { return regexValue; }
            set
            {
                if (value != null && !value.Equals(string.Empty))
                {
                    regexValue = value;
                }
            }
        }
        public bool CheckWithRegex
        {
            get { return checkWithRegex; }
            set
            {
                checkWithRegex = value;
                if (CheckWithRegex)
                {
                    CheckIfEmpty = false;
                }
            }
        }
        public bool CheckIfEmpty
        {
            get { return checkIfEmpty; }
            set
            {
                checkIfEmpty = value;
                if (CheckIfEmpty)
                {
                    CheckWithRegex = false;
                }
            }
        }
        [Description("gets or sets the value to validate")]
        public Control[] ControlsToValidate
        {
            get { return _controlsToValidate; }
            set
            {
                _controlsToValidate = value;
                if ((_controlsToValidate != null) && (!DesignMode))
                {
                    foreach (Control cntr in _controlsToValidate)
                    {
                        cntr.Validating += new CancelEventHandler(_controlToValidate_Validating);
                    }
                }
            }
        }
        string _errorMessage = string.Empty;
        [Category("Behaviour")]
        [Description("Gets or sets the control to validate.")]
        [Browsable(true)]
        public Control ControlToValidate
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
        [Description("Gets or Sets the Error Message")]
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
            }
        }
        ToolTip tip = new ToolTip();
                        
        void _controlToValidate_Validating(object sender, CancelEventArgs e)
        {
            //Validate(sender);
            Control lclcontrol = sender as Control;
            if (checkIfEmpty)
            {
                if (lclcontrol.Text != null)
                {
                    if (lclcontrol.Text.Equals(string.Empty))
                    {
                        Cancel = false;
                        lclcontrol.BackColor = Color.Red;
                        tip.SetToolTip(lclcontrol, ErrorMessage);
                        tip.Active = true;
                    }
                    else
                    {
                        lclcontrol.BackColor = Color.White;
                        tip.Active = false;
                    }
                }
            }
            else if (CheckWithRegex)
            {
                regex = new Regex(RegexValue);
                if (!regex.Match(lclcontrol.Text).Success)
                {
                    //e.Cancel = true;
                    Cancel = false;
                    //_errorProvider.SetError(lclcontrol, ErrorMessage);
                    lclcontrol.BackColor = Color.Red;
                }
                else
                {
                    lclcontrol.BackColor = Color.White;
                }
            }
        }
    }
}
