using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<NoteItem> notes;

        public MainWindow()
        {
            InitializeComponent();
            notes = new ObservableCollection<NoteItem>();
            lstNotes.ItemsSource = notes;
        }

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            string note = txtNote.Text;
            string formattedNote = $"{notes.Count + 1}. {note}";
            string date = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            NoteItem item = new NoteItem(formattedNote, Brushes.Black, date);
            notes.Add(item);
            txtNote.Text = string.Empty;
        }

        private void AddRedNote_Click(object sender, RoutedEventArgs e)
        {
            string note = txtNote.Text;
            string formattedNote = $"{notes.Count + 1}. {note}";
            string date = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            NoteItem item = new NoteItem(formattedNote, Brushes.Red, date);
            notes.Add(item);
            txtNote.Text = string.Empty;
        }

        private void ClearNotes_Click(object sender, RoutedEventArgs e)
        {
            notes.Clear();
        }
    }

    public class NoteItem
    {
        public string Note { get; set; }
        public Brush Color { get; set; }
        public string Date { get; set; }

        public NoteItem(string note, Brush color, string date)
        {
            Note = note;
            Color = color;
            Date = date;
        }
    }
}
