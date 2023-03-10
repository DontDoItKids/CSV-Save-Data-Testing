namespace CSV_Save_Data_Testing
{
    public partial class Form1 : Form
    {
        
        const int ARRAYSIZE = 5;
        int[] SaveDataArr = new int[ARRAYSIZE];
        const string SAVEFILENAME = "SaveData.txt";


        void SaveFile(string fileName, Array Arr)
        {
            StreamWriter sw = new StreamWriter(fileName);
            foreach (var item in Arr)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
        }

        void LoadFile(string fileName, Array Arr)
        {
            StreamReader sw = new StreamReader(fileName);
            string strLine;
            while ((strLine = sw.ReadLine()) != null)
            {
                foreach (int tmpInt in Arr)
                {
                    lstOutput.Items.Add(tmpInt);
                }
            }
            sw.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile(SAVEFILENAME, SaveDataArr);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFile(SAVEFILENAME, SaveDataArr);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lstOutput.Items.Count == 5)
            {
                MessageBox.Show("Limit of 5 Items Reached");
            }
            else
            {
                lstOutput.Items.Add(txtAdd.Text);
            }

        }

    }

}