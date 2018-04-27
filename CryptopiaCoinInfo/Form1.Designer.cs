namespace CryptopiaCoinInfo
{
    partial class Form1
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
            this.textBoxEndpoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetInfo = new System.Windows.Forms.Button();
            this.dataGridViewBuy = new System.Windows.Forms.DataGridView();
            this.dataGridViewSell = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalBTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStopTimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSell)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEndpoint
            // 
            this.textBoxEndpoint.Location = new System.Drawing.Point(70, 41);
            this.textBoxEndpoint.Name = "textBoxEndpoint";
            this.textBoxEndpoint.Size = new System.Drawing.Size(642, 20);
            this.textBoxEndpoint.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Endpoint :";
            // 
            // buttonGetInfo
            // 
            this.buttonGetInfo.Location = new System.Drawing.Point(718, 26);
            this.buttonGetInfo.Name = "buttonGetInfo";
            this.buttonGetInfo.Size = new System.Drawing.Size(94, 49);
            this.buttonGetInfo.TabIndex = 2;
            this.buttonGetInfo.Text = "Get Info";
            this.buttonGetInfo.UseVisualStyleBackColor = true;
            this.buttonGetInfo.Click += new System.EventHandler(this.buttonGetInfo_ClickAsync);
            // 
            // dataGridViewBuy
            // 
            this.dataGridViewBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPrice,
            this.ColumnTotalBTC});
            this.dataGridViewBuy.Location = new System.Drawing.Point(12, 219);
            this.dataGridViewBuy.Name = "dataGridViewBuy";
            this.dataGridViewBuy.Size = new System.Drawing.Size(381, 215);
            this.dataGridViewBuy.TabIndex = 4;
            // 
            // dataGridViewSell
            // 
            this.dataGridViewSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewSell.Location = new System.Drawing.Point(431, 219);
            this.dataGridViewSell.Name = "dataGridViewSell";
            this.dataGridViewSell.Size = new System.Drawing.Size(381, 215);
            this.dataGridViewSell.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sell";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // ColumnTotalBTC
            // 
            this.ColumnTotalBTC.HeaderText = "Total BTC";
            this.ColumnTotalBTC.Name = "ColumnTotalBTC";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Price";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Total BTC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // buttonStopTimer
            // 
            this.buttonStopTimer.Location = new System.Drawing.Point(718, 81);
            this.buttonStopTimer.Name = "buttonStopTimer";
            this.buttonStopTimer.Size = new System.Drawing.Size(94, 49);
            this.buttonStopTimer.TabIndex = 8;
            this.buttonStopTimer.Text = "Stop Timer";
            this.buttonStopTimer.UseVisualStyleBackColor = true;
            this.buttonStopTimer.Click += new System.EventHandler(this.buttonStopTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 574);
            this.Controls.Add(this.buttonStopTimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSell);
            this.Controls.Add(this.dataGridViewBuy);
            this.Controls.Add(this.buttonGetInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEndpoint);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEndpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetInfo;
        private System.Windows.Forms.DataGridView dataGridViewBuy;
        private System.Windows.Forms.DataGridView dataGridViewSell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalBTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonStopTimer;
    }
}

