namespace task7
{
    internal class Group
    {
        private Teacher[] teachers;
        private Student[] students;
        private Topic[] topics;
        public Student[] Students { get { return students; } }
        public Teacher[] Teachers { get { return teachers; } }
        public Topic[] Topics { get { return Topics; } }
        public string Name { get; set; }
        public DateTime StartDate { get; set ; }
        public DateTime EndDate { get; set; }
        public int GroupNo { get; set; }
        public int Limit1 { get; } = 10;
        public int Limit2 { get; } = 5;
        public int Limit3 { get; } = 8;
        public Group(string name, int groupno, DateTime startdate,DateTime enddate)
        {
            name = Name;
            groupno = GroupNo;
            startdate = StartDate;
            enddate = EndDate;
            students = new Student [0];
            teachers = new Teacher[0];
            topics = new Topic[0];
        }
        public void GetGroupDetails()
        {
            Console.WriteLine($"{GroupNo}, {StartDate}, {EndDate}"); 
        }
        public void AddStudent(Student student)
        {
            if (Limit1 > students.Length)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("qrupda sagird ucun yer yoxdur");
            }
        }
        public void AddTeachers(Teacher teacher)
        {
            if (Limit2 > teachers.Length)
            {
                Array.Resize(ref teachers, teachers.Length + 1);
                teachers[teachers.Length - 1] = teacher;
            }
            else
            {
                Console.WriteLine("qrupda muellim ucun yer yoxdur");
            }
        }
        public void AddTopic(Topic topic)
        {
            if (Limit3 > topics.Length)
            {
                Array.Resize(ref topics, topics.Length + 1);
                topics[topics.Length - 1] = topic;
            }
            else
            {
                Console.WriteLine("qrupda topic ucun yer yoxdur");
            }
        }
        public void RemoveStudent(Student student)
        {
            int index = Array.IndexOf(students, student);
            if (index != -1)
            {
                for (int i = index; i < students.Length - 1; i++)
                {
                    students[index] = students[index + 1];
                }
                Array.Resize(ref students, students.Length - 1);
            }
            else
            {
                Console.WriteLine("Bu sagird qrupda yoxdur");
            }
        }
        public void RemoveTeacher(Teacher teacher)
        {
            int index = Array.IndexOf(teachers, teacher);
            if (index != -1)
            {
                for (int i = index; i < students.Length - 1; i++)
                {
                    teachers[index] = teachers[index + 1];
                }
                Array.Resize(ref teachers, teachers.Length - 1);
            }
            else
            {
                Console.WriteLine("Bu muellim qrupda yoxdur");
            }
        }
        public void RemoveTopic(Topic topic)
        {
            int index = Array.IndexOf(topics, topic);
            if (index != -1)
            {
                for (int i = index; i < topics.Length - 1; i++)
                {
                    topics[index] = topics[index + 1];
                }
                Array.Resize(ref topics, topics.Length - 1);
            }
            else
            {
                Console.WriteLine("Bu topic qrupda yoxdur");
            }
        }
        public void GetStudents()
        {
            foreach (var student in students)
            {
                student.GetDetails();
            }
        }
        public void GetTeachers()
        {
            foreach (var teacher in teachers)
            {
                teacher.GetDetails();
            }
        }
        public void GetTopics()
        {
            foreach (var topic in topics)
            {
                topic.GetDetails();
            }
        }
    }
}
