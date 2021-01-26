using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketing
{
    class Player : ICustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string NationlayId { get; set; }

    }
}
