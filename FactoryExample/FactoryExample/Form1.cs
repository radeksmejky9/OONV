using System.Windows.Forms;
using FactoryExample;

namespace FactoryExample
{
    internal partial class Form1 : Form
    {
        List<Shape> shapes = new List<Shape>();
        ShapeStateManager stateManager = new ShapeStateManager();
        List<ShapeDecorator> shapeDecorators = new List<ShapeDecorator>();
        List<ShapeFactory> factoryList;
        List<Type> shapeTypes;
        Type currentDecorator;
        public Form1()
        {
            InitializeComponent();
            ShapeComboBox.SelectedIndex = 0;
            DecoratorCombo.SelectedIndex = 0;
            factoryList = new List<ShapeFactory>() {
                new CircleFactory() {
                color = ColorButton.BackColor,
                size = (int)SizeNum.Value,
                isFilled = IsFilledCheck.Checked
            },
                new SquareFactory() {
                color = ColorButton.BackColor,
                size = (int)SizeNum.Value,
                isFilled = IsFilledCheck.Checked
            },
            };

            shapeTypes = new List<Type>();

            foreach (ShapeFactory fact in factoryList)
            {
                shapeTypes.Add(fact.GetShape(new Point(0, 0)).GetType());
            }


        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorButton.BackColor = colorDialog.Color;
            }
        }

        private void SizeNum_ValueChanged(object sender, EventArgs e)
        {
            factoryList.ForEach(f => f.size = (int)SizeNum.Value);
        }

        private void IsFilledCheck_CheckedChanged(object sender, EventArgs e)
        {
            factoryList.ForEach(f => f.isFilled = IsFilledCheck.Checked);
        }

        private void CenterCheck_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ColorButton_BackColorChanged(object sender, EventArgs e)
        {
            factoryList.ForEach(f => f.color = ColorButton.BackColor);
        }

        private void canvas1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Shape s = factoryList[ShapeComboBox.SelectedIndex].GetShape(e.Location);
                stateManager.Subscribe(s);
                if (DecoratorCombo.SelectedIndex == 0)
                    shapes.Add(new BorderDecorator(s));
                else if (DecoratorCombo.SelectedIndex == 1)
                    shapes.Add(new ShadowDecorator(s));
                else if (DecoratorCombo.SelectedIndex == 2)
                    shapes.Add(new ShadowDecorator(new BorderDecorator(s)));
                else
                    shapes.Add(s);
            }
            Refresh();
        }

        private void canvas1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (Shape s in shapes)
            {
                s.Draw(e.Graphics, CenterCheck.Checked);
            }
        }

        private void EnableButton_Click(object sender, EventArgs e)
        {

            stateManager.NotifyStateChanged(shapeTypes[ShapeComboBox.SelectedIndex], true);
            Refresh();
        }

        private void DisableButton_Click(object sender, EventArgs e)
        {
            stateManager.NotifyStateChanged(shapeTypes[ShapeComboBox.SelectedIndex], false);
            Refresh();
        }
    }
}