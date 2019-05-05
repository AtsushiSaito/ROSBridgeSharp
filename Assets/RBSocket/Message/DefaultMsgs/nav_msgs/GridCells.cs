using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class GridCells : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public float cell_width;
        public float cell_height;
        public RBS.Messages.geometry_msgs.Point[] cells;
        public override string Type() { return "nav_msgs/GridCells"; }
        public GridCells()
        {
            header = new RBS.Messages.std_msgs.Header();
            cell_width = 0.0f;
            cell_height = 0.0f;
            cells = new RBS.Messages.geometry_msgs.Point[0];
        }
    }
}