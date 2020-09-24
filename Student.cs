using System;
using System.Collections.Generic;
using System.Text;
/*
Придумать класс, описывающий студента. Предусмотреть в нем следующие моменты: фамилия, имя,
отчество, группа, возраст, массив (зубчатый) оценок по
программированию, администрированию и дизайну.
А также добавить методы по работе с перечисленными 
данными: возможность установки/получения оценки, получение среднего балла по заданному предмету,
распечатка данных о студенте. 
 */
namespace _22_09_20__student_list
{
    class Student
    {
        public string name { set; get; }
        public string surname { set; get; }
        public string fathername { set; get; }
        public string group { set; get; }
        public int age { set; get; }
        int[][] marks = new int[3][];

        public Student() {
            name = "StdName";
            surname = "StdSurname";
            fathername = "StdFatherName";
            group = "15-A";
            age = 20;
            marks[0] = new int[5];
            marks[1] = new int[6];
            marks[2] = new int[7];
        }
        public Student(string n, string sur, string fat, string grp, int a, int f, int s, int t) {
            name = n;
            surname = sur;
            fathername = fat;
            group = grp;
            age = a;
            marks[0] = new int[f];
            marks[1] = new int[s];
            marks[2] = new int[t];
        }
        public void AddMark(int[] mark, int dest) {            
            for (int i = 0; i < marks[dest].Length; i++) {
                marks[dest][i] = mark[i];                
            }           
        }       
        public string GetMiddleValue(int need_l) {
            float middle_value = 0;
            int sum_values = 0;
            for (int i = 0; i < marks[need_l].Length; i++) {
                middle_value += marks[need_l][i];
                sum_values++;
            }
            return Math.Round(middle_value / sum_values, 1).ToString();
        }
        public string ShowInfo() {
            string extract_string = "";
            
            extract_string += "Name: " + name + "\nSurname: " + surname + "\nFather Name: " + fathername + "\nAge: " + age + "\nGroup: " + group + "\n";
            extract_string += "Programming marks: ";
            for (int i = 0; i < marks[0].Length; i++) extract_string += marks[0][i].ToString() + " ";
            extract_string += "\t\t- Middle value: " + GetMiddleValue(0);
            extract_string += "\nAdministrating marks: ";
            for (int i = 0; i < marks[1].Length; i++) extract_string += marks[1][i].ToString() + " ";
            extract_string += "\t- Middle value: " + GetMiddleValue(1);
            extract_string += "\nDesign marks: ";
            for (int i = 0; i < marks[2].Length; i++) extract_string += marks[2][i].ToString() + " ";
            extract_string += "\t\t- Middle value: " + GetMiddleValue(2);
            extract_string += "\n------------------------------------------------------------------";
            return extract_string;
        }
    }
}
