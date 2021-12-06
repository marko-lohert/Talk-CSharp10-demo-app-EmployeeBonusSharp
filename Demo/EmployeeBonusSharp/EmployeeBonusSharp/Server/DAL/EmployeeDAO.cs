using EmployeeBonusSharp.Shared;
using System;
using System.Collections.Generic;

namespace EmployeeBonusSharp.Server.DAL
{
    public class EmployeeDAO
    {
        public static List<Employee> GetAllEmployees()
        {
            // Mock data.
            // todo Read data from a database.
            List<Employee> employees = new();

            employees.Add(
                new Employee()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    DateOfEmployment = new DateTime(2001, 11, 27),
                    Certificates = new List<Certificate>()
                    {
                        new Certificate() { Name = "C# advanced", Description = "Advanced C#"},
                        new Certificate() { Name = "OOP", Description = "Object-oriented programming"},
                    },
                    EmployeeBonus = new(),
                    TotalVotesForHelpingOtherColleagues = 5,
                    AllPerformanceReviewByManager = new()
                    {
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2019, 12, 2),
                            Mark = 5
                        },
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2020, 12, 1),
                            Mark = 5
                        },
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2021, 12, 1),
                            Mark = 5
                        },
                    }
                }
            );

            employees.Add(
                new Employee()
                {
                    FirstName = "Jane",
                    LastName = "Smith",
                    DateOfEmployment = new DateTime(2001, 02, 01),
                    Certificates = new List<Certificate>()
                    {
                        new Certificate() { Name = "F# advanced", Description = "Advanced F#"},
                        new Certificate() { Name = "OOP", Description = "Object-oriented programming"},
                    },
                    EmployeeBonus = new(),
                    TotalVotesForHelpingOtherColleagues = 4,
                    AllPerformanceReviewByManager = new()
                    {
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2019, 12, 2),
                            Mark = 5
                        },
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2020, 12, 1),
                            Mark = 4
                        },
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2021, 12, 1),
                            Mark = 5
                        },
                    }
                }
            );

            employees.Add(
                new Employee()
                {
                    FirstName = "Joe",
                    LastName = "Doe",
                    DateOfEmployment = new DateTime(2020, 02, 01),
                    Certificates = new List<Certificate>()
                    {
                        new Certificate() { Name = "C# advanced", Description = "Advanced C#"},
                    },
                    EmployeeBonus = new(),
                    TotalVotesForHelpingOtherColleagues = 3,
                    AllPerformanceReviewByManager = new()
                    {
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2019, 12, 2),
                            Mark = 4
                        },
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2020, 12, 1),
                            Mark = 4
                        },
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2021, 12, 1),
                            Mark = 3
                        },
                    }
                }
            );

            employees.Add(
                new Employee()
                {
                    FirstName = "Kate",
                    LastName = "Fischer",
                    DateOfEmployment = new DateTime(2021, 11, 01),
                    Certificates = new List<Certificate>()
                    {
                        new Certificate() { Name = "C# advanced", Description = "Advanced C#"},
                        new Certificate() { Name = "F# advanced", Description = "Advanced F#"},
                        new Certificate() { Name = "Scrum Master", Description = "Scrum certificate for Scrum Master"},
                        new Certificate() { Name = "Erlang", Description = "Erlang programming language"},
                        new Certificate() { Name = "AI", Description = "Artificial intelligence"},
                        new Certificate() { Name = "IoT", Description = "Internet of Things"},
                        new Certificate() { Name = "Software Arhitecture", Description = "Modern software arhitecture"},
                    },
                    EmployeeBonus = new(),
                    TotalVotesForHelpingOtherColleagues = 7,
                    AllPerformanceReviewByManager = new()
                    {
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2019, 12, 2),
                            Mark = 3
                        },
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2020, 12, 1),
                            Mark = 4
                        },
                        new PerformanceReviewByManager()
                        {
                            DateOfReview = new DateTime(2021, 12, 1),
                            Mark = 5
                        },
                    }
                }
            );

            return employees;
        }
    }
}
