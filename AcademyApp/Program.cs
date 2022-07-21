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
            //GroupRepository _groupRepository = new GroupRepository();
            //StudentRepository _studentRepository = new StudentRepository();

            ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, "Welcome");
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
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "0 - Exit");
                Console.WriteLine("---");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Gray, "Select option");
                string number = Console.ReadLine();

                int selectedNumber;
                bool result = int.TryParse(number, out selectedNumber);
                if (result)
                {
                    if (selectedNumber >= 0 && selectedNumber <= 10)
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
    }
}