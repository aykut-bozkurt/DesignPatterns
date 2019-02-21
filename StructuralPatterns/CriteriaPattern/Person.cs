using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CriteriaPattern
{

	public enum Gender
	{
		MALE,
		FEMALE
	}

	public class Person
	{
		private string name;
		private int age;
		private Gender gender;

		public string Name { get { return name; } set { name = value; } }
		public int Age { get { return age; } set { age = value; } }
		public Gender Gender { get { return gender; } set { gender = value; } }

		public Person(string name, int age, Gender gender)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
		}

	}

}
