using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment7_Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Random _random = new Random();
        private readonly List<Task> _heavyTasks = new List<Task>(3);

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // Clean-up
            _heavyTasks.ForEach(task => task.Dispose());
            _heavyTasks.Clear();
            base.OnClosing(e);
        }

        private async void StartButtonOnClick(object sender, RoutedEventArgs e)
        {
            // Fresh start every button click
            if (OutputTextBox.Text.Length > 0 || _heavyTasks.Count > 0)
            {
                OutputTextBox.Text = string.Empty;
                _heavyTasks.ForEach(task => task.Dispose()); // releases the resources
                _heavyTasks.Clear();
            }

            // 1) Start 3 tasks in parallel 2) Indicate that each task has started
            OutputTextBox.Text += "Task 1 started\n";
            _heavyTasks.Add(HeavyWorkAsync());

            OutputTextBox.Text += "Task 2 started\n";
            _heavyTasks.Add(HeavyWorkAsync());

            OutputTextBox.Text += "Task 3 started\n";
            _heavyTasks.Add(HeavyWorkAsync());

            // 4) If not all 3 tasks are completed within 8 seconds indicate that there is still work to be done
            await Task.Delay(8000).ContinueWith(_ =>
            {
                if (_heavyTasks.Any(task => !task.IsCompleted))
                {
                    Dispatcher.Invoke(() => OutputTextBox.Text += "Still work to do...\n");
                }
            });

            // 3) Update label when all 3 tasks are completed
            await Task.WhenAll(_heavyTasks).ContinueWith(_ =>
            {
                Dispatcher.Invoke(() => OutputTextBox.Text += $"All tasks are completed\n");
            });
        }

        public void HeavyWork()
        {
            double secondsToSleep = _random.NextDouble() * 1;
            Thread.Sleep(TimeSpan.FromSeconds(secondsToSleep));
        }

        public Task HeavyWorkAsync()
        {
            return Task.Run(HeavyWork);
        }
    }
}

