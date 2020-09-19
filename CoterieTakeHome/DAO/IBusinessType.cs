using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace CoterieTakeHome.Interfaces
{
    interface IBusinessType
    {
        public void Architect();

        public void Plumber();

        public void Programmer();
    }
}
