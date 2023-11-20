using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQMDCore.DataModels
{
    public class AQMDContact
    {
        /// <summary>

        /// 	This property represents the first name of the contact person.

        /// </summary>

        public string FirstName { get; set; }

        /// <summary>

        ///  	It represents the last name of the contact person.

        /// </summary>

        public string LastName { get; set; }

        /// <summary>

        /// 	This property represents the job title or position of the contact person within the organization.

        /// </summary>

        public string Title { get; set; }

        /// <summary>

        ///  	It represents the email address of the contact person.

        /// </summary>

        public string ContactEmail { get; set; }

        /// <summary>

        /// 	This property represents the area code for the contact person's telephone number.

        /// </summary>

        public string AreaCodeTelephone { get; set; }

        /// <summary>

        /// 	It represents the main telephone number of the contact person, excluding the area code.

        /// </summary>

        public string Telephone { get; set; }

        /// <summary>

        /// 	This property represents the area code for the contact person's fax number.

        /// </summary>

        public string AreaCodeFax { get; set; }

        /// <summary>

        /// 	It represents the fax number of the contact person, excluding the area code.

        /// </summary>

        public string Fax { get; set; }

        /// <summary>

        ///  	This property represents a prefix or honorific title for the contact person (e.g., "Mr.," "Ms.," "Dr.").

        /// </summary>

        public string ContactPrefix { get; set; }

        /// <summary>

        /// 	This property appears to represent a type or category associated with the contact information, such as a system type.

        /// </summary>

        public string SystemType { get; set; }

        /// <summary>

        /// 	It represents a suffix or additional title for the contact person (e.g., "Jr.," "Sr.").

        /// </summary>

        public string ContactSuffix { get; set; }

        /// <summary>

        /// 	This property represents any extension number for the contact person's telephone.

        /// </summary>

        public string Extension { get; set; }

        /// <summary>

        ///  	This property represents any extension number for the contact person's telephone.

        /// </summary>

        public string Department { get; set; }

        /// <summary>

        /// 	This property appears to be an identifier, possibly for associating this contact information with some other entity or record, such as a business information ID.

        /// </summary>

        public int BusIInfoID { get; set; }


    }
}
