namespace Project_demo
{
    partial class EquipmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMuscle = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_viewEqipment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipment Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Muscle used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delivery Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cost";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(280, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtMuscle
            // 
            this.txtMuscle.Location = new System.Drawing.Point(280, 249);
            this.txtMuscle.Name = "txtMuscle";
            this.txtMuscle.Size = new System.Drawing.Size(254, 23);
            this.txtMuscle.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(280, 387);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(254, 23);
            this.txtCost.TabIndex = 7;
            // 
            // dateTimePickerDeliveryDate
            // 
            this.dateTimePickerDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDeliveryDate.Location = new System.Drawing.Point(280, 313);
            this.dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            this.dateTimePickerDeliveryDate.Size = new System.Drawing.Size(254, 23);
            this.dateTimePickerDeliveryDate.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(280, 147);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(254, 70);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(186, 517);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(97, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(301, 517);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(97, 23);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "button2";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_viewEqipment
            // 
            this.btn_viewEqipment.Location = new System.Drawing.Point(431, 517);
            this.btn_viewEqipment.Name = "btn_viewEqipment";
            this.btn_viewEqipment.Size = new System.Drawing.Size(133, 23);
            this.btn_viewEqipment.TabIndex = 12;
            this.btn_viewEqipment.Text = "View Equipment";
            this.btn_viewEqipment.UseVisualStyleBackColor = true;
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 589);
            this.Controls.Add(this.btn_viewEqipment);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dateTimePickerDeliveryDate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtMuscle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Equipment";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Equipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtMuscle;
        private TextBox txtCost;
        private DateTimePicker dateTimePickerDeliveryDate;
        private RichTextBox txtDescription;
        private Button btn_save;
        private Button btn_reset;
        private Button btn_viewEqipment;
    }
}