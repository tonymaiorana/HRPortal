using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models;

namespace HRPortal.Data
{
    public interface IPositionRepository
    {
        List<Position> GetAllPositions();
        void Add(Position newPosition);
        void Delete(int positionID);
        void Edit(Position position);
        Position GetByID(int positionID);
    }
}
