using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;     // necessário para ter acesso as portas
using System.IO;


namespace milimeter
{

    public partial class Form1 : Form
    {
        string RxString;
        string filename;
        UInt64 countItem = 0;
        UInt16 autoSave = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            dataGridViewDataRx.Columns[0].DefaultCellStyle.BackColor = Color.WhiteSmoke;

        }

        private void updateListCOMs()
        {
            
            if (SerialPort.GetPortNames().Length > 0)
            {
                if (comboBoxCOM.Items.Count != SerialPort.GetPortNames().Length)
                {
                    comboBoxCOM.Items.Clear();
                    //adiciona todas as COM diponíveis na lista
                    foreach (string s in SerialPort.GetPortNames())
                    {
                        comboBoxCOM.Items.Add(s);
                    }

                    comboBoxCOM.SelectedIndex = 0;
                }
                else
                {
                    var i = 0;
                    foreach (string s in SerialPort.GetPortNames())
                    {
                        if (comboBoxCOM.Items[i++].Equals(s) == false)
                        {
                            comboBoxCOM.Items.Clear();
                            comboBoxCOM.Text = "";
                            comboBoxCOM.SelectedIndex = -1;
                            return;
                        }
                    }
                }
            }
            else 
            {
                if (comboBoxCOM.Items.Count > 0) //limpa comboBox
                {
                    comboBoxCOM.Items.Clear();
                    comboBoxCOM.Text = "";
                    comboBoxCOM.SelectedIndex = -1;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                updateListCOMs();
                if (autoSave > 0)   // se dispositivo foi removido, salva dados
                {
                    saveCSV();
                    autoSave = 0;
                }
                btConectar.Text = "Conectar";
                comboBoxCOM.Enabled = true;
                toolStripStatusLbCOM.Text = "COM  ";
                lbVolt.Text = "0.000";
                lbCurr.Text = "0.000";
                lbPower.Text = "0.000";
                
            }
            else
            {
                btConectar.Text = "Desconectar";
                comboBoxCOM.Enabled = false;
                toolStripStatusLbFileName.Text = "Arquivo: " + filename;
                toolStripStatusLbCOM.Text = serialPort1.PortName;
                autoSave++;
                if (autoSave >= 10*60) // salva arquivo a cada 10 minutos conectado
                {
                    autoSave = 0;
                    saveCSV();
                    
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                   
                    countItem = 0;
                    dataGridViewDataRx.Rows.Clear();
                    dataGridViewDataRx.Refresh();

                    serialPort1.PortName = comboBoxCOM.Items[comboBoxCOM.SelectedIndex].ToString();
                    serialPort1.Open();
                    DateTime date = DateTime.Now;
                    filename = "log_" + date.ToString("dd-MM-yy_HH-mm-ss") + ".csv";
                    

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btConectar.Text = "Desconectar";
                    comboBoxCOM.Enabled = false;
                }
            }
            else
            {

                try
                {
                    saveCSV();
                    autoSave = 0;    // reinicia autosave quando desconectar 
                    comboBoxCOM.Enabled = true;
                    serialPort1.Close();
                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadTo("\n");              //le o dado disponível na serial
            try
            {
                this.Invoke(new EventHandler(dataReceived));   //chama outra thread para escrever o dado no text box
            }
            catch
            { return; }

        }

        private void dataReceived(object sender, EventArgs e)
        {
            if (RxString != "PING")
            {
                string[] data = RxString.Split(';');
                if (data.Length == 3)
                {
                    lbVolt.Text = data[0];
                    lbCurr.Text = data[1];
                    lbPower.Text = data[2];
                    var index = dataGridViewDataRx.Rows.Add(1);
                    dataGridViewDataRx.Rows[index].Cells[0].Value = ++countItem;
                    dataGridViewDataRx.Rows[index].Cells[1].Value = DateTimeOffset.Now.ToUnixTimeSeconds();
                    dataGridViewDataRx.Rows[index].Cells[2].Value = data[0].Replace(".", ",");
                    dataGridViewDataRx.Rows[index].Cells[3].Value = data[1].Replace(".", ",");
                    dataGridViewDataRx.Rows[index].Cells[4].Value = data[2].Replace(".", ",");
                    if (checkBoxAutoScroll.Checked == true)
                        dataGridViewDataRx.FirstDisplayedScrollingRowIndex = dataGridViewDataRx.RowCount - 1;
                }
            }

            if (RxString == "PING")
            {
                serialPort1.Write("PONG");
            }

        }

        private void saveCSV()
        {
            if (dataGridViewDataRx.Rows.Count == 0)
                    return;
            
            var csv = new StringBuilder();
            string curDir = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
            string new_dir = curDir + "\\log";
            System.IO.Directory.CreateDirectory(new_dir);

            try
            {
                int columnCount = dataGridViewDataRx.Columns.Count;
                string columnNames = "";
                string[] outputCsv = new string[dataGridViewDataRx.Rows.Count + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += dataGridViewDataRx.Columns[i].HeaderText.ToString() + ";";
                }
                outputCsv[0] += columnNames;

                for (int i = 1; (i - 1) < dataGridViewDataRx.Rows.Count; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        outputCsv[i] += dataGridViewDataRx.Rows[i - 1].Cells[j].Value.ToString() + ";";
                    }
                }

                File.WriteAllLines((new_dir+"\\"+filename).ToString(), outputCsv, Encoding.UTF8);
                //MessageBox.Show("Dados salvos com sucesso !!!", "Info");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error :" + ex.Message + " Os dados serão salvos com outro nome!");
                DateTime date = DateTime.Now;
                filename = "log_" + date.ToString("dd-MM-yy_HH-mm-ss") + ".csv";
                saveCSV();
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
            {
                e.Cancel = true;            // cancela fechamento da aplicação
                saveCSV();                  // salva dados
                MessageBox.Show("Desconete a porta serial antes de finalizar.", "Info");
                
            }
                
        }
    }
}
