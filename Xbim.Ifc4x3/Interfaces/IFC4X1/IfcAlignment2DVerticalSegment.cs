// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.GeometricConstraintResource
{
	public partial class @IfcAlignment2DVerticalSegment : IIfcAlignment2DVerticalSegment
	{

		[CrossSchemaAttribute(typeof(IIfcAlignment2DVerticalSegment), 4)]
		Ifc4.MeasureResource.IfcLengthMeasure IIfcAlignment2DVerticalSegment.StartDistAlong 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(StartDistAlong);
			} 
			set
			{
				StartDistAlong = new MeasureResource.IfcLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAlignment2DVerticalSegment), 5)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcAlignment2DVerticalSegment.HorizontalLength 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(HorizontalLength);
			} 
			set
			{
				HorizontalLength = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAlignment2DVerticalSegment), 6)]
		Ifc4.MeasureResource.IfcLengthMeasure IIfcAlignment2DVerticalSegment.StartHeight 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(StartHeight);
			} 
			set
			{
				StartHeight = new MeasureResource.IfcLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAlignment2DVerticalSegment), 7)]
		Ifc4.MeasureResource.IfcRatioMeasure IIfcAlignment2DVerticalSegment.StartGradient 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcRatioMeasure(StartGradient);
			} 
			set
			{
				StartGradient = new MeasureResource.IfcRatioMeasure(value);
				
			}
		}
		IEnumerable<IIfcAlignment2DVertical> IIfcAlignment2DVerticalSegment.ToVertical 
		{ 
			get
			{
				return Model.Instances.Where<IIfcAlignment2DVertical>(e => e.Segments != null &&  e.Segments.Contains(this), "Segments", this);
			} 
		}
	//## Custom code
	//##
	}
}