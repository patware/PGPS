using System;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace PGPS.Views.MainForm
{
    partial class MainFormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainFormView));
            this.uxMainSplitContainer = new SplitContainer();
            this.uxUnparsedTextBox = new TextBox();
            this.uxResultTextbox = new TextBox();
            this.uxNotifyPanel = new Panel();
            this.uxINotifyPropertyChangedCheckBox = new CheckBox();
            this.uxAttributePanel = new Panel();
            this.uxAttributeTextBox = new TextBox();
            this.uxAttributeLabel = new Label();
            this.uxMainToolTip = new ToolTip(this.components);
            this.uxMainSplitContainer.Panel1.SuspendLayout();
            this.uxMainSplitContainer.Panel2.SuspendLayout();
            this.uxMainSplitContainer.SuspendLayout();
            this.uxNotifyPanel.SuspendLayout();
            this.uxAttributePanel.SuspendLayout();
            base.SuspendLayout();
            this.uxMainSplitContainer.Dock = DockStyle.Fill;
            this.uxMainSplitContainer.Location = new Point(0, 0);
            this.uxMainSplitContainer.Name = "uxMainSplitContainer";
            this.uxMainSplitContainer.Panel1.Controls.Add(this.uxUnparsedTextBox);
            this.uxMainSplitContainer.Panel2.Controls.Add(this.uxResultTextbox);
            this.uxMainSplitContainer.Panel2.Controls.Add(this.uxNotifyPanel);
            this.uxMainSplitContainer.Panel2.Controls.Add(this.uxAttributePanel);
            this.uxMainSplitContainer.Size = new Size(406, 266);
            this.uxMainSplitContainer.SplitterDistance = 135;
            this.uxMainSplitContainer.TabIndex = 0;
            this.uxUnparsedTextBox.AcceptsReturn = true;
            this.uxUnparsedTextBox.AcceptsTab = true;
            this.uxUnparsedTextBox.Dock = DockStyle.Fill;
            this.uxUnparsedTextBox.Location = new Point(0, 0);
            this.uxUnparsedTextBox.Multiline = true;
            this.uxUnparsedTextBox.Name = "uxUnparsedTextBox";
            this.uxUnparsedTextBox.Size = new Size(135, 266);
            this.uxUnparsedTextBox.TabIndex = 0;
            this.uxUnparsedTextBox.TextChanged +=uxUnparsedTextBox_TextChanged;
            this.uxResultTextbox.Dock = DockStyle.Fill;
            this.uxResultTextbox.Location = new Point(0, 53);
            this.uxResultTextbox.Multiline = true;
            this.uxResultTextbox.Name = "uxResultTextbox";
            this.uxResultTextbox.Size = new Size(267, 213);
            this.uxResultTextbox.TabIndex = 0;
            this.uxNotifyPanel.Controls.Add(this.uxINotifyPropertyChangedCheckBox);
            this.uxNotifyPanel.Dock = DockStyle.Top;
            this.uxNotifyPanel.Location = new Point(0, 26);
            this.uxNotifyPanel.Name = "uxNotifyPanel";
            this.uxNotifyPanel.Size = new Size(267, 27);
            this.uxNotifyPanel.TabIndex = 2;
            this.uxINotifyPropertyChangedCheckBox.AutoSize = true;
            this.uxINotifyPropertyChangedCheckBox.Location = new Point(8, 6);
            this.uxINotifyPropertyChangedCheckBox.Name = "uxINotifyPropertyChangedCheckBox";
            this.uxINotifyPropertyChangedCheckBox.Size = new Size(138, 17);
            this.uxINotifyPropertyChangedCheckBox.TabIndex = 0;
            this.uxINotifyPropertyChangedCheckBox.Text = "INotifyPropertyChanged";
            this.uxINotifyPropertyChangedCheckBox.UseVisualStyleBackColor = true;
            this.uxINotifyPropertyChangedCheckBox.CheckedChanged += this.uxINotifyPropertyChangedCheckBox_CheckedChanged;
            this.uxAttributePanel.Controls.Add(this.uxAttributeTextBox);
            this.uxAttributePanel.Controls.Add(this.uxAttributeLabel);
            this.uxAttributePanel.Dock = DockStyle.Top;
            this.uxAttributePanel.Location = new Point(0, 0);
            this.uxAttributePanel.Name = "uxAttributePanel";
            this.uxAttributePanel.Size = new Size(267, 26);
            this.uxAttributePanel.TabIndex = 1;
            this.uxAttributeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.uxAttributeTextBox.Location = new Point(55, 2);
            this.uxAttributeTextBox.Name = "uxAttributeTextBox";
            this.uxAttributeTextBox.Size = new Size(212, 20);
            this.uxAttributeTextBox.TabIndex = 1;
            this.uxMainToolTip.SetToolTip(this.uxAttributeTextBox, componentResourceManager.GetString("uxAttributeTextBox.ToolTip"));
            this.uxAttributeTextBox.TextChanged += this.uxAttributeTextBox_TextChanged;
            this.uxAttributeLabel.AutoSize = true;
            this.uxAttributeLabel.Location = new Point(3, 5);
            this.uxAttributeLabel.Name = "uxAttributeLabel";
            this.uxAttributeLabel.Size = new Size(46, 13);
            this.uxAttributeLabel.TabIndex = 0;
            this.uxAttributeLabel.Text = "Attribute";
            base.AutoScaleDimensions = new SizeF(6, 13);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(406, 266);
            base.Controls.Add(this.uxMainSplitContainer);
            base.Name = "MainFormView";
            base.Text = "PGPS";
            base.Load += new EventHandler(this.MainForm_Load);
            this.uxMainSplitContainer.Panel1.ResumeLayout(false);
            this.uxMainSplitContainer.Panel1.PerformLayout();
            this.uxMainSplitContainer.Panel2.ResumeLayout(false);
            this.uxMainSplitContainer.Panel2.PerformLayout();
            this.uxMainSplitContainer.ResumeLayout(false);
            this.uxNotifyPanel.ResumeLayout(false);
            this.uxNotifyPanel.PerformLayout();
            this.uxAttributePanel.ResumeLayout(false);
            this.uxAttributePanel.PerformLayout();
            base.ResumeLayout(false);
        }

        #endregion
                
        private Label uxAttributeLabel;

        private Panel uxAttributePanel;

        private TextBox uxAttributeTextBox;

        private CheckBox uxINotifyPropertyChangedCheckBox;

        private SplitContainer uxMainSplitContainer;

        private ToolTip uxMainToolTip;

        private Panel uxNotifyPanel;

        private TextBox uxResultTextbox;

        private TextBox uxUnparsedTextBox;
    }
}

