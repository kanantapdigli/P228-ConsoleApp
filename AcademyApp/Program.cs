using Core.Constants;
using Core.Entities;
using Core.Helpers;
using DataAccess.Repositories.Implementations;
using Manage.Controllers;

namespace Manage
{
    public class Program
    {
        static void Main()
        {
            GroupController _groupController = new GroupController();
            StudentController _studentController = new StudentController();
            AdminController _adminController = new AdminController();
            TeacherController _teacherController = new TeacherController();

            Authentication:  var admin = _adminController.Authenticate();
          
            if (admin != null)
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, $"Welcome, {admin.Username}");
                Console.WriteLine("---");

                while (true)
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "1 - Create Group");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "2 - Update Group");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "3 - Delete Group");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "4 - All Groups");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "5 - Get Group by name");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "6 - Create Student");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "7 - Update Student");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "8 - Delete Student");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "9 - All Students by Group");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "10 - Get Student by Group");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "11 - Create Teacher");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "12 - Update Teacher");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "13 - Delete Teacher");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "14 - All Teachers");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "15 - Add Group to Teacher");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "16 - All Groups of Teacher");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "0 - Exit");
                    Console.WriteLine("---");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Gray, "Select option");
                    string number = Console.ReadLine();

                    int selectedNumber;
                    bool result = int.TryParse(number, out selectedNumber);
                    if (result)
                    {
                        if (selectedNumber >= 0 && selectedNumber <= 16)
                        {

                            switch (selectedNumber)
                            {
                                case (int)Options.CreateGroup:
                                    _groupController.CreateGroup();
                                    break;
                                case (int)Options.UpdateGroup:
                                    _groupController.UpdateGroup();
                                    break;
                                case (int)Options.DeleteGroup:
                                    _groupController.DeleteGroup();
                                    break;
                                case (int)Options.AllGroups:
                                    _groupController.AllGroups();
                                    break;
                                case (int)Options.GetGroupByName:
                                    _groupController.GetGroupName();
                                    break;
                                case (int)Options.CreateStudent:
                                    _studentController.CreateStudent();
                                    break;
                                case (int)Options.GetAllStudentsByGroup:
                                    _studentController.GetAllStudentsByGroup();
                                    break;
                                case (int)Options.CreateTeacher:
                                    _teacherController.Create();
                                    break;
                                case (int)Options.UpdateTeacher:
                                    _teacherController.Update();
                                    break;
                                case (int)Options.DeleteTeacher:
                                    _teacherController.Delete();
                                    break;
                                case (int)Options.AllTeachers:
                                    _teacherController.GetAll();
                                    break;
                                case (int)Options.AddGroupToTeacher:
                                    _teacherController.AddGroupToTeacher();
                                    break;
                                case (int)Options.AllGroupsOfTeacher:
                                    _teacherController.GetAllGroupsByTeacher();
                                    break;
                                case (int)Options.Exit:
                                    _groupController.Exit();
                                    return;
                            }
                        }
                        else
                        {
                            ConsoleHelper.WriteTextWithColor(ConsoleColor.Red, "Please, enter correct number");
                        }
                    }
                    else
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.Red, "Please, enter correct number");
                    }
                }
            }
            else
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Red, "Admin username or password is incorrect");
                goto Authentication;
            }
        }
    }
}