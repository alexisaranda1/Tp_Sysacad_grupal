﻿namespace Formularios
{
    partial class FormPanelEstudiante
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
            label1 = new Label();
            btnAgregarCurso = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(287, 30);
            label1.Name = "label1";
            label1.Size = new Size(282, 32);
            label1.TabIndex = 0;
            label1.Text = "Administrador Estudiante";
            label1.Click += label1_Click;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.BackColor = SystemColors.ButtonHighlight;
            btnAgregarCurso.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarCurso.Location = new Point(12, 121);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(193, 34);
            btnAgregarCurso.TabIndex = 1;
            btnAgregarCurso.Text = "Inscripcion a curso";
            btnAgregarCurso.UseVisualStyleBackColor = false;
            // 
            // FormPanelEstudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(btnAgregarCurso);
            Controls.Add(label1);
            Name = "FormPanelEstudiante";
            Text = "FormPanelEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregarCurso;
    }
}