// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ExternalReferenceResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.CostResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.CostResource
{
	[ExpressType("IfcReferencesValueDocument", 551)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReferencesValueDocument : PersistEntity, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcReferencesValueDocument>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReferencesValueDocument(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_referencingValues = new ItemSet<IfcAppliedValue>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcDocumentSelect _referencedDocument;
		private readonly ItemSet<IfcAppliedValue> _referencingValues;
		private IfcLabel? _name;
		private IfcText? _description;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcDocumentSelect @ReferencedDocument 
		{ 
			get 
			{
				if(_activated) return _referencedDocument;
				Activate();
				return _referencedDocument;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _referencedDocument = v, _referencedDocument, value,  "ReferencedDocument", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 2)]
		public IItemSet<IfcAppliedValue> @ReferencingValues 
		{ 
			get 
			{
				if(_activated) return _referencingValues;
				Activate();
				return _referencingValues;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
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
				SetValue( v =>  _name = v, _name, value,  "Name", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
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
				SetValue( v =>  _description = v, _description, value,  "Description", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_referencedDocument = (IfcDocumentSelect)(value.EntityVal);
					return;
				case 1: 
					_referencingValues.InternalAdd((IfcAppliedValue)value.EntityVal);
					return;
				case 2: 
					_name = value.StringVal;
					return;
				case 3: 
					_description = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReferencesValueDocument other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ReferencedDocument != null)
					yield return @ReferencedDocument;
				foreach(var entity in @ReferencingValues)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @ReferencingValues)
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