
namespace milimeter
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.panelVolt = new System.Windows.Forms.Panel();
            this.lbmV = new System.Windows.Forms.Label();
            this.lbVolt = new System.Windows.Forms.Label();
            this.panelCurr = new System.Windows.Forms.Panel();
            this.lbmA = new System.Windows.Forms.Label();
            this.lbCurr = new System.Windows.Forms.Label();
            this.panelPower = new System.Windows.Forms.Panel();
            this.lbmW = new System.Windows.Forms.Label();
            this.lbPower = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewDataRx = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxAutoScroll = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLbCOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLbFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelVolt.SuspendLayout();
            this.panelCurr.SuspendLayout();
            this.panelPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataRx)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(12, 17);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(75, 23);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(93, 18);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(99, 21);
            this.comboBoxCOM.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBoxCOM, "Seleção de Porta Serial");
            // 
            // panelVolt
            // 
            this.panelVolt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelVolt.Controls.Add(this.lbmV);
            this.panelVolt.Controls.Add(this.lbVolt);
            this.panelVolt.Location = new System.Drawing.Point(12, 56);
            this.panelVolt.Name = "panelVolt";
            this.panelVolt.Size = new System.Drawing.Size(111, 71);
            this.panelVolt.TabIndex = 5;
            this.panelVolt.Tag = "";
            // 
            // lbmV
            // 
            this.lbmV.AutoSize = true;
            this.lbmV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmV.ForeColor = System.Drawing.Color.Orange;
            this.lbmV.Location = new System.Drawing.Point(78, 3);
            this.lbmV.Name = "lbmV";
            this.lbmV.Size = new System.Drawing.Size(30, 17);
            this.lbmV.TabIndex = 1;
            this.lbmV.Text = "mV";
            // 
            // lbVolt
            // 
            this.lbVolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolt.ForeColor = System.Drawing.Color.Orange;
            this.lbVolt.Location = new System.Drawing.Point(0, 0);
            this.lbVolt.Name = "lbVolt";
            this.lbVolt.Size = new System.Drawing.Size(111, 71);
            this.lbVolt.TabIndex = 0;
            this.lbVolt.Text = "0.000";
            this.lbVolt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbVolt, "Tensão");
            // 
            // panelCurr
            // 
            this.panelCurr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCurr.Controls.Add(this.lbmA);
            this.panelCurr.Controls.Add(this.lbCurr);
            this.panelCurr.Location = new System.Drawing.Point(129, 56);
            this.panelCurr.Name = "panelCurr";
            this.panelCurr.Size = new System.Drawing.Size(111, 71);
            this.panelCurr.TabIndex = 6;
            // 
            // lbmA
            // 
            this.lbmA.AutoSize = true;
            this.lbmA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmA.ForeColor = System.Drawing.Color.LightCoral;
            this.lbmA.Location = new System.Drawing.Point(78, 3);
            this.lbmA.Name = "lbmA";
            this.lbmA.Size = new System.Drawing.Size(30, 17);
            this.lbmA.TabIndex = 1;
            this.lbmA.Text = "mA";
            // 
            // lbCurr
            // 
            this.lbCurr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurr.ForeColor = System.Drawing.Color.LightCoral;
            this.lbCurr.Location = new System.Drawing.Point(0, 0);
            this.lbCurr.Name = "lbCurr";
            this.lbCurr.Size = new System.Drawing.Size(111, 71);
            this.lbCurr.TabIndex = 0;
            this.lbCurr.Text = "0.000";
            this.lbCurr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbCurr, "Corrente");
            // 
            // panelPower
            // 
            this.panelPower.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelPower.Controls.Add(this.lbmW);
            this.panelPower.Controls.Add(this.lbPower);
            this.panelPower.Location = new System.Drawing.Point(246, 56);
            this.panelPower.Name = "panelPower";
            this.panelPower.Size = new System.Drawing.Size(111, 71);
            this.panelPower.TabIndex = 7;
            // 
            // lbmW
            // 
            this.lbmW.AutoSize = true;
            this.lbmW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmW.ForeColor = System.Drawing.Color.Turquoise;
            this.lbmW.Location = new System.Drawing.Point(74, 3);
            this.lbmW.Name = "lbmW";
            this.lbmW.Size = new System.Drawing.Size(34, 17);
            this.lbmW.TabIndex = 1;
            this.lbmW.Text = "mW";
            // 
            // lbPower
            // 
            this.lbPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPower.ForeColor = System.Drawing.Color.Turquoise;
            this.lbPower.Location = new System.Drawing.Point(0, 0);
            this.lbPower.Name = "lbPower";
            this.lbPower.Size = new System.Drawing.Size(111, 71);
            this.lbPower.TabIndex = 0;
            this.lbPower.Text = "0.000";
            this.lbPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbPower, "Potência");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // dataGridViewDataRx
            // 
            this.dataGridViewDataRx.AllowUserToAddRows = false;
            this.dataGridViewDataRx.AllowUserToDeleteRows = false;
            this.dataGridViewDataRx.AllowUserToResizeRows = false;
            this.dataGridViewDataRx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDataRx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDataRx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataRx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.timestamp,
            this.voltage,
            this.current,
            this.power});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDataRx.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDataRx.EnableHeadersVisualStyles = false;
            this.dataGridViewDataRx.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewDataRx.Name = "dataGridViewDataRx";
            this.dataGridViewDataRx.ReadOnly = true;
            this.dataGridViewDataRx.RowHeadersVisible = false;
            this.dataGridViewDataRx.RowTemplate.Height = 16;
            this.dataGridViewDataRx.RowTemplate.ReadOnly = true;
            this.dataGridViewDataRx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDataRx.Size = new System.Drawing.Size(345, 180);
            this.dataGridViewDataRx.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dataGridViewDataRx, "Dados salvos");
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 50;
            // 
            // timestamp
            // 
            this.timestamp.HeaderText = "TimeStamp";
            this.timestamp.Name = "timestamp";
            this.timestamp.ReadOnly = true;
            this.timestamp.Width = 65;
            // 
            // voltage
            // 
            this.voltage.HeaderText = "Tensão_mV";
            this.voltage.Name = "voltage";
            this.voltage.ReadOnly = true;
            this.voltage.Width = 70;
            // 
            // current
            // 
            this.current.HeaderText = "Corrente_mA";
            this.current.Name = "current";
            this.current.ReadOnly = true;
            this.current.Width = 70;
            // 
            // power
            // 
            this.power.HeaderText = "Potência_mW";
            this.power.Name = "power";
            this.power.ReadOnly = true;
            this.power.Width = 70;
            // 
            // checkBoxAutoScroll
            // 
            this.checkBoxAutoScroll.AutoSize = true;
            this.checkBoxAutoScroll.Checked = true;
            this.checkBoxAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoScroll.Location = new System.Drawing.Point(12, 319);
            this.checkBoxAutoScroll.Name = "checkBoxAutoScroll";
            this.checkBoxAutoScroll.Size = new System.Drawing.Size(96, 17);
            this.checkBoxAutoScroll.TabIndex = 9;
            this.checkBoxAutoScroll.Text = "Auto Rolagem ";
            this.checkBoxAutoScroll.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbVersion,
            this.toolStripStatusLbCOM,
            this.toolStripStatusLbFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(369, 24);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbVersion
            // 
            this.toolStripStatusLbVersion.AutoSize = false;
            this.toolStripStatusLbVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLbVersion.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLbVersion.Name = "toolStripStatusLbVersion";
            this.toolStripStatusLbVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLbVersion.Size = new System.Drawing.Size(82, 19);
            this.toolStripStatusLbVersion.Text = "milimeter v1.0";
            // 
            // toolStripStatusLbCOM
            // 
            this.toolStripStatusLbCOM.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLbCOM.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLbCOM.Name = "toolStripStatusLbCOM";
            this.toolStripStatusLbCOM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLbCOM.Size = new System.Drawing.Size(45, 19);
            this.toolStripStatusLbCOM.Text = "COM  ";
            // 
            // toolStripStatusLbFileName
            // 
            this.toolStripStatusLbFileName.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLbFileName.Name = "toolStripStatusLbFileName";
            this.toolStripStatusLbFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLbFileName.Size = new System.Drawing.Size(49, 19);
            this.toolStripStatusLbFileName.Text = "Arquivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBoxAutoScroll);
            this.Controls.Add(this.dataGridViewDataRx);
            this.Controls.Add(this.panelPower);
            this.Controls.Add(this.panelCurr);
            this.Controls.Add(this.panelVolt);
            this.Controls.Add(this.comboBoxCOM);
            this.Controls.Add(this.btConectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "milimeter monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelVolt.ResumeLayout(false);
            this.panelVolt.PerformLayout();
            this.panelCurr.ResumeLayout(false);
            this.panelCurr.PerformLayout();
            this.panelPower.ResumeLayout(false);
            this.panelPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataRx)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Panel panelVolt;
        private System.Windows.Forms.Label lbVolt;
        private System.Windows.Forms.Panel panelCurr;
        private System.Windows.Forms.Label lbCurr;
        private System.Windows.Forms.Panel panelPower;
        private System.Windows.Forms.Label lbPower;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridViewDataRx;
        private System.Windows.Forms.CheckBox checkBoxAutoScroll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbFileName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbCOM;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbVersion;
        private System.Windows.Forms.Label lbmV;
        private System.Windows.Forms.Label lbmA;
        private System.Windows.Forms.Label lbmW;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn current;
        private System.Windows.Forms.DataGridViewTextBoxColumn power;
    }
}

