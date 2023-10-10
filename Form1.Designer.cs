namespace _0001
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_start = new Button();
            btn_stop = new Button();
            listBoxForStart = new ListBox();
            listBoxForStop = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.Location = new Point(350, 123);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(75, 23);
            btn_start.TabIndex = 0;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_stop
            // 
            btn_stop.Location = new Point(350, 182);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(75, 23);
            btn_stop.TabIndex = 0;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // listBoxForStart
            // 
            listBoxForStart.FormattingEnabled = true;
            listBoxForStart.ItemHeight = 15;
            listBoxForStart.Items.AddRange(new object[] { "Блокнот", "Калькулятор", "WordPad" });
            listBoxForStart.Location = new Point(65, 81);
            listBoxForStart.Name = "listBoxForStart";
            listBoxForStart.Size = new Size(249, 199);
            listBoxForStart.TabIndex = 1;
            // 
            // listBoxForStop
            // 
            listBoxForStop.FormattingEnabled = true;
            listBoxForStop.ItemHeight = 15;
            listBoxForStop.Location = new Point(472, 81);
            listBoxForStop.Name = "listBoxForStop";
            listBoxForStop.Size = new Size(249, 199);
            listBoxForStop.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 46);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 2;
            label1.Text = "Програми для запуску";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 46);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 2;
            label2.Text = "Програми для зупинки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxForStop);
            Controls.Add(listBoxForStart);
            Controls.Add(btn_stop);
            Controls.Add(btn_start);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_start;
        private Button btn_stop;
        private ListBox listBoxForStart;
        private ListBox listBoxForStop;
        private Label label1;
        private Label label2;
    }
}