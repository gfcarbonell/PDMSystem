using AGAServerBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGAServerBackend.services
{
    public interface ITurn
    {
        void addTurn(Turn turn);
    }
}
