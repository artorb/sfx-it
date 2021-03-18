using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GruppUppgift4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _exercises = new List<Exercise>();
        }

        private readonly List<Exercise> _exercises;


        private static bool ValidateData(params string[] text)
        {
            return text.All(t => !string.IsNullOrWhiteSpace(t));
        }
        
        private void ValidateNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData(tbxRep.Text, tbxSet.Text, tbxWeight.Text, tbxInitExercise.Text))
            {
                _exercises.Add(new Exercise(tbxInitExercise.Text, Convert.ToInt32(tbxRep.Text),
                    Convert.ToInt32(tbxSet.Text), Convert.ToInt32(tbxWeight.Text)));
                MessageBox.Show("Övning sparat", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Fyll i fälten", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearchWeight_Click(object sender, EventArgs e)
        {
            if (!ValidateData(tbxSearchExercise.Text)) return;
            var exer = _exercises.Find(ex => ex.Equals(tbxSearchExercise.Text));
            if (exer != null)
            {
                tbxSearchWeight.Text = exer.total_weight().ToString();
            }
        }
    }

    public class Exercise
    {
        private string ExerciseName { get; }
        private int Reps { get; }
        private int Sets { get; }
        private int Weight { get; }

        public Exercise(string exerciseName, int reps, int sets, int weight)
        {
            ExerciseName = exerciseName;
            Reps = reps;
            Sets = sets;
            Weight = weight;
        }

        public int total_weight()
        {
            return Reps * Sets * Weight;
        }

        public bool Equals(string str)
        {
            return ExerciseName.Equals(str);
        }
    }
}