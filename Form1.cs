using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DragDropQueryBuilder;

namespace DragDropQueryBuilder
{
    public partial class Form1 : Form
    {

        private String[] fieldNames = { "everything", "id", "name", "gender", "age", "address" };
        private String[] tableNames = { "student", "employee", "author" };
        private String[] operationNames = { "select", "delete" };

        private String[] selectedFields = { };

        private List<PictureBox> fieldImages;
        private List<PictureBox> tableImages;
        private List<PictureBox> operationImages;

        public Form1()
        {
            InitializeComponent();
            InitDragableControls();
            initSelectedFieldComboBox();
        }

        private void InitDragableControls()
        {
            fieldImages = new List<PictureBox>();
            tableImages = new List<PictureBox>();
            operationImages = new List<PictureBox>();

            foreach (String field in fieldNames)
            {
                fieldImages.Add(Util.generateDragablePicture(field));
            }

            foreach (String table in tableNames)
            {
                tableImages.Add(Util.generateDragablePicture(table));
            }

            foreach (String operation in operationNames)
            {
                operationImages.Add(Util.generateDragablePicture(operation));
            }
            this.flowLayoutPanel1.Controls.AddRange(fieldImages.ToArray());
            this.tableLayoutPanel.Controls.AddRange(tableImages.ToArray());
            this.opLayoutPanel.Controls.AddRange(operationImages.ToArray());
            this.operatorComboBox.SelectedIndex = 0;

        }

        private void flowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            Util.useGeneralEffect(e);
        }

        private void flowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            var fieldName = (String)e.Data.GetData(DataFormats.Text);
            PictureBox pic = Util.generateDragablePicture(fieldName);

