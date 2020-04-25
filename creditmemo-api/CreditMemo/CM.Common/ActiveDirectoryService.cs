using CM.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Common
{
    public class ActiveDirectoryService
    {
        string domainPath = string.Empty;
        DirectoryEntry searchRoot;
        DirectorySearcher search;

        public ActiveDirectoryService()
        {
            DirectoryEntry deRootDSE;
            deRootDSE = new DirectoryEntry("GC://RootDSE");
            domainPath = "GC://go.johnsoncontrols.com";
            searchRoot = new DirectoryEntry(domainPath);
            search = new DirectorySearcher(searchRoot);
        }

        public byte[] GetUserProfileImage(string globalId)
        {
            using (DirectorySearcher dsSearcher = new DirectorySearcher())
            {
                dsSearcher.Filter = $"(&(objectClass=user) (cn={globalId}))";
                SearchResult result = dsSearcher.FindOne();
                using (DirectoryEntry user = new DirectoryEntry(result.Path))
                {
                    return user.Properties["thumbnailPhoto"].Value as byte[];
                }
            }
        }

        public User GetUserByGlobalId(string globalId)
        {
            User userDTO = null;

            search.Filter = string.Format("(&(objectCategory=person)(objectClass=user)(|(SAMAccountname={0})))", globalId);
            search.PropertiesToLoad.Add("samaccountname");
            search.PropertiesToLoad.Add("givenName");
            search.PropertiesToLoad.Add("displayname");
            search.PropertiesToLoad.Add("sn");
            search.PropertiesToLoad.Add("Title");
            search.PropertiesToLoad.Add("mail");
            search.PropertiesToLoad.Add("manager");
            search.PropertiesToLoad.Add("physicalDeliveryOfficeName");
            search.PropertiesToLoad.Add("telephoneNumber");
            search.PropertiesToLoad.Add("mobile");

            var result = search.FindOne();

            if (result != null)
            {

                if (result.Properties.Contains("samaccountname")
                    && result.Properties.Contains("mail")
                    && result.Properties.Contains("displayname"))
                {
                    userDTO = new User();
                    userDTO.GlobalID = result.Properties["samaccountname"].Count > 0 ? Convert.ToString(result.Properties["samaccountname"][0]) : "";
                    userDTO.Email = result.Properties["mail"].Count > 0 ? Convert.ToString(result.Properties["mail"][0]) : "";
                    userDTO.FullName = (result.Properties["givenName"].Count > 0 && result.Properties["sn"].Count > 0) ?
                    Convert.ToString(result.Properties["givenName"][0]) + " " + Convert.ToString(result.Properties["sn"][0]) : "";
                    userDTO.OfficeLocation = result.Properties["physicalDeliveryOfficeName"].Count > 0 ? Convert.ToString(result.Properties["physicalDeliveryOfficeName"][0]) : "";
                    userDTO.Title = result.Properties["Title"].Count > 0 ? Convert.ToString(result.Properties["Title"][0]) : "";
                    userDTO.TelephoneNo = result.Properties["telephoneNumber"].Count > 0 ? Convert.ToString(result.Properties["telephoneNumber"][0]) : "";
                    userDTO.Mobile = result.Properties["mobile"].Count > 0 ? Convert.ToString(result.Properties["mobile"][0]) : "";

                }
            }
            return userDTO;
        }


        public string GetUserNameByGlobalId(string globalId)
        {
            var userName = string.Empty;
            search.Filter = string.Format("(&(objectCategory=person)(objectClass=user)(|(SAMAccountname={0})))", globalId);
            search.PropertiesToLoad.Add("samaccountname");
            search.PropertiesToLoad.Add("givenName");
            search.PropertiesToLoad.Add("displayname");
            search.PropertiesToLoad.Add("sn");
            //search.PropertiesToLoad.Add("physicalDeliveryOfficeName");

            var result = search.FindOne();

            if (result != null)
            {

                if (result.Properties.Contains("samaccountname")
                    && result.Properties.Contains("givenName")
                    && result.Properties.Contains("displayname"))
                {
                    userName = (result.Properties["givenName"].Count > 0 && result.Properties["sn"].Count > 0) ?
                    Convert.ToString(result.Properties["givenName"][0]) + " " + Convert.ToString(result.Properties["sn"][0]) : "";
                    //userDTO.OfficeLocation= result.Properties["physicalDeliveryOfficeName"].Count > 0 ? Convert.ToString(result.Properties["physicalDeliveryOfficeName"][0]) : "";
                }
            }
            return userName;
        }

        #region Private Methods

        public User GetSuperVisor(string globalId)
        {
            var superVisorDTO = new User();

            search.Filter = string.Format("(&(objectCategory=person)(objectClass=user)(|(SAMAccountname={0}*)))", globalId);
            search.PropertiesToLoad.Add("samaccountname");
            search.PropertiesToLoad.Add("givenName");
            search.PropertiesToLoad.Add("sn");
            search.PropertiesToLoad.Add("Title");
            search.PropertiesToLoad.Add("mail");
            search.PropertiesToLoad.Add("displayname");
            search.PropertiesToLoad.Add("physicalDeliveryOfficeName");

            var result = search.FindOne();

            if (result != null)
            {

                if (result.Properties.Contains("samaccountname")
                    && result.Properties.Contains("mail")
                    && result.Properties.Contains("displayname"))
                {

                    superVisorDTO.GlobalID = result.Properties["samaccountname"].Count > 0 ? Convert.ToString(result.Properties["samaccountname"][0]) : "";
                    superVisorDTO.Email = result.Properties["mail"].Count > 0 ? Convert.ToString(result.Properties["mail"][0]) : "";
                    superVisorDTO.FullName = (result.Properties["givenName"].Count > 0 && result.Properties["sn"].Count > 0) ?
                    Convert.ToString(result.Properties["givenName"][0]) + " " + Convert.ToString(result.Properties["sn"][0]) : "";
                    superVisorDTO.OfficeLocation = result.Properties["physicalDeliveryOfficeName"].Count > 0 ? Convert.ToString(result.Properties["physicalDeliveryOfficeName"][0]) : "";
                    superVisorDTO.Title = result.Properties["Title"].Count > 0 ? Convert.ToString(result.Properties["Title"][0]) : ""; // Added count check to avoid index out of range error.
                }
            }
            return superVisorDTO;
        }

        #endregion Private Methods

    }
}
