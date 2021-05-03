using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo4317_DJR.Lib
{
    public partial class FrmSemiConductor : Form
    {
        public FrmSemiConductor()
        {
            InitializeComponent();
        }

        private SemiConductor _semiconductor = null;

        public SemiConductor semiconductor
        {
            get { return _semiconductor; }
        }

        public void SetSemiconductor(SemiConductor semiconductor)
        {
            _semiconductor = semiconductor;
            txtboxSubstance_Name.Text = _semiconductor.Substance_name;
            txtboxForbiddenZone_width.Text = _semiconductor.ForbiddenZone_width.ToString();
            txtboxElectron_move.Text = _semiconductor.Electron_move.ToString();
            txtboxHole_move.Text = _semiconductor.Hole_move.ToString();
        }
    }
}
