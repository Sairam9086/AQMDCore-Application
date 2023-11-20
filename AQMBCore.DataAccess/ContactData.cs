using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQMDCore.DataModels;
using Dapper;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace AQMBCore.DataAccess
{
    public class ContactData
    {
        DbConnectors db = new DbConnectors();
        public AQMDContact ContactDetails(int FacilityID, string SystemType)
        {
            var contact = db.Get<AQMDContact>(@"SELECT contact.bus_info_id as BusIInfoID,contact.area_code as AreaCodeTelephone, contact.phone_nbr as Telephone,contact.phone_ext as Extension,contact.rep_pfx ContactPrefix, contact.rep_first as FirstName, contact.rep_last as LastName,contact.rep_sfx as ContactSuffix, contact.rep_job_title as Title, contact.fax_area_code as AreaCodeFax,contact.fax_nbr as Fax, contact.email_addr as ContactEmail, contact.department as Department,contact.system_type as SystemType FROM contact WHERE (contact.bus_info_id =@FacilityID)AND(contact.system_type =@SystemType)", new { FacilityID = FacilityID, SystemType = SystemType });
              return contact;
        }

        //public AQMDContact UpdateContact(AQMDContact aqmdcontact ,int FacilityID)
        //{
        //    var updateParameters = new
        //    {
        //        AreaCodeTelephone = aqmdcontact.AreaCodeTelephone,
        //        Telephone = aqmdcontact.Telephone,
        //        Extension = aqmdcontact.Extension,
        //        ContactPrefix = aqmdcontact.ContactPrefix,
        //        FirstName = aqmdcontact.FirstName,
        //        LastName = aqmdcontact.LastName,
        //        ContactSuffix = aqmdcontact.ContactSuffix,
        //        Title = aqmdcontact.Title,
        //        AreaCodeFax = aqmdcontact.AreaCodeFax,
        //        Fax = aqmdcontact.Fax,
        //        ContactEmail = aqmdcontact.ContactEmail,
        //        Department = aqmdcontact.Department,
        //        SystemType = aqmdcontact.SystemType,
        //        FacilityID = FacilityID
        //    };
        //    var UpdateQuery = " UPDATE contact SET contact.area_code = @AreaCodeTelephone, contact.phone_nbr = @Telephone, contact.phone_ext = @Extension, contact.rep_pfx = @ContactPrefix, contact.rep_first = @FirstName,  contact.rep_last = @LastName, contact.rep_sfx = @ContactSuffix, contact.rep_job_title = @Title, contact.fax_area_code = @AreaCodeFax, contact.fax_nbr = @Fax, contact.email_addr = @ContactEmail contact.department = @Department, contact.system_type = @SystemType contact.bus_info_id = @FacilityID";


        //    var UpdatedContact = db.Update<AQMDContact>(UpdateQuery, updateParameters);

        //    return UpdatedContact;

        //}   

        public string  UpdateContact(AQMDContact aqmdcontact, int FacilityID)
        {
            var updateQuery = new StringBuilder();
            updateQuery.AppendLine("UPDATE contact");
            updateQuery.AppendLine("SET");
            updateQuery.AppendLine("    area_code = @AreaCodeTelephone,");
            updateQuery.AppendLine("    phone_nbr = @Telephone,");
            updateQuery.AppendLine("    phone_ext = @Extension,");
            updateQuery.AppendLine("    rep_pfx = @ContactPrefix,");
            updateQuery.AppendLine("    rep_first = @FirstName,");
            updateQuery.AppendLine("    rep_last = @LastName,");
            updateQuery.AppendLine("    rep_sfx = @ContactSuffix,");
            updateQuery.AppendLine("    rep_job_title = @Title,");
            updateQuery.AppendLine("    fax_area_code = @AreaCodeFax,");
            updateQuery.AppendLine("    fax_nbr = @Fax,");
            updateQuery.AppendLine("    email_addr = @ContactEmail,");
            updateQuery.AppendLine("    department = @Department,");
            updateQuery.AppendLine("    system_type = @SystemType");
            updateQuery.AppendLine("WHERE");
            updateQuery.AppendLine("    bus_info_id = @FacilityID");


            var parameters = new DynamicParameters();
            parameters.Add("AreaCodeTelephone", aqmdcontact.AreaCodeTelephone);
            parameters.Add("Telephone", aqmdcontact.Telephone);
            parameters.Add("Extension", aqmdcontact.Extension);
            parameters.Add("ContactPrefix", aqmdcontact.ContactPrefix);
            parameters.Add("FirstName", aqmdcontact.FirstName);
            parameters.Add("LastName", aqmdcontact.LastName);
            parameters.Add("ContactSuffix", aqmdcontact.ContactSuffix);
            parameters.Add("Title", aqmdcontact.Title);
            parameters.Add("AreaCodeFax", aqmdcontact.AreaCodeFax);
            parameters.Add("Fax", aqmdcontact.Fax);
            parameters.Add("ContactEmail", aqmdcontact.ContactEmail);
            parameters.Add("Department", aqmdcontact.Department);
            parameters.Add("SystemType", aqmdcontact.SystemType);
            parameters.Add("FacilityID", FacilityID);


            var rowsAffected = db.Update(updateQuery.ToString(), parameters);
            return rowsAffected.ToString();
        }

        //public string CreateContact(AQMDContact aqmdcontact)
        //{

        //}
    }
}
