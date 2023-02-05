namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnBrowse = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCreate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDisplay = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCopyMove = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(797, 448);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AnimationHoverSpeed = 0.07F;
            this.btnBrowse.AnimationSpeed = 0.03F;
            this.btnBrowse.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBrowse.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBrowse.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBrowse.CheckedForeColor = System.Drawing.Color.White;
            this.btnBrowse.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.CheckedImage")));
            this.btnBrowse.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBrowse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBrowse.Location = new System.Drawing.Point(60, 473);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBrowse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBrowse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBrowse.OnHoverImage = null;
            this.btnBrowse.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBrowse.OnPressedColor = System.Drawing.Color.Black;
            this.btnBrowse.Size = new System.Drawing.Size(93, 32);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Listele";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSearch.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.CheckedImage")));
            this.btnSearch.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.Location = new System.Drawing.Point(60, 511);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(93, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Ara";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.AnimationHoverSpeed = 0.07F;
            this.btnCreate.AnimationSpeed = 0.03F;
            this.btnCreate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCreate.BorderColor = System.Drawing.Color.Black;
            this.btnCreate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCreate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCreate.CheckedForeColor = System.Drawing.Color.White;
            this.btnCreate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.CheckedImage")));
            this.btnCreate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreate.FocusedColor = System.Drawing.Color.Empty;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCreate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCreate.Location = new System.Drawing.Point(179, 473);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCreate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCreate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCreate.OnHoverImage = null;
            this.btnCreate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCreate.OnPressedColor = System.Drawing.Color.Black;
            this.btnCreate.Size = new System.Drawing.Size(111, 32);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Yeni Klasör";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.CheckedImage")));
            this.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.Location = new System.Drawing.Point(179, 513);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(111, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Klasör Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.CheckedImage")));
            this.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdate.Location = new System.Drawing.Point(316, 473);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(142, 32);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Yeniden Adlandır";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.AnimationHoverSpeed = 0.07F;
            this.btnDisplay.AnimationSpeed = 0.03F;
            this.btnDisplay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDisplay.BorderColor = System.Drawing.Color.Black;
            this.btnDisplay.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDisplay.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDisplay.CheckedForeColor = System.Drawing.Color.White;
            this.btnDisplay.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDisplay.CheckedImage")));
            this.btnDisplay.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDisplay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDisplay.FocusedColor = System.Drawing.Color.Empty;
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplay.Image")));
            this.btnDisplay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDisplay.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDisplay.Location = new System.Drawing.Point(316, 511);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDisplay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDisplay.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDisplay.OnHoverImage = null;
            this.btnDisplay.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDisplay.OnPressedColor = System.Drawing.Color.Black;
            this.btnDisplay.Size = new System.Drawing.Size(142, 32);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Görüntüle";
            this.btnDisplay.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCopyMove
            // 
            this.btnCopyMove.AnimationHoverSpeed = 0.07F;
            this.btnCopyMove.AnimationSpeed = 0.03F;
            this.btnCopyMove.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCopyMove.BorderColor = System.Drawing.Color.Black;
            this.btnCopyMove.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCopyMove.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCopyMove.CheckedForeColor = System.Drawing.Color.White;
            this.btnCopyMove.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCopyMove.CheckedImage")));
            this.btnCopyMove.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCopyMove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCopyMove.FocusedColor = System.Drawing.Color.Empty;
            this.btnCopyMove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCopyMove.ForeColor = System.Drawing.Color.White;
            this.btnCopyMove.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyMove.Image")));
            this.btnCopyMove.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCopyMove.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCopyMove.Location = new System.Drawing.Point(483, 473);
            this.btnCopyMove.Name = "btnCopyMove";
            this.btnCopyMove.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCopyMove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCopyMove.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCopyMove.OnHoverImage = null;
            this.btnCopyMove.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCopyMove.OnPressedColor = System.Drawing.Color.Black;
            this.btnCopyMove.Size = new System.Drawing.Size(111, 32);
            this.btnCopyMove.TabIndex = 8;
            this.btnCopyMove.Text = "Görüntüle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.btnCopyMove);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zesty File Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private Guna.UI.WinForms.GunaAdvenceButton btnBrowse;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnCreate;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdate;
        private Guna.UI.WinForms.GunaAdvenceButton btnDisplay;
        private Guna.UI.WinForms.GunaAdvenceButton btnCopyMove;
    }
}

