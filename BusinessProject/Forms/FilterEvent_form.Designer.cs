namespace BusinessProject
{
    partial class FilterEvent_form
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
            this.App_lbl = new System.Windows.Forms.Label();
            this.Logo_pb = new System.Windows.Forms.PictureBox();
            this.Info_lbl = new System.Windows.Forms.Label();
            this.FilterName_btn = new System.Windows.Forms.Button();
            this.FilterDate_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // App_lbl
            // 
            this.App_lbl.AutoSize = true;
            this.App_lbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.App_lbl.Location = new System.Drawing.Point(331, 64);
            this.App_lbl.Name = "App_lbl";
            this.App_lbl.Size = new System.Drawing.Size(176, 35);
            this.App_lbl.TabIndex = 7;
            this.App_lbl.Text = "VirtualMeet";
            // 
            // Logo_pb
            // 
            this.Logo_pb.Image = global::   BusinessProject.Properties.Resources.Screenshot_2025_04_04_235622;
            this.Logo_pb.Location = new System.Drawing.Point(287, 56);
            this.Logo_pb.Name = "Logo_pb";
            this.Logo_pb.Size = new System.Drawing.Size(38, 43);
            this.Logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo_pb.TabIndex = 13;
            this.Logo_pb.TabStop = false;
            // 
            // Info_lbl
            // 
            this.Info_lbl.AutoSize = true;
            this.Info_lbl.Font = new System.Drawing.Font("Arial", 18.2F, System.Drawing.FontStyle.Bold);
            this.Info_lbl.Location = new System.Drawing.Point(281, 124);
            this.Info_lbl.Name = "Info_lbl";
            this.Info_lbl.Size = new System.Drawing.Size(196, 36);
            this.Info_lbl.TabIndex = 14;
            this.Info_lbl.Text = "Сортировка";
            // 
            // FilterName_btn
            // 
            this.FilterName_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(106)))), ((int)(((byte)(229)))));
            this.FilterName_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.FilterName_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FilterName_btn.Location = new System.Drawing.Point(287, 163);
            this.FilterName_btn.Name = "FilterName_btn";
            this.FilterName_btn.Size = new System.Drawing.Size(211, 35);
            this.FilterName_btn.TabIndex = 16;
            this.FilterName_btn.Text = "Название";
            this.FilterName_btn.UseVisualStyleBackColor = false;
            this.FilterName_btn.Click += new System.EventHandler(this.FilterName_btn_Click);
            // 
            // FilterDate_btn
            // 
            this.FilterDate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(106)))), ((int)(((byte)(229)))));
            this.FilterDate_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.FilterDate_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FilterDate_btn.Location = new System.Drawing.Point(287, 204);
            this.FilterDate_btn.Name = "FilterDate_btn";
            this.FilterDate_btn.Size = new System.Drawing.Size(211, 35);
            this.FilterDate_btn.TabIndex = 17;
            this.FilterDate_btn.Text = "Дата";
            this.FilterDate_btn.UseVisualStyleBackColor = false;
            // 
            // FilterEvent_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilterDate_btn);
            this.Controls.Add(this.FilterName_btn);
            this.Controls.Add(this.Info_lbl);
            this.Controls.Add(this.Logo_pb);
            this.Controls.Add(this.App_lbl);
            this.MaximizeBox = false;
            this.Name = "FilterEvent_form";
            this.Text = "Фильтр";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label App_lbl;
        private System.Windows.Forms.PictureBox Logo_pb;
        private System.Windows.Forms.Label Info_lbl;
        private System.Windows.Forms.Button FilterName_btn;
        private System.Windows.Forms.Button FilterDate_btn;
    }
}