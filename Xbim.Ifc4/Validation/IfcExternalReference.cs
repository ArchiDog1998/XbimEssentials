using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.ExternalReferenceResource
{
	public partial class IfcExternalReference : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.ExternalReferenceResource.IfcExternalReference");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcExternalReference clause) {
			var retVal = false;
			if (clause == Where.IfcExternalReference.WR1) {
				try {
					retVal = EXISTS(Identification) || EXISTS(Location) || EXISTS(Name);
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcExternalReference.WR1' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcExternalReference.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcExternalReference.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcExternalReference
	{
		public static readonly IfcExternalReference WR1 = new IfcExternalReference();
		protected IfcExternalReference() {}
	}
}