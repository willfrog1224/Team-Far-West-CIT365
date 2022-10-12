using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Towne
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
    public class Desk
    {
        private const int MAX_WIDTH = 96;
        private const int MAX_DEPTH = 48;
        private const int MIN_WIDTH = 24;
        private const int MIN_DEPTH = 12;
        public int Width;
        public int Depth;
        public int Drawers;
        public string DesktopMaterial;

        public Desk(int width, int depth, int drawers, string desktopMaterial)
        {
            Width = width;
            Depth = depth;
            Drawers = drawers;
            DesktopMaterial = desktopMaterial;
        }

        
    }
}
