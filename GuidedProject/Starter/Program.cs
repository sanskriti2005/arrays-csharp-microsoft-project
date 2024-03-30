using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] {90, 86, 87, 98, 100,94, 90};
int[] andrewScores = new int[] {92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[] {90, 85, 87, 98, 68, 89, 89, 89};
int[] loganScores = new int[] {90, 95, 87, 88, 96, 96};

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

decimal examScore = 0;
decimal extraCredit = 0;

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

//Write the report header to the Console
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
    studentScores = andrewScores;

    else if (currentStudent == "Emma")
    studentScores = emmaScores;

    else if (currentStudent == "Logan")
    studentScores = loganScores;

    

    //initialize/reset the sum of scored assignments
    int sumAssignmentScore = 0;

    //initialize/reset the calculated averge of exams + extra credit scores
    decimal currentStudentGrade = 0;

    //initialize/reset a counter for the number of assignments
    int gradedAssignments = 0;
    foreach (int score in studentScores)
    {
        // increment assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // the exam score
            examScore += score;
        
        else 
            // extra credit 
            extraCredit = (decimal) score / 10;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScore += score;
        
        else 
            // extra credit + exam score
            sumAssignmentScore += score / 10;

    }

    examScoreGrade = (decimal)examScore / examAssignments;
    extraCreditGrade = (decimal)extraCredit / examAssignments; 
    currentStudentGrade = (decimal)sumAssignmentScore / examAssignments;

    // Grades
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else 
        currentStudentLetterGrade = "F";
    
    Console.WriteLine($"{currentStudent}\t\t{examScoreGrade}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{extraCredit}");
    
}



Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
