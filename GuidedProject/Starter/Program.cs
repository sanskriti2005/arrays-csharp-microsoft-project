using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] {90, 86, 87, 98, 100};
int[] andrewScores = new int[] {92, 89, 81, 96, 90};
int[] emmaScores = new int[] {90, 85, 87, 98, 68};
int[] loganScores = new int[] {90, 95, 87, 88, 96};

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

//Write the report header to the Console
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Emma")
    studentScores = emmaScores;

    else if (currentStudent == "Logan")
    studentScores = loganScores;
    
    
    //initialize/reset the sum of scored assignments
    int sumAssignmentScore = 0;

    //initialize/reset the calculated averge of exams + extra credit scores
    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScore += score;
    }

    currentStudentGrade = (decimal)sumAssignmentScore / currentAssignments;


    
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
    
}



Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
