namespace ZKCLOUDAPP
{
    public class DBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<DataBaseContext>();
            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                context.Users.AddRange(new List<User>()
                {
                    new ()
                    {
                        FirstName = "Zakhar",
                        LastName ="Kolesnychenko",
                        Login = "admin",
                        Password = "admin",
                        Email = "37652@studentwsei.pl",
                        PhoneNumber = "791426082",
                        UserRole = UserRole.eMGAdministrator,
                        UserStatus = UserStatus.Active
                    }
                });

                context.SaveChanges();
            }
        }
    }
}
