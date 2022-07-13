using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensions;
using GbTeklaManager.Commands;
using Tekla.Structures.Model;

namespace GbTeklaManager
{
    public partial class TeklaManager : Form
    {
        private Model _model;
        private List<Beam> _beams = new List<Beam>();
        public TeklaManager()
        {
            InitializeComponent();
            tbCutObjName.Text = "Pālis";
            tbOffset.Text = "200";
            _model = new Model();
            _beams = _model.GetModelObjectSelector().GetAllObjectsWithType(ModelObject.ModelObjectEnum.BEAM).ToList<Beam>();
            string str = "Test";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = tbCutObjName.Text;
            double offset = double.NaN;
            var boolmy = double.TryParse(tbOffset.Text, out offset);
            

            CreateCutsCommand cmd = new CreateCutsCommand(name,offset);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CutoutCommand cmd = new CutoutCommand(tbCutObjName.Text, tbOffset.Text, _beams, _model);
            cmd.GetSelection();
        }
    }
}
