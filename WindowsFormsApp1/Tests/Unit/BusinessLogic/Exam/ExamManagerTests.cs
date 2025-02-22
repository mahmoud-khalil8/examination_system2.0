using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.BusinessLogic;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Tests.Unit;

namespace WindowsFormsApp1.Tests.Unit.BusinessLogic
{
    // Fake DatabaseHelper to mock database interactions
    

    public class ExamManagerTests
    {
        private readonly FakeDatabaseHelper _fakeDbHelper;

        public ExamManagerTests()
        {
            _fakeDbHelper = new FakeDatabaseHelper();
        }

        public void RunTests()
        {
            Test_AddExam_ValidInput();
            Test_ValidateAnswer_SingleChoice_Correct();
            Test_ValidateAnswer_SingleChoice_Incorrect();
            Test_ValidateAnswer_MultiChoice_Correct();
            Test_ValidateAnswer_MultiChoice_Incorrect();
            Test_saveExamStudent_ValidInput();
            Test_getExamQuestions_ValidExamId();
            Console.WriteLine("All ExamManager tests passed!");
        }

        private void Test_AddExam_ValidInput()
        {
            // Arrange
            string name = "Math Exam";
            int marks = 100;

            // Act
            int result = ExecuteWithFakeDb(() => ExamManager.AddExam(name, marks));

            // Assert
            if (result != 1)
            {
                throw new Exception($"Test_AddExam_ValidInput failed: Expected 1 row affected, got {result}");
            }
            if (!_fakeDbHelper.LastQuery.Contains("INSERT INTO Exam"))
            {
                throw new Exception("Test_AddExam_ValidInput failed: Incorrect SQL query");
            }
            if (_fakeDbHelper.LastParameters.Length != 2 ||
                _fakeDbHelper.LastParameters[0].ParameterName != "@name" ||
                (string)_fakeDbHelper.LastParameters[0].Value != "Math Exam")
            {
                throw new Exception("Test_AddExam_ValidInput failed: Name parameter incorrect");
            }
        }

        private void Test_ValidateAnswer_SingleChoice_Correct()
        {
            // Arrange
            int questionId = 1;
            string studentAnswer = "A";
            var correctAnswers = new DataTable();
            correctAnswers.Columns.Add("correctAnswer", typeof(string));
            correctAnswers.Rows.Add("A");
            _fakeDbHelper.SetMockDataTable(correctAnswers);

            // Act
            bool result = ExecuteWithFakeDb(() => ExamManager.ValidateAnswer(questionId, studentAnswer));

            // Assert
            if (!result)
            {
                throw new Exception("Test_ValidateAnswer_SingleChoice_Correct failed: Expected true for correct answer");
            }
        }

        private void Test_ValidateAnswer_SingleChoice_Incorrect()
        {
            // Arrange
            int questionId = 1;
            string studentAnswer = "B";
            var correctAnswers = new DataTable();
            correctAnswers.Columns.Add("correctAnswer", typeof(string));
            correctAnswers.Rows.Add("A");
            _fakeDbHelper.SetMockDataTable(correctAnswers);

            // Act
            bool result = ExecuteWithFakeDb(() => ExamManager.ValidateAnswer(questionId, studentAnswer));

            // Assert
            if (result)
            {
                throw new Exception("Test_ValidateAnswer_SingleChoice_Incorrect failed: Expected false for incorrect answer");
            }
        }

        private void Test_ValidateAnswer_MultiChoice_Correct()
        {
            // Arrange
            int questionId = 2;
            string studentAnswer = "A, B";
            var correctAnswers = new DataTable();
            correctAnswers.Columns.Add("correctAnswer", typeof(string));
            correctAnswers.Rows.Add("A");
            correctAnswers.Rows.Add("B");
            _fakeDbHelper.SetMockDataTable(correctAnswers);

            // Act
            bool result = ExecuteWithFakeDb(() => ExamManager.ValidateAnswer(questionId, studentAnswer));

            // Assert
            if (!result)
            {
                throw new Exception("Test_ValidateAnswer_MultiChoice_Correct failed: Expected true for correct multi-choice");
            }
        }

        private void Test_ValidateAnswer_MultiChoice_Incorrect()
        {
            // Arrange
            int questionId = 2;
            string studentAnswer = "A, C";
            var correctAnswers = new DataTable();
            correctAnswers.Columns.Add("correctAnswer", typeof(string));
            correctAnswers.Rows.Add("A");
            correctAnswers.Rows.Add("B");
            _fakeDbHelper.SetMockDataTable(correctAnswers);

            // Act
            bool result = ExecuteWithFakeDb(() => ExamManager.ValidateAnswer(questionId, studentAnswer));

            // Assert
            if (result)
            {
                throw new Exception("Test_ValidateAnswer_MultiChoice_Incorrect failed: Expected false for incorrect multi-choice");
            }
        }

        private void Test_saveExamStudent_ValidInput()
        {
            // Arrange
            int studentId = 1;
            int examId = 10;
            int studentMarks = 85;

            // Act
            int result = ExecuteWithFakeDb(() => ExamManager.saveExamStudent(studentId, examId, studentMarks));

            // Assert
            if (result != 1)
            {
                throw new Exception($"Test_saveExamStudent_ValidInput failed: Expected 1 row affected, got {result}");
            }
            if (!_fakeDbHelper.LastQuery.Contains("INSERT INTO STUD_EXAM"))
            {
                throw new Exception("Test_saveExamStudent_ValidInput failed: Incorrect SQL query");
            }
            if (_fakeDbHelper.LastParameters.Length != 3 ||
                (int)_fakeDbHelper.LastParameters[2].Value != 85)
            {
                throw new Exception("Test_saveExamStudent_ValidInput failed: student_marks parameter incorrect");
            }
        }

        private void Test_getExamQuestions_ValidExamId()
        {
            // Arrange
            int examId = 5;
            var mockQuestions = new DataTable();
            mockQuestions.Columns.Add("QID", typeof(int));
            mockQuestions.Rows.Add(1);
            _fakeDbHelper.SetMockDataTable(mockQuestions);

            // Act
            DataTable result = ExecuteWithFakeDb(() => ExamManager.getExamQuestions(examId));

            // Assert
            if (result.Rows.Count != 1 || (int)result.Rows[0]["QID"] != 1)
            {
                throw new Exception("Test_getExamQuestions_ValidExamId failed: Incorrect DataTable returned");
            }
            if (!_fakeDbHelper.LastQuery.Contains("select * from Questions"))
            {
                throw new Exception("Test_getExamQuestions_ValidExamId failed: Incorrect SQL query");
            }
        }

        // Helper to run methods with fake DatabaseHelper
        private T ExecuteWithFakeDb<T>(Func<T> action)
        {
            // Since DatabaseHelper is static, this assumes the fake replaces it in test context
            // In practice, refactor to an interface for true isolation
            return action();
        }
    }
}