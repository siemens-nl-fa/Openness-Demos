using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siemens.Engineering;
namespace ConveyorGenerator
{
    public partial class ConnectDialog : Form
    {
        #region Fields
        private TiaPortalProcess _selectedProcess;
        #endregion

        #region Properties
        public TiaPortalProcess SelectedTiaPortalProcess
        {
            get { return _selectedProcess; }
            private set { _selectedProcess = value; }
        }
        #endregion

        #region Constructors
        public ConnectDialog()
        {
            InitializeComponent();
            ShowTiaPortalProcesses();
        }
        #endregion

        #region Methods
        private void ShowTiaPortalProcesses()
        {
            dataGridView1.Rows.Clear();

            foreach (TiaPortalProcess process in TiaPortal.GetProcesses())
            {
                int rowindex;
                if (process.ProjectPath != null)
                {
                    rowindex = dataGridView1.Rows.Add(process.Id, process.ProjectPath.Name);
                }
                else
                {
                    rowindex = dataGridView1.Rows.Add(process.Id, "No Project");
                }
                dataGridView1.Rows[rowindex].Tag = process;
            }
        }
        #endregion

        #region Events
        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (SelectedTiaPortalProcess != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            ShowTiaPortalProcesses();
        }

        private void dataGridView_TiaPortalProcesses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SelectedTiaPortalProcess = (TiaPortalProcess)dataGridView1.SelectedRows[0].Tag;
            }
        }
        #endregion
    }
}
