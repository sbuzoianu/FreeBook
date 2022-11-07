
namespace FreeBook
{
    partial class FreeBook
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
            this.labelFormLoad = new System.Windows.Forms.Label();
            this.btn_Click = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.labelFormClick = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFormLoad
            // 
            this.labelFormLoad.AutoSize = true;
            this.labelFormLoad.Location = new System.Drawing.Point(45, 44);
            this.labelFormLoad.Name = "labelFormLoad";
            this.labelFormLoad.Size = new System.Drawing.Size(38, 15);
            this.labelFormLoad.TabIndex = 0;
            this.labelFormLoad.Text = "label1";
            // 
            // btn_Click
            // 
            this.btn_Click.Location = new System.Drawing.Point(58, 198);
            this.btn_Click.Name = "btn_Click";
            this.btn_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_Click.TabIndex = 1;
            this.btn_Click.Text = "Click me!";
            this.btn_Click.UseVisualStyleBackColor = true;
            this.btn_Click.Click += new System.EventHandler(this.btn_Click_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(240, 198);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear all!";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(424, 198);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save all";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelFormClick
            // 
            this.labelFormClick.AutoSize = true;
            this.labelFormClick.Location = new System.Drawing.Point(45, 84);
            this.labelFormClick.Name = "labelFormClick";
            this.labelFormClick.Size = new System.Drawing.Size(38, 15);
            this.labelFormClick.TabIndex = 4;
            this.labelFormClick.Text = "label2";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Exit.Location = new System.Drawing.Point(424, 44);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // FreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 261);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.labelFormClick);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Click);
            this.Controls.Add(this.labelFormLoad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FreeBook";
            this.Text = "FreeBook";
            this.Load += new System.EventHandler(this.FreeBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFormLoad;
        private System.Windows.Forms.Button btn_Click;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label labelFormClick;
        private System.Windows.Forms.Button btn_Exit;
    }
}

