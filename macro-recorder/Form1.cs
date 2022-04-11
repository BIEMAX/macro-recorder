using System.Runtime.InteropServices;

namespace macro_recorder
{
    public partial class Form1 : Form
    {

        #region

        public Boolean _recordStart = false;
        private List<Point> _listCoordinates = new();

        #endregion

        #region Methods

        public Form1()
        {
            this.InitializeComponent();
            this.Text += $" - {Application.ProductVersion}";
        }

        public void RecordMouseClicks()
        {
            Point current_pos, prev_pos = new(0, 0);
            List<Point> coords = new();
            do
            {
                if (GetCursorPos(out current_pos))
                {

                    if ((current_pos.X != prev_pos.X) || (current_pos.Y != prev_pos.Y))
                    {
                        Console.WriteLine("({0},{1})", current_pos.X, current_pos.Y);
                        coords.Add(current_pos);
                    }

                    prev_pos.X = current_pos.X;
                    prev_pos.Y = current_pos.Y;
                }

                //} while (!Console.KeyAvailable);
            } while (_recordStart != true);

            var dionei = 1;
        }

        /// <summary>
        /// Get current mouse position
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point point);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(Point point);

        #endregion

        #region Events

        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                _recordStart = _recordStart == false ? true : false;
                btnRecord.Text = _recordStart ? "Stop recorder" : "Start Recorder";
                this.RecordMouseClicks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}