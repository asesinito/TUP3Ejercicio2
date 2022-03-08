
namespace TUP3Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBirthPlace = new System.Windows.Forms.TextBox();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(330, 62);
            this.textName.MaxLength = 20;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(330, 108);
            this.textLastName.MaxLength = 20;
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // textBirthPlace
            // 
            this.textBirthPlace.Location = new System.Drawing.Point(330, 199);
            this.textBirthPlace.MaxLength = 20;
            this.textBirthPlace.Name = "textBirthPlace";
            this.textBirthPlace.Size = new System.Drawing.Size(100, 20);
            this.textBirthPlace.TabIndex = 5;
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Location = new System.Drawing.Point(330, 312);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(34, 17);
            this.radioBtnYes.TabIndex = 6;
            this.radioBtnYes.TabStop = true;
            this.radioBtnYes.Text = "Si";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Location = new System.Drawing.Point(390, 312);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(39, 17);
            this.radioBtnNo.TabIndex = 7;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "No";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(282, 362);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(407, 362);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 10;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha de Nacimiento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Lugar de Nacimiento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pais de Nacimiento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Posee estudios secundarios?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cBCountry
            // 
            this.cBCountry.FormattingEnabled = true;
            this.cBCountry.Items.AddRange(new object[] {
            "Argentina",
            "Brasil",
            "Paraguay",
            "Uruguay",
            "Venezuela",
            "Bolivia",
            "Chile",
            "Colombia",
            "Ecuador",
            "Guayana",
            "Peru",
            "Surinam"});
            this.cBCountry.Location = new System.Drawing.Point(330, 245);
            this.cBCountry.Name = "cBCountry";
            this.cBCountry.Size = new System.Drawing.Size(121, 21);
            this.cBCountry.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.radioBtnNo);
            this.Controls.Add(this.radioBtnYes);
            this.Controls.Add(this.textBirthPlace);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "Formulario de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBirthPlace;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBCountry;
    }
}

