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
	public partial class @IfcCsgPrimitive3D : IIfcCsgPrimitive3D
	{

		[CrossSchemaAttribute(typeof(IIfcCsgPrimitive3D), 1)]
		IIfcAxis2Placement3D IIfcCsgPrimitive3D.Position 
		{ 
			get
			{
				return Position;
			} 
			set
			{
				Position = value as GeometryResource.IfcAxis2Placement3D;
				
			}
		}
		Ifc4.GeometryResource.IfcDimensionCount Ifc4.GeometricModelResource.IfcBooleanOperand.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}