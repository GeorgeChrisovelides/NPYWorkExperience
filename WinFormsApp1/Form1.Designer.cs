namespace WinFormsApp1
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
            this.addButton = new System.Windows.Forms.Button();
            this.Readout = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Meteor1XInput = new System.Windows.Forms.TextBox();
            this.Meteor2XInput = new System.Windows.Forms.TextBox();
            this.Meteor1YInput = new System.Windows.Forms.TextBox();
            this.Meteor2YInput = new System.Windows.Forms.TextBox();
            this.CBisChecked = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TableView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.AmountDone = new System.Windows.Forms.Label();
            this.NumberToGenerate = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(343, 743);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(227, 80);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "add data";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Readout
            // 
            this.Readout.AutoSize = true;
            this.Readout.Location = new System.Drawing.Point(980, 767);
            this.Readout.Name = "Readout";
            this.Readout.Size = new System.Drawing.Size(78, 32);
            this.Readout.TabIndex = 1;
            this.Readout.Text = "label1";
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(688, 718);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(210, 80);
            this.getButton.TabIndex = 2;
            this.getButton.Text = "Get ID 4";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meteor 1 X";
            this.label1.Click += new System.EventHandler(this.getButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meteor 2 X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Meteor 1 Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Meteor 2 Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Checked";
            // 
            // Meteor1XInput
            // 
            this.Meteor1XInput.Location = new System.Drawing.Point(190, 200);
            this.Meteor1XInput.Name = "Meteor1XInput";
            this.Meteor1XInput.Size = new System.Drawing.Size(133, 39);
            this.Meteor1XInput.TabIndex = 8;
            this.Meteor1XInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyKeyPress);
            // 
            // Meteor2XInput
            // 
            this.Meteor2XInput.Location = new System.Drawing.Point(343, 202);
            this.Meteor2XInput.Name = "Meteor2XInput";
            this.Meteor2XInput.Size = new System.Drawing.Size(145, 39);
            this.Meteor2XInput.TabIndex = 9;
            this.Meteor2XInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyKeyPress);
            // 
            // Meteor1YInput
            // 
            this.Meteor1YInput.Location = new System.Drawing.Point(504, 200);
            this.Meteor1YInput.Name = "Meteor1YInput";
            this.Meteor1YInput.Size = new System.Drawing.Size(145, 39);
            this.Meteor1YInput.TabIndex = 10;
            this.Meteor1YInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyKeyPress);
            // 
            // Meteor2YInput
            // 
            this.Meteor2YInput.Location = new System.Drawing.Point(655, 200);
            this.Meteor2YInput.Name = "Meteor2YInput";
            this.Meteor2YInput.Size = new System.Drawing.Size(145, 39);
            this.Meteor2YInput.TabIndex = 11;
            this.Meteor2YInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyKeyPress);
            // 
            // CBisChecked
            // 
            this.CBisChecked.AutoSize = true;
            this.CBisChecked.Location = new System.Drawing.Point(855, 207);
            this.CBisChecked.Name = "CBisChecked";
            this.CBisChecked.Size = new System.Drawing.Size(28, 27);
            this.CBisChecked.TabIndex = 12;
            this.CBisChecked.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(965, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableView
            // 
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Location = new System.Drawing.Point(36, 275);
            this.TableView.Name = "TableView";
            this.TableView.RowHeadersWidth = 82;
            this.TableView.RowTemplate.Height = 41;
            this.TableView.Size = new System.Drawing.Size(1243, 300);
            this.TableView.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 66);
            this.button2.TabIndex = 15;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GenerateNumbers);
            // 
            // AmountDone
            // 
            this.AmountDone.AutoSize = true;
            this.AmountDone.Location = new System.Drawing.Point(374, 625);
            this.AmountDone.Name = "AmountDone";
            this.AmountDone.Size = new System.Drawing.Size(78, 32);
            this.AmountDone.TabIndex = 16;
            this.AmountDone.Text = "label6";
            // 
            // NumberToGenerate
            // 
            this.NumberToGenerate.Location = new System.Drawing.Point(144, 689);
            this.NumberToGenerate.Name = "NumberToGenerate";
            this.NumberToGenerate.Size = new System.Drawing.Size(179, 39);
            this.NumberToGenerate.TabIndex = 17;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(379, 690);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(78, 32);
            this.Message.TabIndex = 18;
            this.Message.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 856);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.NumberToGenerate);
            this.Controls.Add(this.AmountDone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBisChecked);
            this.Controls.Add(this.Meteor2YInput);
            this.Controls.Add(this.Meteor1YInput);
            this.Controls.Add(this.Meteor2XInput);
            this.Controls.Add(this.Meteor1XInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.Readout);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addButton;
        private Label Readout;
        private Button getButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Meteor1XInput;
        private TextBox Meteor2XInput;
        private TextBox Meteor1YInput;
        private TextBox Meteor2YInput;
        private CheckBox CBisChecked;
        private Button button1;
        private DataGridView TableView;
        private Button button2;
        private Label AmountDone;
        private TextBox NumberToGenerate;
        private Label Message;
    }
}