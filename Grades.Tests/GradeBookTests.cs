﻿using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHigestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrades(10);
            book.AddGrades(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrades(10);
            book.AddGrades(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAvarageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrades(91);
            book.AddGrades(89.5f);
            book.AddGrades(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.16, result.AvareGrade, 0.01);
        }

        [TestMethod]
        public void ComputesLetterGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrades(91);
            book.AddGrades(89.5f);
            book.AddGrades(75);
            book.WriteGrades(Console.Out);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("B", result.LetterGrade);
        }

        [TestMethod]
        public void IsDescriptionGradeNameCorrect()
        {
            GradeBook book = new GradeBook();
            book.AddGrades(91);
            book.AddGrades(89.5f);
            book.AddGrades(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("Good", result.Description);
        }

        [TestMethod]
        public void TestWriteGrades()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                GradeBook book = new GradeBook();
                book.AddGrades(91);
                book.WriteGrades(Console.Out);

                string expected = string.Format("91{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }

        }

        [TestMethod]
        public void TestWriteGradesWithStreamWriter()
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                GradeBook book = new GradeBook();
                book.AddGrades(91);
                book.WriteGrades(outputFile);

                Assert.IsNotNull(outputFile);
            }
        }
    }
}
