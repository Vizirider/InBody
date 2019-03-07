namespace InBody
{
    partial class Ugyfeladatok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ugyfeladatok));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ugyfelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.torzsadatDataSet1 = new InBody.torzsadatDataSet1();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szuletesiidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eletkorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemzetisegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelenlegiklubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posztDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelTableAdapter = new InBody.torzsadatDataSet1TableAdapters.ugyfelTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torzsadatDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ugyfelBindingSource, "Nev", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(202, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 30);
            this.textBox1.TabIndex = 0;
            // 
            // ugyfelBindingSource
            // 
            this.ugyfelBindingSource.DataMember = "ugyfel";
            this.ugyfelBindingSource.DataSource = this.torzsadatDataSet1;
            // 
            // torzsadatDataSet1
            // 
            this.torzsadatDataSet1.DataSetName = "torzsadatDataSet1";
            this.torzsadatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ugyfelBindingSource, "Eletkor", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(202, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 30);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ugyfelBindingSource, "Nemzetiseg", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(202, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 30);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ugyfelBindingSource, "Sportag", true));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(202, 252);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 30);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ugyfelBindingSource, "Jelenlegi_klub", true));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(202, 310);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(159, 30);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ugyfelBindingSource, "Poszt", true));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(202, 367);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 30);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ugyfelBindingSource, "Neme", true));
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox8.Location = new System.Drawing.Point(202, 414);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(159, 30);
            this.textBox8.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Születési idő:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Életkor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nemzetiség:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(30, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sportág:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(30, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Jelenlegi klub:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(30, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Poszt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(30, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Neme:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Felvitel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Módosítás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 535);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 37);
            this.button3.TabIndex = 18;
            this.button3.Text = "Törlés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nevDataGridViewTextBoxColumn,
            this.szuletesiidoDataGridViewTextBoxColumn,
            this.eletkorDataGridViewTextBoxColumn,
            this.nemzetisegDataGridViewTextBoxColumn,
            this.sportagDataGridViewTextBoxColumn,
            this.jelenlegiklubDataGridViewTextBoxColumn,
            this.posztDataGridViewTextBoxColumn,
            this.nemeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ugyfelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(453, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 572);
            this.dataGridView1.TabIndex = 19;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // szuletesiidoDataGridViewTextBoxColumn
            // 
            this.szuletesiidoDataGridViewTextBoxColumn.DataPropertyName = "Szuletesi_ido";
            this.szuletesiidoDataGridViewTextBoxColumn.HeaderText = "Szuletesi_ido";
            this.szuletesiidoDataGridViewTextBoxColumn.Name = "szuletesiidoDataGridViewTextBoxColumn";
            // 
            // eletkorDataGridViewTextBoxColumn
            // 
            this.eletkorDataGridViewTextBoxColumn.DataPropertyName = "Eletkor";
            this.eletkorDataGridViewTextBoxColumn.HeaderText = "Eletkor";
            this.eletkorDataGridViewTextBoxColumn.Name = "eletkorDataGridViewTextBoxColumn";
            // 
            // nemzetisegDataGridViewTextBoxColumn
            // 
            this.nemzetisegDataGridViewTextBoxColumn.DataPropertyName = "Nemzetiseg";
            this.nemzetisegDataGridViewTextBoxColumn.HeaderText = "Nemzetiseg";
            this.nemzetisegDataGridViewTextBoxColumn.Name = "nemzetisegDataGridViewTextBoxColumn";
            // 
            // sportagDataGridViewTextBoxColumn
            // 
            this.sportagDataGridViewTextBoxColumn.DataPropertyName = "Sportag";
            this.sportagDataGridViewTextBoxColumn.HeaderText = "Sportag";
            this.sportagDataGridViewTextBoxColumn.Name = "sportagDataGridViewTextBoxColumn";
            // 
            // jelenlegiklubDataGridViewTextBoxColumn
            // 
            this.jelenlegiklubDataGridViewTextBoxColumn.DataPropertyName = "Jelenlegi_klub";
            this.jelenlegiklubDataGridViewTextBoxColumn.HeaderText = "Jelenlegi_klub";
            this.jelenlegiklubDataGridViewTextBoxColumn.Name = "jelenlegiklubDataGridViewTextBoxColumn";
            // 
            // posztDataGridViewTextBoxColumn
            // 
            this.posztDataGridViewTextBoxColumn.DataPropertyName = "Poszt";
            this.posztDataGridViewTextBoxColumn.HeaderText = "Poszt";
            this.posztDataGridViewTextBoxColumn.Name = "posztDataGridViewTextBoxColumn";
            // 
            // nemeDataGridViewTextBoxColumn
            // 
            this.nemeDataGridViewTextBoxColumn.DataPropertyName = "Neme";
            this.nemeDataGridViewTextBoxColumn.HeaderText = "Neme";
            this.nemeDataGridViewTextBoxColumn.Name = "nemeDataGridViewTextBoxColumn";
            // 
            // ugyfelTableAdapter
            // 
            this.ugyfelTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(320, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 37);
            this.button4.TabIndex = 20;
            this.button4.Text = "Diagram";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ugyfelBindingSource, "Szuletesi_ido", true));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 27);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(175, 469);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 37);
            this.button5.TabIndex = 22;
            this.button5.Text = "Keres";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(35, 469);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 37);
            this.button6.TabIndex = 23;
            this.button6.Text = "Új";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Ugyfeladatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 596);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1431, 643);
            this.MinimizeBox = false;
            this.Name = "Ugyfeladatok";
            this.Text = "Ugyfeladatok";
            this.Load += new System.EventHandler(this.Ugyfeladatok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torzsadatDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private torzsadatDataSet1 torzsadatDataSet1;
        private System.Windows.Forms.BindingSource ugyfelBindingSource;
        private torzsadatDataSet1TableAdapters.ugyfelTableAdapter ugyfelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szuletesiidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eletkorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenlegiklubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posztDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}