using Classes;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LP1___Projeto_Final.Notas
{
    public partial class FNotaAtualizar : MaterialForm
    {
        Nota nota { get; set; }
        Func<Nota, Nota, int> UpdateFunc;
        Func<Nota, int> DeleteFunc;
        public FNotaAtualizar(Nota x, Func<Nota, Nota, int> updateFunc, Func<Nota, int> DeleteFunc)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.nota = x;
            UpdateFunc = updateFunc;
            this.DeleteFunc = DeleteFunc;
        }

        private void FNotaAtualizar_Load(object sender, EventArgs e)
        {
            this.TBTitle.Text = this.nota.Title;
            this.MTDescription.Text = this.nota.Description;
            this.DatePickerDate.Value = this.nota.Date;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = TBTitle.Text;
            string description = MTDescription.Text;
            DateTime date = DatePickerDate.Value;
            Nota temp = new Nota(title, description, date);
            this.UpdateFunc(nota, temp);
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.DeleteFunc(nota);
            this.Close();
        }
    }
}
