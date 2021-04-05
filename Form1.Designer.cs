
namespace ConcurrentLab23
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.serialProgressBar = new System.Windows.Forms.ProgressBar();
            this.serialStartButton = new System.Windows.Forms.Button();
            this.serialCancelButton = new System.Windows.Forms.Button();
            this.serialBW = new System.ComponentModel.BackgroundWorker();
            this.parallelCancelButton = new System.Windows.Forms.Button();
            this.parallelStartButton = new System.Windows.Forms.Button();
            this.parallelProgressBar = new System.Windows.Forms.ProgressBar();
            this.parallelBW = new System.ComponentModel.BackgroundWorker();
            this.parallelTimeLabel = new System.Windows.Forms.Label();
            this.serialTimeLabel = new System.Windows.Forms.Label();
            this.numberElementsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberDimenstionsUpDown = new System.Windows.Forms.NumericUpDown();
            this.ansTextBox = new System.Windows.Forms.TextBox();
            this.clusterRadiusInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPrintButton = new System.Windows.Forms.Button();
            this.parallelPrintButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberElementsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberDimenstionsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // serialProgressBar
            // 
            this.serialProgressBar.Location = new System.Drawing.Point(296, 243);
            this.serialProgressBar.Name = "serialProgressBar";
            this.serialProgressBar.Size = new System.Drawing.Size(448, 28);
            this.serialProgressBar.TabIndex = 0;
            // 
            // serialStartButton
            // 
            this.serialStartButton.Location = new System.Drawing.Point(45, 243);
            this.serialStartButton.Name = "serialStartButton";
            this.serialStartButton.Size = new System.Drawing.Size(69, 28);
            this.serialStartButton.TabIndex = 1;
            this.serialStartButton.Text = "Запуск";
            this.serialStartButton.UseVisualStyleBackColor = true;
            this.serialStartButton.Click += new System.EventHandler(this.serialStartButton_Click);
            // 
            // serialCancelButton
            // 
            this.serialCancelButton.Enabled = false;
            this.serialCancelButton.Location = new System.Drawing.Point(120, 243);
            this.serialCancelButton.Name = "serialCancelButton";
            this.serialCancelButton.Size = new System.Drawing.Size(69, 28);
            this.serialCancelButton.TabIndex = 2;
            this.serialCancelButton.Text = "Отмена";
            this.serialCancelButton.UseVisualStyleBackColor = true;
            this.serialCancelButton.Click += new System.EventHandler(this.serialCancelButton_Click);
            // 
            // serialBW
            // 
            this.serialBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.serialBW_DoWork);
            this.serialBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.serialBW_ProgressChanged);
            this.serialBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.serialBW_RunWorkerCompleted);
            // 
            // parallelCancelButton
            // 
            this.parallelCancelButton.Enabled = false;
            this.parallelCancelButton.Location = new System.Drawing.Point(120, 162);
            this.parallelCancelButton.Name = "parallelCancelButton";
            this.parallelCancelButton.Size = new System.Drawing.Size(69, 28);
            this.parallelCancelButton.TabIndex = 5;
            this.parallelCancelButton.Text = "Отмена";
            this.parallelCancelButton.UseVisualStyleBackColor = true;
            this.parallelCancelButton.Click += new System.EventHandler(this.parallelCancelButton_Click);
            // 
            // parallelStartButton
            // 
            this.parallelStartButton.Location = new System.Drawing.Point(45, 162);
            this.parallelStartButton.Name = "parallelStartButton";
            this.parallelStartButton.Size = new System.Drawing.Size(69, 28);
            this.parallelStartButton.TabIndex = 4;
            this.parallelStartButton.Text = "Запуск";
            this.parallelStartButton.UseVisualStyleBackColor = true;
            this.parallelStartButton.Click += new System.EventHandler(this.parallelStartButton_Click);
            // 
            // parallelProgressBar
            // 
            this.parallelProgressBar.Location = new System.Drawing.Point(296, 162);
            this.parallelProgressBar.Name = "parallelProgressBar";
            this.parallelProgressBar.Size = new System.Drawing.Size(448, 28);
            this.parallelProgressBar.TabIndex = 3;
            // 
            // parallelBW
            // 
            this.parallelBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.parallelBW_DoWork);
            this.parallelBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.parallelBW_ProgressChanged);
            this.parallelBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.parallelBW_RunWorkerCompleted);
            // 
            // parallelTimeLabel
            // 
            this.parallelTimeLabel.AutoSize = true;
            this.parallelTimeLabel.Location = new System.Drawing.Point(598, 193);
            this.parallelTimeLabel.Name = "parallelTimeLabel";
            this.parallelTimeLabel.Size = new System.Drawing.Size(0, 16);
            this.parallelTimeLabel.TabIndex = 6;
            // 
            // serialTimeLabel
            // 
            this.serialTimeLabel.AutoSize = true;
            this.serialTimeLabel.Location = new System.Drawing.Point(598, 274);
            this.serialTimeLabel.Name = "serialTimeLabel";
            this.serialTimeLabel.Size = new System.Drawing.Size(0, 16);
            this.serialTimeLabel.TabIndex = 7;
            // 
            // numberElementsUpDown
            // 
            this.numberElementsUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberElementsUpDown.Location = new System.Drawing.Point(296, 12);
            this.numberElementsUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numberElementsUpDown.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numberElementsUpDown.Name = "numberElementsUpDown";
            this.numberElementsUpDown.Size = new System.Drawing.Size(100, 22);
            this.numberElementsUpDown.TabIndex = 8;
            this.numberElementsUpDown.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество точек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Размерность пространства";
            // 
            // numberDimenstionsUpDown
            // 
            this.numberDimenstionsUpDown.Location = new System.Drawing.Point(296, 77);
            this.numberDimenstionsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberDimenstionsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberDimenstionsUpDown.Name = "numberDimenstionsUpDown";
            this.numberDimenstionsUpDown.Size = new System.Drawing.Size(100, 22);
            this.numberDimenstionsUpDown.TabIndex = 11;
            this.numberDimenstionsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ansTextBox
            // 
            this.ansTextBox.Location = new System.Drawing.Point(45, 306);
            this.ansTextBox.Multiline = true;
            this.ansTextBox.Name = "ansTextBox";
            this.ansTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ansTextBox.Size = new System.Drawing.Size(699, 218);
            this.ansTextBox.TabIndex = 12;
            this.ansTextBox.WordWrap = false;
            // 
            // clusterRadiusInput
            // 
            this.clusterRadiusInput.Location = new System.Drawing.Point(644, 15);
            this.clusterRadiusInput.MaxLength = 10;
            this.clusterRadiusInput.Name = "clusterRadiusInput";
            this.clusterRadiusInput.Size = new System.Drawing.Size(100, 22);
            this.clusterRadiusInput.TabIndex = 13;
            this.clusterRadiusInput.Text = "5";
            this.clusterRadiusInput.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Радиус кластера";
            // 
            // serialPrintButton
            // 
            this.serialPrintButton.Enabled = false;
            this.serialPrintButton.Location = new System.Drawing.Point(195, 243);
            this.serialPrintButton.Name = "serialPrintButton";
            this.serialPrintButton.Size = new System.Drawing.Size(69, 28);
            this.serialPrintButton.TabIndex = 15;
            this.serialPrintButton.Text = "Вывод";
            this.serialPrintButton.UseVisualStyleBackColor = true;
            this.serialPrintButton.Click += new System.EventHandler(this.serialPrintButton_Click);
            // 
            // parallelPrintButton
            // 
            this.parallelPrintButton.Enabled = false;
            this.parallelPrintButton.Location = new System.Drawing.Point(195, 162);
            this.parallelPrintButton.Name = "parallelPrintButton";
            this.parallelPrintButton.Size = new System.Drawing.Size(69, 28);
            this.parallelPrintButton.TabIndex = 16;
            this.parallelPrintButton.Text = "Вывод";
            this.parallelPrintButton.UseVisualStyleBackColor = true;
            this.parallelPrintButton.Click += new System.EventHandler(this.parallelPrintButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Параллельный алгортим";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Последовательный алгоритм";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parallelPrintButton);
            this.Controls.Add(this.serialPrintButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clusterRadiusInput);
            this.Controls.Add(this.ansTextBox);
            this.Controls.Add(this.numberDimenstionsUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberElementsUpDown);
            this.Controls.Add(this.serialTimeLabel);
            this.Controls.Add(this.parallelTimeLabel);
            this.Controls.Add(this.parallelCancelButton);
            this.Controls.Add(this.parallelStartButton);
            this.Controls.Add(this.parallelProgressBar);
            this.Controls.Add(this.serialCancelButton);
            this.Controls.Add(this.serialStartButton);
            this.Controls.Add(this.serialProgressBar);
            this.Name = "MainWindow";
            this.Text = "Forel";
            ((System.ComponentModel.ISupportInitialize)(this.numberElementsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberDimenstionsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar serialProgressBar;
        private System.Windows.Forms.Button serialStartButton;
        private System.Windows.Forms.Button serialCancelButton;
        private System.ComponentModel.BackgroundWorker serialBW;
        private System.Windows.Forms.Button parallelCancelButton;
        private System.Windows.Forms.Button parallelStartButton;
        private System.Windows.Forms.ProgressBar parallelProgressBar;
        private System.ComponentModel.BackgroundWorker parallelBW;
        private System.Windows.Forms.Label parallelTimeLabel;
        private System.Windows.Forms.Label serialTimeLabel;
        private System.Windows.Forms.NumericUpDown numberElementsUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberDimenstionsUpDown;
        private System.Windows.Forms.TextBox ansTextBox;
        private System.Windows.Forms.TextBox clusterRadiusInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button serialPrintButton;
        private System.Windows.Forms.Button parallelPrintButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

