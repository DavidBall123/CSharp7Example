using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Examples
{
    public interface IPerson
    {
        (string FirstName, string LastName, int Age) GetPersonDetails();
    }
}
