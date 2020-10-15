using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.Elements
{
    public abstract class Property
    {
        Node containernode;

        public Property(Node containernode)
        {
            this.containernode = containernode;
        }

        public Node ContainerNode { get; }
        public string Name { get; set; }
        public abstract object Value { get; set; }
    }

    public class IntProperty : Property
    {
        public IntProperty(Node containernode) : base(containernode) { }
        int value;
        public override object Value
        {
            get => value;
            set => this.value = (int)value;
        }
    }
    public class StringProperty : Property
    {
        public StringProperty(Node containernode) : base(containernode) { }

        string value;
        public override object Value
        {
            get => value;
            set => this.value = (string)value;
        }
    }

    public class ArrayProperty : Property
    {
        public ArrayProperty(Node containernode) : base(containernode) { }

        List<object> value;
        public override object Value
        {
            get => value;
            set => this.value = (List<object>)value;
        }
    }
}
