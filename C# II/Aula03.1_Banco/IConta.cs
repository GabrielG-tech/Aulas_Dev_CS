using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03._1_Banco {
    public interface IConta {
        void Creditar(double valor); // public void Creditar();
        void Debitar(double valor); // public void Debitar();

    }
}
