namespace PasswordGen
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            _generate_button = new Button();
            _length_slider = new TrackBar();
            _output_box = new RichTextBox();
            _length_slider_label = new Label();
            _include_uppercase_checkbox = new CheckBox();
            _include_lowercase_checkbox = new CheckBox();
            _include_numbers_checkbox = new CheckBox();
            _include_sc_checkbox = new CheckBox();
            _start_with_letter_checkbox = new CheckBox();
            _include_sc_textbox = new TextBox();
            _password_strength = new Label();
            ((System.ComponentModel.ISupportInitialize)_length_slider).BeginInit();
            SuspendLayout();
            // 
            // _generate_button
            // 
            _generate_button.Location = new Point(323, 212);
            _generate_button.Name = "_generate_button";
            _generate_button.Size = new Size(75, 23);
            _generate_button.TabIndex = 1;
            _generate_button.Text = "Generate";
            _generate_button.UseVisualStyleBackColor = true;
            _generate_button.Click += _generate_button_Click;
            // 
            // _length_slider
            // 
            _length_slider.LargeChange = 4;
            _length_slider.Location = new Point(12, 12);
            _length_slider.Maximum = 64;
            _length_slider.Minimum = 1;
            _length_slider.Name = "_length_slider";
            _length_slider.Size = new Size(735, 45);
            _length_slider.TabIndex = 0;
            _length_slider.Value = 16;
            _length_slider.Scroll += _length_slider_Scroll;
            // 
            // _output_box
            // 
            _output_box.DetectUrls = false;
            _output_box.Font = new Font("Mustica Pro SemBd", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _output_box.Location = new Point(12, 255);
            _output_box.Multiline = false;
            _output_box.Name = "_output_box";
            _output_box.Size = new Size(735, 29);
            _output_box.TabIndex = 2;
            _output_box.Text = "";
            // 
            // _length_slider_label
            // 
            _length_slider_label.AutoSize = true;
            _length_slider_label.Location = new Point(305, 60);
            _length_slider_label.Name = "_length_slider_label";
            _length_slider_label.Size = new Size(107, 15);
            _length_slider_label.TabIndex = 3;
            _length_slider_label.Text = "Password length: X";
            // 
            // _include_uppercase_checkbox
            // 
            _include_uppercase_checkbox.AutoSize = true;
            _include_uppercase_checkbox.Checked = true;
            _include_uppercase_checkbox.CheckState = CheckState.Checked;
            _include_uppercase_checkbox.Location = new Point(12, 73);
            _include_uppercase_checkbox.Name = "_include_uppercase_checkbox";
            _include_uppercase_checkbox.Size = new Size(122, 19);
            _include_uppercase_checkbox.TabIndex = 5;
            _include_uppercase_checkbox.Text = "Include uppercase";
            _include_uppercase_checkbox.UseVisualStyleBackColor = true;
            // 
            // _include_lowercase_checkbox
            // 
            _include_lowercase_checkbox.AutoSize = true;
            _include_lowercase_checkbox.Checked = true;
            _include_lowercase_checkbox.CheckState = CheckState.Checked;
            _include_lowercase_checkbox.Location = new Point(12, 98);
            _include_lowercase_checkbox.Name = "_include_lowercase_checkbox";
            _include_lowercase_checkbox.Size = new Size(120, 19);
            _include_lowercase_checkbox.TabIndex = 6;
            _include_lowercase_checkbox.Text = "Include lowercase";
            _include_lowercase_checkbox.UseVisualStyleBackColor = true;
            // 
            // _include_numbers_checkbox
            // 
            _include_numbers_checkbox.AutoSize = true;
            _include_numbers_checkbox.Checked = true;
            _include_numbers_checkbox.CheckState = CheckState.Checked;
            _include_numbers_checkbox.Location = new Point(12, 123);
            _include_numbers_checkbox.Name = "_include_numbers_checkbox";
            _include_numbers_checkbox.Size = new Size(115, 19);
            _include_numbers_checkbox.TabIndex = 7;
            _include_numbers_checkbox.Text = "Include numbers";
            _include_numbers_checkbox.UseVisualStyleBackColor = true;
            // 
            // _include_sc_checkbox
            // 
            _include_sc_checkbox.AutoSize = true;
            _include_sc_checkbox.Checked = true;
            _include_sc_checkbox.CheckState = CheckState.Checked;
            _include_sc_checkbox.Location = new Point(12, 148);
            _include_sc_checkbox.Name = "_include_sc_checkbox";
            _include_sc_checkbox.Size = new Size(161, 19);
            _include_sc_checkbox.TabIndex = 8;
            _include_sc_checkbox.Text = "Include special characters";
            _include_sc_checkbox.UseVisualStyleBackColor = true;
            _include_sc_checkbox.CheckedChanged += _include_sc_checkbox_CheckedChanged;
            // 
            // _start_with_letter_checkbox
            // 
            _start_with_letter_checkbox.AutoSize = true;
            _start_with_letter_checkbox.Checked = true;
            _start_with_letter_checkbox.CheckState = CheckState.Checked;
            _start_with_letter_checkbox.Location = new Point(12, 173);
            _start_with_letter_checkbox.Name = "_start_with_letter_checkbox";
            _start_with_letter_checkbox.Size = new Size(168, 19);
            _start_with_letter_checkbox.TabIndex = 9;
            _start_with_letter_checkbox.Text = "Start password with a letter";
            _start_with_letter_checkbox.UseVisualStyleBackColor = true;
            // 
            // _include_sc_textbox
            // 
            _include_sc_textbox.BorderStyle = BorderStyle.FixedSingle;
            _include_sc_textbox.Font = new Font("Segoe UI", 9F);
            _include_sc_textbox.Location = new Point(183, 146);
            _include_sc_textbox.Name = "_include_sc_textbox";
            _include_sc_textbox.Size = new Size(172, 23);
            _include_sc_textbox.TabIndex = 10;
            _include_sc_textbox.Text = "!_$";
            // 
            // _password_strength
            // 
            _password_strength.AutoSize = true;
            _password_strength.Location = new Point(301, 77);
            _password_strength.Name = "_password_strength";
            _password_strength.Size = new Size(116, 15);
            _password_strength.TabIndex = 11;
            _password_strength.Text = "Password strength: 0";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(763, 304);
            Controls.Add(_password_strength);
            Controls.Add(_include_sc_textbox);
            Controls.Add(_start_with_letter_checkbox);
            Controls.Add(_include_sc_checkbox);
            Controls.Add(_include_numbers_checkbox);
            Controls.Add(_include_lowercase_checkbox);
            Controls.Add(_include_uppercase_checkbox);
            Controls.Add(_length_slider_label);
            Controls.Add(_output_box);
            Controls.Add(_length_slider);
            Controls.Add(_generate_button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            Text = "PasswordGen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)_length_slider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _generate_button;
        private TrackBar _length_slider;
        private RichTextBox _output_box;
        private Label _length_slider_label;
        private CheckBox _include_uppercase_checkbox;
        private CheckBox _include_lowercase_checkbox;
        private CheckBox _include_numbers_checkbox;
        private CheckBox _include_sc_checkbox;
        private CheckBox _start_with_letter_checkbox;
        private TextBox _include_sc_textbox;
        private Label _password_strength;
    }
}
