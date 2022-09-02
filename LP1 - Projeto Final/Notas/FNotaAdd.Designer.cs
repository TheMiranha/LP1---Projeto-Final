namespace LP1___Projeto_Final.Notas
{
    partial class FNotaAdd
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
            this.TBTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.MTDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.DatePickerDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TBTitle
            // 
            this.TBTitle.AnimateReadOnly = false;
            this.TBTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTitle.Depth = 0;
            this.TBTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBTitle.LeadingIcon = null;
            this.TBTitle.Location = new System.Drawing.Point(26, 123);
            this.TBTitle.MaxLength = 50;
            this.TBTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.TBTitle.Multiline = false;
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.Size = new System.Drawing.Size(317, 50);
            this.TBTitle.TabIndex = 0;
            this.TBTitle.Text = "";
            this.TBTitle.TrailingIcon = null;
            this.TBTitle.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(26, 92);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Título";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescription.Location = new System.Drawing.Point(26, 185);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 19);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Descrição";
            // 
            // MTDescription
            // 
            this.MTDescription.AcceptsTab = true;
            this.MTDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MTDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTDescription.Depth = 0;
            this.MTDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MTDescription.Location = new System.Drawing.Point(26, 207);
            this.MTDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTDescription.Name = "MTDescription";
            this.MTDescription.Size = new System.Drawing.Size(317, 147);
            this.MTDescription.TabIndex = 3;
            this.MTDescription.Text = "";
            // 
            // DatePickerDate
            // 
            this.DatePickerDate.Location = new System.Drawing.Point(26, 407);
            this.DatePickerDate.Name = "DatePickerDate";
            this.DatePickerDate.Size = new System.Drawing.Size(317, 23);
            this.DatePickerDate.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.Location = new System.Drawing.Point(26, 375);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 19);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Data";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(245, 448);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(98, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(141, 448);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(96, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FNotaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 493);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.DatePickerDate);
            this.Controls.Add(this.MTDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.TBTitle);
            this.Name = "FNotaAdd";
            this.Text = "Adicionar Nota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TBTitle;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MTDescription;
        private DateTimePicker DatePickerDate;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnCancel;
    }
}