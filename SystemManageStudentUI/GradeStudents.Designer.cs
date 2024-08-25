namespace SystemManageStudentUI
{
    partial class GradeStudents
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
            TittleLabel = new Label();
            PrimerNotaLabel = new Label();
            SegundaNotaLabel = new Label();
            TercerNotaLabel = new Label();
            PromedioLabel = new Label();
            PrimeraNotaTextBox = new TextBox();
            SegundaNotaTextBox = new TextBox();
            TercerNotaTextBox = new TextBox();
            NotaFinalLabel = new Label();
            NotasEstudianteButton = new Button();
            MensajeLabel = new Label();
            MensajeTextBox = new TextBox();
            CorreoLabel = new Label();
            correoEstudianteTextBox = new TextBox();
            SuspendLayout();
            // 
            // TittleLabel
            // 
            TittleLabel.AutoSize = true;
            TittleLabel.Location = new Point(177, 9);
            TittleLabel.Margin = new Padding(4, 0, 4, 0);
            TittleLabel.Name = "TittleLabel";
            TittleLabel.Size = new Size(234, 21);
            TittleLabel.TabIndex = 0;
            TittleLabel.Text = "Ingresar Notas del Estudiante";
            // 
            // PrimerNotaLabel
            // 
            PrimerNotaLabel.AutoSize = true;
            PrimerNotaLabel.Location = new Point(82, 170);
            PrimerNotaLabel.Name = "PrimerNotaLabel";
            PrimerNotaLabel.Size = new Size(76, 21);
            PrimerNotaLabel.TabIndex = 1;
            PrimerNotaLabel.Text = "1er Nota";
            // 
            // SegundaNotaLabel
            // 
            SegundaNotaLabel.AutoSize = true;
            SegundaNotaLabel.Location = new Point(192, 170);
            SegundaNotaLabel.Name = "SegundaNotaLabel";
            SegundaNotaLabel.Size = new Size(80, 21);
            SegundaNotaLabel.TabIndex = 2;
            SegundaNotaLabel.Text = "2da Nota";
            // 
            // TercerNotaLabel
            // 
            TercerNotaLabel.AutoSize = true;
            TercerNotaLabel.Location = new Point(311, 170);
            TercerNotaLabel.Name = "TercerNotaLabel";
            TercerNotaLabel.Size = new Size(76, 21);
            TercerNotaLabel.TabIndex = 3;
            TercerNotaLabel.Text = "3er Nota";
            // 
            // PromedioLabel
            // 
            PromedioLabel.AutoSize = true;
            PromedioLabel.Location = new Point(430, 170);
            PromedioLabel.Name = "PromedioLabel";
            PromedioLabel.Size = new Size(89, 21);
            PromedioLabel.TabIndex = 4;
            PromedioLabel.Text = "Nota Final";
            // 
            // PrimeraNotaTextBox
            // 
            PrimeraNotaTextBox.Location = new Point(82, 207);
            PrimeraNotaTextBox.Name = "PrimeraNotaTextBox";
            PrimeraNotaTextBox.Size = new Size(76, 29);
            PrimeraNotaTextBox.TabIndex = 5;
            // 
            // SegundaNotaTextBox
            // 
            SegundaNotaTextBox.Location = new Point(192, 207);
            SegundaNotaTextBox.Name = "SegundaNotaTextBox";
            SegundaNotaTextBox.Size = new Size(76, 29);
            SegundaNotaTextBox.TabIndex = 6;
            // 
            // TercerNotaTextBox
            // 
            TercerNotaTextBox.Location = new Point(311, 207);
            TercerNotaTextBox.Name = "TercerNotaTextBox";
            TercerNotaTextBox.Size = new Size(76, 29);
            TercerNotaTextBox.TabIndex = 7;
            // 
            // NotaFinalLabel
            // 
            NotaFinalLabel.AutoSize = true;
            NotaFinalLabel.Location = new Point(430, 210);
            NotaFinalLabel.Name = "NotaFinalLabel";
            NotaFinalLabel.Size = new Size(0, 21);
            NotaFinalLabel.TabIndex = 8;
            // 
            // NotasEstudianteButton
            // 
            NotasEstudianteButton.BackColor = SystemColors.MenuHighlight;
            NotasEstudianteButton.Location = new Point(339, 256);
            NotasEstudianteButton.Name = "NotasEstudianteButton";
            NotasEstudianteButton.Size = new Size(165, 50);
            NotasEstudianteButton.TabIndex = 9;
            NotasEstudianteButton.Text = "Obtener Notas";
            NotasEstudianteButton.UseVisualStyleBackColor = false;
            NotasEstudianteButton.Click += NotasEstudianteButton_Click;
            // 
            // MensajeLabel
            // 
            MensajeLabel.AutoSize = true;
            MensajeLabel.Location = new Point(177, 39);
            MensajeLabel.Name = "MensajeLabel";
            MensajeLabel.Size = new Size(219, 21);
            MensajeLabel.TabIndex = 10;
            MensajeLabel.Text = "Mensaje para el Estudiante:";
            // 
            // MensajeTextBox
            // 
            MensajeTextBox.Location = new Point(82, 63);
            MensajeTextBox.Multiline = true;
            MensajeTextBox.Name = "MensajeTextBox";
            MensajeTextBox.PlaceholderText = "Palabras para el estudiante";
            MensajeTextBox.Size = new Size(437, 57);
            MensajeTextBox.TabIndex = 11;
            // 
            // CorreoLabel
            // 
            CorreoLabel.AutoSize = true;
            CorreoLabel.Location = new Point(82, 141);
            CorreoLabel.Name = "CorreoLabel";
            CorreoLabel.Size = new Size(146, 21);
            CorreoLabel.TabIndex = 12;
            CorreoLabel.Text = "Correo Estudiante";
            // 
            // correoEstudianteTextBox
            // 
            correoEstudianteTextBox.Location = new Point(234, 133);
            correoEstudianteTextBox.Name = "correoEstudianteTextBox";
            correoEstudianteTextBox.Size = new Size(285, 29);
            correoEstudianteTextBox.TabIndex = 13;
            // 
            // GradeStudents
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 344);
            Controls.Add(correoEstudianteTextBox);
            Controls.Add(CorreoLabel);
            Controls.Add(MensajeTextBox);
            Controls.Add(MensajeLabel);
            Controls.Add(NotasEstudianteButton);
            Controls.Add(NotaFinalLabel);
            Controls.Add(TercerNotaTextBox);
            Controls.Add(SegundaNotaTextBox);
            Controls.Add(PrimeraNotaTextBox);
            Controls.Add(PromedioLabel);
            Controls.Add(TercerNotaLabel);
            Controls.Add(SegundaNotaLabel);
            Controls.Add(PrimerNotaLabel);
            Controls.Add(TittleLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "GradeStudents";
            Text = "GradeStudents";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TittleLabel;
        private Label PrimerNotaLabel;
        private Label SegundaNotaLabel;
        private Label TercerNotaLabel;
        private Label PromedioLabel;
        private TextBox PrimeraNotaTextBox;
        private TextBox SegundaNotaTextBox;
        private TextBox TercerNotaTextBox;
        private Label NotaFinalLabel;
        private Button NotasEstudianteButton;
        private Label MensajeLabel;
        private TextBox MensajeTextBox;
        private Label CorreoLabel;
        private TextBox correoEstudianteTextBox;
    }
}