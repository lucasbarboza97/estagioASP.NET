using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjetoBebidas
{
    class Style
    {
        /*********************** Definições de estilo de datagridview ***********************/

        public DataGridView styleDataGridView(DataGridView dg)
        {
            dg.RowHeadersVisible = false;
            dg.EnableHeadersVisualStyles = false;
            dg.DefaultCellStyle.Font = new Font("Arial", 9);
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dg.ColumnHeadersHeight = 42;
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);
            dg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.MultiSelect = false;
            dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;


            foreach (DataGridViewColumn column in dg.Columns)
            {
                if (column.DataPropertyName == "primeiraColuna")
                    column.Width = 100;

                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            return dg;
        }
    }
}
