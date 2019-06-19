using SerializingInterfaces.Interfaces;


namespace SerializingInterfaces.Entities
{
    public class UserLogin : IUserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
