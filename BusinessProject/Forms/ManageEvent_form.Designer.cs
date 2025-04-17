using System;

namespace BusinessProject
{
    partial class ManageEvent_form
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
            this.EventName_tb = new System.Windows.Forms.TextBox();
            this.DeleteEvent_btn = new System.Windows.Forms.Button();
            this.ChangeEvent_btn = new System.Windows.Forms.Button();
            this.Info_lbl = new System.Windows.Forms.Label();
            this.EventParticipants_tb = new System.Windows.Forms.TextBox();
            this.Logo_pb = new System.Windows.Forms.PictureBox();
            this.Date_dtp = new System.Windows.Forms.DateTimePicker();
            this.Categories_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // App_lbl
            // 
            this.App_lbl.AutoSize = true;
            this.App_lbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.App_lbl.Location = new System.Drawing.Point(103, 37);
            this.App_lbl.Name = "App_lbl";
            this.App_lbl.Size = new System.Drawing.Size(176, 35);
            this.App_lbl.TabIndex = 6;
            this.App_lbl.Text = "VirtualMeet";
            // 
            // EventName_tb
            // 
            this.EventName_tb.Location = new System.Drawing.Point(71, 142);
            this.EventName_tb.Name = "EventName_tb";
            this.EventName_tb.Size = new System.Drawing.Size(194, 22);
            this.EventName_tb.TabIndex = 8;
            // 
            // DeleteEvent_btn
            // 
            this.DeleteEvent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.DeleteEvent_btn.Font = new System.Drawing.Font("Arial", 7.85F, System.Drawing.FontStyle.Bold);
            this.DeleteEvent_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteEvent_btn.Location = new System.Drawing.Point(173, 256);
            this.DeleteEvent_btn.Name = "DeleteEvent_btn";
            this.DeleteEvent_btn.Size = new System.Drawing.Size(92, 44);
            this.DeleteEvent_btn.TabIndex = 10;
            this.DeleteEvent_btn.Text = "Удалить событие";
            this.DeleteEvent_btn.UseVisualStyleBackColor = false;
            this.DeleteEvent_btn.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeEvent_btn
            // 
            this.ChangeEvent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(177)))), ((int)(((byte)(55)))));
            this.ChangeEvent_btn.Font = new System.Drawing.Font("Arial", 7.85F, System.Drawing.FontStyle.Bold);
            this.ChangeEvent_btn.Location = new System.Drawing.Point(71, 256);
            this.ChangeEvent_btn.Name = "ChangeEvent_btn";
            this.ChangeEvent_btn.Size = new System.Drawing.Size(92, 44);
            this.ChangeEvent_btn.TabIndex = 11;
            this.ChangeEvent_btn.Text = "Изменить событие";
            this.ChangeEvent_btn.UseVisualStyleBackColor = false;
            this.ChangeEvent_btn.Click += new System.EventHandler(this.ChangeEvent_btn_Click);
            // 
            // Info_lbl
            // 
            this.Info_lbl.AutoSize = true;
            this.Info_lbl.Font = new System.Drawing.Font("Arial", 13F);
            this.Info_lbl.Location = new System.Drawing.Point(66, 93);
            this.Info_lbl.Name = "Info_lbl";
            this.Info_lbl.Size = new System.Drawing.Size(259, 25);
            this.Info_lbl.TabIndex = 13;
            this.Info_lbl.Text = "Информация о событии";
            // 
            // EventParticipants_tb
            // 
            this.EventParticipants_tb.Location = new System.Drawing.Point(71, 198);
            this.EventParticipants_tb.Name = "EventParticipants_tb";
            this.EventParticipants_tb.Size = new System.Drawing.Size(194, 22);
            this.EventParticipants_tb.TabIndex = 7;
            // 
            // Logo_pb
            // 
            this.Logo_pb.Image = global::BusinessProject.Properties.Resources.Screenshot_2025_04_04_235622;
            this.Logo_pb.Location = new System.Drawing.Point(59, 29);
            this.Logo_pb.Name = "Logo_pb";
            this.Logo_pb.Size = new System.Drawing.Size(38, 43);
            this.Logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo_pb.TabIndex = 12;
            this.Logo_pb.TabStop = false;
            // 
            // Date_dtp
            // 
            this.Date_dtp.Location = new System.Drawing.Point(71, 170);
            this.Date_dtp.Name = "Date_dtp";
            this.Date_dtp.Size = new System.Drawing.Size(194, 22);
            this.Date_dtp.TabIndex = 14;
            // 
            // Categories_cb
            // 
            this.Categories_cb.FormattingEnabled = true;
            this.Categories_cb.Location = new System.Drawing.Point(71, 226);
            this.Categories_cb.Name = "Categories_cb";
            this.Categories_cb.Size = new System.Drawing.Size(194, 24);
            this.Categories_cb.TabIndex = 15;
            // 
            // ManageEvent_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.Categories_cb);
            this.Controls.Add(this.Date_dtp);
            this.Controls.Add(this.Info_lbl);
            this.Controls.Add(this.Logo_pb);
            this.Controls.Add(this.ChangeEvent_btn);
            this.Controls.Add(this.DeleteEvent_btn);
            this.Controls.Add(this.EventName_tb);
            this.Controls.Add(this.EventParticipants_tb);
            this.Controls.Add(this.App_lbl);
            this.MaximizeBox = false;
            this.Name = "ManageEvent_form";
            this.Text = "Управление событием";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label App_lbl;
        private System.Windows.Forms.TextBox EventName_tb;
        private System.Windows.Forms.Button DeleteEvent_btn;
        private System.Windows.Forms.Button ChangeEvent_btn;
        private System.Windows.Forms.PictureBox Logo_pb;
        private System.Windows.Forms.Label Info_lbl;
        private System.Windows.Forms.TextBox EventParticipants_tb;
        private System.Windows.Forms.DateTimePicker Date_dtp;
        private System.Windows.Forms.ComboBox Categories_cb;
    }
}