using WindowsInput.Events.Sources;

namespace ImageGenerator
{
    public partial class GeneratorFrm : Form
    {
        private IMouseEventSource Mouse = WindowsInput.Capture.Global.Mouse();
        private Button dragButton;
        public GeneratorFrm()
        {
            InitializeComponent();
            Mouse.DragFinished += Mouse_DragFinished;
            ButtonsGrid.Paint += ButtonsGrid_Paint;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(0, 0, 0);
        }
        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }
        Point lastPoint;
        private void GeneratorFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void GeneratorFrm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void GenerateButton_MouseEnter(object sender, EventArgs e)
        {
            GenerateButton.ForeColor = Color.FromArgb(0, 0, 0);
        }
        private void GenerateButton_MouseLeave(object sender, EventArgs e)
        {
            GenerateButton.ForeColor = Color.White;
        }
        private void ButtonsGrid_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);

            e.Graphics.DrawRectangle(pen, 0, 0, ButtonsGrid.Size.Width + 1, ButtonsGrid.Size.Height + 1);

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    e.Graphics.DrawRectangle(pen, ButtonsGrid.Size.Width / 4 * x - 2, ButtonsGrid.Size.Height / 4 * y - 2, ButtonsGrid.Size.Width / 4, ButtonsGrid.Size.Height / 4);
                }
            }
        }
        private void Mouse_DragFinished(object sender, EventSourceEventArgs<IReadOnlyList<WindowsInput.Events.DragDrop>> e)
        {
            if (dragButton == null)
            {
                return;
            }

            var panelGlobalPosition = ButtonsGrid.PointToScreen(Point.Empty);
            var relativePosition = new Point(e.Data[0].Stop.PositionUp.X - panelGlobalPosition.X, e.Data[0].Stop.PositionUp.Y - panelGlobalPosition.Y);

            if (relativePosition.X < 0 || relativePosition.Y < 0)
            {
                dragButton = null;
                return;
            }

            var cellPosition = new Point(
                (int)Math.Ceiling((double)relativePosition.X / (ButtonsGrid.Width / 4)),
                (int)Math.Ceiling((double)relativePosition.Y / (ButtonsGrid.Height / 4))
            );

            if (cellPosition.X > 4 || cellPosition.Y > 4)
            {
                dragButton = null;
                return;
            }

            switch (dragButton.Text)
            {
                case "1 x 1":
                    {
                        if (ButtonsGrid.GetControlFromPosition(cellPosition.X - 1, cellPosition.Y - 1) != null)
                        {
                            dragButton = null;
                            return;
                        }

                        ButtonsGrid.Controls.Add(dragButton, cellPosition.X - 1, cellPosition.Y - 1);
                        break;
                    }

                case "1 x 2":
                    {

                        if (cellPosition.X > 3)
                        {
                            dragButton = null;
                            return;
                        }

                        for (int i = 0; i < 2; i++)
                        {
                            if (ButtonsGrid.GetControlFromPosition(cellPosition.X - 1 + i, cellPosition.Y - 1) != null)
                            {
                                dragButton = null;
                                return;
                            }
                        }

                        Control[] controls = new Control[ButtonsGrid.Controls.Count];

                        ButtonsGrid.Controls.CopyTo(controls, 0);

                        foreach (Button button in controls)
                        {
                            if (button.Text == "1 x 2" && button != dragButton)
                            {
                                button.Dispose();
                            }
                        }

                        ButtonsGrid.Controls.Add(dragButton, cellPosition.X - 1, cellPosition.Y - 1);

                        var clonedButton = dragButton.Clone();
                        clonedButton.Click += OnButtonClick;
                        clonedButton.MouseDown += OnButtonDown;

                        ButtonsGrid.Controls.Add(clonedButton, cellPosition.X, cellPosition.Y - 1);

                        break;
                    }

                case "1 x 3":
                    {

                        if (cellPosition.X > 2)
                        {
                            dragButton = null;
                            return;
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            if (ButtonsGrid.GetControlFromPosition(cellPosition.X - 1 + i, cellPosition.Y - 1) != null)
                            {
                                dragButton = null;
                                return;
                            }
                        }

                        Control[] controls = new Control[ButtonsGrid.Controls.Count];

                        ButtonsGrid.Controls.CopyTo(controls, 0);

                        foreach (Button button in controls)
                        {
                            if (button.Text == "1 x 3" && button != dragButton)
                            {
                                button.Dispose();
                            }
                        }

                        ButtonsGrid.Controls.Add(dragButton, cellPosition.X - 1, cellPosition.Y - 1);

                        for (int i = 0; i < 2; i++)
                        {

                            var clonedButton = dragButton.Clone();
                            clonedButton.Click += OnButtonClick;
                            clonedButton.MouseDown += OnButtonDown;

                            ButtonsGrid.Controls.Add(clonedButton, cellPosition.X + i, cellPosition.Y - 1);
                        }

                        break;
                    }
            }

            dragButton = null;
        }
        private void OnButtonDown(object sender, MouseEventArgs e)
        {
            dragButton = (Button)sender;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            var _sender = (Button)sender;
            if (_sender.Text == "1 x 1")
            {
                ButtonsStoragePanel.Controls.Add(_sender);
                return;
            }

            Control[] controls = new Control[ButtonsGrid.Controls.Count];

            ButtonsGrid.Controls.CopyTo(controls, 0);

            foreach (Button button in controls)
            {
                if (button.Text == _sender.Text && button != _sender)
                {
                    button.Dispose();
                }
            }

            ButtonsStoragePanel.Controls.Add(_sender);

        }
        private void GenerateButtonClick(object sender, EventArgs e)
        {
            bool haveNotFigures = true;
            int[][] illustrationOfFigures = new int[4][];

            for (int y = 0; y < 4; y++)
            {
                int[] line = new int[4];
                for (int x = 0; x < 4; x++)
                {
                    var control = ButtonsGrid.GetControlFromPosition(x, y);

                    if (control is null)
                    {
                        line[x] = 0;
                        continue;
                    }

                    haveNotFigures = false;
                    Button button = (Button)control;

                    switch (button.Text)
                    {
                        case "1 x 1":
                            {
                                line[x] = 1;
                                break;
                            }
                        case "1 x 2":
                            {
                                line[x] = 2;
                                break;
                            }
                        case "1 x 3":
                            {
                                line[x] = 3;
                                break;
                            }
                    }
                }
                illustrationOfFigures[y] = line;
            }
            if (haveNotFigures)
            {
                var otvet = GeneratorTesting.NegativeReaction();
                state.Text += otvet.ToString() + "\r";
                new System.Media.SoundPlayer().Play();
                return;
            }
            else
            {
                var otvet = GeneratorTesting.PositiveReaction();
                state.Text += otvet.ToString() + "\r";
            }

            var finalImage = ImageGenerator.GenerateImage(illustrationOfFigures);
            PictureBox.BackgroundImage = finalImage;
        }
    }
}
