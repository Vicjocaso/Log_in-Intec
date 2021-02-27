using Intec.xamaritanApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intec.xamaritanApp.ViewModels
{
    public class HomeViewModels : BaseViewModel
    {
        public MenuOption GradeMenuOption { get; set; } = new MenuOption();
        public MenuOption YouMenuOption { get; set; } = new MenuOption();
        public MenuOption RecordMenuOption { get; set; } = new MenuOption();
        public MenuOption AssignmentMenuOption { get; set; } = new MenuOption();
        public MenuOption GpaMenuOption { get; set; } = new MenuOption();
        public MenuOption CoursesMenuOption { get; set; } = new MenuOption();
        public HomeViewModels()
        {
            GradeMenuOption.Title = "Grade";
            GradeMenuOption.Image = "Grade";

            YouMenuOption.Title = "You";
            YouMenuOption.Image = "you";

            RecordMenuOption.Title = "Record";
            RecordMenuOption.Image = "Record";

            AssignmentMenuOption.Title = "Assignment";
            AssignmentMenuOption.Image = "Assignment";

            GpaMenuOption.Title = "Gpa";
            GpaMenuOption.Image = "Gpa";

            CoursesMenuOption.Title = "Course";
            CoursesMenuOption.Image = "Courses";
        }

    }

}
