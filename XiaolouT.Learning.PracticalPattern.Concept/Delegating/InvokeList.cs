using System;
using System.Collections.Generic;

namespace XiaolouT.Learning.PracticalPattern.Concept.Delegating
{
    public class InvokeList
    {
        private readonly IList<Action> _handlers;
        private readonly string[] _message = new string[3];

        public InvokeList()
        {
            _handlers = new List<Action>
            {
                AppendHello,
                AppendComma,
                AppendWorld
            };
        }

        public void Invoke()
        {
            foreach (var a in _handlers)
            {
                a.Invoke();
            }
        }

        public string this[int index]
        {
            get { return _message[index]; }
        }

        public void AppendHello()
        {
            _message[0] = "hello";
        }
        public void AppendComma()
        {
            _message[1] = ",";
        }
        public void AppendWorld()
        {
            _message[2] = "world";
        }
    }
}
