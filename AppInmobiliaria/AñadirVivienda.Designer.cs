namespace Presentation
{
    partial class AñadirVivienda
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
            panel1 = new Panel();
            panel2 = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            tipoVivienda = new MaterialSkin.Controls.MaterialComboBox();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            areaTerraza = new MaterialSkin.Controls.MaterialTextBox2();
            cantidadArmarios = new MaterialSkin.Controls.MaterialTextBox2();
            materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
            calefaccionCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            gasCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            garajeCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            salonCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            cantidadBaños = new MaterialSkin.Controls.MaterialTextBox2();
            cantidadHabitaciones = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            materialCard2.SuspendLayout();
            materialCheckedListBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 100);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 513);
            panel2.Name = "panel2";
            panel2.Size = new Size(709, 100);
            panel2.TabIndex = 2;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(tipoVivienda);
            materialCard2.Controls.Add(materialButton2);
            materialCard2.Controls.Add(materialButton1);
            materialCard2.Controls.Add(areaTerraza);
            materialCard2.Controls.Add(cantidadArmarios);
            materialCard2.Controls.Add(materialCheckedListBox1);
            materialCard2.Controls.Add(cantidadBaños);
            materialCard2.Controls.Add(cantidadHabitaciones);
            materialCard2.Controls.Add(label1);
            materialCard2.Depth = 0;
            materialCard2.Font = new Font("Segoe UI", 20F);
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(17, 117);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(677, 361);
            materialCard2.TabIndex = 3;
            // 
            // tipoVivienda
            // 
            tipoVivienda.AutoResize = false;
            tipoVivienda.BackColor = Color.FromArgb(255, 255, 255);
            tipoVivienda.Depth = 0;
            tipoVivienda.DrawMode = DrawMode.OwnerDrawVariable;
            tipoVivienda.DropDownHeight = 174;
            tipoVivienda.DropDownStyle = ComboBoxStyle.DropDownList;
            tipoVivienda.DropDownWidth = 121;
            tipoVivienda.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            tipoVivienda.ForeColor = Color.FromArgb(222, 0, 0, 0);
            tipoVivienda.FormattingEnabled = true;
            tipoVivienda.IntegralHeight = false;
            tipoVivienda.ItemHeight = 43;
            tipoVivienda.Items.AddRange(new object[] { "Casa", "Piso", "Villa" });
            tipoVivienda.Location = new Point(66, 217);
            tipoVivienda.MaxDropDownItems = 4;
            tipoVivienda.MouseState = MaterialSkin.MouseState.OUT;
            tipoVivienda.Name = "tipoVivienda";
            tipoVivienda.Size = new Size(126, 49);
            tipoVivienda.StartIndex = 0;
            tipoVivienda.TabIndex = 9;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(518, 305);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(96, 36);
            materialButton2.TabIndex = 8;
            materialButton2.Text = "Cancelar";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(379, 305);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(104, 36);
            materialButton1.TabIndex = 7;
            materialButton1.Text = "Continuar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // areaTerraza
            // 
            areaTerraza.AnimateReadOnly = false;
            areaTerraza.BackgroundImageLayout = ImageLayout.None;
            areaTerraza.CharacterCasing = CharacterCasing.Normal;
            areaTerraza.Depth = 0;
            areaTerraza.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            areaTerraza.HideSelection = true;
            areaTerraza.Hint = "Área de la terraza";
            areaTerraza.LeadingIcon = null;
            areaTerraza.Location = new Point(363, 147);
            areaTerraza.MaxLength = 32767;
            areaTerraza.MouseState = MaterialSkin.MouseState.OUT;
            areaTerraza.Name = "areaTerraza";
            areaTerraza.PasswordChar = '\0';
            areaTerraza.PrefixSuffixText = null;
            areaTerraza.ReadOnly = false;
            areaTerraza.RightToLeft = RightToLeft.No;
            areaTerraza.SelectedText = "";
            areaTerraza.SelectionLength = 0;
            areaTerraza.SelectionStart = 0;
            areaTerraza.ShortcutsEnabled = true;
            areaTerraza.Size = new Size(251, 48);
            areaTerraza.TabIndex = 6;
            areaTerraza.TabStop = false;
            areaTerraza.TextAlign = HorizontalAlignment.Left;
            areaTerraza.TrailingIcon = null;
            areaTerraza.UseSystemPasswordChar = false;
            // 
            // cantidadArmarios
            // 
            cantidadArmarios.AnimateReadOnly = false;
            cantidadArmarios.BackgroundImageLayout = ImageLayout.None;
            cantidadArmarios.CharacterCasing = CharacterCasing.Normal;
            cantidadArmarios.Depth = 0;
            cantidadArmarios.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cantidadArmarios.HideSelection = true;
            cantidadArmarios.Hint = "Cantidad de armarios";
            cantidadArmarios.LeadingIcon = null;
            cantidadArmarios.Location = new Point(66, 147);
            cantidadArmarios.MaxLength = 32767;
            cantidadArmarios.MouseState = MaterialSkin.MouseState.OUT;
            cantidadArmarios.Name = "cantidadArmarios";
            cantidadArmarios.PasswordChar = '\0';
            cantidadArmarios.PrefixSuffixText = null;
            cantidadArmarios.ReadOnly = false;
            cantidadArmarios.RightToLeft = RightToLeft.No;
            cantidadArmarios.SelectedText = "";
            cantidadArmarios.SelectionLength = 0;
            cantidadArmarios.SelectionStart = 0;
            cantidadArmarios.ShortcutsEnabled = true;
            cantidadArmarios.Size = new Size(251, 48);
            cantidadArmarios.TabIndex = 5;
            cantidadArmarios.TabStop = false;
            cantidadArmarios.TextAlign = HorizontalAlignment.Left;
            cantidadArmarios.TrailingIcon = null;
            cantidadArmarios.UseSystemPasswordChar = false;
            // 
            // materialCheckedListBox1
            // 
            materialCheckedListBox1.AutoScroll = true;
            materialCheckedListBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialCheckedListBox1.Controls.Add(calefaccionCheckbox);
            materialCheckedListBox1.Controls.Add(gasCheckbox);
            materialCheckedListBox1.Controls.Add(garajeCheckbox);
            materialCheckedListBox1.Controls.Add(salonCheckbox);
            materialCheckedListBox1.Depth = 0;
            materialCheckedListBox1.Location = new Point(198, 214);
            materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckedListBox1.Name = "materialCheckedListBox1";
            materialCheckedListBox1.Size = new Size(416, 70);
            materialCheckedListBox1.Striped = false;
            materialCheckedListBox1.StripeDarkColor = Color.Empty;
            materialCheckedListBox1.TabIndex = 4;
            // 
            // calefaccionCheckbox
            // 
            calefaccionCheckbox.AutoSize = true;
            calefaccionCheckbox.Depth = 0;
            calefaccionCheckbox.Location = new Point(195, 15);
            calefaccionCheckbox.Margin = new Padding(0);
            calefaccionCheckbox.MouseLocation = new Point(-1, -1);
            calefaccionCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            calefaccionCheckbox.Name = "calefaccionCheckbox";
            calefaccionCheckbox.ReadOnly = false;
            calefaccionCheckbox.Ripple = true;
            calefaccionCheckbox.Size = new Size(119, 37);
            calefaccionCheckbox.TabIndex = 3;
            calefaccionCheckbox.Text = "Calefacción";
            calefaccionCheckbox.UseVisualStyleBackColor = true;
            // 
            // gasCheckbox
            // 
            gasCheckbox.AutoSize = true;
            gasCheckbox.Depth = 0;
            gasCheckbox.Location = new Point(116, 15);
            gasCheckbox.Margin = new Padding(0);
            gasCheckbox.MouseLocation = new Point(-1, -1);
            gasCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            gasCheckbox.Name = "gasCheckbox";
            gasCheckbox.ReadOnly = false;
            gasCheckbox.Ripple = true;
            gasCheckbox.Size = new Size(63, 37);
            gasCheckbox.TabIndex = 2;
            gasCheckbox.Text = "Gas";
            gasCheckbox.UseVisualStyleBackColor = true;
            // 
            // garajeCheckbox
            // 
            garajeCheckbox.AutoSize = true;
            garajeCheckbox.Depth = 0;
            garajeCheckbox.Location = new Point(14, 15);
            garajeCheckbox.Margin = new Padding(0);
            garajeCheckbox.MouseLocation = new Point(-1, -1);
            garajeCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            garajeCheckbox.Name = "garajeCheckbox";
            garajeCheckbox.ReadOnly = false;
            garajeCheckbox.Ripple = true;
            garajeCheckbox.Size = new Size(81, 37);
            garajeCheckbox.TabIndex = 1;
            garajeCheckbox.Text = "Garaje";
            garajeCheckbox.UseVisualStyleBackColor = true;
            // 
            // salonCheckbox
            // 
            salonCheckbox.AutoSize = true;
            salonCheckbox.Depth = 0;
            salonCheckbox.Location = new Point(327, 15);
            salonCheckbox.Margin = new Padding(0);
            salonCheckbox.MouseLocation = new Point(-1, -1);
            salonCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            salonCheckbox.Name = "salonCheckbox";
            salonCheckbox.ReadOnly = false;
            salonCheckbox.Ripple = true;
            salonCheckbox.Size = new Size(76, 37);
            salonCheckbox.TabIndex = 0;
            salonCheckbox.Text = "Salón";
            salonCheckbox.UseVisualStyleBackColor = true;
            // 
            // cantidadBaños
            // 
            cantidadBaños.AnimateReadOnly = false;
            cantidadBaños.BackgroundImageLayout = ImageLayout.None;
            cantidadBaños.CharacterCasing = CharacterCasing.Normal;
            cantidadBaños.Depth = 0;
            cantidadBaños.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cantidadBaños.HideSelection = true;
            cantidadBaños.Hint = "Cantidad de baños";
            cantidadBaños.LeadingIcon = null;
            cantidadBaños.Location = new Point(363, 81);
            cantidadBaños.MaxLength = 32767;
            cantidadBaños.MouseState = MaterialSkin.MouseState.OUT;
            cantidadBaños.Name = "cantidadBaños";
            cantidadBaños.PasswordChar = '\0';
            cantidadBaños.PrefixSuffixText = null;
            cantidadBaños.ReadOnly = false;
            cantidadBaños.RightToLeft = RightToLeft.No;
            cantidadBaños.SelectedText = "";
            cantidadBaños.SelectionLength = 0;
            cantidadBaños.SelectionStart = 0;
            cantidadBaños.ShortcutsEnabled = true;
            cantidadBaños.Size = new Size(251, 48);
            cantidadBaños.TabIndex = 3;
            cantidadBaños.TabStop = false;
            cantidadBaños.TextAlign = HorizontalAlignment.Left;
            cantidadBaños.TrailingIcon = null;
            cantidadBaños.UseSystemPasswordChar = false;
            // 
            // cantidadHabitaciones
            // 
            cantidadHabitaciones.AnimateReadOnly = false;
            cantidadHabitaciones.BackgroundImageLayout = ImageLayout.None;
            cantidadHabitaciones.CharacterCasing = CharacterCasing.Normal;
            cantidadHabitaciones.Depth = 0;
            cantidadHabitaciones.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cantidadHabitaciones.HideSelection = true;
            cantidadHabitaciones.Hint = "Cantidad de habitaciones";
            cantidadHabitaciones.LeadingIcon = null;
            cantidadHabitaciones.Location = new Point(66, 81);
            cantidadHabitaciones.MaxLength = 32767;
            cantidadHabitaciones.MouseState = MaterialSkin.MouseState.OUT;
            cantidadHabitaciones.Name = "cantidadHabitaciones";
            cantidadHabitaciones.PasswordChar = '\0';
            cantidadHabitaciones.PrefixSuffixText = null;
            cantidadHabitaciones.ReadOnly = false;
            cantidadHabitaciones.RightToLeft = RightToLeft.No;
            cantidadHabitaciones.SelectedText = "";
            cantidadHabitaciones.SelectionLength = 0;
            cantidadHabitaciones.SelectionStart = 0;
            cantidadHabitaciones.ShortcutsEnabled = true;
            cantidadHabitaciones.Size = new Size(251, 48);
            cantidadHabitaciones.TabIndex = 2;
            cantidadHabitaciones.TabStop = false;
            cantidadHabitaciones.TextAlign = HorizontalAlignment.Left;
            cantidadHabitaciones.TrailingIcon = null;
            cantidadHabitaciones.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20F);
            label1.Location = new Point(211, 14);
            label1.Name = "label1";
            label1.Size = new Size(262, 37);
            label1.TabIndex = 1;
            label1.Text = "Datos de la vivienda";
            // 
            // AñadirVivienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 613);
            Controls.Add(materialCard2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AñadirVivienda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AñadirVivienda";
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCheckedListBox1.ResumeLayout(false);
            materialCheckedListBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label label1;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialTextBox2 cantidadBaños;
        private MaterialSkin.Controls.MaterialTextBox2 cantidadHabitaciones;
        private MaterialSkin.Controls.MaterialTextBox2 areaTerraza;
        private MaterialSkin.Controls.MaterialTextBox2 cantidadArmarios;
        private MaterialSkin.Controls.MaterialCheckbox calefaccionCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox gasCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox garajeCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox salonCheckbox;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox tipoVivienda;
    }
}