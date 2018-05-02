using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sage.Peachtree.API;
using SyncTool.model;





namespace SyncTool
{
    class Program
    {

        private static PeachtreeSession apiSession;
        private static List<Companies> companies;


        static void Main(string[] args)
        {
            startSession();
            setCompanyList();

        }


        private static void startSession()
        {
            //Starts connection to Sage 50
            apiSession = new PeachtreeSession();
            apiSession.Begin(Resource1.appID); //Controlled from the Resource1.resx file, blank will allow for connection only to sample companies           

        }

        private static void setCompanyList()
        {
            // Get CompanyIdentifer for Bellwether Garden Supply sample company 
            CompanyIdentifierList m_companyIdList = apiSession.CompanyList();

          
            

            CompanyIdentifier c = m_companyIdList.ElementAt<CompanyIdentifier>(0);


            Console.WriteLine(c.CompanyName + ":" + c.DatabaseName + ":" + c.ServerName + ":" + c.Guid.ToString() + ":" + c.Path);
            Console.ReadLine();



        }

        public static void displayCompanies()
        {
            foreach(Companies c in companies)
            {
                Console.WriteLine(c.CompanyName + ":" + c.Path + ":" + c.Guid);
            }
           
        }

    }
}
