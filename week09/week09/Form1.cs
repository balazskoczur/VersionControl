using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week09.Entities;

namespace week09
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BP> BirthProbabilities = new List<BP>();
        List<DP> DeathProbabilities = new List<DP>();
        public Form1()
        {
            InitializeComponent();
            Population = GetPopulation(@"C:\Windows\Temp\nép.csv");
            BirthProbabilities = GetBP(@"C:\Windows\Temp\születés.csv");
            DeathProbabilities = GetDP(@"C:\Windows\Temp\halál.csv");
        }
        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });
                }
            }

            return population;
        }

        public List<BP> GetBP(string csvpath)
        {
            List<BP> Births = new List<BP>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    Births.Add(new BP()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        BirthProbability = double.Parse(line[2])
                        
                    });
                }
            }

            return Births;
        }

        public List<DP> GetDP(string csvpath)
        {
            List<DP> Deaths = new List<DP>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    Deaths.Add(new DP()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        
                        Age = int.Parse(line[1]),
                        
                        DeathProbability = double.Parse(line[2])
                    });
                }
            }

            return Deaths;
        }
    }
}
