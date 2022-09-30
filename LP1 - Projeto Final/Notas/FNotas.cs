using MaterialSkin;
using MaterialSkin.Controls;
using Classes;

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

        NotasDAO notasDAO = new NotasDAO();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaterialForm fadd = new FNotaAdd(UpdateNotas);
            UpdateNotas();
            fadd.Show();
        }

        private int UpdateNotas(Nota x)
        {
            notasDAO.Create(x);
            this.LP.Controls.Clear();
            List<Nota> notas = notasDAO.List();
            foreach (Nota nota in notas)
            {
                MaterialCard card = generateModelo(nota);
                this.LP.Controls.Add(card);
            }
            return 0;
        }

        private int UpdateNotas()
        {
            this.LP.Controls.Clear();
            List<Nota> notas = notasDAO.List();
            foreach (Nota nota in notas)
            {
                MaterialCard card = generateModelo(nota);
                this.LP.Controls.Add(card);
            }
            return 0;
        }


        private MaterialCard generateModelo(Nota nota)
        {
            MaterialCard materialCard1 = new MaterialCard();
            Label Modelo_Card_Date = new Label();
            Label Modelo_Card_Title = new Label();
            Label Modelo_Card_Desc = new Label();
            MaterialButton Modelo_Card_Button = new MaterialButton();
            materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            materialCard1.Depth = 0;
            materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialCard1.Location = new System.Drawing.Point(14, 14);
            materialCard1.Margin = new System.Windows.Forms.Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Padding = new System.Windows.Forms.Padding(14);
            materialCard1.Size = new System.Drawing.Size(383, 118);
            materialCard1.TabIndex = 0;

            Modelo_Card_Title.AutoSize = true;
            System.Drawing.FontStyle title_style = System.Drawing.FontStyle.Regular;
            Color title_color = System.Drawing.Color.White;
            DateTime now = DateTime.Now;
            if (!nota.Check)
            {
                if (nota.Date.Month == now.Month && nota.Date.Date == nota.Date.Date && nota.Date.Year == now.Year)
                {
                    title_style = FontStyle.Italic;
                    title_color = Color.Yellow;
                } else
                {
                    if (nota.Date.CompareTo(now) < 0)
                    {
                        title_style = FontStyle.Bold;
                        title_color = Color.Red;
                    }
                }
            } else
            {
                title_style = System.Drawing.FontStyle.Strikeout;
                title_color = Color.Green;
            }
            Modelo_Card_Title.Font = new System.Drawing.Font("Roboto", 18F, title_style, System.Drawing.GraphicsUnit.Pixel);
            Modelo_Card_Title.Location = new System.Drawing.Point(14, 14);
            Modelo_Card_Title.Size = new System.Drawing.Size(27, 19);
            Modelo_Card_Title.TabIndex = 1;
            Modelo_Card_Title.Text = nota.Title;
            Modelo_Card_Title.ForeColor = title_color;

            Modelo_Card_Date.AutoSize = true;
            Modelo_Card_Date.Font = new System.Drawing.Font("Roboto", 14F, title_style, System.Drawing.GraphicsUnit.Pixel);
            Modelo_Card_Date.Location = new System.Drawing.Point(17, 90);
            Modelo_Card_Date.Size = new System.Drawing.Size(87, 19);
            Modelo_Card_Date.TabIndex = 2;
            Modelo_Card_Date.Text = nota.Date.ToString("dd/MM/yyyy");
            Modelo_Card_Date.ForeColor = title_color;

            Modelo_Card_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Modelo_Card_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Modelo_Card_Button.Depth = 0;
            Modelo_Card_Button.HighEmphasis = true;
            Modelo_Card_Button.Icon = null;
            Modelo_Card_Button.Location = new System.Drawing.Point(310, 73);
            Modelo_Card_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Modelo_Card_Button.MouseState = MaterialSkin.MouseState.HOVER;
            Modelo_Card_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            Modelo_Card_Button.Size = new System.Drawing.Size(64, 36);
            Modelo_Card_Button.TabIndex = 0;
            Modelo_Card_Button.Text = "Ver";
            Modelo_Card_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Modelo_Card_Button.UseAccentColor = false;
            Modelo_Card_Button.UseVisualStyleBackColor = true;

            Modelo_Card_Desc.AutoSize = true;
            Modelo_Card_Desc.Font = new System.Drawing.Font("Roboto", 14F, title_style, System.Drawing.GraphicsUnit.Pixel);
            Modelo_Card_Desc.Location = new System.Drawing.Point(20, 50);
            Modelo_Card_Desc.Size = new System.Drawing.Size(79, 19);
            Modelo_Card_Desc.TabIndex = 3;
            Modelo_Card_Desc.Text = nota.Description;
            Modelo_Card_Desc.ForeColor = title_color;

            materialCard1.Controls.Add(Modelo_Card_Desc);
            materialCard1.Controls.Add(Modelo_Card_Date);
            materialCard1.Controls.Add(Modelo_Card_Title);
            materialCard1.Controls.Add(Modelo_Card_Button);
            return materialCard1;
        }

        private void FNotas_Load(object sender, EventArgs e)
        {
            UpdateNotas();
        }
    }
}
