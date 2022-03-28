using System;
using System.Collections.Generic;
using System.Text;



namespace ConsoleApp16
{
    internal class Student
    {
        public Student(string fullName, string groupNo, int age)
        {
            this.FullName = fullName; 
            this.GroupNo = groupNo;
            this.Age = age;
        }

        private string _fullName;
        private string _groupNo;
        public string FullName
        {
            get => this._fullName;
            set
            {
                if (CheckFullName(value))
                {
                    this._fullName = value;
                }
            }
        }

        public string GroupNo
        {
            get => this._groupNo;
            set
            {
                if (CheckGroupNo(value))
                {
                    this._groupNo = value;
                }
            }
        }
        public int Age { get; set; }
        public static bool CheckFullName(string name)
        {
            name = name.Trim();
            string[] arrs = name.Split(' ');
            if (arrs.Length == 2)
            {
                foreach (string item in arrs)
                {
                    if (char.IsUpper(item[0]))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckGroupNo(string no)
        {
            if (char.IsUpper(no[0]) && no.Length == 4)
            {

                for (int i = 1; i < no.Length; i++)
                {
                    if (char.IsDigit(no[i]))
                        return true;
                }
                return false;

            }
            return false;
        }

    }
}