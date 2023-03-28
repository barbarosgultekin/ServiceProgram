namespace Core.Plugins.Authentication.Models
{
    public class JwtCreateModel
    {
   
        public int Id { get; set; }
        public string FullName { get; set; }
     
        public JwtCreateModel(int id, string fullName)
        {
            Id = id;
            FullName = fullName;            
        }
    }
}