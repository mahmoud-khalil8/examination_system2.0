using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.BusinessLogic.Teacher;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Tests.Unit;

namespace WindowsFormsApp1.Tests.Unit.BusinessLogic.Teacher
{
    public class TeacherManagerTests
    {
        private readonly FakeDatabaseHelper _fakeDbHelper;

        public TeacherManagerTests()
        {
            _fakeDbHelper = new FakeDatabaseHelper();
        }

        public void RunTests()
        {
            Test_GetTeacherById_ValidId();
            Test_GetTeacherById_InvalidId();
            Test_GetQuestionById_ValidId();
            Test_GetQuestionById_InvalidId();
            Test_DeleteQuestion_Success();
            Test_UpdateQuestion_Success();
            Test_UpdateOptions_Success();
            Test_UpdateAnswer_Success();
            Console.WriteLine("All TeacherManager tests passed!");
        }

        private void Test_GetTeacherById_ValidId()
        {
            int teacherId = 1;
            var mockData = new DataTable();
            mockData.Columns.Add("UserID", typeof(int));
            mockData.Rows.Add(1);
            _fakeDbHelper.SetMockDataTable(mockData);

            var manager = new TeacherManager();
            DataRow result = ExecuteWithFakeDb(() => manager.GetTeacherById(teacherId));

            if (result == null || (int)result["UserID"] != 1)
            {
                throw new Exception("Test_GetTeacherById_ValidId failed: Expected valid DataRow");
            }
            if (!_fakeDbHelper.LastQuery.Contains("SELECT * FROM Users WHERE UserID = @TeacherID"))
            {
                throw new Exception("Test_GetTeacherById_ValidId failed: Incorrect SQL query");
            }
        }

        private void Test_GetTeacherById_InvalidId()
        {
            int teacherId = 999;
            var mockData = new DataTable();
            _fakeDbHelper.SetMockDataTable(mockData);

            var manager = new TeacherManager();
            DataRow result = ExecuteWithFakeDb(() => manager.GetTeacherById(teacherId));

            if (result != null)
            {
                throw new Exception("Test_GetTeacherById_InvalidId failed: Expected null for invalid ID");
            }
        }

        private void Test_GetQuestionById_ValidId()
        {
            int questionId = 2;
            var mockData = new DataTable();
            mockData.Columns.Add("QID", typeof(int));
            mockData.Rows.Add(2);
            _fakeDbHelper.SetMockDataTable(mockData);

            var manager = new TeacherManager();
            DataRow result = ExecuteWithFakeDb(() => manager.GetQuestionById(questionId));

            if (result == null || (int)result["QID"] != 2)
            {
                throw new Exception("Test_GetQuestionById_ValidId failed: Expected valid DataRow");
            }
        }

        private void Test_GetQuestionById_InvalidId()
        {
            int questionId = 999;
            var mockData = new DataTable();
            _fakeDbHelper.SetMockDataTable(mockData);

            var manager = new TeacherManager();
            DataRow result = ExecuteWithFakeDb(() => manager.GetQuestionById(questionId));

            if (result != null)
            {
                throw new Exception("Test_GetQuestionById_InvalidId failed: Expected null for invalid ID");
            }
        }

        private void Test_DeleteQuestion_Success()
        {
            int questionId = 3;

            var manager = new TeacherManager();
            bool result = ExecuteWithFakeDb(() => manager.DeleteQuestion(questionId));

            if (!result)
            {
                throw new Exception("Test_DeleteQuestion_Success failed: Expected true for successful deletion");
            }
            if (!_fakeDbHelper.LastQuery.Contains("DELETE FROM Questions"))
            {
                throw new Exception("Test_DeleteQuestion_Success failed: Incorrect SQL query");
            }
        }

        private void Test_UpdateQuestion_Success()
        {
            // Arrange
            var question = new TrueFalseQuestion(
                qid: 4,
                header: "Test Header",
                body: "Test Body",
                marks: 10,
                teacherId: 1,
                examId: 5,
                correctAnswer: true
            );

            // Act
            var manager = new TeacherManager();
            bool result = ExecuteWithFakeDb(() => manager.UpdateQuestion(question));

            // Assert
            if (!result)
            {
                throw new Exception("Test_UpdateQuestion_Success failed: Expected true for successful update");
            }
            if (!_fakeDbHelper.LastQuery.Contains("UPDATE Questions SET"))
            {
                throw new Exception("Test_UpdateQuestion_Success failed: Incorrect SQL query");
            }
            if (_fakeDbHelper.LastParameters.Length != 7 ||
                _fakeDbHelper.LastParameters[0].ParameterName != "@Header" ||
                (string)_fakeDbHelper.LastParameters[0].Value != "Test Header" ||
                _fakeDbHelper.LastParameters[1].ParameterName != "@Body" ||
                (string)_fakeDbHelper.LastParameters[1].Value != "Test Body" ||
                _fakeDbHelper.LastParameters[2].ParameterName != "@QType" ||
                (string)_fakeDbHelper.LastParameters[2].Value != "TrueFalse" ||
                _fakeDbHelper.LastParameters[3].ParameterName != "@Marks" ||
                (int)_fakeDbHelper.LastParameters[3].Value != 10 ||
                _fakeDbHelper.LastParameters[4].ParameterName != "@TeacherID" ||
                (int)_fakeDbHelper.LastParameters[4].Value != 1 ||
                _fakeDbHelper.LastParameters[5].ParameterName != "@ExamID" ||
                (int)_fakeDbHelper.LastParameters[5].Value != 5 ||
                _fakeDbHelper.LastParameters[6].ParameterName != "@QID" ||
                (int)_fakeDbHelper.LastParameters[6].Value != 4)
            {
                throw new Exception("Test_UpdateQuestion_Success failed: One or more parameters incorrect");
            }
        }

        private void Test_UpdateOptions_Success()
        {
            int questionId = 5;
            var options = new List<OptionModel>
            {
                new OptionModel { Options = "A" },
                new OptionModel { Options = "B" }
            };

            var manager = new TeacherManager();
            bool result = ExecuteWithFakeDb(() => manager.UpdateOptions(questionId, options));

            if (!result)
            {
                throw new Exception("Test_UpdateOptions_Success failed: Expected true for successful update");
            }
            if (!_fakeDbHelper.LastQuery.Contains("INSERT INTO Ques_Options"))
            {
                throw new Exception("Test_UpdateOptions_Success failed: Incorrect insert query");
            }
        }

        private void Test_UpdateAnswer_Success()
        {
            var answer = new AnswerModel
            {
                Ans_ID = 1,
                ISCorrect = true,
                Stud_Marks = 5,
                Ques_ID = 6
            };

            var manager = new TeacherManager();
            bool result = ExecuteWithFakeDb(() => manager.UpdateAnswer(answer));

            if (!result)
            {
                throw new Exception("Test_UpdateAnswer_Success failed: Expected true for successful update");
            }
            if (!_fakeDbHelper.LastQuery.Contains("UPDATE Answers SET"))
            {
                throw new Exception("Test_UpdateAnswer_Success failed: Incorrect SQL query");
            }
        }

        private T ExecuteWithFakeDb<T>(Func<T> action)
        {
            return action();
        }
    }
}