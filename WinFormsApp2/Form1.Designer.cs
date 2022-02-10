
namespace WinFormsApp2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField_Request = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField_Time = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField_ProName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialCheckBox1.Location = new System.Drawing.Point(558, 91);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(107, 30);
            this.materialCheckBox1.TabIndex = 1;
            this.materialCheckBox1.Text = "开始检测";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(468, 291);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "告警截图路径:";
            // 
            // materialSingleLineTextField_Request
            // 
            this.materialSingleLineTextField_Request.Depth = 0;
            this.materialSingleLineTextField_Request.Hint = "";
            this.materialSingleLineTextField_Request.Location = new System.Drawing.Point(468, 313);
            this.materialSingleLineTextField_Request.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_Request.Name = "materialSingleLineTextField_Request";
            this.materialSingleLineTextField_Request.PasswordChar = '\0';
            this.materialSingleLineTextField_Request.SelectedText = "";
            this.materialSingleLineTextField_Request.SelectionLength = 0;
            this.materialSingleLineTextField_Request.SelectionStart = 0;
            this.materialSingleLineTextField_Request.Size = new System.Drawing.Size(263, 23);
            this.materialSingleLineTextField_Request.TabIndex = 3;
            this.materialSingleLineTextField_Request.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField_Time
            // 
            this.materialSingleLineTextField_Time.Depth = 0;
            this.materialSingleLineTextField_Time.Hint = "";
            this.materialSingleLineTextField_Time.Location = new System.Drawing.Point(468, 239);
            this.materialSingleLineTextField_Time.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_Time.Name = "materialSingleLineTextField_Time";
            this.materialSingleLineTextField_Time.PasswordChar = '\0';
            this.materialSingleLineTextField_Time.SelectedText = "";
            this.materialSingleLineTextField_Time.SelectionLength = 0;
            this.materialSingleLineTextField_Time.SelectionStart = 0;
            this.materialSingleLineTextField_Time.Size = new System.Drawing.Size(263, 23);
            this.materialSingleLineTextField_Time.TabIndex = 5;
            this.materialSingleLineTextField_Time.Text = "1000";
            this.materialSingleLineTextField_Time.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(468, 217);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "检测间隔(毫秒):";
            // 
            // materialSingleLineTextField_ProName
            // 
            this.materialSingleLineTextField_ProName.Depth = 0;
            this.materialSingleLineTextField_ProName.Hint = "";
            this.materialSingleLineTextField_ProName.Location = new System.Drawing.Point(468, 166);
            this.materialSingleLineTextField_ProName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_ProName.Name = "materialSingleLineTextField_ProName";
            this.materialSingleLineTextField_ProName.PasswordChar = '\0';
            this.materialSingleLineTextField_ProName.SelectedText = "";
            this.materialSingleLineTextField_ProName.SelectionLength = 0;
            this.materialSingleLineTextField_ProName.SelectionStart = 0;
            this.materialSingleLineTextField_ProName.Size = new System.Drawing.Size(263, 23);
            this.materialSingleLineTextField_ProName.TabIndex = 7;
            this.materialSingleLineTextField_ProName.Text = "notepad";
            this.materialSingleLineTextField_ProName.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(468, 144);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(135, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "切换进程(进程名):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 367);
            this.Controls.Add(this.materialSingleLineTextField_ProName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialSingleLineTextField_Time);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialSingleLineTextField_Request);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "目标检测";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_Request;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_Time;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_ProName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}

