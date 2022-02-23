using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220210_Quiz
{
    public class UserPrefs
    {
        private int _width;
        private int _height;
        private int _top;
        private int _left;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height= value; }
        }

        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public int Left
        {
            get { return _left; }
            set { _left = value; }
        }

        public UserPrefs()
        {
            this.Width = 391;
            this.Height= 332;
            this.Top = 0;
            this.Left = 0;
        }

        public UserPrefs(int width, int height, int top, int left)
        {
            this.Width = width;
            this.Height= height;
            this.Top = top;
            this.Left = left;
        }
    }
}
