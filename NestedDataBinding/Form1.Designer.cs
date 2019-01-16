namespace NestedDataBinding
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label housenumberLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label ageLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label housenumberLabel1;
            System.Windows.Forms.Label postalCodeLabel1;
            System.Windows.Forms.Label streetLabel1;
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.housenumberTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.housenumberTextBox1 = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.streetTextBox1 = new System.Windows.Forms.TextBox();
            ageLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            housenumberLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            ageLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            housenumberLabel1 = new System.Windows.Forms.Label();
            postalCodeLabel1 = new System.Windows.Forms.Label();
            streetLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(NestedDataBinding.Models.Person);
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(75, 40);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 0;
            ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(119, 37);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(75, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(119, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // housenumberLabel
            // 
            housenumberLabel.AutoSize = true;
            housenumberLabel.Location = new System.Drawing.Point(75, 126);
            housenumberLabel.Name = "housenumberLabel";
            housenumberLabel.Size = new System.Drawing.Size(76, 13);
            housenumberLabel.TabIndex = 4;
            housenumberLabel.Text = "Housenumber:";
            // 
            // housenumberTextBox
            // 
            this.housenumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address.Housenumber", true));
            this.housenumberTextBox.Location = new System.Drawing.Point(157, 123);
            this.housenumberTextBox.Name = "housenumberTextBox";
            this.housenumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.housenumberTextBox.TabIndex = 5;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(75, 152);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 6;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address.PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(157, 149);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTextBox.TabIndex = 7;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(75, 178);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 8;
            streetLabel.Text = "Street:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address.Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(157, 175);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetTextBox.TabIndex = 9;
            // 
            // ageLabel1
            // 
            ageLabel1.AutoSize = true;
            ageLabel1.Location = new System.Drawing.Point(502, 56);
            ageLabel1.Name = "ageLabel1";
            ageLabel1.Size = new System.Drawing.Size(29, 13);
            ageLabel1.TabIndex = 10;
            ageLabel1.Text = "Age:";
            // 
            // ageTextBox1
            // 
            this.ageTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Age", true));
            this.ageTextBox1.Location = new System.Drawing.Point(546, 53);
            this.ageTextBox1.Name = "ageTextBox1";
            this.ageTextBox1.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox1.TabIndex = 11;
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(502, 82);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 12;
            nameLabel1.Text = "Name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(546, 79);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox1.TabIndex = 13;
            // 
            // housenumberLabel1
            // 
            housenumberLabel1.AutoSize = true;
            housenumberLabel1.Location = new System.Drawing.Point(502, 142);
            housenumberLabel1.Name = "housenumberLabel1";
            housenumberLabel1.Size = new System.Drawing.Size(76, 13);
            housenumberLabel1.TabIndex = 14;
            housenumberLabel1.Text = "Housenumber:";
            // 
            // housenumberTextBox1
            // 
            this.housenumberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address.Housenumber", true));
            this.housenumberTextBox1.Location = new System.Drawing.Point(584, 139);
            this.housenumberTextBox1.Name = "housenumberTextBox1";
            this.housenumberTextBox1.Size = new System.Drawing.Size(100, 20);
            this.housenumberTextBox1.TabIndex = 15;
            // 
            // postalCodeLabel1
            // 
            postalCodeLabel1.AutoSize = true;
            postalCodeLabel1.Location = new System.Drawing.Point(502, 168);
            postalCodeLabel1.Name = "postalCodeLabel1";
            postalCodeLabel1.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel1.TabIndex = 16;
            postalCodeLabel1.Text = "Postal Code:";
            // 
            // postalCodeTextBox1
            // 
            this.postalCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address.PostalCode", true));
            this.postalCodeTextBox1.Location = new System.Drawing.Point(584, 165);
            this.postalCodeTextBox1.Name = "postalCodeTextBox1";
            this.postalCodeTextBox1.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTextBox1.TabIndex = 17;
            // 
            // streetLabel1
            // 
            streetLabel1.AutoSize = true;
            streetLabel1.Location = new System.Drawing.Point(502, 194);
            streetLabel1.Name = "streetLabel1";
            streetLabel1.Size = new System.Drawing.Size(38, 13);
            streetLabel1.TabIndex = 18;
            streetLabel1.Text = "Street:";
            // 
            // streetTextBox1
            // 
            this.streetTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address.Street", true));
            this.streetTextBox1.Location = new System.Drawing.Point(584, 191);
            this.streetTextBox1.Name = "streetTextBox1";
            this.streetTextBox1.Size = new System.Drawing.Size(100, 20);
            this.streetTextBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(housenumberLabel1);
            this.Controls.Add(this.housenumberTextBox1);
            this.Controls.Add(postalCodeLabel1);
            this.Controls.Add(this.postalCodeTextBox1);
            this.Controls.Add(streetLabel1);
            this.Controls.Add(this.streetTextBox1);
            this.Controls.Add(ageLabel1);
            this.Controls.Add(this.ageTextBox1);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(housenumberLabel);
            this.Controls.Add(this.housenumberTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox housenumberTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox ageTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox housenumberTextBox1;
        private System.Windows.Forms.TextBox postalCodeTextBox1;
        private System.Windows.Forms.TextBox streetTextBox1;
    }
}

