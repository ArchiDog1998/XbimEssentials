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
namespace Xbim.Ifc4x3.ElectricalDomain
{
	public partial class @IfcAudioVisualApplianceType : IIfcAudioVisualApplianceType
	{

		[CrossSchemaAttribute(typeof(IIfcAudioVisualApplianceType), 10)]
		Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum IIfcAudioVisualApplianceType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcAudioVisualApplianceTypeEnum.AMPLIFIER:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.AMPLIFIER;
					case IfcAudioVisualApplianceTypeEnum.CAMERA:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.CAMERA;
					case IfcAudioVisualApplianceTypeEnum.COMMUNICATIONTERMINAL:
						//## Handle translation of COMMUNICATIONTERMINAL member from IfcAudioVisualApplianceTypeEnum in property PredefinedType
						//TODO: Handle translation of COMMUNICATIONTERMINAL member from IfcAudioVisualApplianceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcAudioVisualApplianceTypeEnum.DISPLAY:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.DISPLAY;
					case IfcAudioVisualApplianceTypeEnum.MICROPHONE:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.MICROPHONE;
					case IfcAudioVisualApplianceTypeEnum.PLAYER:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.PLAYER;
					case IfcAudioVisualApplianceTypeEnum.PROJECTOR:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.PROJECTOR;
					case IfcAudioVisualApplianceTypeEnum.RECEIVER:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.RECEIVER;
					case IfcAudioVisualApplianceTypeEnum.RECORDINGEQUIPMENT:
						//## Handle translation of RECORDINGEQUIPMENT member from IfcAudioVisualApplianceTypeEnum in property PredefinedType
						//TODO: Handle translation of RECORDINGEQUIPMENT member from IfcAudioVisualApplianceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcAudioVisualApplianceTypeEnum.SPEAKER:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.SPEAKER;
					case IfcAudioVisualApplianceTypeEnum.SWITCHER:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.SWITCHER;
					case IfcAudioVisualApplianceTypeEnum.TELEPHONE:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.TELEPHONE;
					case IfcAudioVisualApplianceTypeEnum.TUNER:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.TUNER;
					case IfcAudioVisualApplianceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.USERDEFINED;
					case IfcAudioVisualApplianceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.AMPLIFIER:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.AMPLIFIER;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.CAMERA:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.CAMERA;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.DISPLAY:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.DISPLAY;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.MICROPHONE:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.MICROPHONE;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.PLAYER:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.PLAYER;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.PROJECTOR:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.PROJECTOR;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.RECEIVER:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.RECEIVER;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.SPEAKER:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.SPEAKER;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.SWITCHER:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.SWITCHER;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.TELEPHONE:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.TELEPHONE;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.TUNER:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.TUNER;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.USERDEFINED:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcAudioVisualApplianceTypeEnum.NOTDEFINED:
						PredefinedType = IfcAudioVisualApplianceTypeEnum.NOTDEFINED;
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