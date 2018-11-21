using System;
using System.Collections.Generic;
using System.Text;

namespace IDesThings.ManTrace.Interfaces
{
    public interface IPersonnel
    {
        string Lastname { get; set; }
        string Firstname { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        DateTime BirtDate { get; set; }
        string PersonnelClassification { get; set; }


    }
}
