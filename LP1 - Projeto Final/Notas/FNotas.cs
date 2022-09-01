using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP1___Projeto_Final.Notas
{
    public partial class FNotas : MaterialForm
    {
        public FNotas()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaterialCard modelo = generateModelo();
            this.LP.Controls.Add(modelo);
        }


        private MaterialCard generateModelo()
        {
            MaterialCard materialCard1 = new MaterialCard();
            MaterialLabel Modelo_Card_Date = new MaterialLabel();
            MaterialLabel Modelo_Card_Title = new MaterialLabel();
            MaterialLabel Modelo_Card_Desc = new MaterialLabel();
            MaterialButton Modelo_Card_Button = new MaterialButton();
            materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            materialCard1.Depth = 0;
            materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialCard1.Location = new System.Drawing.Point(14, 14);
            materialCard1.Margin = new System.Windows.Forms.Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new System.Windows.Forms.Padding(14);
            materialCard1.Size = new System.Drawing.Size(383, 118);
            materialCard1.TabIndex = 0;
            Modelo_Card_Date.AutoSize = true;
            Modelo_Card_Date.Depth = 0;
            Modelo_Card_Date.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Modelo_Card_Date.ForeColor = System.Drawing.Color.Black;
            Modelo_Card_Date.Location = new System.Drawing.Point(17, 90);
            Modelo_Card_Date.MouseState = MaterialSkin.MouseState.HOVER;
            Modelo_Card_Date.Name = "Modelo_Card_Date";
            Modelo_Card_Date.Size = new System.Drawing.Size(87, 19);
            Modelo_Card_Date.TabIndex = 2;
            Modelo_Card_Date.Text = "10/01/2077";
            Modelo_Card_Title.AutoSize = true;
            Modelo_Card_Title.Depth = 0;
            Modelo_Card_Title.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Modelo_Card_Title.Location = new System.Drawing.Point(20, 14);
            Modelo_Card_Title.MouseState = MaterialSkin.MouseState.HOVER;
            Modelo_Card_Title.Name = "Modelo_Card_Title";
            Modelo_Card_Title.Size = new System.Drawing.Size(27, 19);
            Modelo_Card_Title.TabIndex = 1;
            Modelo_Card_Title.Text = "title";
            Modelo_Card_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Modelo_Card_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Modelo_Card_Button.Depth = 0;
            Modelo_Card_Button.HighEmphasis = true;
            Modelo_Card_Button.Icon = null;
            Modelo_Card_Button.Location = new System.Drawing.Point(310, 73);
            Modelo_Card_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Modelo_Card_Button.MouseState = MaterialSkin.MouseState.HOVER;
            Modelo_Card_Button.Name = "Modelo_Card_Button";
            Modelo_Card_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            Modelo_Card_Button.Size = new System.Drawing.Size(64, 36);
            Modelo_Card_Button.TabIndex = 0;
            Modelo_Card_Button.Text = "Ver";
            Modelo_Card_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Modelo_Card_Button.UseAccentColor = false;
            Modelo_Card_Button.UseVisualStyleBackColor = true;
            Modelo_Card_Desc.AutoSize = true;
            Modelo_Card_Desc.Depth = 0;
            Modelo_Card_Desc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Modelo_Card_Desc.Location = new System.Drawing.Point(20, 50);
            Modelo_Card_Desc.MouseState = MaterialSkin.MouseState.HOVER;
            Modelo_Card_Desc.Name = "Modelo_Card_Desc";
            Modelo_Card_Desc.Size = new System.Drawing.Size(79, 19);
            Modelo_Card_Desc.TabIndex = 3;
            Modelo_Card_Desc.Text = "description";
            materialCard1.Controls.Add(Modelo_Card_Desc);
            materialCard1.Controls.Add(Modelo_Card_Date);
            materialCard1.Controls.Add(Modelo_Card_Title);
            materialCard1.Controls.Add(Modelo_Card_Button);
            return materialCard1;
        }
    }
}
