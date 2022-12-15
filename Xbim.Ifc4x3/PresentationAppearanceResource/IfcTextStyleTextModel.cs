// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	[ExpressType("IfcTextStyleTextModel", 581)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyleTextModel : IfcPresentationItem, IInstantiableEntity, IEquatable<@IfcTextStyleTextModel>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextStyleTextModel(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcSizeSelect _textIndent;
		private IfcTextAlignment? _textAlign;
		private IfcTextDecoration? _textDecoration;
		private IfcSizeSelect _letterSpacing;
		private IfcSizeSelect _wordSpacing;
		private IfcTextTransformation? _textTransform;
		private IfcSizeSelect _lineHeight;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcSizeSelect @TextIndent 
		{ 
			get 
			{
				if(_activated) return _textIndent;
				Activate();
				return _textIndent;
			} 
			set
			{
				SetValue( v =>  _textIndent = v, _textIndent, value,  "TextIndent", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcTextAlignment? @TextAlign 
		{ 
			get 
			{
				if(_activated) return _textAlign;
				Activate();
				return _textAlign;
			} 
			set
			{
				SetValue( v =>  _textAlign = v, _textAlign, value,  "TextAlign", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcTextDecoration? @TextDecoration 
		{ 
			get 
			{
				if(_activated) return _textDecoration;
				Activate();
				return _textDecoration;
			} 
			set
			{
				SetValue( v =>  _textDecoration = v, _textDecoration, value,  "TextDecoration", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcSizeSelect @LetterSpacing 
		{ 
			get 
			{
				if(_activated) return _letterSpacing;
				Activate();
				return _letterSpacing;
			} 
			set
			{
				SetValue( v =>  _letterSpacing = v, _letterSpacing, value,  "LetterSpacing", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcSizeSelect @WordSpacing 
		{ 
			get 
			{
				if(_activated) return _wordSpacing;
				Activate();
				return _wordSpacing;
			} 
			set
			{
				SetValue( v =>  _wordSpacing = v, _wordSpacing, value,  "WordSpacing", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcTextTransformation? @TextTransform 
		{ 
			get 
			{
				if(_activated) return _textTransform;
				Activate();
				return _textTransform;
			} 
			set
			{
				SetValue( v =>  _textTransform = v, _textTransform, value,  "TextTransform", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 7)]
		public IfcSizeSelect @LineHeight 
		{ 
			get 
			{
				if(_activated) return _lineHeight;
				Activate();
				return _lineHeight;
			} 
			set
			{
				SetValue( v =>  _lineHeight = v, _lineHeight, value,  "LineHeight", 7);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_textIndent = (IfcSizeSelect)(value.EntityVal);
					return;
				case 1: 
					_textAlign = value.StringVal;
					return;
				case 2: 
					_textDecoration = value.StringVal;
					return;
				case 3: 
					_letterSpacing = (IfcSizeSelect)(value.EntityVal);
					return;
				case 4: 
					_wordSpacing = (IfcSizeSelect)(value.EntityVal);
					return;
				case 5: 
					_textTransform = value.StringVal;
					return;
				case 6: 
					_lineHeight = (IfcSizeSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextStyleTextModel other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}