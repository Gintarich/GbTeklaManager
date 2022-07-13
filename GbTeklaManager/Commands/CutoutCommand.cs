using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Selector = Tekla.Structures.Model.UI.ModelObjectSelector;

namespace GbTeklaManager.Commands
{
    public class CutoutCommand
    {
        
        public CutoutCommand(string objName, string offset, List<Beam> beams, Model model)
        {
            ObjectName = objName;
            double tempOffset;
            bool isValidOffset = double.TryParse(offset, out tempOffset);
            if (!isValidOffset) Offset = 0;
            _beams = beams;
            _model = model;
        }

        public string ObjectName { get; }
        public double Offset { get; }
        private List<Beam> _beams { get; }
        private Model _model { get; }
        private List<Part> _objectsToCut { get; set; }

        public void GetSelection()
        {
            Selector selector = new Selector();
            var selectedObjects = selector.GetSelectedObjects().ToList();
            if (selectedObjects.Count <1)
            {
                Picker picker = new Picker();
                _objectsToCut = picker.PickObjects(Picker.PickObjectsEnum.PICK_N_PARTS).ToList<Part>();
            }
            else
            {
                _objectsToCut = selectedObjects.OfType<Part>().ToList();
            }
        }
    }
}
