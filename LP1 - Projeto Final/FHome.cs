using MaterialSkin;
using MaterialSkin.Controls;

namespace LP1___Projeto_Final
{
    public partial class FHome : MaterialForm
    {
        public FHome()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            Notas.FNotas fm = new Notas.FNotas();
            fm.Show();
        }
    }
}