namespace HanoiTowerAssignment
{
    partial class MainForm
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
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.peg1 = new System.Windows.Forms.Panel();
            this.lbl_Disk1 = new System.Windows.Forms.Label();
            this.lbl_Disk2 = new System.Windows.Forms.Label();
            this.lbl_Disk3 = new System.Windows.Forms.Label();
            this.lbl_Disk4 = new System.Windows.Forms.Label();
            this.peg3 = new System.Windows.Forms.Panel();
            this.peg2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.Base = new System.Windows.Forms.Panel();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.timer = new System.Timers.Timer();
            this.txt_Moves = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Count
            // 
            this.txt_Count.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Count.Location = new System.Drawing.Point(316, 14);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.ReadOnly = true;
            this.txt_Count.Size = new System.Drawing.Size(41, 29);
            this.txt_Count.TabIndex = 5;
            this.txt_Count.DragDrop += new System.Windows.Forms.DragEventHandler(this.peg_DragDrop);
            this.txt_Count.DragEnter += new System.Windows.Forms.DragEventHandler(this.peg_DragEnter);
            this.txt_Count.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // peg1
            // 
            this.peg1.AllowDrop = true;
            this.peg1.BackColor = System.Drawing.Color.Orange;
            this.peg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.peg1.Location = new System.Drawing.Point(215, 140);
            this.peg1.Name = "peg1";
            this.peg1.Size = new System.Drawing.Size(20, 210);
            this.peg1.TabIndex = 6;
            this.peg1.DragDrop += new System.Windows.Forms.DragEventHandler(this.peg_DragDrop);
            this.peg1.DragEnter += new System.Windows.Forms.DragEventHandler(this.peg_DragEnter);
            // 
            // lbl_Disk1
            // 
            this.lbl_Disk1.BackColor = System.Drawing.Color.OliveDrab;
            this.lbl_Disk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk1.Location = new System.Drawing.Point(190, 190);
            this.lbl_Disk1.Name = "lbl_Disk1";
            this.lbl_Disk1.Size = new System.Drawing.Size(66, 40);
            this.lbl_Disk1.TabIndex = 9;
            this.lbl_Disk1.Text = "1";
            this.lbl_Disk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // lbl_Disk2
            // 
            this.lbl_Disk2.BackColor = System.Drawing.Color.OliveDrab;
            this.lbl_Disk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk2.Location = new System.Drawing.Point(177, 230);
            this.lbl_Disk2.Name = "lbl_Disk2";
            this.lbl_Disk2.Size = new System.Drawing.Size(94, 40);
            this.lbl_Disk2.TabIndex = 10;
            this.lbl_Disk2.Text = "2";
            this.lbl_Disk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // lbl_Disk3
            // 
            this.lbl_Disk3.BackColor = System.Drawing.Color.OliveDrab;
            this.lbl_Disk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk3.Location = new System.Drawing.Point(158, 270);
            this.lbl_Disk3.Name = "lbl_Disk3";
            this.lbl_Disk3.Size = new System.Drawing.Size(129, 40);
            this.lbl_Disk3.TabIndex = 11;
            this.lbl_Disk3.Text = "3";
            this.lbl_Disk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // lbl_Disk4
            // 
            this.lbl_Disk4.BackColor = System.Drawing.Color.OliveDrab;
            this.lbl_Disk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk4.Location = new System.Drawing.Point(140, 310);
            this.lbl_Disk4.Name = "lbl_Disk4";
            this.lbl_Disk4.Size = new System.Drawing.Size(166, 40);
            this.lbl_Disk4.TabIndex = 12;
            this.lbl_Disk4.Text = "4";
            this.lbl_Disk4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // peg3
            // 
            this.peg3.AllowDrop = true;
            this.peg3.BackColor = System.Drawing.Color.Orange;
            this.peg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.peg3.Location = new System.Drawing.Point(655, 140);
            this.peg3.Name = "peg3";
            this.peg3.Size = new System.Drawing.Size(20, 210);
            this.peg3.TabIndex = 8;
            this.peg3.DragDrop += new System.Windows.Forms.DragEventHandler(this.peg_DragDrop);
            this.peg3.DragEnter += new System.Windows.Forms.DragEventHandler(this.peg_DragEnter);
            // 
            // peg2
            // 
            this.peg2.AllowDrop = true;
            this.peg2.BackColor = System.Drawing.Color.Orange;
            this.peg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.peg2.Location = new System.Drawing.Point(435, 140);
            this.peg2.Name = "peg2";
            this.peg2.Size = new System.Drawing.Size(20, 210);
            this.peg2.TabIndex = 7;
            this.peg2.DragDrop += new System.Windows.Forms.DragEventHandler(this.peg_DragDrop);
            this.peg2.DragEnter += new System.Windows.Forms.DragEventHandler(this.peg_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Moves:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(795, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Movements:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 31);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Base
            // 
            this.Base.BackColor = System.Drawing.Color.SaddleBrown;
            this.Base.Location = new System.Drawing.Point(99, 350);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(683, 48);
            this.Base.TabIndex = 18;
            // 
            // btnAnimate
            // 
            this.btnAnimate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimate.Location = new System.Drawing.Point(12, 60);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(86, 33);
            this.btnAnimate.TabIndex = 19;
            this.btnAnimate.Text = "Animation";
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 33);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save Game";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2000D;
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // txt_Moves
            // 
            this.txt_Moves.Location = new System.Drawing.Point(799, 60);
            this.txt_Moves.Multiline = true;
            this.txt_Moves.Name = "txt_Moves";
            this.txt_Moves.ReadOnly = true;
            this.txt_Moves.Size = new System.Drawing.Size(136, 325);
            this.txt_Moves.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 445);
            this.Controls.Add(this.txt_Moves);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Disk4);
            this.Controls.Add(this.lbl_Disk3);
            this.Controls.Add(this.lbl_Disk2);
            this.Controls.Add(this.lbl_Disk1);
            this.Controls.Add(this.peg2);
            this.Controls.Add(this.peg3);
            this.Controls.Add(this.peg1);
            this.Controls.Add(this.txt_Count);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Panel peg1;
        private System.Windows.Forms.Label lbl_Disk1;
        private System.Windows.Forms.Label lbl_Disk2;
        private System.Windows.Forms.Label lbl_Disk3;
        private System.Windows.Forms.Label lbl_Disk4;
        private System.Windows.Forms.Panel peg3;
        private System.Windows.Forms.Panel peg2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel Base;
        private System.Windows.Forms.Button btnAnimate;
        private System.Windows.Forms.Button btnSave;
        private System.Timers.Timer timer;
        private System.Windows.Forms.TextBox txt_Moves;
    }
}

