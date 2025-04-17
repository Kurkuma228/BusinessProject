namespace BusinessProject
{
    partial class EventList_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddEvent_btn = new System.Windows.Forms.Button();
            this.Filter_btn = new System.Windows.Forms.Button();
            this.AddReport_btn = new System.Windows.Forms.Button();
            this.EventList_dgv = new System.Windows.Forms.DataGridView();
            this.Info_lbl = new System.Windows.Forms.Label();
            this.App_lbl = new System.Windows.Forms.Label();
            this.Logo_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EventList_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEvent_btn
            // 
            this.AddEvent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(204)))), ((int)(((byte)(178)))));
            this.AddEvent_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.AddEvent_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddEvent_btn.Location = new System.Drawing.Point(51, 103);
            this.AddEvent_btn.Name = "AddEvent_btn";
            this.AddEvent_btn.Size = new System.Drawing.Size(157, 37);
            this.AddEvent_btn.TabIndex = 0;
            this.AddEvent_btn.Text = "Добавить событие";
            this.AddEvent_btn.UseVisualStyleBackColor = false;
            this.AddEvent_btn.Click += new System.EventHandler(this.AddEvent_btn_Click);
            // 
            // Filter_btn
            // 
            this.Filter_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(106)))), ((int)(((byte)(232)))));
            this.Filter_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Filter_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Filter_btn.Location = new System.Drawing.Point(676, 107);
            this.Filter_btn.Name = "Filter_btn";
            this.Filter_btn.Size = new System.Drawing.Size(118, 33);
            this.Filter_btn.TabIndex = 1;
            this.Filter_btn.Text = "Сортировка";
            this.Filter_btn.UseVisualStyleBackColor = false;
            this.Filter_btn.Click += new System.EventHandler(this.Filter_btn_Click);
            // 
            // AddReport_btn
            // 
            this.AddReport_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(106)))), ((int)(((byte)(232)))));
            this.AddReport_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.AddReport_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddReport_btn.Location = new System.Drawing.Point(551, 107);
            this.AddReport_btn.Name = "AddReport_btn";
            this.AddReport_btn.Size = new System.Drawing.Size(118, 33);
            this.AddReport_btn.TabIndex = 2;
            this.AddReport_btn.Text = "Отчет";
            this.AddReport_btn.UseVisualStyleBackColor = false;
            this.AddReport_btn.Click += new System.EventHandler(this.AddReport_btn_Click);
            // 
            // EventList_dgv
            // 
            this.EventList_dgv.AllowUserToAddRows = false;
            this.EventList_dgv.AllowUserToDeleteRows = false;
            this.EventList_dgv.AllowUserToResizeColumns = false;
            this.EventList_dgv.AllowUserToResizeRows = false;
            this.EventList_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventList_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EventList_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EventList_dgv.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.EventList_dgv.ColumnHeadersHeight = 29;
            this.EventList_dgv.Location = new System.Drawing.Point(51, 146);
            this.EventList_dgv.Name = "EventList_dgv";
            this.EventList_dgv.ReadOnly = true;
            this.EventList_dgv.RowHeadersWidth = 51;
            this.EventList_dgv.Size = new System.Drawing.Size(743, 353);
            this.EventList_dgv.TabIndex = 0;
            this.EventList_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // Info_lbl
            // 
            this.Info_lbl.AutoSize = true;
            this.Info_lbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_lbl.Location = new System.Drawing.Point(45, 65);
            this.Info_lbl.Name = "Info_lbl";
            this.Info_lbl.Size = new System.Drawing.Size(239, 35);
            this.Info_lbl.TabIndex = 3;
            this.Info_lbl.Text = "Список событий";
            // 
            // App_lbl
            // 
            this.App_lbl.AutoSize = true;
            this.App_lbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.App_lbl.Location = new System.Drawing.Point(94, 27);
            this.App_lbl.Name = "App_lbl";
            this.App_lbl.Size = new System.Drawing.Size(176, 35);
            this.App_lbl.TabIndex = 5;
            this.App_lbl.Text = "VirtualMeet";
            // 
            // Logo_pb
            // 
            this.Logo_pb.Image = global::BusinessProject.Properties.Resources.Screenshot_2025_04_04_235622;
            this.Logo_pb.Location = new System.Drawing.Point(50, 19);
            this.Logo_pb.Name = "Logo_pb";
            this.Logo_pb.Size = new System.Drawing.Size(38, 43);
            this.Logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo_pb.TabIndex = 4;
            this.Logo_pb.TabStop = false;
            // 
            // EventList_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(857, 607);
            this.Controls.Add(this.App_lbl);
            this.Controls.Add(this.Logo_pb);
            this.Controls.Add(this.Info_lbl);
            this.Controls.Add(this.EventList_dgv);
            this.Controls.Add(this.AddReport_btn);
            this.Controls.Add(this.Filter_btn);
            this.Controls.Add(this.AddEvent_btn);
            this.Name = "EventList_form";
            this.Text = "Список событий";
            ((System.ComponentModel.ISupportInitialize)(this.EventList_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEvent_btn;
        private System.Windows.Forms.Button Filter_btn;
        private System.Windows.Forms.Button AddReport_btn;
        private System.Windows.Forms.DataGridView EventList_dgv;
        private System.Windows.Forms.Label Info_lbl;
        private System.Windows.Forms.PictureBox Logo_pb;
        private System.Windows.Forms.Label App_lbl;
    }
}

