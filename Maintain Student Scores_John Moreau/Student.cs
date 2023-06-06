using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * John Moreau
 * CSS133
 * 6/5/2023
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{
    [Serializable]
    public class Student : ICloneable, IComparable<Student>
    {
        public static Random random = new Random();

        public string Name { get; set; }
        public Scores StudentScores { get; set; }
        public string StudentId { get; set; }
        public DateTime RecordStartDate { get; private set; } // private so we can't change it later
        public string FirstName => Name.Split(' ')[0];
        // Returns the last name if there is one, otherwise returns an empty string.
        // Handles middle names by reversing the array and joining it back together into a single string to make the last name always return at the beginning of the LastName string for alpha sort.
        public string LastName => Name.Split(' ').Length > 1 ? string.Join(" ", Name.Split(' ').Skip(1).Reverse()) : "";

        public Student(string nameAndScoresString)
        {
           (string name, int[] newScoresArray) = SplitNameAndScores(nameAndScoresString);
            Name = name;
            string[] nameArray = name.Split(' ');
            StudentScores = new Scores(newScoresArray);
            StudentId = random.Next(000000001, 999999999).ToString("D9"); // D9 to pad with 0s SOURCE: https://stackoverflow.com/questions/3459610/pad-with-leading-zeros
            RecordStartDate = DateTime.Now;
        }

        public Student(string name, Scores scores)
        {
            Name = name;
            string[] nameArray = name.Split(' ');
            StudentScores = scores;
            StudentId = random.Next(000000001, 999999999).ToString();
            RecordStartDate = DateTime.Now;
        }
        
        // pre: none
        // post: returns a string of the student's name and scores concatenated together with | as a seperator
        public override string ToString() 
        {
            string NameAndScoresString = Name;
            foreach (int score in StudentScores.ScoresArray) {
                string currentScore = score.ToString();
                NameAndScoresString += "|" + currentScore;
            }
            return NameAndScoresString;
        }

        // pre: a string with the names and scores with | as a seperator
        // post: a tuple with the name and an int array of the scores
        private (string, int[]) SplitNameAndScores(string nameAndScoresString)
        {
            string[] studentArray = nameAndScoresString.Split('|');

            // Create an int array to hold the parsed scores, -1 because we already took out the name
            int[] newScoresArray = new int[studentArray.Length - 1];

            for (int i = 1; i < studentArray.Length; ++i)
            {
                if (int.TryParse(studentArray[i], out int score))
                {
                    newScoresArray[i - 1] = score;
                }
            }

            return (studentArray[0], newScoresArray);
        }

        public object Clone()
        {
            Student newStudent = new Student(Name, (Scores)StudentScores.Clone());
            newStudent.StudentId = StudentId;
            newStudent.RecordStartDate = RecordStartDate;

            return newStudent;
        }

        public int CompareTo(Student other)
        {
            return LastName.CompareTo(other.LastName);
        }


    }



}
