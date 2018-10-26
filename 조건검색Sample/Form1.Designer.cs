namespace 조건검색Sample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.loginButton = new System.Windows.Forms.Button();
            this.requestConditionButton = new System.Windows.Forms.Button();
            this.conditionComboBox = new System.Windows.Forms.ComboBox();
            this.conditionSearchButton = new System.Windows.Forms.Button();
            this.conditionSearchListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.realConditionListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(726, 12);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(62, 18);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.AutoEllipsis = true;
            this.loginButton.Location = new System.Drawing.Point(13, 13);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "로그인";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // requestConditionButton
            // 
            this.requestConditionButton.Location = new System.Drawing.Point(104, 13);
            this.requestConditionButton.Name = "requestConditionButton";
            this.requestConditionButton.Size = new System.Drawing.Size(75, 23);
            this.requestConditionButton.TabIndex = 2;
            this.requestConditionButton.Text = "조건식 호출";
            this.requestConditionButton.UseVisualStyleBackColor = true;
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.Location = new System.Drawing.Point(13, 63);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(121, 21);
            this.conditionComboBox.TabIndex = 3;
            // 
            // conditionSearchButton
            // 
            this.conditionSearchButton.Location = new System.Drawing.Point(141, 63);
            this.conditionSearchButton.Name = "conditionSearchButton";
            this.conditionSearchButton.Size = new System.Drawing.Size(75, 23);
            this.conditionSearchButton.TabIndex = 4;
            this.conditionSearchButton.Text = "조건검색";
            this.conditionSearchButton.UseVisualStyleBackColor = true;
            // 
            // conditionSearchListBox
            // 
            this.conditionSearchListBox.FormattingEnabled = true;
            this.conditionSearchListBox.Location = new System.Drawing.Point(12, 152);
            this.conditionSearchListBox.Name = "conditionSearchListBox";
            this.conditionSearchListBox.Size = new System.Drawing.Size(367, 277);
            this.conditionSearchListBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "조건검색";
            // 
            // realConditionListBox
            // 
            this.realConditionListBox.FormattingEnabled = true;
            this.realConditionListBox.Location = new System.Drawing.Point(406, 153);
            this.realConditionListBox.Name = "realConditionListBox";
            this.realConditionListBox.Size = new System.Drawing.Size(381, 264);
            this.realConditionListBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "실시간 조건 종목";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.realConditionListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conditionSearchListBox);
            this.Controls.Add(this.conditionSearchButton);
            this.Controls.Add(this.conditionComboBox);
            this.Controls.Add(this.requestConditionButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button requestConditionButton;
        private System.Windows.Forms.ComboBox conditionComboBox;
        private System.Windows.Forms.Button conditionSearchButton;
        private System.Windows.Forms.ListBox conditionSearchListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox realConditionListBox;
        private System.Windows.Forms.Label label2;
    }
}

