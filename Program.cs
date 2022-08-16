namespace DelegateClasswork
{

    /// <summary>
    /// Main program
    /// </summary>
    public class Program
    {
        public delegate bool Predicate(XClass a);       //predicate

        public bool WhereOne(Predicate b)       //method that takes in the delegate
        {
            return true;
        }
        static void Main(string[] args)
        {
            var repoUser = new Program();
            var x = new XClass();
            var possibleUsername = x.FirstName + "." + x.LastName;
            var dUserCount = repoUser.WhereOne(a => a.UserName == possibleUsername);
        }

    }
    /// <summary>
    /// Public class with the properties
    /// </summary>
    public class XClass
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
    }
}