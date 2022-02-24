
namespace CocktailBlog
{
    partial class UpdateCocktail
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ImgCocktail = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCocktail)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.TxtName.Location = new System.Drawing.Point(12, 50);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(351, 38);
            this.TxtName.TabIndex = 0;
            // 
            // TxtInfo
            // 
            this.TxtInfo.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.TxtInfo.Location = new System.Drawing.Point(12, 156);
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.Size = new System.Drawing.Size(638, 318);
            this.TxtInfo.TabIndex = 1;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(7, 16);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(124, 25);
            this.LblUserName.TabIndex = 8;
            this.LblUserName.Text = "Cocktail name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cocktail info";
            // 
            // ImgCocktail
            // 
            this.ImgCocktail.Location = new System.Drawing.Point(694, 50);
            this.ImgCocktail.Name = "ImgCocktail";
            this.ImgCocktail.Size = new System.Drawing.Size(413, 641);
            this.ImgCocktail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCocktail.TabIndex = 10;
            this.ImgCocktail.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(12, 496);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(96, 38);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // UpdateCocktail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 761);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.ImgCocktail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.TxtName);
            this.Name = "UpdateCocktail";
            this.Text = "UpdateCocktail";
            ((System.ComponentModel.ISupportInitialize)(this.ImgCocktail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImgCocktail;
        private System.Windows.Forms.Button BtnSave;
    }
}