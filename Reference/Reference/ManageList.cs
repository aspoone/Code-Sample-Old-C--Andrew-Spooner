using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    [Serializable]
    class ManageList
    {
        static List<Reference> referenceList = new List<Reference>();

        public List<Reference> ReferenceList
        {
            get { return referenceList; }
            set { referenceList = value; }
        }
    }
}
