﻿namespace GerenciamentoProduto
{
    partial class FormBemVindo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleFinanceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.atualizarTabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.atualizarTabelaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProdutoToolStripMenuItem,
            this.editarProdutoToolStripMenuItem,
            this.excluirProdutoToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.novoProdutoToolStripMenuItem.Text = "Novo produto";
            this.novoProdutoToolStripMenuItem.Click += new System.EventHandler(this.novoProdutoToolStripMenuItem_Click);
            // 
            // editarProdutoToolStripMenuItem
            // 
            this.editarProdutoToolStripMenuItem.Name = "editarProdutoToolStripMenuItem";
            this.editarProdutoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editarProdutoToolStripMenuItem.Text = "Editar produto";
            this.editarProdutoToolStripMenuItem.Click += new System.EventHandler(this.editarProdutoToolStripMenuItem_Click);
            // 
            // excluirProdutoToolStripMenuItem
            // 
            this.excluirProdutoToolStripMenuItem.Name = "excluirProdutoToolStripMenuItem";
            this.excluirProdutoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.excluirProdutoToolStripMenuItem.Text = "Excluir produto";
            this.excluirProdutoToolStripMenuItem.Click += new System.EventHandler(this.excluirProdutoToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDeEstoqueToolStripMenuItem,
            this.controleFinanceiroToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.controleDeEstoqueToolStripMenuItem.Text = "Controle de estoque";
            this.controleDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.controleDeEstoqueToolStripMenuItem_Click);
            // 
            // controleFinanceiroToolStripMenuItem
            // 
            this.controleFinanceiroToolStripMenuItem.Name = "controleFinanceiroToolStripMenuItem";
            this.controleFinanceiroToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.controleFinanceiroToolStripMenuItem.Text = "Controle financeiro";
            this.controleFinanceiroToolStripMenuItem.Click += new System.EventHandler(this.controleFinanceiroToolStripMenuItem_Click);
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(12, 37);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(650, 456);
            this.listViewProdutos.TabIndex = 32;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.SelectedIndexChanged += new System.EventHandler(this.listViewProdutos_SelectedIndexChanged);
            // 
            // atualizarTabelaToolStripMenuItem
            // 
            this.atualizarTabelaToolStripMenuItem.Name = "atualizarTabelaToolStripMenuItem";
            this.atualizarTabelaToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.atualizarTabelaToolStripMenuItem.Text = "Atualizar tabela";
            this.atualizarTabelaToolStripMenuItem.Click += new System.EventHandler(this.atualizarTabelaToolStripMenuItem_Click);
            // 
            // FormBemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 505);
            this.Controls.Add(this.listViewProdutos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBemVindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem vindo";
            this.Load += new System.EventHandler(this.FormBemVindo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleFinanceiroToolStripMenuItem;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ToolStripMenuItem atualizarTabelaToolStripMenuItem;
    }
}

