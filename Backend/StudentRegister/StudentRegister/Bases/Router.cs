namespace StudentRegister.Bases
{
    public static class Router
    {
        public const string root = "Api/";
        public const string version = "V1/";
        public const string rule = root + version;

        public static class StudentRouting
        {
            public const string prefix = rule + "Student/";

            public const string List = prefix + "List/";
            public const string Create = prefix + "Create/";
        }

        public static class CourseRouting
        {
            public const string prefix = rule + "Course/";

            public const string List = prefix + "List/";
        }
    }
}
