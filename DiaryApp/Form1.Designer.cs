
namespace DiaryApp
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
            this.panelBorder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSu = new System.Windows.Forms.Button();
            this.buttonWe = new System.Windows.Forms.Button();
            this.buttonTu = new System.Windows.Forms.Button();
            this.buttonSa = new System.Windows.Forms.Button();
            this.buttonFr = new System.Windows.Forms.Button();
            this.buttonTh = new System.Windows.Forms.Button();
            this.buttonMo = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.labelHint1 = new System.Windows.Forms.Label();
            this.labelHint3 = new System.Windows.Forms.Label();
            this.labelHint2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(186)))));
            this.panelBorder.Controls.Add(this.label1);
            this.panelBorder.Controls.Add(this.pictureBox1);
            this.panelBorder.Controls.Add(this.buttonMinimize);
            this.panelBorder.Controls.Add(this.buttonClose);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(805, 25);
            this.panelBorder.TabIndex = 0;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiaryApp.Properties.Resources.Icon2;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(186)))));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::DiaryApp.Properties.Resources.Minimized;
            this.buttonMinimize.Location = new System.Drawing.Point(705, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(50, 25);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonMinimize_MouseClick);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(186)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(2)))), ((int)(((byte)(27)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::DiaryApp.Properties.Resources.Close;
            this.buttonClose.Location = new System.Drawing.Point(755, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 25);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseClick);
            // 
            // buttonSu
            // 
            this.buttonSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(122)))), ((int)(((byte)(201)))));
            this.buttonSu.FlatAppearance.BorderSize = 0;
            this.buttonSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSu.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSu.Location = new System.Drawing.Point(690, 25);
            this.buttonSu.Name = "buttonSu";
            this.buttonSu.Size = new System.Drawing.Size(115, 30);
            this.buttonSu.TabIndex = 3;
            this.buttonSu.Text = "Sunday";
            this.buttonSu.UseVisualStyleBackColor = false;
            // 
            // buttonWe
            // 
            this.buttonWe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(122)))), ((int)(((byte)(201)))));
            this.buttonWe.FlatAppearance.BorderSize = 0;
            this.buttonWe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonWe.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonWe.Location = new System.Drawing.Point(230, 25);
            this.buttonWe.Name = "buttonWe";
            this.buttonWe.Size = new System.Drawing.Size(115, 30);
            this.buttonWe.TabIndex = 2;
            this.buttonWe.Text = "Wednesday";
            this.buttonWe.UseVisualStyleBackColor = false;
            // 
            // buttonTu
            // 
            this.buttonTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(122)))), ((int)(((byte)(201)))));
            this.buttonTu.FlatAppearance.BorderSize = 0;
            this.buttonTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTu.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTu.Location = new System.Drawing.Point(115, 25);
            this.buttonTu.Name = "buttonTu";
            this.buttonTu.Size = new System.Drawing.Size(115, 30);
            this.buttonTu.TabIndex = 1;
            this.buttonTu.Text = "Tuesday";
            this.buttonTu.UseVisualStyleBackColor = false;
            // 
            // buttonSa
            // 
            this.buttonSa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(122)))), ((int)(((byte)(201)))));
            this.buttonSa.FlatAppearance.BorderSize = 0;
            this.buttonSa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSa.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSa.Location = new System.Drawing.Point(575, 25);
            this.buttonSa.Name = "buttonSa";
            this.buttonSa.Size = new System.Drawing.Size(115, 30);
            this.buttonSa.TabIndex = 6;
            this.buttonSa.Text = "Saturday";
            this.buttonSa.UseVisualStyleBackColor = false;
            // 
            // buttonFr
            // 
            this.buttonFr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(122)))), ((int)(((byte)(201)))));
            this.buttonFr.FlatAppearance.BorderSize = 0;
            this.buttonFr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFr.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFr.Location = new System.Drawing.Point(460, 25);
            this.buttonFr.Name = "buttonFr";
            this.buttonFr.Size = new System.Drawing.Size(115, 30);
            this.buttonFr.TabIndex = 5;
            this.buttonFr.Text = "Friday";
            this.buttonFr.UseVisualStyleBackColor = false;
            // 
            // buttonTh
            // 
            this.buttonTh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(122)))), ((int)(((byte)(201)))));
            this.buttonTh.FlatAppearance.BorderSize = 0;
            this.buttonTh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTh.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTh.Location = new System.Drawing.Point(345, 25);
            this.buttonTh.Name = "buttonTh";
            this.buttonTh.Size = new System.Drawing.Size(115, 30);
            this.buttonTh.TabIndex = 4;
            this.buttonTh.Text = "Thursday";
            this.buttonTh.UseVisualStyleBackColor = false;
            // 
            // buttonMo
            // 
            this.buttonMo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(122)))), ((int)(((byte)(201)))));
            this.buttonMo.FlatAppearance.BorderSize = 0;
            this.buttonMo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMo.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMo.Location = new System.Drawing.Point(0, 25);
            this.buttonMo.Name = "buttonMo";
            this.buttonMo.Size = new System.Drawing.Size(115, 30);
            this.buttonMo.TabIndex = 0;
            this.buttonMo.Text = "Monday";
            this.buttonMo.UseVisualStyleBackColor = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelChildForm.Location = new System.Drawing.Point(0, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(805, 358);
            this.panelChildForm.TabIndex = 7;
            // 
            // labelHint1
            // 
            this.labelHint1.AutoSize = true;
            this.labelHint1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.labelHint1.Location = new System.Drawing.Point(12, 411);
            this.labelHint1.Name = "labelHint1";
            this.labelHint1.Size = new System.Drawing.Size(548, 15);
            this.labelHint1.TabIndex = 70;
            this.labelHint1.Text = "*Select any of the days of the week by clicking on one of them on the top panel a" +
    "nd edit your schedule";
            // 
            // labelHint3
            // 
            this.labelHint3.AutoSize = true;
            this.labelHint3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.labelHint3.Location = new System.Drawing.Point(12, 441);
            this.labelHint3.Name = "labelHint3";
            this.labelHint3.Size = new System.Drawing.Size(232, 15);
            this.labelHint3.TabIndex = 69;
            this.labelHint3.Text = "*Use a double click on the line to expand it";
            // 
            // labelHint2
            // 
            this.labelHint2.AutoSize = true;
            this.labelHint2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.labelHint2.Location = new System.Drawing.Point(12, 426);
            this.labelHint2.Name = "labelHint2";
            this.labelHint2.Size = new System.Drawing.Size(243, 15);
            this.labelHint2.TabIndex = 72;
            this.labelHint2.Text = "*The time must be written in numeric format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 73;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(805, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHint2);
            this.Controls.Add(this.labelHint1);
            this.Controls.Add(this.labelHint3);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.buttonMo);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.buttonTh);
            this.Controls.Add(this.buttonFr);
            this.Controls.Add(this.buttonSa);
            this.Controls.Add(this.buttonSu);
            this.Controls.Add(this.buttonTu);
            this.Controls.Add(this.buttonWe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelBorder;
        private Button buttonClose;
        private Button buttonMinimize;
        private Button buttonSa;
        private Button buttonFr;
        private Button buttonTh;
        private Button buttonSu;
        private Button buttonWe;
        private Button buttonTu;
        private Button buttonMo;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelHint3;
        private Label labelHint1;
        private Label labelHint2;
        private Label label2;
    }
}