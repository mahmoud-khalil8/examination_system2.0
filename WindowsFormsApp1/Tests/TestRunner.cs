// Tests/Unit/TestRunner.cs
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Tests.Unit
{
    public class TestRunner
    {
        public static void RunAllTests()
        {
            var testClasses = new List<(string name, Action run)>
            {
                ("UserManagerTests", () => new BusinessLogic.Admin.UserManagerTests().RunTests()),
                ("ExamManagerTests", () => new BusinessLogic.ExamManagerTests().RunTests()),
                ("StudentManagerTests", () => new BusinessLogic.StudentManagerTests().RunTests()),
                ("TeacherManagerTests", () => new BusinessLogic.Teacher.TeacherManagerTests().RunTests()),
                ("DatabaseHelperTests", () => new DataAccess.DatabaseHelperTests().RunTests())
            };

            bool allPassed = true;
            foreach (var (name, run) in testClasses)
            {
                try
                {
                    Console.WriteLine($"Running {name}...");
                    run();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed in {name}: {ex.Message}");
                    allPassed = false;
                }
            }

            if (allPassed)
            {
                Console.WriteLine("All tests completed successfully!");
            }
            else
            {
                Console.WriteLine("Some tests failed. Check output for details.");
            }
        }

        // Temporary entry point for testing
        public static void Main(string[] args)
        {
            RunAllTests();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}