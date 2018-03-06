namespace FindItFast.Backend.Helpers
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;

    public class GlobalMethods
    {
        public static List<string> LoadGenders()
        {
            var strGenders = ConfigurationManager.AppSettings["Genders"].ToString();

            List<string> strAllGenders = strGenders.Split(',').ToList();
            return strAllGenders;
        }
    }    
}
