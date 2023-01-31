// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometricConstraintResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometricConstraintResource
{
	[ExpressType("IfcLocalPlacement", 481)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLocalPlacement : IfcObjectPlacement, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcLocalPlacement>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLocalPlacement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAxis2Placement _relativePlacement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcAxis2Placement @RelativePlacement 
		{ 
			get 
			{
				if(_activated) return _relativePlacement;
				Activate();
				return _relativePlacement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relativePlacement = v, _relativePlacement, value,  "RelativePlacement", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_relativePlacement = (IfcAxis2Placement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLocalPlacement other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@PlacementRelTo != null)
					yield return @PlacementRelTo;
				if (@RelativePlacement != null)
					yield return @RelativePlacement;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@PlacementRelTo != null)
					yield return @PlacementRelTo;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}