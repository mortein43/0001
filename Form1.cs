using System.Diagnostics;
using System.Linq.Expressions;

namespace _0001
{
    public partial class Form1 : Form
    {
        private Process programProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {

            switch (listBoxForStart.Text)
            {
                case "Блокнот":
                    string programPathForNotepad = @"c:\Windows\System32\notepad.exe";
                    startProcess(programPathForNotepad, "Блокнот");
                    break;
                case "Калькулятор":
                    string programPathForCalc = @"c:\Windows\System32\calc.exe";
                    startProcess(programPathForCalc, "Калькулятор");
                    break;
                case "WordPad":
                    string programPathForWordPad = @"c:\Program Files\Windows NT\Accessories\wordpad.exe";
                    startProcess(programPathForWordPad, "WordPad");
                    break;
                default:
                    break;
            }

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            switch (listBoxForStop.Text)
            {
                case "Блокнот":
                    string processNameForNotepad = "notepad";
                    stopProcess(processNameForNotepad, "Блокнот");
                    break;
                case "Калькулятор":
                    string processNameForCalc = "CalculatorApp";
                    stopProcess(processNameForCalc, "Калькулятор");
                    break;
                case "WordPad":
                    string processNameForWordPad = "wordpad";
                    stopProcess(processNameForWordPad, "WordPad");
                    break;
                default: break;
            }

        }
        void startProcess(string programPath, string name)
        {
            programProcess = new Process();
            programProcess.StartInfo.FileName = programPath;
            try
            {
                programProcess.Start();
                listBoxForStop.Items.Add(name);
                listBoxForStart.Items.Remove(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося відкрити програму: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void stopProcess(string processName, string name)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            foreach (Process process in processes)
            {
                process.Kill();
            }
            listBoxForStart.Items.Add(name);
            listBoxForStop.Items.Remove(name);
        }

    }
}