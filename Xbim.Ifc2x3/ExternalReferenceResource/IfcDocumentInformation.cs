// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.ExternalReferenceResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[ExpressType("IfcDocumentInformation", 208)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDocumentInformation : PersistEntity, IInstantiableEntity, IfcDocumentSelect, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcDocumentInformation>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDocumentInformation(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_documentReferences = new OptionalItemSet<IfcDocumentReference>( this, 0,  4);
			_editors = new OptionalItemSet<IfcActorSelect>( this, 0,  10);
		}

		#region Explicit attribute fields
		private IfcIdentifier _documentId;
		private IfcLabel _name;
		private IfcText? _description;
		private readonly OptionalItemSet<IfcDocumentReference> _documentReferences;
		private IfcText? _purpose;
		private IfcText? _intendedUse;
		private IfcText? _scope;
		private IfcLabel? _revision;
		private IfcActorSelect _documentOwner;
		private readonly OptionalItemSet<IfcActorSelect> _editors;
		private IfcDateAndTime _creationTime;
		private IfcDateAndTime _lastRevisionTime;
		private IfcDocumentElectronicFormat _electronicFormat;
		private IfcCalendarDate _validFrom;
		private IfcCalendarDate _validUntil;
		private IfcDocumentConfidentialityEnum? _confidentiality;
		private IfcDocumentStatusEnum? _status;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcIdentifier @DocumentId 
		{ 
			get 
			{
				if(_activated) return _documentId;
				Activate();
				return _documentId;
			} 
			set
			{
				SetValue( v =>  _documentId = v, _documentId, value,  "DocumentId", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
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
				SetValue( v =>  _description = v, _description, value,  "Description", 3);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IOptionalItemSet<IfcDocumentReference> @DocumentReferences 
		{ 
			get 
			{
				if(_activated) return _documentReferences;
				Activate();
				return _documentReferences;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcText? @Purpose 
		{ 
			get 
			{
				if(_activated) return _purpose;
				Activate();
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcText? @IntendedUse 
		{ 
			get 
			{
				if(_activated) return _intendedUse;
				Activate();
				return _intendedUse;
			} 
			set
			{
				SetValue( v =>  _intendedUse = v, _intendedUse, value,  "IntendedUse", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcText? @Scope 
		{ 
			get 
			{
				if(_activated) return _scope;
				Activate();
				return _scope;
			} 
			set
			{
				SetValue( v =>  _scope = v, _scope, value,  "Scope", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcLabel? @Revision 
		{ 
			get 
			{
				if(_activated) return _revision;
				Activate();
				return _revision;
			} 
			set
			{
				SetValue( v =>  _revision = v, _revision, value,  "Revision", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 9)]
		public IfcActorSelect @DocumentOwner 
		{ 
			get 
			{
				if(_activated) return _documentOwner;
				Activate();
				return _documentOwner;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _documentOwner = v, _documentOwner, value,  "DocumentOwner", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 10)]
		public IOptionalItemSet<IfcActorSelect> @Editors 
		{ 
			get 
			{
				if(_activated) return _editors;
				Activate();
				return _editors;
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 11)]
		public IfcDateAndTime @CreationTime 
		{ 
			get 
			{
				if(_activated) return _creationTime;
				Activate();
				return _creationTime;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _creationTime = v, _creationTime, value,  "CreationTime", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 12)]
		public IfcDateAndTime @LastRevisionTime 
		{ 
			get 
			{
				if(_activated) return _lastRevisionTime;
				Activate();
				return _lastRevisionTime;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _lastRevisionTime = v, _lastRevisionTime, value,  "LastRevisionTime", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 13)]
		public IfcDocumentElectronicFormat @ElectronicFormat 
		{ 
			get 
			{
				if(_activated) return _electronicFormat;
				Activate();
				return _electronicFormat;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _electronicFormat = v, _electronicFormat, value,  "ElectronicFormat", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 14)]
		public IfcCalendarDate @ValidFrom 
		{ 
			get 
			{
				if(_activated) return _validFrom;
				Activate();
				return _validFrom;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _validFrom = v, _validFrom, value,  "ValidFrom", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 15)]
		public IfcCalendarDate @ValidUntil 
		{ 
			get 
			{
				if(_activated) return _validUntil;
				Activate();
				return _validUntil;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _validUntil = v, _validUntil, value,  "ValidUntil", 15);
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 16)]
		public IfcDocumentConfidentialityEnum? @Confidentiality 
		{ 
			get 
			{
				if(_activated) return _confidentiality;
				Activate();
				return _confidentiality;
			} 
			set
			{
				SetValue( v =>  _confidentiality = v, _confidentiality, value,  "Confidentiality", 16);
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 17)]
		public IfcDocumentStatusEnum? @Status 
		{ 
			get 
			{
				if(_activated) return _status;
				Activate();
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status", 17);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedDocuments")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 18)]
		public IEnumerable<IfcDocumentInformationRelationship> @IsPointedTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDocumentInformationRelationship>(e => e.RelatedDocuments != null &&  e.RelatedDocuments.Contains(this), "RelatedDocuments", this);
			} 
		}
		[InverseProperty("RelatingDocument")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 19)]
		public IEnumerable<IfcDocumentInformationRelationship> @IsPointer 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDocumentInformationRelationship>(e => Equals(e.RelatingDocument), "RelatingDocument", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_documentId = value.StringVal;
					return;
				case 1: 
					_name = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_documentReferences.InternalAdd((IfcDocumentReference)value.EntityVal);
					return;
				case 4: 
					_purpose = value.StringVal;
					return;
				case 5: 
					_intendedUse = value.StringVal;
					return;
				case 6: 
					_scope = value.StringVal;
					return;
				case 7: 
					_revision = value.StringVal;
					return;
				case 8: 
					_documentOwner = (IfcActorSelect)(value.EntityVal);
					return;
				case 9: 
					_editors.InternalAdd((IfcActorSelect)value.EntityVal);
					return;
				case 10: 
					_creationTime = (IfcDateAndTime)(value.EntityVal);
					return;
				case 11: 
					_lastRevisionTime = (IfcDateAndTime)(value.EntityVal);
					return;
				case 12: 
					_electronicFormat = (IfcDocumentElectronicFormat)(value.EntityVal);
					return;
				case 13: 
					_validFrom = (IfcCalendarDate)(value.EntityVal);
					return;
				case 14: 
					_validUntil = (IfcCalendarDate)(value.EntityVal);
					return;
				case 15: 
                    _confidentiality = (IfcDocumentConfidentialityEnum) System.Enum.Parse(typeof (IfcDocumentConfidentialityEnum), value.EnumVal, true);
					return;
				case 16: 
                    _status = (IfcDocumentStatusEnum) System.Enum.Parse(typeof (IfcDocumentStatusEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDocumentInformation other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @DocumentReferences)
					yield return entity;
				if (@DocumentOwner != null)
					yield return @DocumentOwner;
				foreach(var entity in @Editors)
					yield return entity;
				if (@CreationTime != null)
					yield return @CreationTime;
				if (@LastRevisionTime != null)
					yield return @LastRevisionTime;
				if (@ElectronicFormat != null)
					yield return @ElectronicFormat;
				if (@ValidFrom != null)
					yield return @ValidFrom;
				if (@ValidUntil != null)
					yield return @ValidUntil;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @DocumentReferences)
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