using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.Elements
{
    public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<Property> Inputs = new List<Property>();
        public List<Property> Outputs = new List<Property>();
        public bool Enabled { get; set; } = true;

        public virtual void Update() { }

        public virtual void Draw(Graphics g)
        {

        }
    }

    public class ValueNode : Node
    {
        public ValueNode()
        {
        }

        public override void Update()
        {

        }
    }

    public class IntValueNode : ValueNode
    {

    }
}
