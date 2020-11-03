// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.MaterialResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.MaterialResource
{
	[ExpressType("IfcMaterialConstituent", 1201)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialConstituent : IfcMaterialDefinition, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcMaterialConstituent>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialConstituent(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcMaterial _material;
		private IfcNormalisedRatioMeasure? _fraction;
		private IfcLabel? _category;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcMaterial @Material 
		{ 
			get 
			{
				if(_activated) return _material;
				Activate();
				return _material;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _material = v, _material, value,  "Material", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcNormalisedRatioMeasure? @Fraction 
		{ 
			get 
			{
				if(_activated) return _fraction;
				Activate();
				return _fraction;
			} 
			set
			{
				SetValue( v =>  _fraction = v, _fraction, value,  "Fraction", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcLabel? @Category 
		{ 
			get 
			{
				if(_activated) return _category;
				Activate();
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category", 5);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("MaterialConstituents")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, null, null, 9)]
		public IfcMaterialConstituentSet @ToMaterialConstituentSet 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcMaterialConstituentSet>(e => e.MaterialConstituents != null &&  e.MaterialConstituents.Contains(this), "MaterialConstituents", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_material = (IfcMaterial)(value.EntityVal);
					return;
				case 3: 
					_fraction = value.RealVal;
					return;
				case 4: 
					_category = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialConstituent other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Material != null)
					yield return @Material;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}