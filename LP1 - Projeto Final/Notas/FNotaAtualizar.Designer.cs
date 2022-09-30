namespace LP1___Projeto_Final.Notas
{
    partial class FNotaAtualizar
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
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.DatePickerDate = new System.Windows.Forms.DateTimePicker();
            this.MTDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.TBTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(129, 429);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(96, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(238, 429);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(99, 36);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Atualizar";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.Location = new System.Drawing.Point(19, 356);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 19);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Data";
            // 
            // DatePickerDate
            // 
            this.DatePickerDate.Location = new System.Drawing.Point(19, 388);
            this.DatePickerDate.Name = "DatePickerDate";
            this.DatePickerDate.Size = new System.Drawing.Size(317, 23);
            this.DatePickerDate.TabIndex = 12;
            // 
            // MTDescription
            // 
            this.MTDescription.AcceptsTab = true;
            this.MTDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MTDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTDescription.Depth = 0;
            this.MTDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MTDescription.Location = new System.Drawing.Point(19, 188);
            this.MTDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTDescription.Name = "MTDescription";
            this.MTDescription.Size = new System.Drawing.Size(317, 147);
            this.MTDescription.TabIndex = 11;
            this.MTDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescription.Location = new System.Drawing.Point(19, 166);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 19);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Descrição";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(19, 73);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 19);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Título";
            // 
            // TBTitle
            // 
            this.TBTitle.AnimateReadOnly = false;
            this.TBTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTitle.Depth = 0;
            this.TBTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBTitle.LeadingIcon = null;
            this.TBTitle.Location = new System.Drawing.Point(19, 104);
            this.TBTitle.MaxLength = 50;
            this.TBTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.TBTitle.Multiline = false;
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.Size = new System.Drawing.Size(317, 50);
            this.TBTitle.TabIndex = 8;
            this.TBTitle.Text = "";
            this.TBTitle.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(19, 429);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(96, 36);
            this.materialButton1.TabIndex = 16;
            this.materialButton1.Text = "Deletar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // FNotaAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 473);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.DatePickerDate);
            this.Controls.Add(this.MTDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.TBTitle);
            this.Name = "FNotaAtualizar";
            this.Text = "Editar nota";
            this.Load += new System.EventHandler(this.FNotaAtualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private DateTimePicker DatePickerDate;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MTDescription;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialTextBox TBTitle;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}