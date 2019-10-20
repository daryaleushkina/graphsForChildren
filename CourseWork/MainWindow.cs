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
        const int INF = 1000000000;
        private GViewer gViewer;
        bool[] visited = new bool[100];
        bool[] used = new bool[100];
        int n, m;
        int points = 0;
        private Graph graph1 = new Graph();
        private Graph graph2 = new Graph();
        private Graph graph3 = new Graph();
        private Graph graph4 = new Graph();
        private Data data;

        public MainWindow()
        {
            InitializeComponent();
            labelForEdge.Hide();
            labelForNode.Hide();
            textBoxForEdge.Hide();
            textBoxForNode.Hide();
            labelForTask.Hide();
            textBoxForTask.Hide();
            goToSecondTask.Hide();
            goToThirdTask.Hide();
            goToTask4.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            groupBox1.Hide();
            Send1.Hide();
            Send2.Hide();
            Send3.Hide();
            Send4.Hide();

            gViewer = new GViewer()
            {
                Dock = DockStyle.Fill
            };
            gViewer = new GViewer()
            {
                Dock = DockStyle.Fill
            };
            gViewer = new GViewer()
            {
                Dock = DockStyle.Fill
            };
            SuspendLayout();
            task.Controls.Add(gViewer);
            
            ResumeLayout();
        }

        private void goToFirstTask_Click(object sender, EventArgs e)
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
            labelForTheory.Hide();
            data = new Data(new StreamReader("C:\\Users\\user\\Desktop\\Старый ноут\\Курсовая работа Аврааменко\\CourseWork\\6_1.txt"));

            for (int i = 0; i < data.GetTreeData.Count; i++) 
                if (!used[i])
                    dfs(i, ref graph1);
            if (check())
                ShowInfoAboutGraph(ref graph1, ref gViewer);
            
            
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
            if (textBoxForNode.Text == "6" && textBoxForEdge.Text == "5")
            {
                MessageBox.Show("Верно! Дерзай дальше!", "Переход к следующему вопросу");
                points += 25;
                labelForPoints.Text = "Количество баллов: " + points.ToString();
            }
            else MessageBox.Show("Не верно. На рисунке 6 вершин и 5 ребер");
            labelForEdge.Hide();
            labelForNode.Hide();
            textBoxForEdge.Hide();
            textBoxForNode.Hide();

            labelForTheory.Show();
            labelForTheory.Text = "Графы используются не только в математике. Так, например, люди\nчасто пользуются графами, не догадываясь об этом, когда изображают\nразличные объекты: населенные пункты, карты городов, схемы\nэлектроприборов, атомы.Схема метро это тоже граф: вершины конечные \nстанции и станции пересадок, ребра – пути, соединяющие эти станции.\nДворянство тоже применяло графы для создания генеалогического дерева. \nВ них вершины – это члены рода, а связывающие их линии -отношения\nродственности, ведущие от родителей к детям.Ниже приведен \nфрагмент родословной А.С.Пушкина.";
            goToSecondTask.Show();
            goToFirstTask.Hide();
            groupBox1.Hide();
            Send1.Hide();
            pictureBox2.Show();

        }

        private void Send2_Click(object sender, EventArgs e)
        {
            if (textBoxForTask.Text == "8")
            {
                MessageBox.Show("Верно! Ты молодец!");
                points += 25;
                labelForPoints.Text = "Количество баллов: " + points.ToString();

            }
            else MessageBox.Show("Не верно, правильный ответ 8", "Переход к следующему вопросу");
            labelForTheory.Text = "Взвешенный граф — граф, каждому ребру которого поставлено \nв соответствие некое значение(вес ребра) \nВес любого пути будем называть длиной  этого пути. Ясно, \nчто между двумя вершинами существует такой путь, который\nимеет минимальную возможную длину. Эта длина и называется \nрасстоянием между двумя вершинами. Путь, который эту длину\nреализует, естественно, называется кратчайшим.";
            labelForTheory.Show();
            labelForTask.Text = "Между населёнными пунктами A, B, C, D, E, F построены дороги,  \nпротяжённость которых(в километрах) изображена на рёбрах. \nОпределите длину кратчайшего пути между пунктами B и C.\nПередвигаться можно только по дорогам.";
            labelForTask.Hide();
            groupBox1.Hide();
            textBoxForTask.Clear();
            textBoxForTask.Hide();
            Send2.Hide();
            pictureBox3.Show();
            goToThirdTask.Show();
        }

        private void GoToSecondTask_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            goToSecondTask.Hide();
            labelForTask.Show();
            labelForTask.Text = "На рисунке — схема дорог, связывающих города А, Б, В, Г, Д, Е, Ж и К. \nПо каж­дой дороге можно двигаться только в одном направлении, указанном\nстрелкой.Сколько существует различных путей из города А в город K?";
            textBoxForTask.Show();
            Send2.Show();
            groupBox1.Show();
            labelForTheory.Hide();

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

            ShowInfoAboutGraph(ref graph2, ref gViewer);
        }

        private void GoToThirdTask_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            task.Show();
            goToThirdTask.Hide();
            pictureBox3.Hide();
            labelForTheory.Hide();
            labelForTask.Show();
            textBoxForTask.Show();
            Send3.Show();


            data = new Data(new StreamReader("C:\\Users\\user\\Desktop\\Старый ноут\\Курсовая работа Аврааменко\\CourseWork\\dist.txt"));
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
                        graph3.AddEdge((data.GetTreeData[i].ID + 1).ToString(),
                          (data.GetTreeData[i].Childs[j] + 1).ToString()).Attr.ArrowheadAtTarget = ArrowStyle.None;
                        m++;
                    }
                }

            String nameEdges = "3723112";
            int k = 0;
            foreach (Edge item in graph3.Edges)
            {
                item.LabelText = nameEdges[k].ToString();
                k++;
            }

            ShowInfoAboutGraph(ref graph3, ref gViewer);
        }

        private void Send3_Click(object sender, EventArgs e)
        {
            if (textBoxForTask.Text == "9")
            {
                MessageBox.Show("Отлично! Давай дальше!");
                points += 25;
                labelForPoints.Text = "Количество баллов: " + points.ToString();

            }
            else MessageBox.Show("Не верно, правильный ответ 9", "Переход к следующему вопросу");
            labelForTheory.Text = "\nБинарное дерево, это дерево в котором для любого узла выполняется \nследующее правило: потомки слева этого узла всегда меньше него,\nпотомки справа — всегда больше. Следовательно, такое дерево очень\nлегко превратить в сортированный массив, найти самое маленькое\nи самое большое значение, или же просто найти необходимое значение.";
            labelForTheory.Show();
            labelForTask.Text = "Найдите сумму всех потомков у красной вершины";
            labelForTask.Hide();
            groupBox1.Hide();
            textBoxForTask.Clear();
            textBoxForTask.Hide();
            Send3.Hide();
            pictureBox4.Show();
            goToTask4.Show();
        }

        private void GoToTask4_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            task.Show();
            goToTask4.Hide();
            pictureBox4.Hide();
            labelForTheory.Hide();
            labelForTask.Show();
            textBoxForTask.Show();
            Send4.Show();


            data = new Data(new StreamReader("C:\\Users\\user\\Desktop\\Старый ноут\\Курсовая работа Аврааменко\\CourseWork\\binTree.txt"));
            for (int i = 0; i < 100; i++)
            {
                used[i] = false;
                visited[i] = false;
            }
            for (int i = 0; i < data.GetTreeData.Count; i++)
                if (!used[i])
                    dfs(i, ref graph4);

            int k = 0;
            int[] binTree = { 100, 70, 150, 50, 90, 200, 55, 10, 170, 210, 60, 58, 65 };
            foreach (Node item in graph4.Nodes)
            {
                item.LabelText = binTree[k].ToString();
                k++;
                item.Attr.XRadius = 130;
                item.Attr.YRadius = 130;

            }
            if (check())
                ShowInfoAboutGraph(ref graph4, ref gViewer);
        }

        private void Send4_Click(object sender, EventArgs e)
        {
            if (textBoxForTask.Text == "248")
            {
                points += 25;
                labelForPoints.Text = "Количество баллов: " + points.ToString();
                if (points == 100)
                    MessageBox.Show("Ты набрал 100 из 100 баллов. Превосходно!", "Конец игры");
                else MessageBox.Show("Ты набрал " + points + " баллов из 100. Стоит немного подготовиться!", "Конец игры");
            }
            else MessageBox.Show("Не верно, правильный ответ 248. Ты набрал " + points + " баллов из 100. Стоит немного подготовиться", "Конец игры");

            
            labelForTheory.Text = "\nБинарное дерево, это дерево в котором для любого узла выполняется \nследующее правило: потомки слева этого узла всегда меньше него,\nпотомки справа — всегда больше. Следовательно, такое дерево очень\nлегко превратить в сортированный массив, найти самое маленькое\nи самое большое значение, или же просто найти необходимое значение.";
            labelForTheory.Show();
            labelForTask.Text = "Найдите сумму всех потомков у красной вершины";
            labelForTask.Hide();
            groupBox1.Hide();
            textBoxForTask.Clear();
            textBoxForTask.Hide();
            Send4.Hide();
            this.Close();
        }

        private void ShowInfoAboutGraph(ref Graph graph, ref GViewer gViewer)
        {
            String alphabet = "АБВГДЕЖKИКЛМНОПРСТ";
            int k = 0;
            foreach (Node item in graph.Nodes)
            {
                if (item.LabelText == "100")
                    break;
                else
                {
                    item.LabelText = alphabet[k].ToString();
                    k++;
                    item.Attr.XRadius = 15;
                    item.Attr.YRadius = 15;
                }
                
            }
            task.Controls.Clear();
            task.Controls.Add(gViewer);
            gViewer.Graph = graph;
            

        }

    }
   
}