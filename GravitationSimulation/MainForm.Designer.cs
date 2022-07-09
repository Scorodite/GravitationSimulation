namespace GravitationSimulation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>s
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
            this.components = new System.ComponentModel.Container();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SpaceBitmapBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlanetAnimationBox = new System.Windows.Forms.ComboBox();
            this.PlanetStaticBox = new System.Windows.Forms.CheckBox();
            this.PlanetMassBox = new System.Windows.Forms.NumericUpDown();
            this.PlanetAngleBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PlanetSpeedBox = new System.Windows.Forms.NumericUpDown();
            this.PlanetAnimationPreviewBox = new System.Windows.Forms.PictureBox();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreatePlanetRadio = new System.Windows.Forms.RadioButton();
            this.MoveCameraRadio = new System.Windows.Forms.RadioButton();
            this.AccelerationVectorsBox = new System.Windows.Forms.CheckBox();
            this.PlanetList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBitmapBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetMassBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetAngleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetSpeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetAnimationPreviewBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 16;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // SpaceBitmapBox
            // 
            this.SpaceBitmapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpaceBitmapBox.Location = new System.Drawing.Point(0, 0);
            this.SpaceBitmapBox.Name = "SpaceBitmapBox";
            this.SpaceBitmapBox.Size = new System.Drawing.Size(919, 758);
            this.SpaceBitmapBox.TabIndex = 0;
            this.SpaceBitmapBox.TabStop = false;
            this.SpaceBitmapBox.SizeChanged += new System.EventHandler(this.SpaceBitmapBox_SizeChanged);
            this.SpaceBitmapBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpaceBitmapBox_MouseClick);
            this.SpaceBitmapBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpaceBitmapBox_MouseDown);
            this.SpaceBitmapBox.MouseLeave += new System.EventHandler(this.SpaceBitmapBox_MouseLeave);
            this.SpaceBitmapBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SpaceBitmapBox_MouseMove);
            this.SpaceBitmapBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SpaceBitmapBox_MouseUp);
            this.SpaceBitmapBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.SpaceBitmapBox_MouseWheel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 758);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.PauseButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ClearButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.AccelerationVectorsBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.PlanetList, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 758);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 324);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create planet";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PlanetAnimationBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlanetStaticBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PlanetMassBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PlanetAngleBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.PlanetSpeedBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.PlanetAnimationPreviewBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 302);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PlanetAnimationBox
            // 
            this.PlanetAnimationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlanetAnimationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlanetAnimationBox.FormattingEnabled = true;
            this.PlanetAnimationBox.Location = new System.Drawing.Point(72, 169);
            this.PlanetAnimationBox.Name = "PlanetAnimationBox";
            this.PlanetAnimationBox.Size = new System.Drawing.Size(212, 23);
            this.PlanetAnimationBox.TabIndex = 0;
            this.PlanetAnimationBox.SelectedIndexChanged += new System.EventHandler(this.PlanetAnimationBox_SelectedIndexChanged);
            // 
            // PlanetStaticBox
            // 
            this.PlanetStaticBox.AutoSize = true;
            this.PlanetStaticBox.Location = new System.Drawing.Point(72, 198);
            this.PlanetStaticBox.Name = "PlanetStaticBox";
            this.PlanetStaticBox.Size = new System.Drawing.Size(15, 14);
            this.PlanetStaticBox.TabIndex = 1;
            this.PlanetStaticBox.UseVisualStyleBackColor = true;
            // 
            // PlanetMassBox
            // 
            this.PlanetMassBox.DecimalPlaces = 2;
            this.PlanetMassBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlanetMassBox.Location = new System.Drawing.Point(72, 218);
            this.PlanetMassBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.PlanetMassBox.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.PlanetMassBox.Name = "PlanetMassBox";
            this.PlanetMassBox.Size = new System.Drawing.Size(212, 23);
            this.PlanetMassBox.TabIndex = 2;
            // 
            // PlanetAngleBox
            // 
            this.PlanetAngleBox.DecimalPlaces = 4;
            this.PlanetAngleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlanetAngleBox.Location = new System.Drawing.Point(72, 247);
            this.PlanetAngleBox.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PlanetAngleBox.Name = "PlanetAngleBox";
            this.PlanetAngleBox.Size = new System.Drawing.Size(212, 23);
            this.PlanetAngleBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Animation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Static";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mass";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Angle";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Speed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlanetSpeedBox
            // 
            this.PlanetSpeedBox.DecimalPlaces = 2;
            this.PlanetSpeedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlanetSpeedBox.Location = new System.Drawing.Point(72, 276);
            this.PlanetSpeedBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PlanetSpeedBox.Name = "PlanetSpeedBox";
            this.PlanetSpeedBox.Size = new System.Drawing.Size(212, 23);
            this.PlanetSpeedBox.TabIndex = 9;
            // 
            // PlanetAnimationPreviewBox
            // 
            this.PlanetAnimationPreviewBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.SetColumnSpan(this.PlanetAnimationPreviewBox, 2);
            this.PlanetAnimationPreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlanetAnimationPreviewBox.Location = new System.Drawing.Point(3, 3);
            this.PlanetAnimationPreviewBox.Name = "PlanetAnimationPreviewBox";
            this.PlanetAnimationPreviewBox.Size = new System.Drawing.Size(281, 160);
            this.PlanetAnimationPreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PlanetAnimationPreviewBox.TabIndex = 10;
            this.PlanetAnimationPreviewBox.TabStop = false;
            // 
            // PauseButton
            // 
            this.PauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseButton.Location = new System.Drawing.Point(3, 23);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(69, 23);
            this.PauseButton.TabIndex = 3;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.Location = new System.Drawing.Point(221, 23);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear space";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox2, 3);
            this.groupBox2.Controls.Add(this.CreatePlanetRadio);
            this.groupBox2.Controls.Add(this.MoveCameraRadio);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 69);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mouse";
            // 
            // CreatePlanetRadio
            // 
            this.CreatePlanetRadio.AutoSize = true;
            this.CreatePlanetRadio.Location = new System.Drawing.Point(6, 44);
            this.CreatePlanetRadio.Name = "CreatePlanetRadio";
            this.CreatePlanetRadio.Size = new System.Drawing.Size(95, 19);
            this.CreatePlanetRadio.TabIndex = 1;
            this.CreatePlanetRadio.Text = "Create planet";
            this.CreatePlanetRadio.UseVisualStyleBackColor = true;
            // 
            // MoveCameraRadio
            // 
            this.MoveCameraRadio.AutoSize = true;
            this.MoveCameraRadio.Checked = true;
            this.MoveCameraRadio.Location = new System.Drawing.Point(6, 22);
            this.MoveCameraRadio.Name = "MoveCameraRadio";
            this.MoveCameraRadio.Size = new System.Drawing.Size(97, 19);
            this.MoveCameraRadio.TabIndex = 0;
            this.MoveCameraRadio.TabStop = true;
            this.MoveCameraRadio.Text = "Move camera";
            this.MoveCameraRadio.UseVisualStyleBackColor = true;
            // 
            // AccelerationVectorsBox
            // 
            this.AccelerationVectorsBox.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.AccelerationVectorsBox, 3);
            this.AccelerationVectorsBox.Location = new System.Drawing.Point(3, 52);
            this.AccelerationVectorsBox.Name = "AccelerationVectorsBox";
            this.AccelerationVectorsBox.Size = new System.Drawing.Size(130, 19);
            this.AccelerationVectorsBox.TabIndex = 7;
            this.AccelerationVectorsBox.Text = "Show speed vectors";
            this.AccelerationVectorsBox.UseVisualStyleBackColor = true;
            // 
            // PlanetList
            // 
            this.PlanetList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader8});
            this.tableLayoutPanel2.SetColumnSpan(this.PlanetList, 3);
            this.PlanetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlanetList.FullRowSelect = true;
            this.PlanetList.HideSelection = false;
            this.PlanetList.Location = new System.Drawing.Point(3, 482);
            this.PlanetList.Name = "PlanetList";
            this.PlanetList.Size = new System.Drawing.Size(293, 273);
            this.PlanetList.TabIndex = 8;
            this.PlanetList.UseCompatibleStateImageBehavior = false;
            this.PlanetList.View = System.Windows.Forms.View.Details;
            this.PlanetList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlanetList_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "X";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Y";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mass";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Speed";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Static";
            this.columnHeader8.Width = 45;
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.panel1);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.SpaceBitmapBox);
            this.MainSplitContainer.Size = new System.Drawing.Size(1222, 758);
            this.MainSplitContainer.SplitterDistance = 299;
            this.MainSplitContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 758);
            this.Controls.Add(this.MainSplitContainer);
            this.Name = "MainForm";
            this.Text = "Gravitation simulation";
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBitmapBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetMassBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetAngleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetSpeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetAnimationPreviewBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.PictureBox SpaceBitmapBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton CreatePlanetRadio;
        private System.Windows.Forms.RadioButton MoveCameraRadio;
        private System.Windows.Forms.CheckBox AccelerationVectorsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox PlanetAnimationBox;
        private System.Windows.Forms.CheckBox PlanetStaticBox;
        private System.Windows.Forms.NumericUpDown PlanetMassBox;
        private System.Windows.Forms.NumericUpDown PlanetAngleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PlanetSpeedBox;
        private System.Windows.Forms.PictureBox PlanetAnimationPreviewBox;
        private System.Windows.Forms.ListView PlanetList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

