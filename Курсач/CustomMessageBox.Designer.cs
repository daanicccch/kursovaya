namespace Курсач
{
    partial class CustomMessageBox
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
            closeButton=new Button();
            messageLabel=new Label();
            pictureBox1=new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location=new Point(415, 117);
            closeButton.Name="closeButton";
            closeButton.Size=new Size(108, 34);
            closeButton.TabIndex=0;
            closeButton.Text="OK";
            closeButton.UseVisualStyleBackColor=true;
            closeButton.Click+=closeButton_Click_1;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize=true;
            messageLabel.Location=new Point(69, 68);
            messageLabel.Name="messageLabel";
            messageLabel.Size=new Size(0, 20);
            messageLabel.TabIndex=1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources._0c6e112c8a20034216df9cea26bc11ff;
            pictureBox1.Location=new Point(407, 117);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(116, 37);
            pictureBox1.TabIndex=2;
            pictureBox1.TabStop=false;
            pictureBox1.Visible=false;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(535, 166);
            Controls.Add(pictureBox1);
            Controls.Add(messageLabel);
            Controls.Add(closeButton);
            Name="CustomMessageBox";
            Text="CustomMessageBox";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Label messageLabel;
        private PictureBox pictureBox1;
    }
}