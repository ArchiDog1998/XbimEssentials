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
namespace Xbim.Ifc4x3.ConstructionMgmtDomain
{
	public partial class @IfcConstructionEquipmentResourceType : IIfcConstructionEquipmentResourceType
	{

		[CrossSchemaAttribute(typeof(IIfcConstructionEquipmentResourceType), 12)]
		Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum IIfcConstructionEquipmentResourceType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcConstructionEquipmentResourceTypeEnum.DEMOLISHING:
						return Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.DEMOLISHING;
					case IfcConstructionEquipmentResourceTypeEnum.EARTHMOVING:
						return Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.EARTHMOVING;
					case IfcConstructionEquipmentResourceTypeEnum.ERECTING:
						return Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.ERECTING;
					case IfcConstructionEquipmentResourceTypeEnum.HEATING:
						return Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.HEATING;
					case IfcConstructionEquipmentResourceTypeEnum.LIGHTING:
						return Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.LIGHTING;
					case IfcConstructionEquipmentResourceTypeEnum.PAVING:
						return Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.PAVING;
					case IfcConstructionEquipmentResourceTypeEnum.PUMPING:
						return Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.PUMPING;
					case IfcConstructionEquipmentResourceTypeEnum.TRANSPORTING:
						return Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.TRANSPORTING;
					case IfcConstructionEquipmentResourceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.USERDEFINED;
					case IfcConstructionEquipmentResourceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.DEMOLISHING:
						PredefinedType = IfcConstructionEquipmentResourceTypeEnum.DEMOLISHING;
						return;
					case Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.EARTHMOVING:
						PredefinedType = IfcConstructionEquipmentResourceTypeEnum.EARTHMOVING;
						return;
					case Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.ERECTING:
						PredefinedType = IfcConstructionEquipmentResourceTypeEnum.ERECTING;
						return;
					case Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.HEATING:
						PredefinedType = IfcConstructionEquipmentResourceTypeEnum.HEATING;
						return;
					case Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.LIGHTING:
						PredefinedType = IfcConstructionEquipmentResourceTypeEnum.LIGHTING;
						return;
					case Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.PAVING:
						PredefinedType = IfcConstructionEquipmentResourceTypeEnum.PAVING;
						return;
					case Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.PUMPING:
						PredefinedType = IfcConstructionEquipmentResourceTypeEnum.PUMPING;
						return;
					case Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.TRANSPORTING:
						PredefinedType = IfcConstructionEquipmentResourceTypeEnum.TRANSPORTING;
						return;
					case Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.USERDEFINED:
						PredefinedType = IfcConstructionEquipmentResourceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum.NOTDEFINED:
						PredefinedType = IfcConstructionEquipmentResourceTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}