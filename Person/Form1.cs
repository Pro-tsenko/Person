namespace Person
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                return;
            }
            Person person;
            try 
            {
                person = new Person(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDateTime(textBox4.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (person.DateBirth > DateTime.Now || DateTime.Now.Year - person.DateBirth.Year > 135)
            {
                MessageBox.Show("³� �� ��������");
                return;
            }
            if (person.IsBirthday)
            {
                MessageBox.Show("� ���� ����������! =)");
            }
            var thread = new Thread(() =>
            {
                MessageBox.Show(person.ToString());
            });
            thread.Start();
            thread.Join();
        }
    }
}