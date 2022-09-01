namespace LP1___Projeto_Final.Notas
{
    partial class FNotas
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
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.LP = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Modelo_Card_Desc = new MaterialSkin.Controls.MaterialLabel();
            this.Modelo_Card_Date = new MaterialSkin.Controls.MaterialLabel();
            this.Modelo_Card_Title = new MaterialSkin.Controls.MaterialLabel();
            this.Modelo_Card_Button = new MaterialSkin.Controls.MaterialButton();
            this.LP.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(10, 595);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(141, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar Nota";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnAdd.UseAccentColor = true;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // LP
            // 
            this.LP.AutoScroll = true;
            this.LP.Controls.Add(this.materialCard1);
            this.LP.Location = new System.Drawing.Point(6, 86);
            this.LP.Name = "LP";
            this.LP.Size = new System.Drawing.Size(1445, 500);
            this.LP.TabIndex = 3;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.Modelo_Card_Desc);
            this.materialCard1.Controls.Add(this.Modelo_Card_Date);
            this.materialCard1.Controls.Add(this.Modelo_Card_Title);
            this.materialCard1.Controls.Add(this.Modelo_Card_Button);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(383, 118);
            this.materialCard1.TabIndex = 0;
            // 
            // Modelo_Card_Desc
            // 
            this.Modelo_Card_Desc.AutoSize = true;
            this.Modelo_Card_Desc.Depth = 0;
            this.Modelo_Card_Desc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Modelo_Card_Desc.Location = new System.Drawing.Point(20, 50);
            this.Modelo_Card_Desc.MouseState = MaterialSkin.MouseState.HOVER;
            this.Modelo_Card_Desc.Name = "Modelo_Card_Desc";
            this.Modelo_Card_Desc.Size = new System.Drawing.Size(79, 19);
            this.Modelo_Card_Desc.TabIndex = 3;
            this.Modelo_Card_Desc.Text = "description";
            // 
            // Modelo_Card_Date
            // 
            this.Modelo_Card_Date.AutoSize = true;
            this.Modelo_Card_Date.Depth = 0;
            this.Modelo_Card_Date.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Modelo_Card_Date.ForeColor = System.Drawing.Color.Black;
            this.Modelo_Card_Date.Location = new System.Drawing.Point(17, 90);
            this.Modelo_Card_Date.MouseState = MaterialSkin.MouseState.HOVER;
            this.Modelo_Card_Date.Name = "Modelo_Card_Date";
            this.Modelo_Card_Date.Size = new System.Drawing.Size(87, 19);
            this.Modelo_Card_Date.TabIndex = 2;
            this.Modelo_Card_Date.Text = "10/01/2077";
            // 
            // Modelo_Card_Title
            // 
            this.Modelo_Card_Title.AutoSize = true;
            this.Modelo_Card_Title.Depth = 0;
            this.Modelo_Card_Title.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Modelo_Card_Title.Location = new System.Drawing.Point(20, 14);
            this.Modelo_Card_Title.MouseState = MaterialSkin.MouseState.HOVER;
            this.Modelo_Card_Title.Name = "Modelo_Card_Title";
            this.Modelo_Card_Title.Size = new System.Drawing.Size(27, 19);
            this.Modelo_Card_Title.TabIndex = 1;
            this.Modelo_Card_Title.Text = "title";
            // 
            // Modelo_Card_Button
            // 
            this.Modelo_Card_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Modelo_Card_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Modelo_Card_Button.Depth = 0;
            this.Modelo_Card_Button.HighEmphasis = true;
            this.Modelo_Card_Button.Icon = null;
            this.Modelo_Card_Button.Location = new System.Drawing.Point(310, 73);
            this.Modelo_Card_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Modelo_Card_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Modelo_Card_Button.Name = "Modelo_Card_Button";
            this.Modelo_Card_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Modelo_Card_Button.Size = new System.Drawing.Size(64, 36);
            this.Modelo_Card_Button.TabIndex = 0;
            this.Modelo_Card_Button.Text = "Ver";
            this.Modelo_Card_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Modelo_Card_Button.UseAccentColor = false;
            this.Modelo_Card_Button.UseVisualStyleBackColor = true;
            // 
            // FNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 651);
            this.Controls.Add(this.LP);
            this.Controls.Add(this.btnAdd);
            this.Name = "FNotas";
            this.Text = "Suas Notas";
            this.LP.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private FlowLayoutPanel LP;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel Modelo_Card_Date;
        private MaterialSkin.Controls.MaterialLabel Modelo_Card_Title;
        private MaterialSkin.Controls.MaterialButton Modelo_Card_Button;
        private MaterialSkin.Controls.MaterialLabel Modelo_Card_Desc;
    }
}