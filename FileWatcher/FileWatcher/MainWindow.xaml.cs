using System;
using System.IO;
using System.Windows;

namespace FileWatcher
{
    public partial class MainWindow : Window
    {
        private readonly string filePath = @"C:\Users\Rajat\Documents\test.txt";

        private FileSystemWatcher watcher;

        public MainWindow()
        {
            InitializeComponent();
            PathTextBox.Text = filePath;
            CreateFileIfNeeded();
            LoadFile();
            StartFileWatcher();
        }

        private void CreateFileIfNeeded()
        {
            string directory = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath,"Write in this file.");
            }
        }

        private void LoadFile()
        {
            ContentTextBox.Text = File.ReadAllText(filePath);
        }

        private void StartFileWatcher()
        {
            watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(filePath);
            watcher.Filter = Path.GetFileName(filePath);
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size;
            watcher.Changed += FileChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void FileChanged(object sender, FileSystemEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                LoadFile();
            });
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(filePath,ContentTextBox.Text);
        }

        protected override void OnClosed(EventArgs e)
        {
            watcher?.Dispose();
            base.OnClosed(e);
        }
    }
}