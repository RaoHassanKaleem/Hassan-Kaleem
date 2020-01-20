using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniManagmentSystem_UMT
{
    // System genrated form. 
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }


        private Color _Color1 = System.Drawing.SystemColors.GradientActiveCaption;
        private Color _Color2 = Color.White;
        private float _ColorAngle = 30f;
        public Color Color1
        {
            get { return _Color1; }
            internal set
            {
                _Color1 = value;
                this.Invalidate(); // Tell the Form to repaint itself
            }
        }
        public Color Color2
        {
            get { return _Color2; }
            internal set
            {
                _Color2 = value;
                this.Invalidate(); // Tell the Form to repaint itself
            }
        }
        public float ColorAngle
        {
            get { return _ColorAngle; }
            set
            {
                _ColorAngle = value;
                this.Invalidate(); // Tell the Form to repaint itself
            }
        }
        private void SetStyles()
        {
            // Makes sure the form repaints when it was resized
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Getting the graphics object
            Graphics g = pevent.Graphics;

            // Creating the rectangle for the gradient
            Rectangle rBackground = new Rectangle(0, 0, this.Width, this.Height);

            // Creating the lineargradient
            System.Drawing.Drawing2D.LinearGradientBrush bBackground
                = new System.Drawing.Drawing2D.LinearGradientBrush(rBackground, _Color1, _Color2, _ColorAngle);

            // Draw the gradient onto the form
            g.FillRectangle(bBackground, rBackground);

            // Disposing of the resources held by the brush
            bBackground.Dispose();
        }
        //public TPanel ParentPanel
        //{
        //    get { return pnlParent; }
        //}

        bool validateFlag = true;

        protected void ClearForm(Control.ControlCollection ctrl)
        {
            foreach (Control var in ctrl)
            {
                if (var is TextBox)
                    ((TextBox)var).Text = "";
                else if (var is CheckBox)
                    ((CheckBox)var).Checked = false;
                //else if (var is ComboBox)
                //    ((ComboBox)var).SelectedIndex = -1;
                else if (var is NumericUpDown)
                {
                    if (((NumericUpDown)var).Minimum <= 0)
                        ((NumericUpDown)var).Value = 0;
                    else
                        ((NumericUpDown)var).Value = ((NumericUpDown)var).Minimum;
                }
                else if (var is ComboBox)
                {
                    ((ComboBox)var).SelectedIndex = 0;
                }
                else if (var is GroupBox || var is Panel)
                    ClearForm(var.Controls);
                else if (var is DataGridView)
                    if (((DataGridView)var).DataSource != null)
                    {
                        ((DataGridView)var).DataSource = null;
                    }
                    else
                    {
                        ((DataGridView)var).Rows.Clear();
                    }

            }

        }
 
      

        protected void SetDataGridViewStyle(params DataGridView[] ArrDgv)
        {
            if (ArrDgv == null)
                return;

            foreach (DataGridView dgv in ArrDgv)
            {
                dgv.MultiSelect = false;

                dgv.BackgroundColor = Color.WhiteSmoke;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgv.ColumnHeadersHeight = 33;
                dgv.EnableHeadersVisualStyles = false;
                dgv.RowHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;

            }
        }
    }
}
