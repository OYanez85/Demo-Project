namespace BackOffice
{
    public class BackOfficeLogic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public bool IsUserAdmin(string role)
        {
            return role.ToLower() == "admin";
        }
    }
}
