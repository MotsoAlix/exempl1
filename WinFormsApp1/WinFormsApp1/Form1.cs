namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( txtUser.Text == "admi" &&  txtPasswd.Text == "admi")
            {
                userAccount account = new userAccount();
                account.Show();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}