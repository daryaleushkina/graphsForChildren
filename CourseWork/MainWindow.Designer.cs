namespace CourseWork
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.goToFirstTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.task = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelForNode = new System.Windows.Forms.Label();
            this.labelForEdge = new System.Windows.Forms.Label();
            this.textBoxForNode = new System.Windows.Forms.TextBox();
            this.textBoxForEdge = new System.Windows.Forms.TextBox();
            this.Send1 = new System.Windows.Forms.Button();
            this.labelForPoints = new System.Windows.Forms.Label();
            this.Send2 = new System.Windows.Forms.Button();
            this.labelForCountCity = new System.Windows.Forms.Label();
            this.textBoxCountPoint = new System.Windows.Forms.TextBox();
            this.goToSecondTask = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // goToFirstTask
            // 
            this.goToFirstTask.Location = new System.Drawing.Point(19, 281);
            this.goToFirstTask.Margin = new System.Windows.Forms.Padding(4);
            this.goToFirstTask.Name = "goToFirstTask";
            this.goToFirstTask.Size = new System.Drawing.Size(212, 28);
            this.goToFirstTask.TabIndex = 0;
            this.goToFirstTask.Text = "Решить 1 задание";
            this.goToFirstTask.UseVisualStyleBackColor = true;
            this.goToFirstTask.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.task);
            this.groupBox1.Location = new System.Drawing.Point(577, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(905, 645);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дерево";
            // 
            // task
            // 
            this.task.Location = new System.Drawing.Point(41, 23);
            this.task.Margin = new System.Windows.Forms.Padding(4);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(835, 638);
            this.task.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 119);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // labelForNode
            // 
            this.labelForNode.AutoSize = true;
            this.labelForNode.Location = new System.Drawing.Point(12, 193);
            this.labelForNode.Name = "labelForNode";
            this.labelForNode.Size = new System.Drawing.Size(171, 17);
            this.labelForNode.TabIndex = 8;
            this.labelForNode.Text = "Сколько вершин в графе";
            // 
            // labelForEdge
            // 
            this.labelForEdge.AutoSize = true;
            this.labelForEdge.Location = new System.Drawing.Point(12, 228);
            this.labelForEdge.Name = "labelForEdge";
            this.labelForEdge.Size = new System.Drawing.Size(161, 17);
            this.labelForEdge.TabIndex = 9;
            this.labelForEdge.Text = "Сколько ребёр в графе";
            // 
            // textBoxForNode
            // 
            this.textBoxForNode.Location = new System.Drawing.Point(208, 187);
            this.textBoxForNode.Name = "textBoxForNode";
            this.textBoxForNode.Size = new System.Drawing.Size(36, 22);
            this.textBoxForNode.TabIndex = 10;
            // 
            // textBoxForEdge
            // 
            this.textBoxForEdge.Location = new System.Drawing.Point(208, 228);
            this.textBoxForEdge.Name = "textBoxForEdge";
            this.textBoxForEdge.Size = new System.Drawing.Size(36, 22);
            this.textBoxForEdge.TabIndex = 11;
            // 
            // Send1
            // 
            this.Send1.Location = new System.Drawing.Point(12, 278);
            this.Send1.Name = "Send1";
            this.Send1.Size = new System.Drawing.Size(219, 31);
            this.Send1.TabIndex = 12;
            this.Send1.Text = "Отправить решение";
            this.Send1.UseVisualStyleBackColor = true;
            this.Send1.Click += new System.EventHandler(this.Send1_Click);
            // 
            // labelForPoints
            // 
            this.labelForPoints.AutoSize = true;
            this.labelForPoints.Location = new System.Drawing.Point(615, 22);
            this.labelForPoints.Name = "labelForPoints";
            this.labelForPoints.Size = new System.Drawing.Size(145, 17);
            this.labelForPoints.TabIndex = 13;
            this.labelForPoints.Text = "Количество баллов: ";
            // 
            // Send2
            // 
            this.Send2.Location = new System.Drawing.Point(12, 278);
            this.Send2.Name = "Send2";
            this.Send2.Size = new System.Drawing.Size(219, 31);
            this.Send2.TabIndex = 14;
            this.Send2.Text = "Отправить решение";
            this.Send2.UseVisualStyleBackColor = true;
            this.Send2.Click += new System.EventHandler(this.Send2_Click);
            // 
            // labelForCountCity
            // 
            this.labelForCountCity.AutoSize = true;
            this.labelForCountCity.Location = new System.Drawing.Point(12, 176);
            this.labelForCountCity.Name = "labelForCountCity";
            this.labelForCountCity.Size = new System.Drawing.Size(250, 17);
            this.labelForCountCity.TabIndex = 15;
            this.labelForCountCity.Text = "Сколько путей из города A в город Б";
            // 
            // textBoxCountPoint
            // 
            this.textBoxCountPoint.Location = new System.Drawing.Point(15, 250);
            this.textBoxCountPoint.Name = "textBoxCountPoint";
            this.textBoxCountPoint.Size = new System.Drawing.Size(36, 22);
            this.textBoxCountPoint.TabIndex = 16;
            // 
            // goToSecondTask
            // 
            this.goToSecondTask.Location = new System.Drawing.Point(19, 257);
            this.goToSecondTask.Margin = new System.Windows.Forms.Padding(4);
            this.goToSecondTask.Name = "goToSecondTask";
            this.goToSecondTask.Size = new System.Drawing.Size(212, 28);
            this.goToSecondTask.TabIndex = 17;
            this.goToSecondTask.Text = "Решить 2 задание";
            this.goToSecondTask.UseVisualStyleBackColor = true;
            this.goToSecondTask.Click += new System.EventHandler(this.GoToSecondTask_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.loop;
            this.pictureBox1.Location = new System.Drawing.Point(15, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CourseWork.Properties.Resources.Pushkin;
            this.pictureBox2.Location = new System.Drawing.Point(12, 326);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 1037);
            this.Controls.Add(this.textBoxCountPoint);
            this.Controls.Add(this.labelForCountCity);
            this.Controls.Add(this.labelForNode);
            this.Controls.Add(this.Send2);
            this.Controls.Add(this.labelForPoints);
            this.Controls.Add(this.Send1);
            this.Controls.Add(this.textBoxForEdge);
            this.Controls.Add(this.textBoxForNode);
            this.Controls.Add(this.labelForEdge);
            this.Controls.Add(this.goToFirstTask);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.goToSecondTask);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Курсовая работа Аврааменко Алексей 411 группа";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToFirstTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel task;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxForEdge;
        private System.Windows.Forms.TextBox textBoxForNode;
        private System.Windows.Forms.Label labelForEdge;
        private System.Windows.Forms.Label labelForNode;
        private System.Windows.Forms.Button Send1;
        private System.Windows.Forms.Label labelForPoints;
        private System.Windows.Forms.Button Send2;
        private System.Windows.Forms.Label labelForCountCity;
        private System.Windows.Forms.TextBox textBoxCountPoint;
        private System.Windows.Forms.Button goToSecondTask;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

