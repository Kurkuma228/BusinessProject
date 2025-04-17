namespace BusinessProject
{
    partial class AddEvent_form
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
            this.AddEvent_btn = new System.Windows.Forms.Button();
            this.Participants_txt = new System.Windows.Forms.TextBox();
            this.EventName_txt = new System.Windows.Forms.TextBox();
            this.App_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.Participants_lbl = new System.Windows.Forms.Label();
            this.Logo_pb = new System.Windows.Forms.PictureBox();
            this.Categories_cb = new System.Windows.Forms.ComboBox();
            this.Date_dtp = new System.Windows.Forms.DateTimePicker();
            this.Category_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEvent_btn
            // 
            this.AddEvent_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddEvent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(106)))), ((int)(((byte)(232)))));
            this.AddEvent_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.AddEvent_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddEvent_btn.Location = new System.Drawing.Point(117, 247);
            this.AddEvent_btn.Name = "AddEvent_btn";
            this.AddEvent_btn.Size = new System.Drawing.Size(220, 30);
            this.AddEvent_btn.TabIndex = 0;
            this.AddEvent_btn.Text = "Добавить";
            this.AddEvent_btn.UseVisualStyleBackColor = false;
            this.AddEvent_btn.Click += new System.EventHandler(this.AddEvent_btn_Click);
            // 
            // Participants_txt
            // 
            this.Participants_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Participants_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Participants_txt.Location = new System.Drawing.Point(117, 174);
            this.Participants_txt.Multiline = true;
            this.Participants_txt.Name = "Participants_txt";
            this.Participants_txt.Size = new System.Drawing.Size(220, 22);
            this.Participants_txt.TabIndex = 1;
            // 
            // EventName_txt
            // 
            this.EventName_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EventName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EventName_txt.Location = new System.Drawing.Point(117, 85);
            this.EventName_txt.Multiline = true;
            this.EventName_txt.Name = "EventName_txt";
            this.EventName_txt.Size = new System.Drawing.Size(220, 23);
            this.EventName_txt.TabIndex = 3;
            // 
            // App_lbl
            // 
            this.App_lbl.AutoSize = true;
            this.App_lbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.App_lbl.Location = new System.Drawing.Point(161, 28);
            this.App_lbl.Name = "App_lbl";
            this.App_lbl.Size = new System.Drawing.Size(176, 35);
            this.App_lbl.TabIndex = 6;
            this.App_lbl.Text = "VirtualMeet";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(114, 66);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(130, 16);
            this.Name_lbl.TabIndex = 7;
            this.Name_lbl.Text = "Название события";
            // 
            // Date_lbl
            // 
            this.Date_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Location = new System.Drawing.Point(114, 111);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(93, 16);
            this.Date_lbl.TabIndex = 8;
            this.Date_lbl.Text = "Дата и время";
            // 
            // Participants_lbl
            // 
            this.Participants_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Participants_lbl.AutoSize = true;
            this.Participants_lbl.Location = new System.Drawing.Point(114, 155);
            this.Participants_lbl.Name = "Participants_lbl";
            this.Participants_lbl.Size = new System.Drawing.Size(77, 16);
            this.Participants_lbl.TabIndex = 9;
            this.Participants_lbl.Text = "Участники";
            // 
            // Logo_pb
            // 
            this.Logo_pb.Image = global::BusinessProject.Properties.Resources.Screenshot_2025_04_04_235622;
            this.Logo_pb.Location = new System.Drawing.Point(117, 20);
            this.Logo_pb.Name = "Logo_pb";
            this.Logo_pb.Size = new System.Drawing.Size(38, 43);
            this.Logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo_pb.TabIndex = 5;
            this.Logo_pb.TabStop = false;
            // 
            // Categories_cb
            // 
            this.Categories_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categories_cb.FormattingEnabled = true;
            this.Categories_cb.Location = new System.Drawing.Point(117, 217);
            this.Categories_cb.Name = "Categories_cb";
            this.Categories_cb.Size = new System.Drawing.Size(220, 24);
            this.Categories_cb.TabIndex = 10;
            // 
            // Date_dtp
            // 
            this.Date_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_dtp.Location = new System.Drawing.Point(117, 130);
            this.Date_dtp.Name = "Date_dtp";
            this.Date_dtp.Size = new System.Drawing.Size(220, 22);
            this.Date_dtp.TabIndex = 11;
            // 
            // Category_lbl
            // 
            this.Category_lbl.AutoSize = true;
            this.Category_lbl.Location = new System.Drawing.Point(114, 199);
            this.Category_lbl.Name = "Category_lbl";
            this.Category_lbl.Size = new System.Drawing.Size(75, 16);
            this.Category_lbl.TabIndex = 12;
            this.Category_lbl.Text = "Категория";
            // 
            // AddEvent_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(443, 413);
            this.Controls.Add(this.Category_lbl);
            this.Controls.Add(this.Date_dtp);
            this.Controls.Add(this.Categories_cb);
            this.Controls.Add(this.Participants_lbl);
            this.Controls.Add(this.Date_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.App_lbl);
            this.Controls.Add(this.Logo_pb);
            this.Controls.Add(this.EventName_txt);
            this.Controls.Add(this.Participants_txt);
            this.Controls.Add(this.AddEvent_btn);
            this.MaximizeBox = false;
            this.Name = "AddEvent_form";
            this.Text = "Добавление события";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEvent_btn;
        private System.Windows.Forms.TextBox Participants_txt;
        private System.Windows.Forms.TextBox EventName_txt;
        private System.Windows.Forms.PictureBox Logo_pb;
        private System.Windows.Forms.Label App_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.Label Participants_lbl;
        private System.Windows.Forms.ComboBox Categories_cb;
        private System.Windows.Forms.DateTimePicker Date_dtp;
        private System.Windows.Forms.Label Category_lbl;
    }
}