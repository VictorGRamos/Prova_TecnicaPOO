using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3A1_VICTORGONÇALVES_42.Code.BLL;
using _3A1_VICTORGONÇALVES_42.Code.DTO;

namespace _3A1_VICTORGONÇALVES_42
{
    public partial class Form1 : Form
    {

        JogosDTO jogosDTO = new JogosDTO();
        JogosBLL jogosBLL = new JogosBLL();

        public Form1()
        {
            InitializeComponent();
        }

        public void LimparTxt() 
        {
            txt_id.Clear();
            txt_nomejogo.Clear();
            txt_preco.Clear();
            txt_quantidade.Clear();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            jogosDTO.Nomejogo = txt_nomejogo.Text;
            jogosDTO.Preco = double.Parse(txt_preco.Text);
            jogosDTO.Quantidade = int.Parse(txt_quantidade.Text);

            jogosBLL.Inserir(jogosDTO);

            MessageBox.Show("Cadastro feito com sucesso!", "SavassiGames", MessageBoxButtons.OK);

            LimparTxt();

            jogosBLL.Listar();
        }


        private void btn_editar_Click(object sender, EventArgs e)
        {
           
            jogosDTO.Id = int.Parse(txt_id.Text);
            jogosDTO.Nomejogo = txt_nomejogo.Text;
            jogosDTO.Preco = double.Parse(txt_preco.Text);
            jogosDTO.Quantidade = int.Parse(txt_quantidade.Text);

            jogosBLL.Editar(jogosDTO);

            MessageBox.Show("Alteração feito com sucesso!", "SavassiGames", MessageBoxButtons.OK);

            jogosBLL.Listar();

            LimparTxt();
        }

      

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           
            jogosDTO.Id = int.Parse(txt_id.Text);

            jogosBLL.Exclui(jogosDTO);

            MessageBox.Show("Excluido com sucesso!", "SavassiGames", MessageBoxButtons.OK);

            jogosBLL.Listar();

            LimparTxt();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtg_estoque.DataSource = jogosBLL.Listar();
            dtg_estoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_estoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dtg_estoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            txt_id.Text = dtg_estoque.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nomejogo.Text = dtg_estoque.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_preco.Text = dtg_estoque.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_quantidade.Text = dtg_estoque.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
    }
}
