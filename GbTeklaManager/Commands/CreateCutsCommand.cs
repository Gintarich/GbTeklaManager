using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Filtering;
using Extensions;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Geometry3d;

namespace GbTeklaManager.Commands
{
    public class CreateCutsCommand
    {
        private Model _model;
        public CreateCutsCommand(string Name = "Pālis",double offset = 200)
        {
            _model = new Model();
            List<Beam> intersectingObjects = new List<Beam>();

            var selector = _model.GetModelObjectSelector();
            var objectsToCheck = _model.GetModelObjectSelector().GetAllObjectsWithType(ModelObject.ModelObjectEnum.BEAM).ToList().
                OfType<Beam>().Where(a => a.Name == Name);
            Picker picker = new Picker();
            var mainpart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART) as Part;
            foreach (var obj in objectsToCheck)
            {
                var objSp = obj.StartPoint;
                var objEp = obj.EndPoint;
                var centerLine = new LineSegment(objSp, objEp);
                var mainSolid = mainpart.GetSolid();

                var intersectPoints = mainSolid.Intersect(centerLine);
                if (intersectPoints.Count >= 1)
                {
                    intersectingObjects.Add(obj);
                }
            }

            foreach (var obj in intersectingObjects)
            {
                BooleanPart bp = new BooleanPart();
                bp.Father = mainpart;
                var operativePart = CreateFakePart(obj);
                bp.SetOperativePart(operativePart);
                bp.Type = BooleanPart.BooleanTypeEnum.BOOLEAN_CUT;
                bp.Insert();
                operativePart.Delete();
            }
            _model.CommitChanges();
            Console.WriteLine("Test");
        }
        private Beam CreateFakePart(Beam obj)
        {
            Beam b = new Beam();
            if (obj.Profile.ProfileString.StartsWith("D")) ;
            {
                var index = obj.Profile.ProfileString.IndexOf("D");
                var subString = obj.Profile.ProfileString.Substring(index+1);
                var diameter = double.Parse(subString);
                var newDiameter = diameter + 200;
                var newProfile = "D" + newDiameter.ToString();
                b.Profile.ProfileString = newProfile;
                
            }
            b.Name = "AutoCut";
            b.StartPoint = obj.StartPoint;
            b.EndPoint = obj.EndPoint;
            b.Position = obj.Position;
            b.Class = BooleanPart.BooleanOperativeClassName;
            b.Insert();

            return b;
        }
    }
}
