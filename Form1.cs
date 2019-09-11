using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitWiseComparison
{
    [Flags] public enum Kleuren
    {
        Rood = 1,
        Groen = 2,
        Blauw = 4,
        Oranje = 8,
        Paars = 16
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IiIntWaarde_ValueChanged(object sender, EventArgs e)
        {
            Kleuren k;
            k = (Kleuren)Enum.Parse(typeof(Kleuren), iiIntWaarde.Value.ToString());

            chkRood.Checked = k.HasFlag(Kleuren.Rood);
            chkGroen.Checked = k.HasFlag(Kleuren.Groen);
            chkBlauw.Checked = k.HasFlag(Kleuren.Blauw);
            chkOranje.Checked = k.HasFlag(Kleuren.Oranje);
            chkPaars.Checked = k.HasFlag(Kleuren.Paars);
        }

        private void ChkKleur_CheckedChanged(object sender, EventArgs e)
        {
            Kleuren k = 0;
            if (chkRood.Checked) k = k | Kleuren.Rood;
            if (chkGroen.Checked) k = k | Kleuren.Groen;
            if (chkBlauw.Checked) k = k | Kleuren.Blauw;
            if (chkOranje.Checked) k = k | Kleuren.Oranje;
            if (chkPaars.Checked) k = k | Kleuren.Paars;

            iiIntWaarde.Value = (int) k;
        }
    }
}
