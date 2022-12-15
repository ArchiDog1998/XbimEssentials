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
using Xbim.Ifc4x3.GeometricModelResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometricModelResource
{
	[ExpressType("IfcPolygonalFaceSet", 1324)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPolygonalFaceSet : IfcTessellatedFaceSet, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcPolygonalFaceSet>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPolygonalFaceSet(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_faces = new ItemSet<IfcIndexedPolygonalFace>( this, 0,  3);
			_pnIndex = new OptionalItemSet<IfcPositiveInteger>( this, 0,  4);
		}

		#region Explicit attribute fields
		private IfcBoolean? _closed;
		private readonly ItemSet<IfcIndexedPolygonalFace> _faces;
		private readonly OptionalItemSet<IfcPositiveInteger> _pnIndex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcBoolean? @Closed 
		{ 
			get 
			{
				if(_activated) return _closed;
				Activate();
				return _closed;
			} 
			set
			{
				SetValue( v =>  _closed = v, _closed, value,  "Closed", 2);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 7)]
		public IItemSet<IfcIndexedPolygonalFace> @Faces 
		{ 
			get 
			{
				if(_activated) return _faces;
				Activate();
				return _faces;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 8)]
		public IOptionalItemSet<IfcPositiveInteger> @PnIndex 
		{ 
			get 
			{
				if(_activated) return _pnIndex;
				Activate();
				return _pnIndex;
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
					_closed = value.BooleanVal;
					return;
				case 2: 
					_faces.InternalAdd((IfcIndexedPolygonalFace)value.EntityVal);
					return;
				case 3: 
					_pnIndex.InternalAdd(value.IntegerVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPolygonalFaceSet other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Coordinates != null)
					yield return @Coordinates;
				foreach(var entity in @Faces)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Faces)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}