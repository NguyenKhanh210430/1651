namespace Exercise2;

class Program
{
    public static void Main(String[] args)
    {
        Student student = new Student();
        student.Name = "Nguyen Khanh";
        student.Age = 20;
        student.Gpa = 2;
        student.DisplayInfomation();
        Student student1 = new Student("Duy", 19, 3);
        student1.DisplayInfomation();
    }
}