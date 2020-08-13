namespace SkylineMap
{
    partial class FrmMain
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
            this.panel_Top = new System.Windows.Forms.Panel();
            this.button_ReadDynamicXY = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_dynamicObject = new System.Windows.Forms.Button();
            this.checkBox_Rain = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_OpenEx = new System.Windows.Forms.Button();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Map3D = new System.Windows.Forms.Panel();
            this.panel_Map3DEx = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.button_ReadDynamicXY);
            this.panel_Top.Controls.Add(this.dataGridView1);
            this.panel_Top.Controls.Add(this.button_dynamicObject);
            this.panel_Top.Controls.Add(this.checkBox_Rain);
            this.panel_Top.Controls.Add(this.button5);
            this.panel_Top.Controls.Add(this.button4);
            this.panel_Top.Controls.Add(this.button2);
            this.panel_Top.Controls.Add(this.richTextBox1);
            this.panel_Top.Controls.Add(this.button3);
            this.panel_Top.Controls.Add(this.button1);
            this.panel_Top.Controls.Add(this.button_OpenEx);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1192, 80);
            this.panel_Top.TabIndex = 0;
            // 
            // button_ReadDynamicXY
            // 
            this.button_ReadDynamicXY.Location = new System.Drawing.Point(388, 43);
            this.button_ReadDynamicXY.Name = "button_ReadDynamicXY";
            this.button_ReadDynamicXY.Size = new System.Drawing.Size(129, 23);
            this.button_ReadDynamicXY.TabIndex = 11;
            this.button_ReadDynamicXY.Text = "读取动态对象坐标";
            this.button_ReadDynamicXY.UseVisualStyleBackColor = true;
            this.button_ReadDynamicXY.Click += new System.EventHandler(this.button_ReadDynamicXY_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(877, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(303, 64);
            this.dataGridView1.TabIndex = 10;
            // 
            // button_dynamicObject
            // 
            this.button_dynamicObject.Location = new System.Drawing.Point(273, 43);
            this.button_dynamicObject.Name = "button_dynamicObject";
            this.button_dynamicObject.Size = new System.Drawing.Size(109, 23);
            this.button_dynamicObject.TabIndex = 9;
            this.button_dynamicObject.Text = "动态生成对象";
            this.button_dynamicObject.UseVisualStyleBackColor = true;
            this.button_dynamicObject.Click += new System.EventHandler(this.button_dynamicObject_Click);
            // 
            // checkBox_Rain
            // 
            this.checkBox_Rain.AutoSize = true;
            this.checkBox_Rain.Location = new System.Drawing.Point(182, 43);
            this.checkBox_Rain.Name = "checkBox_Rain";
            this.checkBox_Rain.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Rain.TabIndex = 8;
            this.checkBox_Rain.Text = "降雨";
            this.checkBox_Rain.UseVisualStyleBackColor = true;
            this.checkBox_Rain.CheckedChanged += new System.EventHandler(this.checkBox_Rain_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(429, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "遍历组对象";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "保存工程";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "打开扩展球工程";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(567, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(256, 64);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "指北";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "打开工程";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_OpenEx
            // 
            this.button_OpenEx.Location = new System.Drawing.Point(18, 10);
            this.button_OpenEx.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenEx.Name = "button_OpenEx";
            this.button_OpenEx.Size = new System.Drawing.Size(63, 23);
            this.button_OpenEx.TabIndex = 0;
            this.button_OpenEx.Text = "显示两球";
            this.button_OpenEx.UseVisualStyleBackColor = true;
            this.button_OpenEx.Click += new System.EventHandler(this.button_OpenEx_Click);
            // 
            // panel_Left
            // 
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 80);
            this.panel_Left.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(206, 534);
            this.panel_Left.TabIndex = 1;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel_Map3D);
            this.panel_Main.Controls.Add(this.panel_Map3DEx);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(206, 80);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(986, 534);
            this.panel_Main.TabIndex = 2;
            this.panel_Main.Resize += new System.EventHandler(this.panel_Main_Resize);
            // 
            // panel_Map3D
            // 
            this.panel_Map3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Map3D.Location = new System.Drawing.Point(0, 0);
            this.panel_Map3D.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Map3D.Name = "panel_Map3D";
            this.panel_Map3D.Size = new System.Drawing.Size(553, 534);
            this.panel_Map3D.TabIndex = 2;
            // 
            // panel_Map3DEx
            // 
            this.panel_Map3DEx.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Map3DEx.Location = new System.Drawing.Point(553, 0);
            this.panel_Map3DEx.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Map3DEx.Name = "panel_Map3DEx";
            this.panel_Map3DEx.Size = new System.Drawing.Size(433, 534);
            this.panel_Map3DEx.TabIndex = 4;
            this.panel_Map3DEx.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 614);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Top);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button button_OpenEx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_Map3D;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel_Map3DEx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox_Rain;
        private System.Windows.Forms.Button button_dynamicObject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ReadDynamicXY;
    }
}