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
using Application = Autodesk.Revit.ApplicationServices.Application;

namespace ParameterExport
{
	[Transaction(TransactionMode.ReadOnly)]
	public class Command : IExternalCommand
	{
		private static Event _handler;
		private static ExternalEvent _externalEvent;

		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			if (_handler == null)
			{
				_handler = new Event();
				_externalEvent = ExternalEvent.Create(_handler);
			}

			// Trigger the external event to execute the event handler
			_externalEvent.Raise();

			return Result.Succeeded;
		}
	}
}
