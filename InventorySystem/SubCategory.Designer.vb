﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubCategory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_gotom = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.grid_category = New System.Windows.Forms.DataGridView()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combo_catnam = New System.Windows.Forms.ComboBox()
        Me.txtb_SubName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtb_SubID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_InventoryDataSet2 = New InventorySystem.DB_InventoryDataSet2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DB_InventoryDataSet = New InventorySystem.DB_InventoryDataSet()
        Me.TBCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_CategoryTableAdapter = New InventorySystem.DB_InventoryDataSetTableAdapters.TB_CategoryTableAdapter()
        Me.TB_CategoryTableAdapter1 = New InventorySystem.DB_InventoryDataSet2TableAdapters.TB_CategoryTableAdapter()
        CType(Me.grid_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TBCategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_InventoryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_InventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(6, 39)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_gotom
        '
        Me.btn_gotom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gotom.Location = New System.Drawing.Point(89, 39)
        Me.btn_gotom.Name = "btn_gotom"
        Me.btn_gotom.Size = New System.Drawing.Size(75, 23)
        Me.btn_gotom.TabIndex = 3
        Me.btn_gotom.Text = "Back"
        Me.btn_gotom.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(168, 10)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 2
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'grid_category
        '
        Me.grid_category.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grid_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_category.Location = New System.Drawing.Point(301, 51)
        Me.grid_category.Name = "grid_category"
        Me.grid_category.Size = New System.Drawing.Size(343, 233)
        Me.grid_category.TabIndex = 21
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(87, 10)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(6, 10)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 0
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_clear)
        Me.Panel1.Controls.Add(Me.btn_gotom)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.btn_insert)
        Me.Panel1.Location = New System.Drawing.Point(17, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 78)
        Me.Panel1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Daftar Sub Kategori"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combo_catnam)
        Me.GroupBox1.Controls.Add(Me.txtb_SubName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtb_SubID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 241)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Sub Kategori"
        '
        'combo_catnam
        '
        Me.combo_catnam.FormattingEnabled = True
        Me.combo_catnam.Location = New System.Drawing.Point(128, 81)
        Me.combo_catnam.Name = "combo_catnam"
        Me.combo_catnam.Size = New System.Drawing.Size(138, 24)
        Me.combo_catnam.TabIndex = 24
        '
        'txtb_SubName
        '
        Me.txtb_SubName.Location = New System.Drawing.Point(128, 115)
        Me.txtb_SubName.Name = "txtb_SubName"
        Me.txtb_SubName.Size = New System.Drawing.Size(138, 21)
        Me.txtb_SubName.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nama Sub Kat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Sub Kat"
        '
        'txtb_SubID
        '
        Me.txtb_SubID.Location = New System.Drawing.Point(128, 41)
        Me.txtb_SubID.Name = "txtb_SubID"
        Me.txtb_SubID.Size = New System.Drawing.Size(100, 21)
        Me.txtb_SubID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Kategori"
        '
        'TBCategoryBindingSource1
        '
        Me.TBCategoryBindingSource1.DataMember = "TB_Category"
        Me.TBCategoryBindingSource1.DataSource = Me.DB_InventoryDataSet2
        '
        'DB_InventoryDataSet2
        '
        Me.DB_InventoryDataSet2.DataSetName = "DB_InventoryDataSet2"
        Me.DB_InventoryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Sub Kategori"
        '
        'DB_InventoryDataSet
        '
        Me.DB_InventoryDataSet.DataSetName = "DB_InventoryDataSet"
        Me.DB_InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBCategoryBindingSource
        '
        Me.TBCategoryBindingSource.DataMember = "TB_Category"
        Me.TBCategoryBindingSource.DataSource = Me.DB_InventoryDataSet
        '
        'TB_CategoryTableAdapter
        '
        Me.TB_CategoryTableAdapter.ClearBeforeFill = True
        '
        'TB_CategoryTableAdapter1
        '
        Me.TB_CategoryTableAdapter1.ClearBeforeFill = True
        '
        'SubCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 293)
        Me.Controls.Add(Me.grid_category)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "SubCategory"
        Me.Text = "SubCategory"
        CType(Me.grid_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TBCategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_InventoryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_InventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_gotom As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents grid_category As System.Windows.Forms.DataGridView
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtb_SubName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtb_SubID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DB_InventoryDataSet As InventorySystem.DB_InventoryDataSet
    Friend WithEvents TBCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_CategoryTableAdapter As InventorySystem.DB_InventoryDataSetTableAdapters.TB_CategoryTableAdapter
    Friend WithEvents DB_InventoryDataSet2 As InventorySystem.DB_InventoryDataSet2
    Friend WithEvents TBCategoryBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TB_CategoryTableAdapter1 As InventorySystem.DB_InventoryDataSet2TableAdapters.TB_CategoryTableAdapter
    Friend WithEvents combo_catnam As ComboBox
End Class
