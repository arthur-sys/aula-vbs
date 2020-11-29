<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerernciamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BloquearContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.GerernciamentoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FuncionariosToolStripMenuItem, Me.FornecedoresToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Image = Global.euuu.My.Resources.Resources.home_icon
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CadastroToolStripMenuItem.Text = "&Cadastro"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FuncionariosToolStripMenuItem
        '
        Me.FuncionariosToolStripMenuItem.Name = "FuncionariosToolStripMenuItem"
        Me.FuncionariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FuncionariosToolStripMenuItem.Text = "Funcionarios"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'GerernciamentoToolStripMenuItem
        '
        Me.GerernciamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContasLoginToolStripMenuItem})
        Me.GerernciamentoToolStripMenuItem.Name = "GerernciamentoToolStripMenuItem"
        Me.GerernciamentoToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.GerernciamentoToolStripMenuItem.Text = "&Gerenciamento "
        '
        'ContasLoginToolStripMenuItem
        '
        Me.ContasLoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriarContaToolStripMenuItem, Me.AlterarContaToolStripMenuItem, Me.BloquearContaToolStripMenuItem})
        Me.ContasLoginToolStripMenuItem.Name = "ContasLoginToolStripMenuItem"
        Me.ContasLoginToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContasLoginToolStripMenuItem.Text = "Contas Login"
        '
        'CriarContaToolStripMenuItem
        '
        Me.CriarContaToolStripMenuItem.Name = "CriarContaToolStripMenuItem"
        Me.CriarContaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CriarContaToolStripMenuItem.Text = "Criar Conta"
        '
        'AlterarContaToolStripMenuItem
        '
        Me.AlterarContaToolStripMenuItem.Name = "AlterarContaToolStripMenuItem"
        Me.AlterarContaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AlterarContaToolStripMenuItem.Text = "Alterar Conta"
        '
        'BloquearContaToolStripMenuItem
        '
        Me.BloquearContaToolStripMenuItem.Name = "BloquearContaToolStripMenuItem"
        Me.BloquearContaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BloquearContaToolStripMenuItem.Text = "Bloquear Conta "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerernciamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CriarContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BloquearContaToolStripMenuItem As ToolStripMenuItem
End Class
