using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDatabase
{
    public class DataAccess
    {
        // cemadgzl;Cem;Adiguzel;Sales;2015-12-31;+90 533 12345678

        private string fileName;

        public DataAccess(string fileName)
        {
            this.fileName = fileName;
        }

        public int loadData()
        {
            int results = 0;
            StreamReader reader = new StreamReader(this.fileName);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(';');

                string username = line[0];
                string firstname = line[1];
                string lastname = line[2];
                string department = line[3];
                string enddate = line[4];
                string phone = line[5];

                if (Validator.validateUsername(username) && Validator.validateName(firstname)
                    && Validator.validateName(lastname) && Validator.validateDepartment(department)
                    && Validator.validateDate(enddate) && Validator.validatePhoneNumber(phone))
                {
                    results++;
                }
            }
            reader.Close();
            return results;
        }

        public List<Personel> findByName(string firstName, string lastName)
        {
            List<Personel> data = new List<Personel>();

            StreamReader reader = new StreamReader(this.fileName);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(';');

                if (line[1].ToLower() == firstName.ToLower() && line[2].ToLower() == lastName.ToLower())
                {

                    string username = line[0];
                    string firstname = line[1];
                    string lastname = line[2];
                    string department = line[3];
                    string enddate = line[4];
                    string phone = line[5];

                    if (Validator.validateUsername(username) && Validator.validateName(firstname)
                        && Validator.validateName(lastname) && Validator.validateDepartment(department)
                        && Validator.validateDate(enddate) && Validator.validatePhoneNumber(phone))
                    {
                        Personel personel = new Personel();
                        personel.Username = username;
                        personel.FirstName = firstname;
                        personel.LastName = lastname;
                        personel.Department = department;
                        personel.AccountEndDate = convertDateTime(enddate);
                        personel.PhoneNumber = phone;

                        data.Add(personel);
                    }
                }

            }
            reader.Close();

            return data;
        }

        public List<Personel> findByDepartment(string _department)
        {
            List<Personel> data = new List<Personel>();

            StreamReader reader = new StreamReader(this.fileName);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(';');

                if (line[3].ToLower() == _department.ToLower())
                {

                    string username = line[0];
                    string firstname = line[1];
                    string lastname = line[2];
                    string department = line[3];
                    string enddate = line[4];
                    string phone = line[5];

                    if (Validator.validateUsername(username) && Validator.validateName(firstname)
                        && Validator.validateName(lastname) && Validator.validateDepartment(department)
                        && Validator.validateDate(enddate) && Validator.validatePhoneNumber(phone))
                    {
                        Personel personel = new Personel();
                        personel.Username = username;
                        personel.FirstName = firstname;
                        personel.LastName = lastname;
                        personel.Department = department;
                        personel.AccountEndDate = convertDateTime(enddate);
                        personel.PhoneNumber = phone;

                        data.Add(personel);
                    }
                }

            }
            reader.Close();

            return data;
        }

        public List<Personel> findByTelephoneNumber(string telephoneNumber)
        {
            List<Personel> data = new List<Personel>();

            StreamReader reader = new StreamReader(this.fileName);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(';');

                if (line[5] == telephoneNumber)
                {

                    string username = line[0];
                    string firstname = line[1];
                    string lastname = line[2];
                    string department = line[3];
                    string enddate = line[4];
                    string phone = line[5];

                    if (Validator.validateUsername(username) && Validator.validateName(firstname)
                        && Validator.validateName(lastname) && Validator.validateDepartment(department)
                        && Validator.validateDate(enddate) && Validator.validatePhoneNumber(phone))
                    {
                        Personel personel = new Personel();
                        personel.Username = username;
                        personel.FirstName = firstname;
                        personel.LastName = lastname;
                        personel.Department = department;
                        personel.AccountEndDate = convertDateTime(enddate);
                        personel.PhoneNumber = phone;

                        data.Add(personel);
                    }
                }

            }
            reader.Close();

            return data;
        }

        public List<Personel> findByEndDate(DateTime intervalStart, DateTime IntervalEnd) 
        {
            List<Personel> data = new List<Personel>();

            StreamReader reader = new StreamReader(this.fileName);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(';');

                DateTime accountEndDate = convertDateTime(line[4]);

                if (accountEndDate >= intervalStart && accountEndDate <= IntervalEnd)
                {
                    string username = line[0];
                    string firstname = line[1];
                    string lastname = line[2];
                    string department = line[3];
                    string enddate = line[4];
                    string phone = line[5];

                    if (Validator.validateUsername(username) && Validator.validateName(firstname)
                        && Validator.validateName(lastname) && Validator.validateDepartment(department)
                        && Validator.validateDate(enddate) && Validator.validatePhoneNumber(phone))
                    {
                        Personel personel = new Personel();
                        personel.Username = username;
                        personel.FirstName = firstname;
                        personel.LastName = lastname;
                        personel.Department = department;
                        personel.AccountEndDate = accountEndDate;
                        personel.PhoneNumber = phone;

                        data.Add(personel);
                    }
                }

            }
            reader.Close();

            return data;
        }

        public List<Personel> findByUsername(string _username)
        {
            List<Personel> data = new List<Personel>();

            StreamReader reader = new StreamReader(this.fileName);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(';');

                if (line[0].ToLower() == _username.ToLower())
                {

                    string username = line[0];
                    string firstname = line[1];
                    string lastname = line[2];
                    string department = line[3];
                    string enddate = line[4];
                    string phone = line[5];

                    if (Validator.validateUsername(username) && Validator.validateName(firstname)
                        && Validator.validateName(lastname) && Validator.validateDepartment(department)
                        && Validator.validateDate(enddate) && Validator.validatePhoneNumber(phone))
                    {
                        Personel personel = new Personel();
                        personel.Username = username;
                        personel.FirstName = firstname;
                        personel.LastName = lastname;
                        personel.Department = department;
                        personel.AccountEndDate = convertDateTime(enddate);
                        personel.PhoneNumber = phone;

                        data.Add(personel);
                    }
                }

            }
            reader.Close();

            return data;
        }

        public List<Personel> findByUserNameAndFirstName(string _username, string _firstname) 
        {
            List<Personel> data = new List<Personel>();

            StreamReader reader = new StreamReader(this.fileName);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(';');

                if (line[0].ToLower() == _username.ToLower() && line[1].ToLower() == _firstname.ToLower())
                {

                    string username = line[0];
                    string firstname = line[1];
                    string lastname = line[2];
                    string department = line[3];
                    string enddate = line[4];
                    string phone = line[5];

                    if (Validator.validateUsername(username) && Validator.validateName(firstname)
                        && Validator.validateName(lastname) && Validator.validateDepartment(department)
                        && Validator.validateDate(enddate) && Validator.validatePhoneNumber(phone))
                    {
                        Personel personel = new Personel();
                        personel.Username = username;
                        personel.FirstName = firstname;
                        personel.LastName = lastname;
                        personel.Department = department;
                        personel.AccountEndDate = convertDateTime(enddate);
                        personel.PhoneNumber = phone;

                        data.Add(personel);
                    }
                }

            }
            reader.Close();

            return data;
        }

        // yyyy-mm-dd
        public DateTime convertDateTime(string input) 
        {
            string[] array = input.Split('-');

            int year = int.Parse(array[0]);
            int month = int.Parse(array[1]);
            int day = int.Parse(array[2]);

            return new DateTime(year, month, day);
        }
    }
}
