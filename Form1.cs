using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace ConcurrentLab23
{
    public partial class MainWindow : Form
    {
        private volatile Stopwatch parallelSW;
        private volatile Stopwatch serialSW;
        private IForel serialForel;
        private IForel parallelForel;
        private List<Point> points;
        private Random random;
        private List<Cluster> ansSerial;
        private List<Cluster> ansParallel;

        public MainWindow()
        {
            InitializeComponent();
            serialBW.WorkerReportsProgress = true;
            serialBW.WorkerSupportsCancellation = true;
            parallelBW.WorkerReportsProgress = true;
            parallelBW.WorkerSupportsCancellation = true;
            parallelSW = new Stopwatch();
            serialSW = new Stopwatch();
            serialForel = new SerialForel();
            parallelForel = new ParallelForel();
            points = new List<Point>();
            random = new Random(111);
        }

        private void generatePoints(int amount, int dimensisons)
        {
            points.Clear();
            for (int i = 0; i < amount; i++)
            {
                var dims = new double[dimensisons];
                for (int d = 0; d < dimensisons; d++)
                {
                    dims[d] = random.NextDouble() * 100;
                }
                points.Add(new Point(dims));
            }
        }

        private void serialStartButton_Click(object sender, EventArgs e)
        {
            if (serialBW.IsBusy != true)
            {
                serialStartButton.Enabled = false;
                serialCancelButton.Enabled = true;
                generatePoints((int)numberElementsUpDown.Value, (int)numberDimenstionsUpDown.Value);
                serialSW.Start();
                serialBW.RunWorkerAsync();
            }
        }

        private void serialCancelButton_Click(object sender, EventArgs e)
        {
            serialBW.CancelAsync();
        }

        private void serialBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            double elapsed = Math.Round(serialSW.Elapsed.TotalMilliseconds);
            serialTimeLabel.Text = String.Format("{0} ms", elapsed);
            serialProgressBar.Value = e.ProgressPercentage;
        }

        private bool validateInput()
        {
            try
            {
                Convert.ToDouble(clusterRadiusInput.Text);
                return true;
            } catch(FormatException)
            {
                MessageBox.Show("Пример значения: 4,2", "Размер кластера указан неверно");
            }
            return false;
        }

        private void serialBW_DoWork(object sender, DoWorkEventArgs e)
        {
            if (validateInput())
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                Thread work = new Thread(() =>
                {
                    ansSerial = serialForel.Clusterise(points, Convert.ToDouble(clusterRadiusInput.Text));
                });
                work.Start();
                while (true)
                {
                    worker.ReportProgress(serialForel.getProgress());
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        work.Abort();
                        break;
                    }
                    if (!work.IsAlive)
                    {
                        break;
                    }
                    Thread.Sleep(100);
                }
            }
        }

        private void serialBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            serialSW.Reset();
            serialProgressBar.Value = 0;
            serialStartButton.Enabled = true;
            serialCancelButton.Enabled = false;
            serialPrintButton.Enabled = true;
        }

        private void parallelStartButton_Click(object sender, EventArgs e)
        {
            if (parallelBW.IsBusy != true)
            {
                parallelStartButton.Enabled = false;
                parallelCancelButton.Enabled = true;
                generatePoints((int)numberElementsUpDown.Value, (int)numberDimenstionsUpDown.Value);
                parallelSW.Start();
                parallelBW.RunWorkerAsync();
            }
        }

        private void parallelCancelButton_Click(object sender, EventArgs e)
        {
            parallelBW.CancelAsync();
        }

        private void parallelBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            double elapsed = Math.Round(parallelSW.Elapsed.TotalMilliseconds);
            parallelTimeLabel.Text = String.Format("{0} ms", elapsed);
            parallelProgressBar.Value = e.ProgressPercentage;
        }

        private void parallelBW_DoWork(object sender, DoWorkEventArgs e)
        {
            if (validateInput())
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                Thread work = new Thread(() =>
                {
                    ansParallel = parallelForel.Clusterise(points, Convert.ToDouble(clusterRadiusInput.Text));
                });
                work.Start();
                while (true)
                {
                    worker.ReportProgress(parallelForel.getProgress());
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        work.Abort();
                        break;
                    }
                    if (!work.IsAlive)
                    {
                        break;
                    }
                    Thread.Sleep(100);
                }
            }
        }

        private void parallelBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            parallelSW.Reset();
            parallelProgressBar.Value = 0;
            parallelStartButton.Enabled = true;
            parallelCancelButton.Enabled = false;
            parallelPrintButton.Enabled = true;
        }

        private void printResult(List<Cluster> res)
        {
            if (res != null)
            {
                var ansText = new String[res.Count];
                for (var i = 0; i < res.Count; i++)
                {
                    ansText[i] = res[i].Print();
                }
                ansTextBox.Lines = ansText;
            }
        }

        private void parallelPrintButton_Click(object sender, EventArgs e)
        {
            printResult(ansParallel);
        }

        private void serialPrintButton_Click(object sender, EventArgs e)
        {
            printResult(ansSerial);
        }
    }
}
