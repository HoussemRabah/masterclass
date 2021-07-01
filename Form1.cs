
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace MasterClassUI
{
    public partial class Form1 : Form
    {

        string[] fdv =null;
        string jsonPath = "config.json";
        string processPath = @"process.exe"; 
        /* process.exe is a built version of Python code "MatserClass"using PyInstaller
        it must be in same path of this program*/





        public void loadConfig(dynamic config, TextBox listEtdPath, TextBox listEtdSheet,
            TextBox classementPath, TextBox classementSheet, TextBox fdvStart, TextBox formuleText,
            DataGridView spTable)
        {
            Dictionary<string, string> path;
            Dictionary<string, string> formule;

            path = (Dictionary<string, string>)config.listEtudiants;
            listEtdPath.Text = path["filename"];
            listEtdSheet.Text = path["sheetname"];

            path = (Dictionary<string, string>)config.classement;
            classementPath.Text = path["filename"];
            classementSheet.Text = path["sheetname"];

            fdvStart.Text = config.choixStartIndex.ToString();


            formule = (Dictionary<string, string>)config.formule;
            String eq = formule["form"];
            for (int i = 1; i < formule.Count(); i++)
            {
                eq = eq.Replace("$" + i.ToString() + "$", formule[i.ToString()]);
            }
            formuleText.Text = eq;

            DataTable table = new DataTable();
            table.Columns.Add("specialites", typeof(string));
            table.Columns.Add("nombre des places", typeof(int));
            Dictionary<string, int> specialites = (Dictionary<string, int>)config.specialites;
            for (int i = 0; i < specialites.Count(); i++)
            {
                table.Rows.Add(specialites.Keys.ElementAt(i), specialites[specialites.Keys.ElementAt(i)]);
            }
            dataGridView1.DataSource = table;

        }

        public Dictionary<string, object> createConfig(Dictionary<string, string> listEtudiants, 
            Dictionary<string, string> classement , List<Dictionary<string, string>> ficheVoeux,int choixStartIndex,
            Dictionary<string, string>  formule , Dictionary<string, int>  specialites , 
            Dictionary<string, string>  output
            )
        {
            Dictionary<string, object> config = new Dictionary<string, object>();
            config.Add("listEtudiants", listEtudiants);
            config.Add("classement", classement);
            config.Add("ficheVoeux", ficheVoeux);
            config.Add("choixStartIndex", choixStartIndex);
            config.Add("formule", formule);
            config.Add("specialites", specialites);
            config.Add("output", output);

            return config;


        }

        public void saveConfig(string output, Dictionary<string, object> config )
        {
            string json = JsonConvert.SerializeObject(config);
            File.WriteAllText(output, json);
           
        }

        public string chooseOutput()
        {
            SaveFileDialog choofdlog = new SaveFileDialog();
            choofdlog.Filter = "fichier excel | *.xlsx*";
            choofdlog.OverwritePrompt=true;
            choofdlog.CreatePrompt=false;


            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                 return choofdlog.FileName;

            }
            return null;
        }

        public void chooseFile(TextBox output)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "fichier excel | *.xlsx*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                output.Text= choofdlog.FileName;
              
            }
        }


        public string[] chooseMultiFiles(TextBox output)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "des fichiers excel | *.xlsx*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            string[] files=null;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                files = choofdlog.FileNames;
            }
            output.Text = "";
            if (files == null) return null;
            for (int i=0;i<files.Length;i++)
            {
                output.Text= output.Text+( files[i]+" ;");
            }
            output.Text = output.Text.Substring(0, output.Text.Length-1);
            return files;
        }

        public Dictionary<string, string> parseFormule(string f)
        {
            int getCharType(char c)
            {


                List<char> op = new List<char>();
                op.Add('*');
                op.Add('+');
                op.Add('-');
                op.Add('/');
                op.Add(')');
                op.Add('(');
                op.Add('=');

                if (op.Contains(c)) return 0;
                try
                {
                    int.Parse(c + "");
                    return 1;
                }
                catch
                {
                    if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
                        return 2;
                    else
                        return 3;
                }
            }
            f = f + "=";
            string form = "";
            List<string> vars = new List<string>();
            for (int i = 0; i < f.Length; i++)
            {
                if (getCharType(f[i]) != 0 && getCharType(f[i])!=1)
                {
                    string temp = "";
                    while (getCharType(f[i]) != 0)
                    {
                        temp += f[i];
                        i++;
                    }
                    vars.Add(temp);
                    form += "$" + vars.Count() + "$" + f[i];
                }
                else
                {
                    form += f[i];
                }
            }

            form = form.Substring(0, form.Length - 1);
            Dictionary<string, string> formule = new Dictionary<string, string>();
            formule.Add("form", form);
            for (int i = 0; i < vars.Count(); i++)
                formule.Add((i + 1).ToString(), vars[i]);

            return formule;
        }


        void changeConfig(string c_output, string o_output)
        {

            Dictionary<string, string> listEtudiants = new Dictionary<string, string>();
            Dictionary<string, string> classement = new Dictionary<string, string>();
            List<Dictionary<string, string>> ficheVoeux = new List<Dictionary<string, string>>();
            int choixStartIndex = 0;
            Dictionary<string, string> formule = new Dictionary<string, string>();
            Dictionary<string, int> specialites = new Dictionary<string, int>();
            Dictionary<string, string> output = new Dictionary<string, string>();


            listEtudiants.Add("filename", textBox2.Text);
            listEtudiants.Add("sheetname", textBox1.Text);
            classement.Add("filename", textBox4.Text);
            classement.Add("sheetname", textBox3.Text);
            if (fdv != null)
            {
                for (int i = 0; i < fdv.Count(); i++)
                {
                    Dictionary<string, string> temp = new Dictionary<string, string>();
                    temp.Add("filename", fdv[i]);
                    temp.Add("sheetname", textBox5.Text);
                    ficheVoeux.Add(temp);
                }
            }else
            {
                Dictionary<string, string> temp = new Dictionary<string, string>();
                temp.Add("filename", "");
                temp.Add("sheetname","");
                ficheVoeux.Add(temp);
            }
            choixStartIndex = int.Parse(textBox7.Text);
            formule = parseFormule(textBox8.Text);
            DataTable table = (DataTable)dataGridView1.DataSource;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                specialites.Add((string)table.Rows[i][0], (int)table.Rows[i][1]);
            }
            output.Add("classement", c_output);
            output.Add("orientation", o_output);


            Dictionary<string, object> config = createConfig(listEtudiants, classement, ficheVoeux, choixStartIndex,
                formule, specialites, output);
            saveConfig(jsonPath, config);

        }

        public void changePage(Button btn , TabPage page)
        {
            pages.SelectedTab = page;
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.RoyalBlue;

        }



        public void runPython(string pythonFile, string arg)
        {
            System.Diagnostics.Process.Start(pythonFile,arg);
        }










        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            changePage(button1, page_class);
            if (!File.Exists(jsonPath))
            {
                
                File.WriteAllText(jsonPath, Properties.Resources.default_config);

            }

            string json = File.ReadAllText(jsonPath);

            try
            {
                var definition = new 
                { listEtudiants = new Dictionary<string, string>(),
                  classement = new Dictionary<string, string>(),
                  ficheVoeux = new List<Dictionary<string,string>>(),
                  choixStartIndex = 0,
                    formule = new Dictionary<string, string>(),
                    specialites = new Dictionary<string, int>(),
                    output= new Dictionary<string, string>()
                };

                var config = JsonConvert.DeserializeAnonymousType(json, definition);
                loadConfig(config, textBox2, textBox1, textBox4, textBox3, textBox7, textBox8, dataGridView1);
            }
            catch (Exception )
            {
                MessageBox.Show("error de config");
            }
           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chooseFile(textBox2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chooseFile(textBox4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] temp =chooseMultiFiles(textBox6);
            if (temp != null)
                fdv = temp;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> formule = parseFormule(textBox8.Text);
            label10.Text ="";
            int taille = formule.Count();
            for (int i=1;i<taille;i++)
                {
                    label10.Text += formule[i.ToString()]+" ";
                }
            }

        private void button6_Click(object sender, EventArgs e)
        {
            string temp = chooseOutput();
            if(temp!=null)
            {
                changeConfig(temp+".xlsx", "");
                if (File.Exists(processPath))
                    runPython(processPath, "0");
                else
                    MessageBox.Show("il manque process.exe");
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string p = @"\d$";   
            Match m = Regex.Match(textBox7.Text, p);

            if (!m.Success)
                textBox7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changePage(button1, page_class);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            changePage(button2, page_or);
        }

        private void pages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel1.Capture = false; //select control

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel2.Capture = false; //select control

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changePage(button3, page_config);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changePage(button4, page_apr);
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string temp = chooseOutput();
            if (temp != null)
            {
                
                changeConfig("",temp + ".xlsx");
                if (File.Exists(@"process.exe"))
                    runPython(@"process.exe", "1");
                else
                    MessageBox.Show("il manque process.exe");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            changeConfig("", "");
            MessageBox.Show("done");
        }
    }
    }





