
namespace WinFormsApp1
{
    partial class Intel8086
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intel8086));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnSymulation = new System.Windows.Forms.Button();
            this.MOV = new System.Windows.Forms.CheckBox();
            this.XCHG = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            resources.ApplyResources(this.btnRandom, "btnRandom");
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // btnSymulation
            // 
            resources.ApplyResources(this.btnSymulation, "btnSymulation");
            this.btnSymulation.Name = "btnSymulation";
            this.btnSymulation.UseVisualStyleBackColor = true;
            // 
            // MOV
            // 
            resources.ApplyResources(this.MOV, "MOV");
            this.MOV.Name = "MOV";
            this.MOV.UseVisualStyleBackColor = true;
            this.MOV.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // XCHG
            // 
            resources.ApplyResources(this.XCHG, "XCHG");
            this.XCHG.Name = "XCHG";
            this.XCHG.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Intel8086
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.XCHG);
            this.Controls.Add(this.MOV);
            this.Controls.Add(this.btnSymulation);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Name = "Intel8086";
            this.Load += new System.EventHandler(this.Intel8086_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnSymulation;
        private System.Windows.Forms.CheckBox MOV;
        private System.Windows.Forms.CheckBox XCHG;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

