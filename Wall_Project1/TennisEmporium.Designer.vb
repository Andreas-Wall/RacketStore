<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TennisEmporium
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TennisEmporium))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.loginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblProductBrand = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.lblProductQuantity = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pbxImage = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menuStrip1.SuspendLayout()
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Sitka Subheading", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(249, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 47)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Tennis Emporium!"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.aboutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.menuStrip1.TabIndex = 3
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exitToolStripMenuItem, Me.loginToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.exitToolStripMenuItem.Text = "&Exit"
        '
        'loginToolStripMenuItem
        '
        Me.loginToolStripMenuItem.Name = "loginToolStripMenuItem"
        Me.loginToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.loginToolStripMenuItem.Text = "&Report"
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.aboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "A&bout"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(490, 97)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(78, 13)
        Me.lblProductName.TabIndex = 4
        Me.lblProductName.Text = "Product Name:"
        '
        'lblProductBrand
        '
        Me.lblProductBrand.AutoSize = True
        Me.lblProductBrand.Location = New System.Drawing.Point(499, 136)
        Me.lblProductBrand.Name = "lblProductBrand"
        Me.lblProductBrand.Size = New System.Drawing.Size(69, 13)
        Me.lblProductBrand.TabIndex = 5
        Me.lblProductBrand.Text = "Brand Name:"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(494, 213)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(74, 13)
        Me.lblProductPrice.TabIndex = 6
        Me.lblProductPrice.Text = "Product Price:"
        '
        'lblProductQuantity
        '
        Me.lblProductQuantity.AutoSize = True
        Me.lblProductQuantity.Location = New System.Drawing.Point(519, 175)
        Me.lblProductQuantity.Name = "lblProductQuantity"
        Me.lblProductQuantity.Size = New System.Drawing.Size(49, 13)
        Me.lblProductQuantity.TabIndex = 7
        Me.lblProductQuantity.Text = "Quantity:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(470, 255)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(103, 13)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Product Description:"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(605, 92)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(158, 23)
        Me.lblName.TabIndex = 9
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBrand
        '
        Me.lblBrand.BackColor = System.Drawing.SystemColors.Control
        Me.lblBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBrand.Location = New System.Drawing.Point(605, 131)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(158, 23)
        Me.lblBrand.TabIndex = 10
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuantity.Location = New System.Drawing.Point(605, 170)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(158, 23)
        Me.lblQuantity.TabIndex = 11
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Location = New System.Drawing.Point(605, 208)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(158, 23)
        Me.lblPrice.TabIndex = 12
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDesc.Location = New System.Drawing.Point(0, 1)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(163, 203)
        Me.lblDesc.TabIndex = 13
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(21, 394)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 14
        Me.btnFirst.Text = "&First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(123, 357)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(21, 357)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 16
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(123, 394)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 17
        Me.btnLast.Text = "&Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.Location = New System.Drawing.Point(312, 357)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(161, 60)
        Me.btnAddToCart.TabIndex = 18
        Me.btnAddToCart.Text = "&Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Location = New System.Drawing.Point(685, 415)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(103, 23)
        Me.btnCheckOut.TabIndex = 19
        Me.btnCheckOut.Text = "&CheckOut"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Graphene 360 Speed Pro.jpg")
        Me.ImageList1.Images.SetKeyName(1, "Radical Oversize Ltd.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Pure Drive VS.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Aero G.jpg")
        Me.ImageList1.Images.SetKeyName(4, "Textreme Tour 95 Racquets.jpg")
        Me.ImageList1.Images.SetKeyName(5, "Phantom Pro 93P (14x18).jpg")
        Me.ImageList1.Images.SetKeyName(6, "head bag.jpg")
        Me.ImageList1.Images.SetKeyName(7, "babolat bag.jpg")
        Me.ImageList1.Images.SetKeyName(8, "Dunlop Strings.jpg")
        Me.ImageList1.Images.SetKeyName(9, "head strings.jpg")
        '
        'pbxImage
        '
        Me.pbxImage.Location = New System.Drawing.Point(21, 66)
        Me.pbxImage.Name = "pbxImage"
        Me.pbxImage.Size = New System.Drawing.Size(200, 250)
        Me.pbxImage.TabIndex = 20
        Me.pbxImage.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Location = New System.Drawing.Point(605, 254)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 139)
        Me.Panel1.TabIndex = 21
        '
        'TennisEmporium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbxImage)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblProductQuantity)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.lblProductBrand)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.name = "TennisEmporium"
        Me.Text = "TennisEmporium"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents fileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents loginToolStripMenuItem As ToolStripMenuItem
    Private WithEvents aboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblProductBrand As Label
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents lblProductQuantity As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents pbxImage As PictureBox
    Friend WithEvents Panel1 As Panel
    Public WithEvents ImageList1 As ImageList
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
End Class
