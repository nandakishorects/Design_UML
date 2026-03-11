using System;

namespace UAHighschool
{
    public class Highschool
    {
        private static Highschool _instance;
        public string schoolName;

        private Highschool() {}

        public static Highschool GetSchoolInstance()
        {
            if (_instance == null)
            {
                _instance = new Highschool();
            }
            return _instance;
        }
    }
}
