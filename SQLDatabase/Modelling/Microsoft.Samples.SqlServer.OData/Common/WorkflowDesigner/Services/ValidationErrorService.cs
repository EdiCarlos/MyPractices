﻿// Copyright Microsoft
    
using System;
using System.Activities.Presentation.Validation;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Microsoft.Samples.SqlServer.Workflow.Designer
{
    public class ValidationErrorService : IValidationErrorService
    {
        private ListBox lb;

        public ValidationErrorService(ListBox listBox)
        {
            lb = listBox;
        }

        public void ShowValidationErrors(IList<ValidationErrorInfo> errors)
        {
            lb.Items.Clear();
            foreach (ValidationErrorInfo error in errors)
            {
                if (String.IsNullOrEmpty(error.PropertyName))
                {
                    lb.Items.Add(error.Message);
                }
                else
                {
                    lb.Items.Add(String.Format("{0}: {1}", error.PropertyName, error.Message));
                }
            }
        }
    }
}
