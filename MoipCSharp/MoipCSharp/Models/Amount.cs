﻿#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Amount
    {
        public string currency { get; set; }
        public Subtotals subtotals { get; set; }
        public int _fixed { get; set; }
        public int paid { get; set; }
        public int total { get; set; }
        public int fees { get; set; }
        public int refunds { get; set; }
        public int liquid { get; set; }
        public int otherReceivers { get; set; }
        public int addition { get; set; }
        public int deduction { get; set; }
        public int gross { get; set; }
    }
}