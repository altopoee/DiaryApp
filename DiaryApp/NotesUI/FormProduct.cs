using System.Text.RegularExpressions;

namespace DiaryApp.NotesUI
{
    public partial class FormProduct : Form
    {
        byte previousTextLength;
        byte textBoxIndex;
        public byte dayIndex;
        string text;
        string[,] schedule;
        int pos;
        TextBox[] textBoxes;

        public FormProduct()
        {
            InitializeComponent();

            textBoxes = new TextBox[]
            {
                textBoxTime1, textBoxEvent1, textBoxNote1,
                textBoxTime2, textBoxEvent2, textBoxNote2,
                textBoxTime3, textBoxEvent3, textBoxNote3,
                textBoxTime4, textBoxEvent4, textBoxNote4,
                textBoxTime5, textBoxEvent5, textBoxNote5,
                textBoxTime6, textBoxEvent6, textBoxNote6,
                textBoxTime7, textBoxEvent7, textBoxNote7,
                textBoxTime8, textBoxEvent8, textBoxNote8,
                textBoxTime9, textBoxEvent9, textBoxNote9
            };

            for (int i = 0; i < textBoxes.Length; i++)
            { 
                if(Days.DaysArray[Days.CurrentIndex].Schedule[i] != "" && Days.DaysArray[Days.CurrentIndex].Schedule[i] != null)
                    textBoxes[i].Text = Days.DaysArray[Days.CurrentIndex].Schedule[i];

                if (textBoxes[i].Size.Width == textBoxTime1.Size.Width && textBoxes[i].Text != "")
                    textBoxes[i].ForeColor = Color.FromArgb(20, 20, 20);
            }

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Size.Width == textBoxTime1.Size.Width)
                {
                    if (!TimeIsValid(textBox, false))
                    {
                        textBox.Text = "00:00";
                        textBox.ForeColor = SystemColors.ButtonFace;
                    }

                    textBox.Enter += (sender, e) =>
                    {
                        if (TimeIsValid(sender, false))
                        {
                            textBox.ResetText();
                            textBox.ForeColor = Color.FromArgb(20, 20, 20);
                        }
                    };

                    textBox.TextChanged += (sender, e) =>
                    {
                        AutoColon(sender);
                        SaveData(sender);
                    };

                    textBox.Leave += (sender, e) =>
                    {
                        if (TimeIsValid(sender))
                        {
                            if (textBox.Text.Length == 5 && textBox.Text.StartsWith("0"))
                            {
                                textBox.Text = textBox.Text.Remove(0, 1);
                            }
                            if (textBox.Text.Length == 4)
                            {
                                textBox.Text = " " + textBox.Text;
                            }
                            if (textBox.Text == "")
                            {
                                textBox.Text = "00:00"; textBox.ForeColor = SystemColors.ButtonFace;
                            }

                        }

                    };

                    textBox.KeyDown += (sender, e) =>
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            e.SuppressKeyPress = true;
                            FocusNext((TextBox)sender, textBoxes);
                        }
                    };

                }

                if (textBox.Size.Width == textBoxEvent1.Size.Width)
                {
                    textBox.TextChanged += (sender, e) =>
                    {
                        SaveData(sender);
                    };

                    textBox.KeyDown += (sender, e) =>
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            e.SuppressKeyPress = true;
                            FocusNext(textBox, textBoxes);
                        }
                    };

                    textBox.Leave += (sender, e) =>
                    {
                        text = textBox.Text;

                        textBox.ResetText();

                        textBox.Text = text;
                    };
                }

                if (textBox.Size.Width == textBoxNote1.Size.Width)
                {
                    textBox.MouseDoubleClick += (sender, e) => { ExpandLine(sender); };

                    textBox.Leave += (sender, e) =>
                    {
                        ContractLine(sender);

                        text = textBox.Text;

                        textBox.ResetText();

                        textBox.Text = text;
                    };

                    textBox.KeyDown += (sender, e) =>
                    {
                        if (e.Shift && e.KeyCode == Keys.Enter)
                        {
                            textBox.Text += "\r\n";
                            textBox.ScrollBars = ScrollBars.Vertical;
                            textBox.SelectionStart = textBox.Text.Length;
                            e.SuppressKeyPress = true;
                        }
                        else if (e.KeyCode == Keys.Enter)
                        {
                            e.SuppressKeyPress = true;
                            FocusNext(textBox, textBoxes);
                        }
                    };

                    textBox.Leave += (sender, e) =>
                    {
                        if (((string[])textBox.Lines).Length < 1)
                            textBox.ScrollBars = ScrollBars.None;
                    };

                    textBox.TextChanged += (sender, e) =>
                    {
                        if (((string[])textBox.Lines).Length > 1)
                            textBox.ScrollBars = ScrollBars.Vertical;
                        SaveData(sender);
                    };
                }
            }
        }

        static void ContractLine(object sender)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Size = new Size(497, 25);
        }

        static void ExpandLine(object sender)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BringToFront();

            if (textBox.Size.Height == 25)
                textBox.Size = new Size(497, 87);
            else
                textBox.Size = new Size(497, 25);
        }

        void AutoColon(object sender)
        {
            TextBox textBox = (TextBox)sender;

            bool isMatch = Regex.IsMatch(textBox.Text, @"\d\d");


            if ((textBox.Text.Length == 2) && isMatch && textBox.Text.Length > previousTextLength)
            {
                textBox.Text += ":";
                textBox.SelectionStart = textBox.Text.Length;
            }
            previousTextLength = (byte)textBox.Text.Length;

        }

        static bool TimeIsValid(object sender, bool processing = true)
        {
            TextBox textBox = (TextBox)sender;

            if (processing)
            {
                if (Regex.IsMatch(textBox.Text, @"(^(([0-1]\d|2[0-3])|(\d)):[0-5]\d$)|(^ *$)"))
                {
                    textBox.Text = textBox.Text.Trim();
                    textBox.SelectionStart = textBox.Text.Length;
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid time format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Focus();
                    return false;
                }
            }
            else
            {
                if (textBox.Text == "")
                    textBox.Text = "00:00";
                if (textBox.Text == "00:00")
                    textBox.ForeColor = SystemColors.ButtonFace;

                if (Regex.IsMatch(textBox.Text, @"(^(([0-1]\d|2[0-3])|(\d)):[0-5]\d$)|(^ *$)"))
                    return true;
                else
                    return false;
            }
        }

        void FocusNext(TextBox textBox, TextBox[] textBoxes)
        {
            textBoxIndex = (byte)((byte)Array.IndexOf(textBoxes, textBox) + 1);

            if (textBoxIndex < textBoxes.Length)
                textBoxes[textBoxIndex].Focus();
        }
        void SaveData(object sender)
        {
            for (int i = 0; i < 27; i++)
            {
                Days.DaysArray[Days.CurrentIndex].Schedule[i] = textBoxes[i].Text;
            }
        }
    }
}
