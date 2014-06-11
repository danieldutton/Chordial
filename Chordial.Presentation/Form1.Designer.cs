namespace Chordial.Presentation
{
    partial class Form1
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
            this._comboBoxNotes = new System.Windows.Forms.ComboBox();
            this._comboBoxScale = new System.Windows.Forms.ComboBox();
            this._panelFretboard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _comboBoxNotes
            // 
            this._comboBoxNotes.FormattingEnabled = true;
            this._comboBoxNotes.Location = new System.Drawing.Point(13, 13);
            this._comboBoxNotes.Name = "_comboBoxNotes";
            this._comboBoxNotes.Size = new System.Drawing.Size(121, 21);
            this._comboBoxNotes.TabIndex = 0;
            // 
            // _comboBoxScale
            // 
            this._comboBoxScale.FormattingEnabled = true;
            this._comboBoxScale.Location = new System.Drawing.Point(158, 13);
            this._comboBoxScale.Name = "_comboBoxScale";
            this._comboBoxScale.Size = new System.Drawing.Size(121, 21);
            this._comboBoxScale.TabIndex = 1;
            // 
            // _panelFretboard
            // 
            this._panelFretboard.Location = new System.Drawing.Point(13, 51);
            this._panelFretboard.Name = "_panelFretboard";
            this._panelFretboard.Size = new System.Drawing.Size(586, 145);
            this._panelFretboard.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 262);
            this.Controls.Add(this._panelFretboard);
            this.Controls.Add(this._comboBoxScale);
            this.Controls.Add(this._comboBoxNotes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _comboBoxNotes;
        private System.Windows.Forms.ComboBox _comboBoxScale;
        private System.Windows.Forms.Panel _panelFretboard;
    }
}

