namespace nvidia_color_profiles {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dvLabel = new System.Windows.Forms.Label();
      this.dvTrackBar = new System.Windows.Forms.TrackBar();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.displayComboBox = new System.Windows.Forms.ComboBox();
      this.hueLabel = new System.Windows.Forms.Label();
      this.hueTrackBar = new System.Windows.Forms.TrackBar();
      this.label6 = new System.Windows.Forms.Label();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dvTrackBar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.hueTrackBar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.hueLabel);
      this.groupBox1.Controls.Add(this.hueTrackBar);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.dvLabel);
      this.groupBox1.Controls.Add(this.dvTrackBar);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(12, 47);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(319, 142);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      // 
      // dvLabel
      // 
      this.dvLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.dvLabel.Location = new System.Drawing.Point(252, 19);
      this.dvLabel.Name = "dvLabel";
      this.dvLabel.Size = new System.Drawing.Size(55, 13);
      this.dvLabel.TabIndex = 2;
      this.dvLabel.Text = "1 %";
      this.dvLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // dvTrackBar
      // 
      this.dvTrackBar.Location = new System.Drawing.Point(6, 35);
      this.dvTrackBar.Maximum = 100;
      this.dvTrackBar.Name = "dvTrackBar";
      this.dvTrackBar.Size = new System.Drawing.Size(307, 45);
      this.dvTrackBar.TabIndex = 1;
      this.dvTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
      this.dvTrackBar.ValueChanged += new System.EventHandler(this.dvTrackBar_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 19);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Digital vibrance:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 12);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Display:";
      // 
      // displayComboBox
      // 
      this.displayComboBox.CausesValidation = false;
      this.displayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.displayComboBox.FormattingEnabled = true;
      this.displayComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.displayComboBox.Location = new System.Drawing.Point(18, 28);
      this.displayComboBox.Name = "displayComboBox";
      this.displayComboBox.Size = new System.Drawing.Size(188, 21);
      this.displayComboBox.TabIndex = 4;
      // 
      // hueLabel
      // 
      this.hueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.hueLabel.Location = new System.Drawing.Point(259, 70);
      this.hueLabel.Name = "hueLabel";
      this.hueLabel.Size = new System.Drawing.Size(48, 13);
      this.hueLabel.TabIndex = 5;
      this.hueLabel.Text = "0°";
      this.hueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // hueTrackBar
      // 
      this.hueTrackBar.Location = new System.Drawing.Point(6, 86);
      this.hueTrackBar.Maximum = 359;
      this.hueTrackBar.Name = "hueTrackBar";
      this.hueTrackBar.Size = new System.Drawing.Size(307, 45);
      this.hueTrackBar.TabIndex = 4;
      this.hueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
      this.hueTrackBar.ValueChanged += new System.EventHandler(this.hueTrackBar_ValueChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(14, 70);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(30, 13);
      this.label6.TabIndex = 3;
      this.label6.Text = "Hue:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(343, 202);
      this.Controls.Add(this.displayComboBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.groupBox1);
      this.Name = "MainForm";
      this.Text = "Nvidia color profiles";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dvTrackBar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.hueTrackBar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label dvLabel;
    private System.Windows.Forms.TrackBar dvTrackBar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox displayComboBox;
    private System.Windows.Forms.Label hueLabel;
    private System.Windows.Forms.TrackBar hueTrackBar;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.BindingSource bindingSource1;
  }
}

