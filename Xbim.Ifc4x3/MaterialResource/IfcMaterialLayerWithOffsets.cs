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
	[ExpressType("IfcMaterialLayerWithOffsets", 1204)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayerWithOffsets : IfcMaterialLayer, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcMaterialLayerWithOffsets>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialLayerWithOffsets(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_offsetValues = new ItemSet<IfcLengthMeasure>( this, 2,  9);
		}

		#region Explicit attribute fields
		private IfcLayerSetDirectionEnum _offsetDirection;
		private readonly ItemSet<IfcLengthMeasure> _offsetValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 12)]
		public IfcLayerSetDirectionEnum @OffsetDirection 
		{ 
			get 
			{
				if(_activated) return _offsetDirection;
				Activate();
				return _offsetDirection;
			} 
			set
			{
				SetValue( v =>  _offsetDirection = v, _offsetDirection, value,  "OffsetDirection", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Array, EntityAttributeType.None, new int [] { 1 }, new int [] { 2 }, 13)]
		public IItemSet<IfcLengthMeasure> @OffsetValues 
		{ 
			get 
			{
				if(_activated) return _offsetValues;
				Activate();
				return _offsetValues;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
                    _offsetDirection = (IfcLayerSetDirectionEnum) System.Enum.Parse(typeof (IfcLayerSetDirectionEnum), value.EnumVal, true);
					return;
				case 8: 
					_offsetValues.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialLayerWithOffsets other)
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