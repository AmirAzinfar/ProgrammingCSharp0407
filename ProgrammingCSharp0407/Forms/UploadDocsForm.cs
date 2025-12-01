

namespace ProgrammingCSharp0407.Forms
{
    public partial class UploadDocsForm : Form
    {
        public UploadDocsForm()
        {
            InitializeComponent();
        }

        private void MotivationButton_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\amirazinfar\source\repos\ProgrammingCSharp0407\ProgrammingCSharp0407\DOCs\Info.txt";

            //"Reading File using File.ReadAllText()

            if (File.Exists(file))
            {
                string str = File.ReadAllText(file);
                MessageBox.Show(str);
            }
            else
            {
                MessageBox.Show("فایل مورد نظر در این آدرس وجود ندارد \n !لطفا مطمئن شوید آدرس فایل صحیح وارد شده باشد");
            }
        }

        private void CVButton_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\amirazinfar\source\repos\ProgrammingCSharp0407\ProgrammingCSharp0407\DOCs\Info.txt";

            //"Reading File using File.ReadAllLines()

            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);

                foreach (string item in lines)
                    MessageBox.Show(item);
            }
            else
            {
                MessageBox.Show("فایل مورد نظر در این آدرس وجود ندارد \n !لطفا مطمئن شوید آدرس فایل صحیح وارد شده باشد");
            }
        }

        private void EducationButton_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\amirazinfar\source\repos\ProgrammingCSharp0407\ProgrammingCSharp0407\DOCs\Info.txt";

            //"Reading File using StreamReader

            if (File.Exists(file))
            {
                StreamReader Textfile = new StreamReader(file);

                string line;
                while ((line = Textfile.ReadLine()) != null)
                {
                    MessageBox.Show(line);
                }
                Textfile.Close();
            }
            else
            {
                MessageBox.Show("فایل مورد نظر در این آدرس وجود ندارد \n !لطفا مطمئن شوید آدرس فایل صحیح وارد شده باشد");
            }
        }

        private void WorkExperiencButton_Click(object sender, EventArgs e)
        {
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DOCs", "Info.txt");

            //"Reading File by dynamic Path:
            //Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"FoldersName","FileName");
            //and Reading File using File.ReadAllText();

            if (File.Exists(filepath))
            {
                string ShowAllText = File.ReadAllText(filepath);

                MessageBox.Show(ShowAllText);
            }
            else
            {
                MessageBox.Show("فایل مورد نظر در این آدرس وجود ندارد \n !لطفا مطمئن شوید آدرس فایل صحیح وارد شده باشد");
                //MessageBox.Show(filepath);
            }
        }

        private void WorkCertificateButton_Click(object sender, EventArgs e)
        {
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DOCs", "AddTextToFile.txt");

            if (File.Exists(filepath))
            {
                //contents write on file (write on file) using AppendAllText(path:filepath, contents:"someting");

                File.AppendAllText(path:filepath,contents:"Hier ist mein zweiets Codeline");
                //now, read new added Text
                string ShowAddedAllText = File.ReadAllText(filepath);

            MessageBox.Show(ShowAddedAllText);
             //if use File.WriteAllText-->overwrite all of text on file with my contents
            //File.WriteAllText(filepath,"Hier ist mein zweiets Codeline");
            }
            else
            {
                MessageBox.Show("فایل مورد نظر در این آدرس وجود ندارد \n !لطفا مطمئن شوید آدرس فایل صحیح وارد شده باشد");
                //MessageBox.Show(filepath);
            }
        }
    }
}
