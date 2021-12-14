using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_8
{
    interface IHuman
    {
        public string HumanBriefInfo(); //по фамилии
        public string HumanFullInfo(); //фио
        public void Meeting(IHuman human); //встреча
        public bool IsSelected { get; set; }
    }
}
