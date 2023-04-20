using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Electrical;
using Autodesk.Revit.UI;

namespace FamilyReadParameter
{
	[Transaction(TransactionMode.ReadOnly)]
	public class Command : IExternalCommand
	{
		public static Event _handler;
		public static ExternalEvent _externalEvent;

		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			if (_handler == null)
			{
				_handler = new Event();
				_externalEvent = ExternalEvent.Create(_handler);
			}

			AddinForm addinForm = new AddinForm(commandData.Application, _handler);
			addinForm.Show();

			return Result.Succeeded;
		}
	}
}
