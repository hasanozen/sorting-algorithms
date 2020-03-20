using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        public static Form1 Instance { get; private set; }
        public static bool isSorted { get; set; }

        static Settings Settings { get; set; } //TODO: Add Array accesses and comparisons
        Bitmap DrawArea;
        COLOR colorStatus;

        public static int upperSize;
        public static int delayMs;
        public static int arrayAccess;
        public static int comparison;
        string methodName_lb;

        public Form1()
        {
            InitializeComponent();

            if (Instance == null)
            {
                Instance = this;
            }

            this.Icon = new Icon("Resources/Icons/large_E3s_icon.ico");

            upperSize = visualArea.Height;

            DrawArea = new Bitmap(visualArea.Size.Width, visualArea.Size.Height);
            visualArea.Image = DrawArea;

            Settings = new Settings(Defaults.RND, Defaults.SIZE, Defaults.LOWER_LIMIT,
                Defaults.UPPER_LIMIT, Defaults.DELAY, Defaults.COLORIZED, Defaults.STYLE);

            MethodNames.Init();
            Colorization.Init();
            VisualStyleNames.Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nud_Delay.Maximum = 200;

            lbl_Infos.Text = " ";
            lbl_Infos.BackColor = Color.Black;
            lbl_Infos.ForeColor = Color.White;
            
            lbl_Status.BackColor = Color.Black;
            lbl_Status.ForeColor = Color.White;

            visualArea.BackColor = Color.Black;
            list_History.BorderStyle = BorderStyle.None;

            btn_Generate.FlatStyle = FlatStyle.Flat;
            btn_Generate.BackColor = Colorization.ColorSchema[0];
            btn_Generate.ForeColor = Color.White;

            btn_Sort.FlatStyle = FlatStyle.Flat;
            btn_Sort.BackColor = Colorization.ColorSchema[2];
            btn_Sort.ForeColor = Color.White;

            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.BackColor = Colorization.ColorSchema[3];
            btn_Cancel.ForeColor = Color.White;
            
            tb_Size.Text = Settings.Size.ToString();
            nud_Delay.Value = Settings.Delay;

            for (int i = 1; i < MethodNames.Methods.Count + 1; i++)
            {
                cb_Algorithm.Items.Add(MethodNames.Methods[i].ToString());
            }

            for (int i = 1; i < VisualStyleNames.VisualStyle.Count + 1; i++)
            {
                cb_Style.Items.Add(VisualStyleNames.VisualStyle[i].ToString());
            }

            cb_Style.SelectedIndex = 0;

        }

        private void tb_Size_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_Size.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tb_Size.Text = tb_Size.Text.Remove(tb_Size.Text.Length - 1);
            }
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            btn_Sort.Text = "SORT";

            GetSettings();
            CreateArray();
        }

        Thread thread;
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            arrayAccess = 0;
            comparison = 0;

            isSorted = false;

            if (ArrayHolder.Arr == null)
            {
                MessageBox.Show("A created string was not found. Created with default settings.");
                GetSettings();
                CreateArray();
            }

            SetAlgorithm();
        }

        private void SetAlgorithm()
        {
            int selectedIndex = cb_Algorithm.SelectedIndex + 1;

            string selectedAlgorithm;
            try
            {
                selectedAlgorithm = MethodNames.Methods[selectedIndex];
                methodName_lb = MethodNames.Methods[selectedIndex].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.\n" + ex.Message);
                selectedAlgorithm = MethodNames.Methods[2];
                throw;
            }

            switch (selectedAlgorithm)
            {
                case "Selection Sort":
                    thread = new Thread(() => Algorithms.Selection(ArrayHolder.Arr));
                    thread.Start();
                    ThreadingArrayVisualSet();
                    AddRecent();
                    break;
                case "Bubble Sort":
                    thread = new Thread(() => Algorithms.Bubble(ArrayHolder.Arr));
                    thread.Start();
                    ThreadingArrayVisualSet();
                    SetStatus();
                    AddRecent();
                    break;
                case "Coctail Sort":
                    thread = new Thread(() => Algorithms.Cocktail(ArrayHolder.Arr));
                    thread.Start();
                    ThreadingArrayVisualSet();
                    SetStatus();
                    AddRecent();
                    break;
                case "Odd-Even Sort":
                    thread = new Thread(() => Algorithms.OddEven(ArrayHolder.Arr));
                    thread.Start();
                    ThreadingArrayVisualSet();
                    SetStatus();
                    AddRecent();
                    break;
                case "Comb Sort":
                    thread = new Thread(() => Algorithms.Comb(ArrayHolder.Arr));
                    thread.Start();
                    ThreadingArrayVisualSet();
                    SetStatus();
                    AddRecent();
                    break;
                case "Insertion Sort":
                    thread = new Thread(() => Algorithms.Insertion(ArrayHolder.Arr));
                    thread.Start();
                    ThreadingArrayVisualSet();
                    SetStatus();
                    AddRecent();
                    break;
                case "Shell Sort":
                    thread = new Thread(() => Algorithms.Shell(ArrayHolder.Arr));
                    thread.Start();
                    ThreadingArrayVisualSet();
                    SetStatus();
                    AddRecent();
                    break;
                case "Merge Sort":
                    thread = new Thread(() => Algorithms.MergeSort(ArrayHolder.Arr, 0,
                        Settings.Size - 1, Settings.Size));
                    thread.Start();
                    ThreadingArrayVisualSet();
                    SetStatus();
                    AddRecent();
                    break;
                case "Counting Sort":
                    thread = new Thread(() => Algorithms.CountSort(ArrayHolder.Arr));
                    thread.Start();
                    ThreadingArrayVisualSet();
                    SetStatus();
                    AddRecent();
                    break;
                case "Quick Sort":
                    thread = new Thread(() => Algorithms.QuickSort(ArrayHolder.Arr, 0, ArrayHolder.Arr.Length - 1));
                    thread.Start();
                    ThreadingArrayVisualSet();
                    SetStatus();
                    AddRecent();
                    break;
                default:
                    MessageBox.Show("Select valid algorithm");
                    break;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            thread.Abort();
            isSorted = false;
            btn_Sort.Text = "CONTINUE";
        }

        public void SetStatus()
        {
            lbl_Status.Text = isSorted == true ? STATUS.SORTED.ToString() : STATUS.SORTING.ToString();
        }

        private void ThreadingArrayVisualSet()
        {
            int visualDelay = Settings.Delay + 1;

            while (thread.IsAlive)
            {
                Application.DoEvents();
                Thread.Sleep(visualDelay);
                SetStatus();
                VisualizeArray();
            }

            VisualizeArray();
            isSorted = true;
            SetStatus();
        }

        private void GetSettings()
        {
            int size = Convert.ToInt32(tb_Size.Text);
            int delay = (int)nud_Delay.Value;
            bool isColor = chb_Color.Checked == true ? isColor = true : isColor = false;
            int style = cb_Style.SelectedIndex;

            ApplySettings(size, delay, isColor, style);
            delayMs = Settings.Delay;
        }

        private void ApplySettings(int size = Defaults.SIZE, int delay = Defaults.DELAY, bool isColor = Defaults.COLORIZED,
            int style = Defaults.STYLE, bool isRnd = Defaults.RND, int lower = Defaults.LOWER_LIMIT, int upper = Defaults.UPPER_LIMIT)
        {
            Settings = new Settings(isRnd, size, lower, upper, delay, isColor, style);
        }

        private void CreateArray()
        {
            ArrayHolder.Arr = new int[Settings.Size];

            GenerateRandomNumbers();
        }

        private void GenerateRandomNumbers()
        {
            Random rnd = new Random();

            for (int i = 0; i < ArrayHolder.Arr.Length; i++)
                ArrayHolder.Arr[i] = rnd.Next(20, visualArea.Size.Height - 10);

            lbl_Status.Text = STATUS.GENERATED.ToString();

            VisualizeArray();
        }

        Graphics g;
        Pen myPen;
        public void VisualizeArray()
        {
            g = Graphics.FromImage(DrawArea);
            myPen = new Pen(Brushes.White);
            myPen.Width = visualArea.Size.Width / (float)ArrayHolder.Arr.Length;

            colorStatus = Settings.IsColor == true ? COLOR.POLI : COLOR.MONO;

            g.Clear(visualArea.BackColor);

            float x1 = 0;
            float y1 = visualArea.Size.Height;
            float increase = myPen.Width;

            for (int i = ArrayHolder.Arr.Length - 1; i >= 0; i--)
            {
                if (colorStatus == COLOR.POLI)
                {
                    int c = ArrayHolder.Arr[i] % 7;
                    myPen.Color = Colorization.ColorSchema[c];
                }

                if (Settings.VisualizeStyle == 0)
                {
                    LineVisualize(myPen, x1, y1, i);
                    UpdateInfos();
                }
                else if (Settings.VisualizeStyle == 1)
                {
                    DotVisualize(myPen, x1, i);
                    UpdateInfos();
                }
                else
                    MessageBox.Show("Visualization unsuccessfull. Check your settings.");

                x1 += increase;
            }

            visualArea.Refresh();
        }

        private void LineVisualize(Pen pen, float x, float y, int i)
        {
            g.DrawLine(myPen, x, y, x, ArrayHolder.Arr[i]);
        }

        private void DotVisualize(Pen pen, float x, int i)
        {
            Rectangle rect = new Rectangle((int)x, ArrayHolder.Arr[i], 1, 1);
            g.DrawEllipse(myPen, rect);
        }

        private void AddRecent()
        {
            list_History.Items.Add("> " + methodName_lb + " (" + Settings.Size + "," + Settings.Delay +")");
            list_History.Items.Add("   Sorted in " + Algorithms.sortTime.Elapsed);
            list_History.Items.Add("   Comparison: " + comparison);
            list_History.Items.Add("   Arr Access: " + arrayAccess);
            list_History.Items.Add("\n");
        }
        
        private void UpdateInfos()
        {
            lbl_Infos.Text = "Comparisons: " + comparison + " | " + "Array Accesses: " + arrayAccess;
        }

        private void visualArea_SizeChanged(object sender, EventArgs e)
        {
            upperSize = visualArea.Height;

            DrawArea.Dispose();

            DrawArea = new Bitmap(visualArea.Size.Width, visualArea.Size.Height);
            visualArea.Image = DrawArea;

            if (ArrayHolder.Arr != null && ArrayHolder.Arr.Length > 0)
                VisualizeArray();
        }

        private void chb_Color_CheckedChanged(object sender, EventArgs e)
        {
            Settings.IsColor = chb_Color.Checked == true ? Settings.IsColor = true : Settings.IsColor = false;

            CheckArrayAndVisualize();
        }

        private void cb_Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.VisualizeStyle = cb_Style.SelectedIndex;

            CheckArrayAndVisualize();
        }

        private void nud_Delay_ValueChanged(object sender, EventArgs e)
        {
            Settings.Delay = (int)nud_Delay.Value;

            CheckArrayAndVisualize();
        }

        private void CheckArrayAndVisualize()
        {
            if (ArrayHolder.Arr != null && ArrayHolder.Arr.Length > 0)
                VisualizeArray();
        }
    }
}
