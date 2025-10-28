namespace BOOSEide
{
    partial class Form1
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
            booseInput = new TextBox();
            runButton = new Button();
            clearButton = new Button();
            pictureBoxCanvas = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).BeginInit();
            SuspendLayout();
            // 
            // booseInput
            // 
            booseInput.Location = new Point(12, 12);
            booseInput.Multiline = true;
            booseInput.Name = "booseInput";
            booseInput.PlaceholderText = "Type BOOSE code";
            booseInput.Size = new Size(249, 541);
            booseInput.TabIndex = 0;
            // 
            // runButton
            // 
            runButton.Location = new Point(12, 559);
            runButton.Name = "runButton";
            runButton.Size = new Size(122, 29);
            runButton.TabIndex = 1;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(140, 559);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(122, 29);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // pictureBoxCanvas
            // 
            pictureBoxCanvas.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxCanvas.Location = new Point(267, 12);
            pictureBoxCanvas.Name = "pictureBoxCanvas";
            pictureBoxCanvas.Size = new Size(635, 576);
            pictureBoxCanvas.TabIndex = 3;
            pictureBoxCanvas.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBoxCanvas);
            Controls.Add(clearButton);
            Controls.Add(runButton);
            Controls.Add(booseInput);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox booseInput;
        private Button runButton;
        private Button clearButton;
        private PictureBox picture;
        private PictureBox pictureBoxCanvas;
    }
}
