using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace CourseWork
{
    public partial class MainWindow : Form
    {
        private GViewer gViewer1;
        private GViewer gViewer2;
        private GViewer gViewer3;
        bool[] visited = new bool[100];
        bool[] used = new bool[100];
        int n, m;
        int points = 0;
        private Graph graph1 = new Graph();
        private Graph graph2 = new Graph();
        private Data data;

        public MainWindow()
        {
            InitializeComponent();
            labelForEdge.Hide();
            labelForNode.Hide();
            textBoxForEdge.Hide();
            textBoxForNode.Hide();
            labelForCountCity.Hide();
            textBoxCountPoint.Hide();
            goToSecondTask.Hide();
            pictureBox2.Hide();
            groupBox1.Hide();
            Send1.Hide();
            Send2.Hide();
            
            gViewer1 = new GViewer()
            {
                Dock = DockStyle.Fill
            };
            gViewer2 = new GViewer()
            {
                Dock = DockStyle.Fill
            };
            gViewer3 = new GViewer()
            {
                Dock = DockStyle.Fill
            };
            SuspendLayout();
            task.Controls.Add(gViewer1);
            
            ResumeLayout();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            labelForEdge.Show();
            labelForNode.Show();
            textBoxForEdge.Show();
            textBoxForNode.Show();
            task.Show();
            Send1.Show();
            goToFirstTask.Hide();
            pictureBox1.Hide();
            label1.Hide();
            data = new Data(new StreamReader("C:\\Users\\user\\Desktop\\Старый ноут\\Курсовая работа Аврааменко\\CourseWork\\6_1.txt"));

            for (int i = 0; i < data.GetTreeData.Count; i++) 
                if (!used[i])
                    dfs(i, ref graph1);
            ShowInfoAboutGraph(ref graph1, ref gViewer1);
            
            
        }

        private void dfs(int v, ref Graph graph)
        {
            used[v] = true;
            for (int i = data.GetTreeData[v].Childs.Count -1 ; i >= 0; i--)
            {
                int to = data.GetTreeData[v].Childs[i];
                if (!used[to])
                {
                    graph.AddEdge((data.GetTreeData[v].ID + 1).ToString(),
                      (data.GetTreeData[v].Childs[i] + 1).ToString()).Attr.ArrowheadAtTarget = ArrowStyle.Normal;
                    m++;
                    dfs(to, ref graph);
                }
            }
        } //нужно для отрисовки дерева

        private int comp(int v)
        {
            int visitedVertices = 1;
            visited[v] = true;               // помечаем вершину как пройденную
            for (int i = 0; i < data.GetTreeData[v].Childs.Count; i++) 
            { 
                int to = data.GetTreeData[v].Childs[i];                      // проходим по смежным с v вершинам
                if (!visited[to])                    // проверяем, не находились ли мы ранее в выбранной вершине
                {
                    visitedVertices += comp(to);
                    Console.WriteLine(visitedVertices);
                }
            }
            return visitedVertices;
        }
        private int getEdge()//возвращает количество ребер
        {
            int edge = 0;
            for (int i = 0; i < data.GetTreeData.Count; i++)
                for (int j = 0; j < data.GetTreeData[i].Childs.Count; j++)
                    if (data.GetTreeData[i].Childs[j] > i)
                        edge++;
            return edge;
        }
        private bool check() // проверка, является ли граф деревом
        {
            n = data.GetTreeData.Count;
            m = getEdge();
            if (comp(0) == n && n == m + 1) 
                return true;

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Граф не является деревом", "Некорректные данные", buttons);

            return false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void Send1_Click(object sender, EventArgs e)
        {
            if (textBoxForNode.Text == "6" && textBoxForEdge.Text == "6")
            {
                MessageBox.Show("Верно");
                points += 25;
                labelForPoints.Text = "Количество баллов: " + points.ToString();
            }
            else MessageBox.Show("Не верно. На рисунке 6 ребёр и 6 вершин");
            labelForEdge.Hide();
            labelForNode.Hide();
            textBoxForEdge.Hide();
            textBoxForNode.Hide();

            label1.Show();
            label1.Text = "Графы используются не только в математике. Так, например, люди\nчасто пользуются графами, не догадываясь об этом, когда изображают\nразличные объекты: населенные пункты, карты городов, схемы\nэлектроприборов, атомы.Схема метро это тоже граф: вершины конечные \nстанции и станции пересадок, ребра – пути, соединяющие эти станции.\nДворянство тоже применяло графы для создания генеалогического дерева. \nВ них вершины – это члены рода, а связывающие их линии -отношения\nродственности, ведущие от родителей к детям.Ниже приведен \nфрагмент родословной А.С.Пушкина.";
            goToSecondTask.Show();
            goToFirstTask.Hide();
            groupBox1.Hide();
            Send1.Hide();
            pictureBox2.Show();

        }

        private void Send2_Click(object sender, EventArgs e)
        {
            if (textBoxCountPoint.Text == "8")
            {
                MessageBox.Show("Верно! Ты молодец!");
                points += 25;
                labelForPoints.Text = "Количество баллов: " + points.ToString();
            }
            else MessageBox.Show("Не верно, правильный ответ 8");
        }

        private void GoToSecondTask_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            goToSecondTask.Hide();
            labelForCountCity.Show();
            labelForCountCity.Text = "На рисунке — схема дорог, связывающих города А, Б, В, Г, Д, Е, Ж и К. \nПо каж­дой дороге можно двигаться только в одном направлении, указанном\nстрелкой.Сколько существует различных путей из города А в город K?";
            textBoxCountPoint.Show();
            Send2.Show();
            groupBox1.Show();
            label1.Hide();

            data = new Data(new StreamReader("C:\\Users\\user\\Desktop\\Старый ноут\\Курсовая работа Аврааменко\\CourseWork\\oge.txt"));
            for (int i = 0; i < 100; i++)
            {
                used[i] = false;
                visited[i] = false;
            }
            for (int i = 0; i < data.GetTreeData.Count; i++)
                for (int j = data.GetTreeData[i].Childs.Count - 1; j >= 0; j--)
                {
                    int to = data.GetTreeData[i].Childs[j];
                    if (!used[to])
                    {
                        graph2.AddEdge((data.GetTreeData[i].ID + 1).ToString(),
                          (data.GetTreeData[i].Childs[j] + 1).ToString()).Attr.ArrowheadAtTarget = ArrowStyle.Normal;
                        m++;
                    }
                }

            ShowInfoAboutGraph(ref graph2, ref gViewer2);
        }

        private void ShowInfoAboutGraph(ref Graph graph, ref GViewer gViewer)
        {
            String alphabet = "АБВГДЕЖKИКЛМНОПРСТ";
            int k = 0;
            foreach (Node item in graph.Nodes)
            {
                item.LabelText = alphabet[k].ToString();
                k++;
                item.Attr.XRadius = 15;
                item.Attr.YRadius = 15;
            }
            //if (check())
            //{
                task.Controls.Clear();
                task.Controls.Add(gViewer);
                gViewer.Graph = graph;
            //}

        }
    }
}