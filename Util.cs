using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDropQueryBuilder
{
    class Util
    {
        public static PictureBox generateDragablePicture(string fieldName)
        {
            ToolTip tooltip = new ToolTip();
            var pic = new PictureBox
            {
                Name = fieldName,
                Size = new Size(48, 48),
                Image = (Image)Properties.Resources.ResourceManager.GetObject($"{fieldName}")
            };
            pic.MouseDown += new MouseEventHandler((object sender2, MouseEventArgs e2) =>
            {
                var source = ((PictureBox)sender2);
                source.DoDragDrop(source.Name, DragDropEffects.Move);
            });
            tooltip.SetToolTip(pic, fieldName);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            return pic;
        }

        public static void useGeneralEffect(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        public static bool isTable(String field)
        {
            if (field == "student" || field == "author" || field == "employee")
            {
                return true;
            }

            return false;
        }

        public static bool isOperation(String field)
        {
            if (field == "select" || field == "delete")
            {
                return true;
            }
            return false;
        }

        public static String ContainsGroupField(FlowLayoutPanel panel, String[] fieldGroup) {
            foreach (var field in fieldGroup) {
                if (panel.Controls.ContainsKey(field)) {
                    return field;
                }
            }
            return null;
        }
    }
}
