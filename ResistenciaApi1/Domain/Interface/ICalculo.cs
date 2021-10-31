using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistenciaApi1.Domain.Interface
{
    public interface ICalculo
    {
        void Line1(string Line1);

        void Line2(string Line2);

        void Line3(string Line3);

        void Line4(string Line4);

        string Retornardatos();
    }
}
