using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTFSScriptOverlord.Script_GUI_s
{
    public partial class AlgoaGUI : Form
    {
        private DirectoryInfo _rawDir { get; set; }

        public AlgoaGUI()
        {
            InitializeComponent();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (endDateTimePicker.Value < startDateTimePicker.Value) endDateTimePicker.Value = startDateTimePicker.Value;

            endDateTimePicker.MinDate = startDateTimePicker.Value;
            UpdateDates();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateDates();
        }

        private void UpdateDates()
        {
            Console.WriteLine(startDateTimePicker.Value.ToString("yyyyMMdd"));
            Console.WriteLine(endDateTimePicker.Value.ToString("yyyyMMdd"));
        }
    }
}
