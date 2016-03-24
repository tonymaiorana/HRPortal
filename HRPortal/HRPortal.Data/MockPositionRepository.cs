using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models;

namespace HRPortal.Data
{
    public class MockPositionRepository : IPositionRepository
    {
        private static List<Position>  _positions = new List<Position>();

        public MockPositionRepository()
        {
            if (!_positions.Any())
            {
                _positions.AddRange(new List<Position>()
                {
                    new Position
                    {
                        Title = "Software Engineer"
                    },

                      new Position
                    {
                        Title = "Database Engineer"
                    }
                });
            }

        }

        public List<Position> GetAllPositions()
        {
            return _positions;
        }

        public void Add(Position newPosition)
        {
            newPosition.PositionID = (_positions.Any()) ? _positions.Max(r => r.PositionID) + 1 : 1;
            _positions.Add(newPosition);
        }

        public void Delete(int positionID)
        {
            _positions.RemoveAll(r => r.PositionID == positionID); ;
        }

        public void Edit(Position position)
        {
            Delete(position.PositionID);
            _positions.Add(position);
        }

        public Position GetByID(int positionID)
        {
            return _positions.FirstOrDefault((r => r.PositionID == positionID));
        }
    }
}
