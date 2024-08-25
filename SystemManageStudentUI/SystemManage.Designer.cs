namespace SystemManageStudentUI
{
    partial class SystemManage
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
            bluePanel = new Panel();
            agregarEstudianteButton = new Button();
            duiRegistroTexBox = new TextBox();
            duiRegistroLabel = new Label();
            telefonoRegistroTexBox = new TextBox();
            telefonoRegistroLabel = new Label();
            correoRegistroTexBox = new TextBox();
            correoRegistroLabel = new Label();
            tittle2Label = new Label();
            nombreRegistroTexBox = new TextBox();
            NombreRegistroLabel = new Label();
            goldPanel = new Panel();
            informeEstudianteButton = new Button();
            estudiantesLabel = new Label();
            estudiantesComboBox = new ComboBox();
            correoTexBox = new TextBox();
            correoEstudianteLabel = new Label();
            duiTexBox = new TextBox();
            duiEstudianteLabel = new Label();
            tittleLabel = new Label();
            bluePanel.SuspendLayout();
            goldPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bluePanel
            // 
            bluePanel.BackColor = SystemColors.HotTrack;
            bluePanel.Controls.Add(agregarEstudianteButton);
            bluePanel.Controls.Add(duiRegistroTexBox);
            bluePanel.Controls.Add(duiRegistroLabel);
            bluePanel.Controls.Add(telefonoRegistroTexBox);
            bluePanel.Controls.Add(telefonoRegistroLabel);
            bluePanel.Controls.Add(correoRegistroTexBox);
            bluePanel.Controls.Add(correoRegistroLabel);
            bluePanel.Controls.Add(tittle2Label);
            bluePanel.Controls.Add(nombreRegistroTexBox);
            bluePanel.Controls.Add(NombreRegistroLabel);
            bluePanel.Location = new Point(1, 0);
            bluePanel.Name = "bluePanel";
            bluePanel.Size = new Size(408, 371);
            bluePanel.TabIndex = 0;
            // 
            // agregarEstudianteButton
            // 
            agregarEstudianteButton.BackColor = Color.Gold;
            agregarEstudianteButton.Location = new Point(114, 311);
            agregarEstudianteButton.Name = "agregarEstudianteButton";
            agregarEstudianteButton.Size = new Size(178, 39);
            agregarEstudianteButton.TabIndex = 15;
            agregarEstudianteButton.Text = "Agregar Estudiante";
            agregarEstudianteButton.UseVisualStyleBackColor = false;
            agregarEstudianteButton.Click += agregarEstudianteButton_Click;
            // 
            // duiRegistroTexBox
            // 
            duiRegistroTexBox.Location = new Point(116, 210);
            duiRegistroTexBox.Name = "duiRegistroTexBox";
            duiRegistroTexBox.Size = new Size(268, 29);
            duiRegistroTexBox.TabIndex = 12;
            // 
            // duiRegistroLabel
            // 
            duiRegistroLabel.AutoSize = true;
            duiRegistroLabel.Location = new Point(20, 218);
            duiRegistroLabel.Name = "duiRegistroLabel";
            duiRegistroLabel.Size = new Size(39, 21);
            duiRegistroLabel.TabIndex = 11;
            duiRegistroLabel.Text = "DUI";
            // 
            // telefonoRegistroTexBox
            // 
            telefonoRegistroTexBox.Location = new Point(116, 154);
            telefonoRegistroTexBox.Name = "telefonoRegistroTexBox";
            telefonoRegistroTexBox.Size = new Size(268, 29);
            telefonoRegistroTexBox.TabIndex = 10;
            // 
            // telefonoRegistroLabel
            // 
            telefonoRegistroLabel.AutoSize = true;
            telefonoRegistroLabel.Location = new Point(20, 162);
            telefonoRegistroLabel.Name = "telefonoRegistroLabel";
            telefonoRegistroLabel.Size = new Size(77, 21);
            telefonoRegistroLabel.TabIndex = 9;
            telefonoRegistroLabel.Text = "Telefono";
            // 
            // correoRegistroTexBox
            // 
            correoRegistroTexBox.Location = new Point(114, 102);
            correoRegistroTexBox.Name = "correoRegistroTexBox";
            correoRegistroTexBox.Size = new Size(268, 29);
            correoRegistroTexBox.TabIndex = 8;
            // 
            // correoRegistroLabel
            // 
            correoRegistroLabel.AutoSize = true;
            correoRegistroLabel.Location = new Point(20, 110);
            correoRegistroLabel.Name = "correoRegistroLabel";
            correoRegistroLabel.Size = new Size(65, 21);
            correoRegistroLabel.TabIndex = 7;
            correoRegistroLabel.Text = "Correo ";
            // 
            // tittle2Label
            // 
            tittle2Label.AutoSize = true;
            tittle2Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tittle2Label.Location = new Point(206, 9);
            tittle2Label.Name = "tittle2Label";
            tittle2Label.Size = new Size(199, 30);
            tittle2Label.TabIndex = 4;
            tittle2Label.Text = "Sistema de Manejo";
            // 
            // nombreRegistroTexBox
            // 
            nombreRegistroTexBox.Location = new Point(114, 48);
            nombreRegistroTexBox.Name = "nombreRegistroTexBox";
            nombreRegistroTexBox.Size = new Size(268, 29);
            nombreRegistroTexBox.TabIndex = 3;
            // 
            // NombreRegistroLabel
            // 
            NombreRegistroLabel.AutoSize = true;
            NombreRegistroLabel.Location = new Point(20, 56);
            NombreRegistroLabel.Name = "NombreRegistroLabel";
            NombreRegistroLabel.Size = new Size(80, 21);
            NombreRegistroLabel.TabIndex = 2;
            NombreRegistroLabel.Text = "Nombres";
            // 
            // goldPanel
            // 
            goldPanel.BackColor = Color.Gold;
            goldPanel.Controls.Add(informeEstudianteButton);
            goldPanel.Controls.Add(estudiantesLabel);
            goldPanel.Controls.Add(estudiantesComboBox);
            goldPanel.Controls.Add(correoTexBox);
            goldPanel.Controls.Add(correoEstudianteLabel);
            goldPanel.Controls.Add(duiTexBox);
            goldPanel.Controls.Add(duiEstudianteLabel);
            goldPanel.Controls.Add(tittleLabel);
            goldPanel.Location = new Point(408, 0);
            goldPanel.Name = "goldPanel";
            goldPanel.Size = new Size(409, 368);
            goldPanel.TabIndex = 2;
            // 
            // informeEstudianteButton
            // 
            informeEstudianteButton.BackColor = SystemColors.HotTrack;
            informeEstudianteButton.Location = new Point(120, 311);
            informeEstudianteButton.Name = "informeEstudianteButton";
            informeEstudianteButton.Size = new Size(178, 39);
            informeEstudianteButton.TabIndex = 16;
            informeEstudianteButton.Text = "Informe Estudiante";
            informeEstudianteButton.UseVisualStyleBackColor = false;
            informeEstudianteButton.Click += informeEstudianteButton_Click;
            // 
            // estudiantesLabel
            // 
            estudiantesLabel.AutoSize = true;
            estudiantesLabel.Location = new Point(23, 154);
            estudiantesLabel.Name = "estudiantesLabel";
            estudiantesLabel.Size = new Size(92, 21);
            estudiantesLabel.TabIndex = 14;
            estudiantesLabel.Text = "En Listado:";
            // 
            // estudiantesComboBox
            // 
            estudiantesComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            estudiantesComboBox.FormattingEnabled = true;
            estudiantesComboBox.Location = new Point(121, 146);
            estudiantesComboBox.Name = "estudiantesComboBox";
            estudiantesComboBox.Size = new Size(268, 29);
            estudiantesComboBox.TabIndex = 13;
            estudiantesComboBox.SelectedIndexChanged += estudiantesComboBox_SelectedIndexChanged;
            // 
            // correoTexBox
            // 
            correoTexBox.Location = new Point(120, 94);
            correoTexBox.Name = "correoTexBox";
            correoTexBox.Size = new Size(268, 29);
            correoTexBox.TabIndex = 12;
            // 
            // correoEstudianteLabel
            // 
            correoEstudianteLabel.AutoSize = true;
            correoEstudianteLabel.Location = new Point(24, 102);
            correoEstudianteLabel.Name = "correoEstudianteLabel";
            correoEstudianteLabel.Size = new Size(65, 21);
            correoEstudianteLabel.TabIndex = 11;
            correoEstudianteLabel.Text = "Correo ";
            // 
            // duiTexBox
            // 
            duiTexBox.Location = new Point(120, 48);
            duiTexBox.Name = "duiTexBox";
            duiTexBox.Size = new Size(268, 29);
            duiTexBox.TabIndex = 10;
            // 
            // duiEstudianteLabel
            // 
            duiEstudianteLabel.AutoSize = true;
            duiEstudianteLabel.Location = new Point(24, 56);
            duiEstudianteLabel.Name = "duiEstudianteLabel";
            duiEstudianteLabel.Size = new Size(39, 21);
            duiEstudianteLabel.TabIndex = 9;
            duiEstudianteLabel.Text = "DUI";
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tittleLabel.Location = new Point(0, 9);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(155, 30);
            tittleLabel.TabIndex = 5;
            tittleLabel.Text = "de Estudiantes";
            // 
            // SystemManage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 371);
            Controls.Add(goldPanel);
            Controls.Add(bluePanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SystemManage";
            Text = "System Manage";
            bluePanel.ResumeLayout(false);
            bluePanel.PerformLayout();
            goldPanel.ResumeLayout(false);
            goldPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel bluePanel;
        private Panel goldPanel;
        private Label tittle2Label;
        private TextBox nombreRegistroTexBox;
        private Label NombreRegistroLabel;
        private Label tittleLabel;
        private TextBox telefonoRegistroTexBox;
        private Label telefonoRegistroLabel;
        private TextBox correoRegistroTexBox;
        private Label correoRegistroLabel;
        private TextBox duiRegistroTexBox;
        private Label duiRegistroLabel;
        private TextBox correoTexBox;
        private Label correoEstudianteLabel;
        private TextBox duiTexBox;
        private Label duiEstudianteLabel;
        private Label estudiantesLabel;
        private ComboBox estudiantesComboBox;
        private Button agregarEstudianteButton;
        private Button informeEstudianteButton;
    }
}
