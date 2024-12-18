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
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA.Text), Convert.ToInt32(textBoxVarB.Text), Convert.ToInt32(textBoxVarC.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 ||  e.KeyChar >= 58) && (e.KeyChar != ','), && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-24-1 Неделькин Фёдор Андреевич", "Сообщение", MessageBoxButtonsEx.OK, MessageBoxIcon.Error);
        }
    }
}
