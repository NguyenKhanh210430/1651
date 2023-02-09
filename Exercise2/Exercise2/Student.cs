namespace Exercise2
{
    internal class Student
    {
        private String name;
        private int age;
        private float gpa;

        public String Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public float Gpa { get { return gpa; } set { gpa = value; } }

        public Student() { }

        public Student(String name, int age, float gpa)
        {
            this.name = name;
            this.age = age;
            this.gpa = gpa;
        }

        public void DisplayInfomation()
        {
            Console.WriteLine($"Name: {name}     Age: {age}     GPA: {gpa}");
        }
    }
}
