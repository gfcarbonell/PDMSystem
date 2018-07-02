using AGAServerBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGAServerBackend.services
{
    public interface IDailyPart
    {
        void save(DailyPart dailyPart);

        void delete(int id);

        void update(DailyPart dailyPart);

        List<DailyPart> findAllDailyParts();

        DailyPart findById(int id);
    }
}
