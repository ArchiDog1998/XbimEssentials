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
namespace Xbim.Ifc4x3.GeometricModelResource
{
	public partial class @IfcBlock : IIfcBlock
	{

		[CrossSchemaAttribute(typeof(IIfcBlock), 2)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcBlock.XLength 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(XLength);
			} 
			set
			{
				XLength = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBlock), 3)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcBlock.YLength 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(YLength);
			} 
			set
			{
				YLength = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBlock), 4)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcBlock.ZLength 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(ZLength);
			} 
			set
			{
				ZLength = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}