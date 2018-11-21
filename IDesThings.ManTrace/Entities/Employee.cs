using System;
using System.Collections.Generic;
using System.Text;
using IDesThings.ManTrace.Interfaces;

namespace IDesThings.ManTrace.Entities
{
    public class Employee : IPersonnel
    {
        public string Lastname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Firstname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BirtDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PersonnelClassification { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
