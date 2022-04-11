using MouseKeyboardLibrary;
using Json.Net;

namespace macro_recorder
{
    public partial class FrmMain : Form
    {

        #region

        /// <summary>
        /// Set if record has begun.
        /// </summary>
        public Boolean _recordStart = false;
        /// <summary>
        /// List of macro events recorded
        /// </summary>
        List<MacroEvent> _events = new();
        /// <summary>
        /// Last time macro recorded
        /// </summary>
        int _lastTimeRecorded = 0;

        MouseHook mouseHook = new();
        KeyboardHook keyboardHook = new ();

        #endregion

        #region Methods

        public FrmMain()
        {
            InitializeComponent();
            Text += $" - {Application.ProductVersion}";

            mouseHook.MouseMove += new MouseEventHandler(mouseHook_MouseMove);
            mouseHook.MouseDown += new MouseEventHandler(mouseHook_MouseDown);
            mouseHook.MouseUp += new MouseEventHandler(mouseHook_MouseUp);

            keyboardHook.KeyDown += new KeyEventHandler(keyboardHook_KeyDown);
            keyboardHook.KeyUp += new KeyEventHandler(keyboardHook_KeyUp);

            SetXYLabel(MouseSimulator.X, MouseSimulator.Y);
        }

        /// <summary>
        /// Get the KeyValue integer and translate to char
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private char getChar(KeyEventArgs e)
        {
            int keyValue = e.KeyValue;
            if (!e.Shift && keyValue >= (int)Keys.A && keyValue <= (int)Keys.Z)
                return (char)(keyValue + 32);
            return (char)keyValue;
        }

        /// <summary>
        /// Replace multiple matches from a single string
        /// </summary>
        /// <param name="originalString"></param>
        /// <returns></returns>
        private String MultipleReplacement(String originalString)
        {
            var replacements = new Dictionary<string, string> { { "¹", " " }, { "²", " " }, { "³", " " } };
            return replacements.Aggregate(originalString, (current, replacement) => current.Replace(replacement.Key, replacement.Value)).Trim();
        }

        /// <summary>
        /// Check if key being already been choice
        /// </summary>
        /// <returns></returns>
        private Boolean IsKeyBindingNew()
        {
            return txtKeyStart.Text.ToUpper().Trim() == txtKeyStop.Text.ToUpper().Trim();
        }

        void SetXYLabel(int x, int y)
        {
            curXYLabel.Text = String.Format("Current Mouse Point: X={0}, y={1}", x, y);
        }

        private void CheckKeyBindings()
        {
            if (txtKeyStart.Text != String.Empty &&
                txtKeyStop.Text != String.Empty &&
                this.IsKeyBindingNew())
            {
                MessageBox.Show(
                    "Key binding defined already has been selected/defined. Please, choice other key binding",
                    "Duplicate key binding",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
        }

        private void PlayLastMacroRecorded()
        {
            List<String> logs = new();
            foreach (MacroEvent macroEvent in _events)
            {
                logs.Add(JsonNet.Serialize(macroEvent));
                Thread.Sleep(macroEvent.TimeSinceLastEvent);

                switch (macroEvent.MacroEventType)
                {
                    case MacroEventType.MouseMove:
                        {
                            MouseEventArgs mouseArgs = (MouseEventArgs)macroEvent.EventArgs;
                            MouseSimulator.X = mouseArgs.X;
                            MouseSimulator.Y = mouseArgs.Y;
                        }
                        break;
                    case MacroEventType.MouseDown:
                        {
                            MouseEventArgs mouseArgs = (MouseEventArgs)macroEvent.EventArgs;
                            MouseSimulator.MouseDown(mouseArgs.Button);
                        }
                        break;
                    case MacroEventType.MouseUp:
                        {
                            MouseEventArgs mouseArgs = (MouseEventArgs)macroEvent.EventArgs;
                            MouseSimulator.MouseUp(mouseArgs.Button);
                        }
                        break;
                    case MacroEventType.KeyDown:
                        {
                            KeyEventArgs keyArgs = (KeyEventArgs)macroEvent.EventArgs;
                            KeyboardSimulator.KeyDown(keyArgs.KeyCode);
                        }
                        break;
                    case MacroEventType.KeyUp:
                        {
                            KeyEventArgs keyArgs = (KeyEventArgs)macroEvent.EventArgs;
                            KeyboardSimulator.KeyUp(keyArgs.KeyCode);
                        }
                        break;
                    default:
                        break;
                }
            }
            var dionei = 0;
        }

        #endregion

        #region Events

        void mouseHook_MouseMove(object sender, MouseEventArgs e)
        {
            _events.Add(
                new MacroEvent(
                    MacroEventType.MouseMove,
                    e,
                    Environment.TickCount - _lastTimeRecorded
                ));

            _lastTimeRecorded = Environment.TickCount;
            this.SetXYLabel(e.X, e.Y);
        }

        void mouseHook_MouseDown(object sender, MouseEventArgs e)
        {
            _events.Add(
                new MacroEvent(
                    MacroEventType.MouseDown,
                    e,
                    Environment.TickCount - _lastTimeRecorded
                ));

            _lastTimeRecorded = Environment.TickCount;
        }

        void mouseHook_MouseUp(object sender, MouseEventArgs e)
        {
            _events.Add(
                new MacroEvent(
                    MacroEventType.MouseUp,
                    e,
                    Environment.TickCount - _lastTimeRecorded
                ));

            _lastTimeRecorded = Environment.TickCount;
        }

        void keyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            _events.Add(
                new MacroEvent(
                    MacroEventType.KeyDown,
                    e,
                    Environment.TickCount - _lastTimeRecorded
                ));

            _lastTimeRecorded = Environment.TickCount;
        }

        void keyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
            _events.Add(
                new MacroEvent(
                    MacroEventType.KeyUp,
                    e,
                    Environment.TickCount - _lastTimeRecorded
                ));

            _lastTimeRecorded = Environment.TickCount;
        }

        private void recordStartButton_Click(object sender, EventArgs e)
        {
            _events.Clear();
            _lastTimeRecorded = Environment.TickCount;

            keyboardHook.Start();
            mouseHook.Start();
        }


        private void recordStopButton_Click(object sender, EventArgs e)
        {
            keyboardHook.Stop();
            mouseHook.Stop();
        }

        private void playBackMacroButton_Click(object sender, EventArgs e)
        {
            this.PlayLastMacroRecorded();
        }

        private void txtKeyStart_KeyDown(object sender, KeyEventArgs e)
        {
            txtKeyStart.Text = $"{ModifierKeys.ToString().Trim().Replace(",", " + ")} +{getChar(e)}";
            e.Handled = true;
            this.CheckKeyBindings();
        }

        private void txtKeyStart_TextChanged(object sender, EventArgs e)
        {
            txtKeyStart.Text = MultipleReplacement(txtKeyStart.Text);
        }

        private void txtKeyStop_KeyDown(object sender, KeyEventArgs e)
        {
            txtKeyStop.Text = $"{ModifierKeys.ToString().Trim().Replace(",", " + ")} +{getChar(e)}";
            e.Handled = true;
            this.CheckKeyBindings();
        }

        private void txtKeyStop_TextChanged(object sender, EventArgs e)
        {
            txtKeyStop.Text = MultipleReplacement(txtKeyStop.Text);
        }

        private void btnMacroLog_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayMacro_Click(object sender, EventArgs e)
        {
            this.PlayLastMacroRecorded();
        }

        #endregion
    }
}