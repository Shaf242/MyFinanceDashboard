namespace MyProject
{
    partial class IncomeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.income_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.income_item = new System.Windows.Forms.TextBox();
            this.income_income = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.income_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.income_date = new System.Windows.Forms.DateTimePicker();
            this.income_deleteBtn = new System.Windows.Forms.Button();
            this.income_clearBtn = new System.Windows.Forms.Button();
            this.income_updateBtn = new System.Windows.Forms.Button();
            this.income_addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 274);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Income List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.income_deleteBtn);
            this.panel2.Controls.Add(this.income_clearBtn);
            this.panel2.Controls.Add(this.income_updateBtn);
            this.panel2.Controls.Add(this.income_addBtn);
            this.panel2.Controls.Add(this.income_date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.income_description);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.income_income);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.income_item);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.income_category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 299);
            this.panel2.TabIndex = 3;
            // 
            // income_category
            // 
            this.income_category.BackColor = System.Drawing.Color.White;
            this.income_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_category.FormattingEnabled = true;
            this.income_category.Location = new System.Drawing.Point(164, 24);
            this.income_category.Name = "income_category";
            this.income_category.Size = new System.Drawing.Size(254, 34);
            this.income_category.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item:";
            // 
            // income_item
            // 
            this.income_item.BackColor = System.Drawing.Color.White;
            this.income_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_item.Location = new System.Drawing.Point(164, 86);
            this.income_item.Name = "income_item";
            this.income_item.Size = new System.Drawing.Size(254, 32);
            this.income_item.TabIndex = 5;
            // 
            // income_income
            // 
            this.income_income.BackColor = System.Drawing.Color.White;
            this.income_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_income.Location = new System.Drawing.Point(164, 150);
            this.income_income.Name = "income_income";
            this.income_income.Size = new System.Drawing.Size(254, 32);
            this.income_income.TabIndex = 7;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(68, 150);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 26);
            this.label.TabIndex = 6;
            this.label.Text = "Income:";
            // 
            // income_description
            // 
            this.income_description.BackColor = System.Drawing.Color.White;
            this.income_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_description.Location = new System.Drawing.Point(614, 26);
            this.income_description.Multiline = true;
            this.income_description.Name = "income_description";
            this.income_description.Size = new System.Drawing.Size(310, 106);
            this.income_description.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // income_date
            // 
            this.income_date.Location = new System.Drawing.Point(614, 165);
            this.income_date.Name = "income_date";
            this.income_date.Size = new System.Drawing.Size(200, 26);
            this.income_date.TabIndex = 11;
            // 
            // income_deleteBtn
            // 
            this.income_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_deleteBtn.FlatAppearance.BorderSize = 0;
            this.income_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.income_deleteBtn.Location = new System.Drawing.Point(551, 230);
            this.income_deleteBtn.Name = "income_deleteBtn";
            this.income_deleteBtn.Size = new System.Drawing.Size(111, 48);
            this.income_deleteBtn.TabIndex = 15;
            this.income_deleteBtn.Text = "Delete";
            this.income_deleteBtn.UseVisualStyleBackColor = false;
            this.income_deleteBtn.Click += new System.EventHandler(this.income_deleteBtn_Click);
            // 
            // income_clearBtn
            // 
            this.income_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_clearBtn.FlatAppearance.BorderSize = 0;
            this.income_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_clearBtn.ForeColor = System.Drawing.Color.White;
            this.income_clearBtn.Location = new System.Drawing.Point(732, 230);
            this.income_clearBtn.Name = "income_clearBtn";
            this.income_clearBtn.Size = new System.Drawing.Size(121, 48);
            this.income_clearBtn.TabIndex = 14;
            this.income_clearBtn.Text = "Clear";
            this.income_clearBtn.UseVisualStyleBackColor = false;
            this.income_clearBtn.Click += new System.EventHandler(this.income_clearBtn_Click);
            // 
            // income_updateBtn
            // 
            this.income_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_updateBtn.FlatAppearance.BorderSize = 0;
            this.income_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_updateBtn.ForeColor = System.Drawing.Color.White;
            this.income_updateBtn.Location = new System.Drawing.Point(357, 230);
            this.income_updateBtn.Name = "income_updateBtn";
            this.income_updateBtn.Size = new System.Drawing.Size(123, 48);
            this.income_updateBtn.TabIndex = 13;
            this.income_updateBtn.Text = "Update";
            this.income_updateBtn.UseVisualStyleBackColor = false;
            this.income_updateBtn.Click += new System.EventHandler(this.income_updateBtn_Click);
            // 
            // income_addBtn
            // 
            this.income_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_addBtn.FlatAppearance.BorderSize = 0;
            this.income_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_addBtn.ForeColor = System.Drawing.Color.White;
            this.income_addBtn.Location = new System.Drawing.Point(164, 230);
            this.income_addBtn.Name = "income_addBtn";
            this.income_addBtn.Size = new System.Drawing.Size(124, 48);
            this.income_addBtn.TabIndex = 12;
            this.income_addBtn.Text = "Add";
            this.income_addBtn.UseVisualStyleBackColor = false;
            this.income_addBtn.Click += new System.EventHandler(this.income_addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(44, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(861, 211);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Size = new System.Drawing.Size(979, 643);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox income_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox income_category;
        private System.Windows.Forms.DateTimePicker income_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox income_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox income_income;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button income_deleteBtn;
        private System.Windows.Forms.Button income_clearBtn;
        private System.Windows.Forms.Button income_updateBtn;
        private System.Windows.Forms.Button income_addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
