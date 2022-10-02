using LibSaper;
using System;
using System.Windows.Forms;

namespace GameSaper
{
    public partial class Form1 : Form
    {
        int countLose;
        int countWin;

        ClassAllCells field;
        public Form1()
        {
            InitializeComponent();
            countLose = countWin = 0;
            field = new ClassAllCells();
            FillInTheTableCells(9);
            field.LoseGameEvent += LoseGame;
            field.WinGameEvent += WinGame;
            lbLose.Text = "Поражений: " + countLose.ToString();
            lbWin.Text = "Побед: " + countWin.ToString();
        }

        private void LoseGame() 
        {
            MessageBox.Show("Игра окончена(");
            lbResult.Text = "Результат: проигрыш";
            countLose++;
            lbLose.Text = "Поражений: " + countLose.ToString();
        }

        private void WinGame()
        {
            MessageBox.Show("Вы победили!!!!");
            lbResult.Text = "Результат: победа";
            countWin++;
            lbWin.Text = "Побед: " + countWin.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mINewGame_Click(object sender, EventArgs e)
        {
            field = new ClassAllCells();
            tableLayoutPanel1.Controls.Clear();
            FillInTheTableCells(9); 
        }


        private void FillInTheTableCells(int x)
        {
            lbResult.Text = "";
            tableLayoutPanel1.ColumnCount = x;
            tableLayoutPanel1.RowCount = x;
            tableLayoutPanel1.Height = 48 * x;
            tableLayoutPanel1.Width = 48 * x;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    tableLayoutPanel1.Controls.Add(field.cells[i, j], i, j);
                }
                tableLayoutPanel1.RowStyles[i].Height = 48;
                tableLayoutPanel1.ColumnStyles[i].Width = 48;
            }
        }

        private void mIAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила игры следующие:                                                                                   " +
              "Игровое поле состоит из клеток, в каждой из которых может быть мина.Мины размещаются в поле случайным образом.Задача играющего – найти все мины и пометить их флажками.Используя кнопки мыши, игрок может открыть клетку или поставить в нее флажок, указав тем самым, что в клетке обнаружена мина.Клетка открывается щелчком левой кнопки мыши, а флажок ставится щелчком правой." +
              "Если в клетке, которую открыл игрок, есть мина, то происходит взрыв и игра заканчивается поражением игрока.Если в клетке мины нет, то в этой клетке появляется число, соответствующее количеству мин, находящихся в соседних клетках." +
              "Анализируя информацию о количестве мин в клетках, соседних с уже открытыми, игрок может обнаружить и пометить флажками все мины.Ограничений на количество клеток, помеченных флажками, нет.Ошибочно установленный флажок можно убрать, щелкнув правой кнопкой мыши в клетке, в которой он находится." +
              "Для удачного завершения игры(выигрыша) флажки должны быть установлены только в тех клетках, в которых есть мины." +
              "");
        }
    }
}
