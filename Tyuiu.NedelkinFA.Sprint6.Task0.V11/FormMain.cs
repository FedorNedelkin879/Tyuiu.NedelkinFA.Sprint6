using Tyuiu.NedelkinFA.Sprint6.Task0.V11.Lib;

namespace Tyuiu.NedelkinFA.Sprint6.Task0.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int x = Convert.ToInt32(textBoxVarX.Text);
                double result = ds.Calculate(x);
                textBoxResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Введите корректное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ИИПБ-24-1 Неделькин Фёдор Андреевич",
                            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
