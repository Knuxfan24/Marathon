﻿using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Marathon.Toolkit.Controls
{
    public partial class FileExtensionWizardTask : UserControl
    {
        private string _TaskName, _TaskDescription;

        [Description("The name of the task.")]
        public string TaskName
        {
            get => _TaskName;

            set => RadioButton_Task.Text = _TaskName = value;
        }

        [Description("The description given to the task.")]
        public string TaskDescription
        {
            get => _TaskDescription;

            set
            {
                Label_TaskDescription.Text = _TaskDescription = value;
                Width = Label_TaskDescription.Width + 19;
            }
        }

        public FileExtensionWizardTask() => InitializeComponent();

        public event EventHandler Activated;

        private void RadioButton_Task_CheckedChanged(object sender, EventArgs e) => Activated?.Invoke(sender, e);
    }
}
