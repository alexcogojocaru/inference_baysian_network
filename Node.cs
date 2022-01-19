using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAProiect
{
    class Node
    {
        private int _id;
        private Tuple<int, int> _position;
        private List<int> _parents;
        private List<int> _domainOfValues;
        private List<List<double>> _probabilities;

        public int Id { get { return _id; } }
        
        public Tuple<int, int> Position { get { return _position; } }

        public List<int> Parents { get { return _parents; } set { _parents = value; } }

        public List<int> DomainOfValues { get { return _domainOfValues; } set { _domainOfValues = value; } }

        public List<List<double>> Probabilities { get { return _probabilities; } set { _probabilities = value; } }

        public Node(int id, Tuple<int, int> position)
        {
            this._id = id;
            this._position = position;
        }
    }
}
