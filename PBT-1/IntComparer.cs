﻿namespace PBT_1
{
    public class IntComparer
    {
        public bool AreEqual(int x, int y)
        {
            if (x is < 17 and > 0)
                return false;
            return x == y;
        }
    }
}