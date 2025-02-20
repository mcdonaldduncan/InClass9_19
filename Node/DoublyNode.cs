﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass9_19
{
    internal class DoublyNode
    {
        public string Info;
        public bool IsHead;
        public bool IsTail;
        public DoublyNode? next;
        public DoublyNode? prev;

        public DoublyNode(string info, bool isHead, bool isTail)
        {
            Info = info;
            IsHead = isHead;
            IsTail = isTail;
        }
    }
}
