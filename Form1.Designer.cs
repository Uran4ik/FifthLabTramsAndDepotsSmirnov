namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zharFirstDataSet = new WindowsFormsApp3.ZharFirstDataSet();
            this.zharFirstDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_countseats = new System.Windows.Forms.TextBox();
            this.tbDepot_number = new System.Windows.Forms.TextBox();
            this.maskedTB_date = new System.Windows.Forms.MaskedTextBox();
            this.tb_sections_count = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_number_trolleys = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_count_places = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_year_construct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tramTableAdapter = new WindowsFormsApp3.ZharFirstDataSetTableAdapters.TramTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label_count_model = new System.Windows.Forms.Label();
            this.labb_tram_number = new System.Windows.Forms.Label();
            this.tb_tram_length = new System.Windows.Forms.TextBox();
            this.zharFirstDataSet1 = new WindowsFormsApp3.ZharFirstDataSet1();
            this.tramTableAdapter1 = new WindowsFormsApp3.ZharFirstDataSet1TableAdapters.TramTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zharFirstDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zharFirstDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zharFirstDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // zharFirstDataSet
            // 
            this.zharFirstDataSet.DataSetName = "ZharFirstDataSet";
            this.zharFirstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zharFirstDataSetBindingSource
            // 
            this.zharFirstDataSetBindingSource.DataSource = this.zharFirstDataSet;
            this.zharFirstDataSetBindingSource.Position = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.tramBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(798, 33);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // tramBindingSource
            // 
            this.tramBindingSource.DataMember = "Tram";
            this.tramBindingSource.DataSource = this.zharFirstDataSet1;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(212, 695);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 45);
            this.AddButton.TabIndex = 78;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(51, 695);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(123, 45);
            this.EditButton.TabIndex = 77;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 592);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 60);
            this.label10.TabIndex = 75;
            this.label10.Text = "Кол-во трамваев с такой же \r\nмоделью у которых дата кап\r\nремонта была больше 2 ле" +
    "т назад";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 74;
            this.label11.Text = "Номер трамвая";
            // 
            // tb_countseats
            // 
            this.tb_countseats.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tramBindingSource, "count_seats", true));
            this.tb_countseats.Location = new System.Drawing.Point(417, 376);
            this.tb_countseats.MaxLength = 3;
            this.tb_countseats.Name = "tb_countseats";
            this.tb_countseats.Size = new System.Drawing.Size(107, 26);
            this.tb_countseats.TabIndex = 71;
            // 
            // tbDepot_number
            // 
            this.tbDepot_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tramBindingSource, "depot_number", true));
            this.tbDepot_number.Location = new System.Drawing.Point(416, 135);
            this.tbDepot_number.MaxLength = 15;
            this.tbDepot_number.Name = "tbDepot_number";
            this.tbDepot_number.Size = new System.Drawing.Size(107, 26);
            this.tbDepot_number.TabIndex = 70;
            // 
            // maskedTB_date
            // 
            this.maskedTB_date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tramBindingSource, "date_major_repairs", true));
            this.maskedTB_date.Location = new System.Drawing.Point(416, 280);
            this.maskedTB_date.Mask = "00/00/0000";
            this.maskedTB_date.Name = "maskedTB_date";
            this.maskedTB_date.Size = new System.Drawing.Size(107, 26);
            this.maskedTB_date.TabIndex = 69;
            this.maskedTB_date.ValidatingType = typeof(System.DateTime);
            // 
            // tb_sections_count
            // 
            this.tb_sections_count.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tramBindingSource, "sections_number", true));
            this.tb_sections_count.Location = new System.Drawing.Point(416, 528);
            this.tb_sections_count.MaxLength = 3;
            this.tb_sections_count.Name = "tb_sections_count";
            this.tb_sections_count.Size = new System.Drawing.Size(107, 26);
            this.tb_sections_count.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Количество секций в составе";
            // 
            // tb_number_trolleys
            // 
            this.tb_number_trolleys.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tramBindingSource, "trolleys_number", true));
            this.tb_number_trolleys.Location = new System.Drawing.Point(416, 482);
            this.tb_number_trolleys.MaxLength = 3;
            this.tb_number_trolleys.Name = "tb_number_trolleys";
            this.tb_number_trolleys.Size = new System.Drawing.Size(107, 26);
            this.tb_number_trolleys.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Количество тележек";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Длина трамвая";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Количество сидячих мест";
            // 
            // tb_count_places
            // 
            this.tb_count_places.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tramBindingSource, "count_places", true));
            this.tb_count_places.Location = new System.Drawing.Point(416, 334);
            this.tb_count_places.MaxLength = 3;
            this.tb_count_places.Name = "tb_count_places";
            this.tb_count_places.Size = new System.Drawing.Size(107, 26);
            this.tb_count_places.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Количество мест";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Дата капитального ремонта";
            // 
            // tb_year_construct
            // 
            this.tb_year_construct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tramBindingSource, "year_construction", true));
            this.tb_year_construct.Location = new System.Drawing.Point(416, 234);
            this.tb_year_construct.MaxLength = 4;
            this.tb_year_construct.Name = "tb_year_construct";
            this.tb_year_construct.Size = new System.Drawing.Size(107, 26);
            this.tb_year_construct.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Год постройки трамвая";
            // 
            // tb_model
            // 
            this.tb_model.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tramBindingSource, "model", true));
            this.tb_model.Location = new System.Drawing.Point(416, 183);
            this.tb_model.MaxLength = 15;
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(107, 26);
            this.tb_model.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Модель трамвая";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Номер депо в котором расположен тармвай";
            // 
            // tramTableAdapter
            // 
            this.tramTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 695);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 45);
            this.button1.TabIndex = 79;
            this.button1.Text = "Посчитать кол-во моделей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_count_model
            // 
            this.label_count_model.AutoSize = true;
            this.label_count_model.Location = new System.Drawing.Point(417, 612);
            this.label_count_model.Name = "label_count_model";
            this.label_count_model.Size = new System.Drawing.Size(0, 20);
            this.label_count_model.TabIndex = 80;
            // 
            // labb_tram_number
            // 
            this.labb_tram_number.AutoSize = true;
            this.labb_tram_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tramBindingSource, "tram_number", true));
            this.labb_tram_number.Location = new System.Drawing.Point(417, 79);
            this.labb_tram_number.Name = "labb_tram_number";
            this.labb_tram_number.Size = new System.Drawing.Size(97, 20);
            this.labb_tram_number.TabIndex = 81;
            this.labb_tram_number.Text = "                      ";
            // 
            // tb_tram_length
            // 
            this.tb_tram_length.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tramBindingSource, "tram_length", true));
            this.tb_tram_length.Location = new System.Drawing.Point(417, 424);
            this.tb_tram_length.MaxLength = 4;
            this.tb_tram_length.Name = "tb_tram_length";
            this.tb_tram_length.Size = new System.Drawing.Size(100, 26);
            this.tb_tram_length.TabIndex = 83;
            // 
            // zharFirstDataSet1
            // 
            this.zharFirstDataSet1.DataSetName = "ZharFirstDataSet1";
            this.zharFirstDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tramTableAdapter1
            // 
            this.tramTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 813);
            this.Controls.Add(this.tb_tram_length);
            this.Controls.Add(this.labb_tram_number);
            this.Controls.Add(this.label_count_model);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_countseats);
            this.Controls.Add(this.tbDepot_number);
            this.Controls.Add(this.maskedTB_date);
            this.Controls.Add(this.tb_sections_count);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_number_trolleys);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_count_places);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_year_construct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zharFirstDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zharFirstDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zharFirstDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZharFirstDataSet zharFirstDataSet;
        private System.Windows.Forms.BindingSource zharFirstDataSetBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_countseats;
        private System.Windows.Forms.TextBox tbDepot_number;
        private System.Windows.Forms.MaskedTextBox maskedTB_date;
        private System.Windows.Forms.TextBox tb_sections_count;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_number_trolleys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_count_places;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_year_construct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tramBindingSource;
        private ZharFirstDataSetTableAdapters.TramTableAdapter tramTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_count_model;
        private System.Windows.Forms.Label labb_tram_number;
        private System.Windows.Forms.TextBox tb_tram_length;
        private ZharFirstDataSet1 zharFirstDataSet1;
        private ZharFirstDataSet1TableAdapters.TramTableAdapter tramTableAdapter1;
    }
}

