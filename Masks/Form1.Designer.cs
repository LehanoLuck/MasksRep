namespace Masks
{
    partial class Form1
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
            this.CharacterPicture = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CharacterPicture
            // 
            this.CharacterPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CharacterPicture.BackgroundImage = global::Masks.Properties.Resources.errorimage;
            this.CharacterPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CharacterPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharacterPicture.Location = new System.Drawing.Point(0, 0);
            this.CharacterPicture.Name = "CharacterPicture";
            this.CharacterPicture.Size = new System.Drawing.Size(829, 523);
            this.CharacterPicture.TabIndex = 0;
            this.CharacterPicture.TabStop = false;
            this.CharacterPicture.Click += new System.EventHandler(this.CharacterPicture_Click);
            this.CharacterPicture.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CharacterPicture_PreviewKeyDown);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NameLabel.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(0, 454);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(829, 69);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "PSY";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            this.NameLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.NameLabel_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 523);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CharacterPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Mask";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CharacterPicture;
        private System.Windows.Forms.Label NameLabel;
    }
}

