using task7;

public static class Program
{
    public static void Main()
    {
        Student student1 = new Student("Nuray", "Pashayeva", 2006);
        Student student2 = new Student("Leman", "Qasimova", 2008);
        Teacher teacher1 = new Teacher("Sona", "Memmedova", 45);
        Teacher teacher2 = new Teacher("Fariz", "Ismayilzade", 47);
        Topic topic1 = new Topic("Introduction", 20);
        Topic topic2 = new Topic("C#", 40);
        Group group = new Group("PB401",23, new DateTime (2024,03,30), new DateTime(2025,02,12));
        group.GetGroupDetails();
        group.AddStudent(student1);
        group.AddStudent(student2);
        group.GetStudents();
        group.RemoveStudent(student1);
        group.GetStudents();
        group.AddTeachers(teacher1);
        group.AddTeachers(teacher2);
        group.GetTeachers();
        group.RemoveTeacher(teacher2);
        group.GetTeachers();
        group.AddTopic(topic1);
        group.AddTopic(topic2);
        group.GetTopics();
        group.RemoveTopic(topic1);
        group.GetTopics();

    }
}