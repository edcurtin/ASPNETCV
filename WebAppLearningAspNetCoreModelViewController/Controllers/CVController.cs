using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;
using WebAppLearningAspNetCoreModelViewController.Models;

namespace WebAppLearningAspNetCoreModelViewController.Controllers
{
    public class CVController : Controller
    {
        public IActionResult CV()
        {
            var cv = new CVViewModel
            {
                Name = "Ed Curtin",
                Email = "ed.curtin@live.ie",
                Phone = "+44 (0) 7477 090 517",
                LinkedIn = "https://www.linkedin.com/in/edwardcurtin/",
                WorkingModel = "100% Remote - UK / Hybrid - Manchester City",
                WorkExperiences = new List<Experience>
                {
                    new Experience
                    {
                        Role = "Senior Software Engineer .NET",
                        Company = "Advanced Instruments, Bournemouth Office, 100% Remote.",
                        Dates = "6th June 2022 - Present.",
                        IsCurrent = true,
                        Description = "In June 2022, I joined Advanced Instruments (formerly Solentim) as a Senior Software Engineer on a fully remote basis, the team consists of seven members, mixture of hybrid and fully remote staff. Since then, working alongside other team members I've applied my expertise in designing, prototyping, implementing, and documenting new features for the STUDIUS .NET Core application, which facilitates cell seeding into well plates and supports imaging protocols that are utilized across the biopharmaceutical industry. We operate an Agile Scrum development model with two-week sprints, my role extends to mentoring/coaching, ensuring code quality, addressing tech debt, overseeing code reviews, onboarding new team members, and serving as a stand-in for the Development Manager when required.",
                        TechUsed = new List<Tech>
                        {
                            new Tech() { Name = "C#" },
                            new Tech { Name = ".NET Core" },
                            new Tech { Name = "ASP.NET" },
                            new Tech { Name = "Visual Studio" },
                            new Tech { Name = "WPF" },
                            new Tech { Name = "MVVM" },
                            new Tech { Name = "XAML" },
                            new Tech { Name = "IOC" },
                            new Tech { Name = "MSSQL" },
                            new Tech { Name = "SQLite" },
                            new Tech { Name = "Entity Framework" },
                            new Tech { Name = "Azure" },
                            new Tech { Name = "GIT" },
                            new Tech { Name = "NUnit" },
                            new Tech { Name = "XUnit" },
                            new Tech { Name = "AutoMapper" },
                            new Tech { Name = "AutoMoq" },
                            new Tech { Name = "AutoFixture" },
                            new Tech { Name = "SignalR" }
                        }
                    },
                    new Experience
                    {
                        Role = "Senior Software Engineer",
                        Company = "Pico Technology Ltd. Manchester Based Office then 100% Remote",
                        Dates = "1st July 2019 – 29th April 2022",
                        IsCurrent = false,
                        Description = "Joined Pico Technology in July 2019 as a Senior Engineer, contributing to the establishment of a remote Manchester office. Specialized in Automotive software development for Picoscope 7 on Windows, Linux, and Mac, and led the design and implementation of Picoscope Waveform Library, a React Electron app for diagnosing automobile issues, sharing of diagnostic waveforms among community members on various automotive forums. Managed two-way communication between .NET Framework App and React Electron App, implemented multi-language support supporting translation and display of 30 + languages, custom control designs in both WPF and React, and played a key role in maintaining team productivity after the loss of the Software Development Manager, into and throughout covid lockdown.",
                        TechUsed = new List<Tech>
                        {
                            new Tech() { Name = "C#" },
                            new Tech { Name = ".NET Core" },
                            new Tech { Name = ".NET Framework" },
                            new Tech { Name = "ASP.NET" },
                            new Tech { Name = "Visual Studio" },
                            new Tech { Name = "WPF" },
                            new Tech { Name = "MVVM" },
                            new Tech { Name = "XAML" },
                            new Tech { Name = "IOC" },
                            new Tech { Name = "MSSQL" },
                            new Tech { Name = "SSMS" },
                            new Tech { Name = "SQL" },
                            new Tech { Name = "SQLite" },
                            new Tech { Name = "Entity Framework" },
                            new Tech { Name = "Azure" },
                            new Tech { Name = "TFS" },
                            new Tech { Name = "GIT" },
                            new Tech { Name = "NUnit" },
                            new Tech { Name = "XUnit" },
                            new Tech { Name = "SignalR" },
                            new Tech { Name = "React" },
                            new Tech { Name = "TypeScript" },
                            new Tech { Name = "BabelEdit resourcing" }
                        },
                    },
                    new Experience
                    {
                        Role = "C# Desktop / UWP Applications Developer / OPCUA SignalR Communications",
                        Company = "Mettler Toledo Safeline, Off Langworthy Road, Salford, Manchester",
                        Dates = "2nd October 2017 – 21st June 2019",
                        Description = "I joined Mettler Toledo Safeline to work on their new Metal Detector offering, working with but not limited to UWP / XAML / MVVM / SQLite WPF daily. Version control and task tracking was completed using TFS. I also completed work towards communication between devices and worked with both OPCUA and SignalR to provide agnostic communications platform and get away from traditional polling communication towards something more real time.",
                        TechUsed = new List<Tech>
                        {
                            new Tech() { Name = "C#" },
                            new Tech { Name = ".NET Framework" },
                            new Tech { Name = ".NET Standard" },
                            new Tech { Name = ".NET Core" },
                            new Tech { Name = ".NET Native" },
                            new Tech { Name = "ASP.NET" },
                            new Tech { Name = "Visual Studio" },
                            new Tech { Name = "WPF" },
                            new Tech { Name = "UWP" },
                            new Tech { Name = "MVVM" },
                            new Tech { Name = "XAML" },
                            new Tech { Name = "IOC" },
                            new Tech { Name = "SQL" },
                            new Tech { Name = "SQLite" },
                            new Tech { Name = "TFS" },
                            new Tech { Name = "XUnit" },
                            new Tech { Name = "SignalR" },
                            new Tech { Name = "OPCUA" },
                            new Tech { Name = "OPCDA" },
                            new Tech { Name = "Socket Communications" },
                        },
                    },
                    new Experience
                    {
                        Role = "C# Desktop Applications Developer",
                        Company = "Eclipse Recruitment Software, Manchester One Floor 20, Portland Street, Manchester",
                        Dates = "30th January 2017 – 29th September 2017",
                        Description = "Contributed to re-writing Eclipse Recruitment Software's legacy system, initially written in VB porting it to WPF MVVM. Joined as part of a six-member team to address the departure of a senior member, collaborated with both internal and external parties towards meeting new requirements and addressing any bugs / issues around releases.",
                        TechUsed = new List<Tech>
                        {
                            new Tech() { Name = "C#" },
                            new Tech { Name = ".NET Framework" },
                            new Tech { Name = "Visual Basic" },
                            new Tech { Name = "Visual Studio" },
                            new Tech { Name = "WPF" },
                            new Tech { Name = "MVVM" },
                            new Tech { Name = "XAML" },
                            new Tech { Name = "IOC" },
                            new Tech { Name = "SQL" },
                            new Tech { Name = "MSSQL" },
                            new Tech { Name = "SSMS" },
                            new Tech { Name = "Oracle" },
                            new Tech { Name = "GIT" },
                            new Tech { Name = "PRISM" },
                            new Tech { Name = "NHibernate" },
                            new Tech { Name = "Telerik" },
                        },
                    },
                    new Experience
                    {
                        Role = "C# Desktop Software Developer",
                        Company = "K3BTG / K3 Syspro, 50 Kansas Avenue, Salford, Manchester",
                        Dates = "7th August 2014 – 27th January 2017",
                        Description = "Joined K3 a year into the development of their new APS product, fresh out of university I switched from JAVA to C# .NET Framework APS was originally a VB application, we went about designing, prototyping, implementing a new platform delivering a WFP application, originally as part of a two-person team, eventually ending up as a team of four with contract staff and testers taking other seats. Put together a business case for the framework to deliver our solution into the business resulting in us moving forwards with a WPF MVVM utilizing Dev Express controls with a MSSQL back end. Our application also had dynamic data that the user could add to the database such as new tables, columns onto existing tables etc.",
                        TechUsed = new List<Tech>
                        {
                            new Tech() { Name = "C#" },
                            new Tech { Name = ".NET Framework" },
                            new Tech { Name = "Visual Basic" },
                            new Tech { Name = "Visual Studio" },
                            new Tech { Name = "WPF" },
                            new Tech { Name = "MVVM" },
                            new Tech { Name = "XAML" },
                            new Tech { Name = "WinForms" },
                            new Tech { Name = "IOC" },
                            new Tech { Name = "SQL" },
                            new Tech { Name = "MSSQL" },
                            new Tech { Name = "SSMS" },
                            new Tech { Name = "TFS" },
                            new Tech { Name = "Dev Express" },
                        },
                    },
                    new Experience
                    {
                        Role = "Co-Op Placement – Software Developer",
                        Company = "LM Ericsson, Athlone, Co. Westmeath",
                        Dates = "28th May 2012 – 21st December 2012",
                        Description = "Employed with LM Ericsson – on a student Co-Op placement, I was working with the OSS-MT, Operational Support Systems) Monitoring Team. I have been challenged with creating a plug-in written in Groovy as part of VMware’s vFabric Hyperic 4.6, which is a third-party product, currently being branded to Ericsson and will make up part of Ericsson’s OSS Management Software, Hyperic monitors metric data (server data) across various platforms and displays metric data to the user. Current languages I am using are: Groovy / Java and outputting to GSP (Groovy Server Pages), using a mixture of HTML / Grails Scripting and CSS Styling.",
                        TechUsed = new List<Tech>
                        {
                            new Tech() { Name = "Java" },
                            new Tech { Name = "Groovy" },
                            new Tech { Name = "Grails" },
                            new Tech { Name = "Hyperic" },
                            new Tech { Name = "VMWare" },
                            new Tech { Name = "Hyperic" },
                            new Tech { Name = "Project Management" },
                            new Tech { Name = "HTML" },
                            new Tech { Name = "CSS" },
                            new Tech { Name = "JavaScript" },
                            new Tech { Name = "Eclipse IDE" },
                        },
                    }
                },
                Educations = new List<Education>
                {
                    new Education
                    {
                        CourseName = "Bachelor of Science Honours in Software Systems Development",
                        Institution = "Waterford Institute of Technology",
                        Dates =  "Sept 2013 – June 2014",
                        Grade = "First Class Honours - 1.1 – Overall GPA: 79.72% (Awarded January 2015)",
                        Semesters = new List<SemesterModel>()
                        {
                            new SemesterModel()
                            {
                                Name = "4th Year 1st Semester",
                                Results = new List<ResultModel>()
                                {
                                    new ResultModel()
                                    {
                                       Subject = "Web Server Programming – Ruby Rails",
                                       Result = "83%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Agile Software Development - Ruby",
                                       Result = "81%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Inter-organisation Information Systems",
                                       Result = "74%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Info Systems – Project Management",
                                       Result = "76%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "IT Security",
                                       Result = "86%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Final Year Project - Research & Design",
                                       Result = "80%"
                                    },
                                }
                            },
                             new SemesterModel()
                            {
                                Name = "4th Year 2nd Semester",
                                Results = new List<ResultModel>()
                                {
                                    new ResultModel()
                                    {
                                       Subject = "Software Frameworks",
                                       Result = "81%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Software Business",
                                       Result = "81%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Dynamic Web Development",
                                       Result = "79%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Business Intelligence",
                                       Result = "76%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Final Year Project - Implementation",
                                       Result = "80%"
                                    },
                                }
                            }
                        },
                        Project = new ProjectModel()
                        {
                            Name = "FINAL YEAR PROJECT [Monitor I.T Hardware Resource Monitoring]",
                            Description = "As part of my final year project, I created a system called Monitor I.T Hardware Resource Monitoring; this system was responsible for the collection, transmission, storage, and display of metric data which was collected from remote agent machines on the network at regular intervals. Metric data is transmitted to a central server running both a Mongo DB as well as a Rails web application which will provide the user interface. The Research and Design phase has been completed, and a prototype produced to prove concept.  The project involves using an existing API to collect metric data, storing this data in a meaningful form, and then transmitting this data to a multithreaded server via socket communication. Once data from an individual agent has been received by the server it is written to the database which in turn makes historical data available to the front-end Rails application which will be responsible for displaying metric data for the reporting agents to the user."
                        }
                    },
                    new Education
                    {
                        CourseName = "Bachelor of Science Ordinary in Software Systems Development",
                        Institution = "Waterford Institute of Technology",
                        Dates =  "Sept 2012 – May 2013",
                        Grade = "Pass with Distinction (Awarded January 2014)",
                        Semesters = new List<SemesterModel>()
                        {
                            new SemesterModel()
                            {
                                Name = "BSc [Ordinary] in Software Systems Development",
                                Results = new List<ResultModel>()
                                {
                                    new ResultModel()
                                    {
                                       Subject = "User Centred Design",
                                       Result = "83%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Graphical User Interfaces (Java)",
                                       Result = "72%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Organisational Information Systems",
                                       Result = "75%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Advanced Databases",
                                       Result = "73%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Software Enterprise Systems",
                                       Result = "83%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Security Principles",
                                       Result = "75%"
                                    },
                                }
                            }
                        }
                    },
                      new Education
                    {
                        CourseName = "Higher Certificate in Science & Computing Level 6",
                        Institution = "Limerick Institute of Technology, Thurles, Co. Tipperary",
                        Dates =  "Sept 2010 – Aug 2012",
                        Grade = "Pass with Distinction (Awarded 9th November 2012",
                        Semesters = new List<SemesterModel>()
                        {
                            new SemesterModel()
                            {
                                Name = "1st Year Subjects",
                                Results = new List<ResultModel>()
                                {
                                    new ResultModel()
                                    {
                                       Subject = "Intro to Computer Programming (Java)",
                                       Result = "62%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Intro to Object Oriented Programming (Java)",
                                       Result = "78%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Intro to Systems Analysis & Design",
                                       Result = "66%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Intro to Object Oriented Design",
                                       Result = "74%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Computer Architecture",
                                       Result = "72%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Computer Organisation",
                                       Result = "74%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Mathematics for Computing",
                                       Result = "67%"
                                    },
                                   new ResultModel()
                                    {
                                       Subject = "Mathematical Methods",
                                       Result = "86%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Operating Sysems Fundamentals",
                                       Result = "79%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Data Communications",
                                       Result = "70%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Management Principles",
                                       Result = "71%"
                                    },
                                    new ResultModel()
                                    {
                                        Subject = "Developing Your Potential",
                                        Result = "81%"
                                    }
                                }
                            },
                             new SemesterModel()
                            {
                                Name = "2nd Year Subjects",
                                Results = new List<ResultModel>()
                                {
                                    new ResultModel()
                                    {
                                       Subject = "Statistical Data Analysis",
                                       Result = "85%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Procedural Programming (C)",
                                       Result = "83%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Database Planning & Design",
                                       Result = "66%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Electronics for Computing",
                                       Result = "75%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Operating Systems Management",
                                       Result = "81%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Professional Development",
                                       Result = "83%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Data Structures (Java)",
                                       Result = "78%"
                                    },
                                   new ResultModel()
                                    {
                                       Subject = "Human Computer Interface Design",
                                       Result = "77%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Computer Systems Hardware",
                                       Result = "73%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Internetworking",
                                       Result = "78%"
                                    },
                                    new ResultModel()
                                    {
                                       Subject = "Database System Implementation",
                                       Result = "74%"
                                    },
                                }
                             }
                        }
                    }
                }
            };

            return View(cv);
        }
    }
}
