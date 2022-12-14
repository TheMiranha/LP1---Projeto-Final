using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.CompilerServices;
using Classes;

namespace LP1___Projeto_Final.Notas
{
    public partial class FNotaAdd : MaterialForm
    {
        Func<Nota, int> UpdateFunction;

 
        public FNotaAdd(Func<Nota, int> UpdateFunction)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.UpdateFunction = UpdateFunction;
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = TBTitle.Text;
            string description = MTDescription.Text;
            DateTime date = DatePickerDate.Value.Date;
            Nota nota = new Nota(title, description, date);
            this.UpdateFunction(nota);
            this.Close();
        }

        private void FNotaAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
