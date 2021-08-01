
namespace OverlayDrawing
{
    partial class ControlsForm
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
            this.drawPointButton = new System.Windows.Forms.Button();
            this.locationTestLabel = new System.Windows.Forms.Label();
            this.renderButton = new System.Windows.Forms.Button();
            this.drawParabolaButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.polyButton = new System.Windows.Forms.Button();
            this.degreeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.degreeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // drawPointButton
            // 
            this.drawPointButton.Location = new System.Drawing.Point(13, 13);
            this.drawPointButton.Name = "drawPointButton";
            this.drawPointButton.Size = new System.Drawing.Size(140, 63);
            this.drawPointButton.TabIndex = 0;
            this.drawPointButton.Text = "Draw Point";
            this.drawPointButton.UseVisualStyleBackColor = true;
            this.drawPointButton.Click += new System.EventHandler(this.drawPointButton_Click);
            // 
            // locationTestLabel
            // 
            this.locationTestLabel.AutoSize = true;
            this.locationTestLabel.Location = new System.Drawing.Point(12, 266);
            this.locationTestLabel.Name = "locationTestLabel";
            this.locationTestLabel.Size = new System.Drawing.Size(51, 20);
            this.locationTestLabel.TabIndex = 1;
            this.locationTestLabel.Text = "label1";
            // 
            // renderButton
            // 
            this.renderButton.Location = new System.Drawing.Point(181, 475);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(137, 50);
            this.renderButton.TabIndex = 2;
            this.renderButton.Text = "Render";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
            // 
            // drawParabolaButton
            // 
            this.drawParabolaButton.Location = new System.Drawing.Point(16, 91);
            this.drawParabolaButton.Name = "drawParabolaButton";
            this.drawParabolaButton.Size = new System.Drawing.Size(137, 61);
            this.drawParabolaButton.TabIndex = 3;
            this.drawParabolaButton.Text = "Draw Parabola";
            this.drawParabolaButton.UseVisualStyleBackColor = true;
            this.drawParabolaButton.Click += new System.EventHandler(this.drawParabolaButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(16, 475);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 50);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // polyButton
            // 
            this.polyButton.Location = new System.Drawing.Point(16, 172);
            this.polyButton.Name = "polyButton";
            this.polyButton.Size = new System.Drawing.Size(137, 65);
            this.polyButton.TabIndex = 5;
            this.polyButton.Text = "Draw Polynomial";
            this.polyButton.UseVisualStyleBackColor = true;
            this.polyButton.Click += new System.EventHandler(this.polyButton_Click);
            // 
            // degreeUpDown
            // 
            this.degreeUpDown.Location = new System.Drawing.Point(181, 211);
            this.degreeUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.degreeUpDown.Name = "degreeUpDown";
            this.degreeUpDown.Size = new System.Drawing.Size(120, 26);
            this.degreeUpDown.TabIndex = 6;
            this.degreeUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Degree:";
            // 
            // ControlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degreeUpDown);
            this.Controls.Add(this.polyButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.drawParabolaButton);
            this.Controls.Add(this.renderButton);
            this.Controls.Add(this.locationTestLabel);
            this.Controls.Add(this.drawPointButton);
            this.Name = "ControlsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Controls";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.degreeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawPointButton;
        private System.Windows.Forms.Label locationTestLabel;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.Button drawParabolaButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button polyButton;
        private System.Windows.Forms.NumericUpDown degreeUpDown;
        private System.Windows.Forms.Label label1;
    }
}