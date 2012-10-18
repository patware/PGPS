using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PGPS.Views.MainForm
{
    public partial class MainFormView : Form, IMainFormView
    {
        private MainFormViewPresenter _presenter;
        public MainFormView()
        {
            this.components = null;
            this.InitializeComponent();
            this._presenter = new MainFormViewPresenter(this);

        }



        private void uxAttributeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.uxAttributeTextBox.Focused)
            {
                this.go();
            }
        }

        private void uxINotifyPropertyChangedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.uxINotifyPropertyChangedCheckBox.Focused)
            {
                this.go();
            }
        }

        private void uxUnparsedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.uxUnparsedTextBox.Focused)
            {
                this.go();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            base.Text = string.Concat(new string[] { Application.ProductName, " ", Application.ProductVersion, " by ", Application.CompanyName });
            MainFormModel mainFormModel = new MainFormModel();
        }

        private void go()
        {
            this._presenter.Parse(this.uxUnparsedTextBox.Text, this.uxINotifyPropertyChangedCheckBox.Checked, this.uxAttributeTextBox.Text);
        }

        #region IMainFormView Members

        void IMainFormView.ShowResult(MainFormModel model)
        {
            if (this.uxUnparsedTextBox.Text != model.Input)
            {
                this.uxUnparsedTextBox.Text = model.Input;
            }
            if (this.uxAttributeTextBox.Text != model.AttributeDecorator)
            {
                this.uxAttributeTextBox.Text = model.AttributeDecorator;
            }
            if (this.uxINotifyPropertyChangedCheckBox.Checked != model.IsINotifyPropertyChanged)
            {
                this.uxINotifyPropertyChangedCheckBox.Checked = model.IsINotifyPropertyChanged;
            }
            this.uxResultTextbox.Text = model.Result;
        
        }

        #endregion
    }
}