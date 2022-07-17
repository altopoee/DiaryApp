using DiaryApp.Properties;
namespace DiaryApp
{
    public partial class Form1 : Form
    {
        Button currentButton;
        Form activeForm;
        Button[] dayButtons;

        #region shadow

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private static bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1);
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        #endregion

        public Form1()
        {
            InitializeComponent();

            dayButtons = new Button[] { buttonMo, buttonTu, buttonWe, buttonTh, buttonFr, buttonSa, buttonSu };

            foreach (Button button in dayButtons)
                if (button.Size.Width == buttonMo.Size.Width)
                    button.Click += (sender, e) =>
                    {
                        Days.CurrentIndex = (byte)Array.IndexOf(dayButtons, (Button)sender);
                        OpenChildForm(new NotesUI.FormProduct(), sender);
                    };
        }

        void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(240, 240, 240);
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.FromArgb(20, 20, 20);
                    currentButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
                    currentButton.Enabled = false;
                }
            }
        }

        void DisableButton()
        {
            foreach (Control previousButton in Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(52, 122, 201);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    previousButton.Enabled = true;
                }
            }
        }

        void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        void buttonMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        void panelBorder_MouseDown(object sender, MouseEventArgs e)
        {
            panelBorder.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            Settings.Default.ScheduleMon ??= new string[27];
            Settings.Default.ScheduleTue ??= new string[27];
            Settings.Default.ScheduleWed ??= new string[27];
            Settings.Default.ScheduleThu ??= new string[27];
            Settings.Default.ScheduleFri ??= new string[27];
            Settings.Default.ScheduleSat ??= new string[27];
            Settings.Default.ScheduleSun ??= new string[27];
            int line = 0;
            for (int i = 0; i < 27; i++)
            {
                Days.DaysArray[0].Schedule[line] = Settings.Default.ScheduleMon[i];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Days.DaysArray[1].Schedule[line] = Settings.Default.ScheduleTue[i];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Days.DaysArray[2].Schedule[line] = Settings.Default.ScheduleWed[i];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Days.DaysArray[3].Schedule[line] = Settings.Default.ScheduleThu[i];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Days.DaysArray[4].Schedule[line] = Settings.Default.ScheduleFri[i];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Days.DaysArray[5].Schedule[line] = Settings.Default.ScheduleSat[i];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Days.DaysArray[6].Schedule[line] = Settings.Default.ScheduleSun[i];
                line++;
            }
            ActivateCurrentDay();
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            int line = 0;

            for (int i = 0; i < 27; i++)
            {
                Settings.Default.ScheduleMon[i] = Days.DaysArray[0].Schedule[line];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Settings.Default.ScheduleTue[i] = Days.DaysArray[1].Schedule[line];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Settings.Default.ScheduleWed[i] = Days.DaysArray[2].Schedule[line];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Settings.Default.ScheduleThu[i] = Days.DaysArray[3].Schedule[line];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Settings.Default.ScheduleFri[i] = Days.DaysArray[4].Schedule[line];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Settings.Default.ScheduleSat[i] = Days.DaysArray[5].Schedule[line];
                line++;
            }
            line = 0;
            for (int i = 0; i < 27; i++)
            {
                Settings.Default.ScheduleSun[i] = Days.DaysArray[6].Schedule[line];
                line++;
            }

            Settings.Default.Save();
        }
        void ActivateCurrentDay()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Days.CurrentIndex = (byte)Array.IndexOf(dayButtons, buttonMo);
                    OpenChildForm(new NotesUI.FormProduct(), buttonMo);
                    break;

                case DayOfWeek.Tuesday:
                    buttonTu.Click += (sender, e) =>
                    Days.CurrentIndex = (byte)Array.IndexOf(dayButtons, buttonTu);
                    OpenChildForm(new NotesUI.FormProduct(), buttonTu);
                    break;

                case DayOfWeek.Wednesday:
                    Days.CurrentIndex = (byte)Array.IndexOf(dayButtons, buttonWe);
                    OpenChildForm(new NotesUI.FormProduct(), buttonWe);
                    break;

                case DayOfWeek.Thursday:
                    Days.CurrentIndex = (byte)Array.IndexOf(dayButtons, buttonTh);
                    OpenChildForm(new NotesUI.FormProduct(), buttonTh);
                    break;

                case DayOfWeek.Friday:
                    Days.CurrentIndex = (byte)Array.IndexOf(dayButtons, buttonFr);
                    OpenChildForm(new NotesUI.FormProduct(), buttonFr);
                    break;

                case DayOfWeek.Saturday:
                    Days.CurrentIndex = (byte)Array.IndexOf(dayButtons, buttonSa);
                    OpenChildForm(new NotesUI.FormProduct(), buttonSa);
                    break;

                case DayOfWeek.Sunday:
                    Days.CurrentIndex = (byte)Array.IndexOf(dayButtons, buttonSu);
                    OpenChildForm(new NotesUI.FormProduct(), buttonSu);
                    break;

                default:
                    break;
            }
        }
    }
}