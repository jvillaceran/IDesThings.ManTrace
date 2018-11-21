using System;
using System.Collections.Generic;
using System.Text;

namespace IDesThings.ManTrace.Facade
{
    public class ManTraceFacade : Entities.Employee, IManpower, ITimeRecord, IIDesRFID
    {
        public int SaveRawLog(string pJsonStr)
        {
            throw new NotImplementedException();
        }
    }
}
