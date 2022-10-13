using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MegaDesk_2
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
        private int _width;
        private int _depth;
        private int _drawers;
        private string _desktopMaterial;

        public Desk(int width, int depth, int drawers, string desktopMaterial)
        {
            _width = width;
            _depth = depth;
            _drawers = drawers;
            _desktopMaterial = desktopMaterial;
        }

        public int Width { get => _width; set =>_width = value; }
        public int Depth { get => _depth; set => _depth = value; }
        public int Drawers { get => _drawers; set => _drawers = value; }
        public string DesktopMaterial { get => _desktopMaterial; set => _desktopMaterial = value; }

    }
}
