using System;

namespace RBS.Messages.base_local_planner
{
    [System.Serializable]
    public class Position2DInt : ExtendMessage
    {
        public int x;
        public int y;
        public override string Type() { return "base_local_planner/Position2DInt"; }
        public Position2DInt()
        {
            x = 0;
            y = 0;
        }
    }
}