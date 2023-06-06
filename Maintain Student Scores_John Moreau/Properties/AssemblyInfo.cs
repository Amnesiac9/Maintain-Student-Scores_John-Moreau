using Maintain_Student_Scores_John_Moreau;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Maintain Student Scores Form")]
[assembly: AssemblyDescription("Save and manage a record of student names and scores, save scores to a bin file, and load scores upon return. This program was created for Robin Greene's C# Class at WWCC.\r\n\r\n* Change Log: * \r\n\r\n * 5/31/23 * \r\n * Switched to using serializable classes for students and their scores.\r\n * Added a Scores class to hold the scores and calculate the average, min, max, etc.\r\n * Added a Student class to hold a student's name, scores, and date of record creation.\r\n * Added a TOP student class to hold the top student.\r\n * Added a Top Student button to find the index of the current top student.\r\n * Added new label showing when a student record was first created.\r\n * Added student ID to the student class with a ranom 9 digit number.\r\n \r\n * 6/4/23, 6/5/23 *\r\n * Added the validator class to validate user input.\r\n * Added a save button so saving is not automatic.\r\n * Added a try/catch to the save button to catch any errors saving to a binary file.\r\n * Added StudentDB class to handle holding, saving and loading student data.\r\n * Now loads the intital students from a text file if the .bin file is not found.\r\n * Moved the GetTopStudent method to TopStudentRecord class.\r\n * Created a StudentList class to hold a list of students that auto sorts when a new student is added.\r\n * Added a FirstName and LastName property to the Student class to allow sorting by last name.\r\n * Now asks to confirm exiting if changes were made to the student records.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("By: John Moreau")]
[assembly: AssemblyProduct("Maintain Student Scores Form")]
[assembly: AssemblyCopyright("Copyright ©  2023 - MarsBytes Software")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("55f3d7f6-7d6a-44aa-82ba-802080158eb5")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("3.0.0")]
[assembly: AssemblyFileVersion("3.0.0")]