            if (!this.selectedFieldLayoutPanel.Controls.ContainsKey(fieldName))
            {
                if (Util.isTable(fieldName))
                {
                    this.tableLayoutPanel.Controls.RemoveByKey(fieldName);
                    var existingField = Util.ContainsGroupField(this.selectedFieldLayoutPanel, this.tableNames);
                    if (existingField != null)
                    {
                        this.selectedFieldLayoutPanel.Controls.RemoveByKey(existingField);
                        this.tableLayoutPanel.Controls.Add(Util.generateDragablePicture(existingField));
                    }

                }

                if (Util.isOperation(fieldName))
                {
                    this.opLayoutPanel.Controls.RemoveByKey(fieldName);
                    var existingField = Util.ContainsGroupField(this.selectedFieldLayoutPanel, this.operationNames);
                    if (existingField != null)
                    {
                        this.selectedFieldLayoutPanel.Controls.RemoveByKey(existingField);
                        this.opLayoutPanel.Controls.Add(Util.generateDragablePicture(existingField));
                    }

                }


                if (fieldName == "everything")
                {
                    pushItemsBackToFields();
                    removeFieldsFromSelectedPanel();
                }
                else if (!Util.isTable(fieldName) && !Util.isOperation(fieldName))
                {
                    var everythingControlIndex = this.selectedFieldLayoutPanel.Controls.IndexOfKey("everything");
                    if (everythingControlIndex > -1)
                    {
                        this.selectedFieldLayoutPanel.Controls.RemoveByKey("everything");
                        this.flowLayoutPanel1.Controls.Add(Util.generateDragablePicture("everything"));
                    }
                }
                this.flowLayoutPanel1.Controls.RemoveByKey(fieldName);
                this.selectedFieldLayoutPanel.Controls.Add(pic);
                GenerateQuery();
            }
        }

        private void removeFieldsFromSelectedPanel()
        {
            foreach (var field in fieldNames)
            {
                this.selectedFieldLayoutPanel.Controls.RemoveByKey(field);
            }
        }

        private void pushItemsBackToFields()
        {

            foreach (var control in selectedFieldLayoutPanel.Controls)
            {
                var fieldName = ((PictureBox)control).Name;
                if (this.operationNames.Contains<String>(fieldName))
                {
                    continue;
                }
                if (this.tableNames.Contains<String>(fieldName))
                {
                    continue;
                }
                //this.selectedFieldLayoutPanel.Controls.RemoveByKey(fieldName);
                this.flowLayoutPanel1.Controls.Add(Util.generateDragablePicture(fieldName));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initListView();
            logicComboBox.SelectedIndex = 0;
            logicComboBox.Visible = false;
        }

        private void initListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Field Name");
            listView1.Columns.Add("Relation");
            listView1.Columns.Add("Input");
            listView1.FullRowSelect = true;
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            var fieldName = (String)e.Data.GetData(DataFormats.Text);
            if (!flowLayoutPanel1.Controls.ContainsKey(fieldName) && !Util.isTable(fieldName) && !Util.isOperation(fieldName))
            {
                var pic = Util.generateDragablePicture(fieldName);
                this.selectedFieldLayoutPanel.Controls.RemoveByKey(fieldName);
                this.flowLayoutPanel1.Controls.Add(pic);
            }
            //ListViewItem[] fieldConstainItems = listView1.Items.Find(fieldName, true);
            //foreach (ListViewItem item in fieldConstainItems) {
            //    listView1.Items.Remove(item);
            //}
            GenerateQuery();

        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            Util.useGeneralEffect(e);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void initSelectedFieldComboBox()
        {
            selectedFieldComboBox.Items.Clear();
            foreach (var item in fieldNames)
            {
                if (item == "everything") continue;
                selectedFieldComboBox.Items.Add(item);
            }
        }

        private void AddConditionButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedField = selectedFieldComboBox.Items[selectedFieldComboBox.SelectedIndex].ToString();
                string operatorField = operatorComboBox.Items[operatorComboBox.SelectedIndex].ToString();
                string conditionField = conditionTextBox.Text;
                //listBox1.Items.Add($"{selectedField} {operatorField} {conditionField}");

                string[] items = { selectedField, operatorField, conditionField };
                ListViewItem lvItem = new ListViewItem(items);
                lvItem.Name = selectedField;
                lvItem.Tag = logicComboBox.SelectedItem;
                listView1.Items.Add(lvItem);

                logicComboBox.Visible = true;
                handleLogicBoxItems();
                conditionTextBox.Text = "";

                GenerateQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ensure to select valid constraint options");
            }
        }

        private void GenerateQuery()
        {
            clearQueryErrors();
            string columns = "";
            string whereClause = "";

            string operationName = "";
            string tableName = "";

            tableName = Util.ContainsGroupField(this.selectedFieldLayoutPanel, this.tableNames);
            operationName = Util.ContainsGroupField(this.selectedFieldLayoutPanel, this.operationNames);

            if (tableName == null)
                tableName = "";
            if (operationName == null)
                operationName = "";

            foreach (var control in selectedFieldLayoutPanel.Controls)
            {
                var field = ((PictureBox)control).Name;
                if (Util.isTable(field)) continue;
                if (Util.isOperation(field)) continue;
                if (field == "everything")
                    field = "*";
                columns += $" {field}, ";
            }


            if (listView1.Items.Count > 0)
            {
                whereClause = " WHERE ";
                var lastLogicOp = "";

                foreach (var item in listView1.Items)
                {
                    lastLogicOp = (String)((ListViewItem)item).Tag;
                    whereClause += $"{((ListViewItem)item).SubItems[0].Text}";
                    whereClause += $" {((ListViewItem)item).SubItems[1].Text} ";
                    whereClause += $"{wrapIfString(((ListViewItem)item).SubItems[2].Text)} {lastLogicOp} ";
                }
                if (whereClause.Length > 0)
                {
                    whereClause = whereClause.Substring(0, whereClause.LastIndexOf(lastLogicOp));
                }

            }

            if (operationName == "")
            {
                raiseQueryError("No operation selected, drag an operation to the Query Box.");
            }

            if (operationName == "select")
            {
                if (columns.Length > 0)
                {
                    columns = columns.Substring(0, columns.LastIndexOf(","));
                }
                else
                {
                    raiseQueryError("No field selected, drag a field to the Query Box.");
                }

                if (tableName == "")
                {
                    raiseQueryError("No table selected, drag a table to the Query Box.");
                }
                string query = $"{operationName.ToUpper()} {columns} FROM {tableName} {whereClause}";
                
                QueryTextBox.Text = query.Trim() + ";";
                praiseQueryCorrectness();
            }
            else if (operationName == "delete")
            {
                clearQueryErrors();

                if (tableName == "")
                {
                    raiseQueryError("No table selected, drag a table to the Query Box.");
                }
                this.pushItemsBackToFields();
                this.removeFieldsFromSelectedPanel();
                string query = $"DELETE FROM {tableName} {whereClause.Trim()}";
                
                QueryTextBox.Text = query.Trim() + ";";
                praiseQueryCorrectness();
            }
            else
            {
                QueryTextBox.Text = "";
            }


        }

        private void praiseQueryCorrectness()
        {
            if (listBox1.Items.Count < 1 && QueryTextBox.Text != "")
            {
                queryStatus.Text = "Fantastic!";
                queryStatus.ForeColor = Color.Green;
                listBox1.ForeColor = Color.Green;
                listBox1.Items.Add("Your query is correct!");
            }
        }

        private String wrapIfString(String val)
        {
            double myNum = 0;
            if (Double.TryParse(val, out myNum))
            {
                return "" + myNum;
            }
            else
            {
                return "'" + val + "'";
            }
        }

        private void clearQueryErrors()
        {
            listBox1.Items.Clear();
            queryStatus.Text = "";
        }

        private void raiseQueryError(string message)
        {
            queryStatus.ForeColor = Color.Maroon;
            listBox1.ForeColor = Color.Maroon;
            queryStatus.Text = "Incorrect query";
            listBox1.Items.Add(message);
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void selectedOpLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            Util.useGeneralEffect(e);
        }

        private void selectedOpLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            //selectedOpLayoutPanel.Controls.Clear();
            //selectedOpLayoutPanel.Controls.Add(Util.generateDragablePicture((String)e.Data.GetData(DataFormats.Text)));
            //GenerateQuery();
        }

        private void selectedTableLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            Util.useGeneralEffect(e);
        }

        private void selectedTableLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            //selectedTableLayoutPanel.Controls.Clear();
            //selectedTableLayoutPanel.Controls.Add(Util.generateDragablePicture((String)e.Data.GetData(DataFormats.Text)));
            //GenerateQuery();
        }

        private void removeConditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemName = listView1.SelectedItems[0].Name;
            listView1.Items.Remove(listView1.SelectedItems[0]);
            if (listView1.Items.Count < 1)
            {
                logicComboBox.Visible = false;
            }
            if (!selectedFieldComboBox.Items.Contains(itemName))
            {
                selectedFieldComboBox.Items.Add(itemName);
            }

            handleLogicBoxItems();
            GenerateQuery();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void logicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleLogicBoxItems();
        }

        private void handleLogicBoxItems()
        {
            if (logicComboBox.SelectedIndex == 0)
            {
                foreach (ListViewItem lv in listView1.Items)
                {
                    selectedFieldComboBox.Items.Remove(lv.Name);
                }
            }
            else
            {
                initSelectedFieldComboBox();
            }
        }
    }
}
