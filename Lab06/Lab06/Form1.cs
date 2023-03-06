namespace Lab06
{
    public partial class Form1 : Form
    {
        StudentController controller = new StudentController();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_name = this.tbName.Text;
            string input_student_id = this.tbID.Text;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void savefileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.saveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.openFile();
            
        }
    }
}