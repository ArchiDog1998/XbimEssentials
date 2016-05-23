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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcSurfaceStyleRendering : IIfcSurfaceStyleRendering
	{
		IIfcColourOrFactor IIfcSurfaceStyleRendering.DiffuseColour 
		{ 
			get
			{
				if (DiffuseColour == null) return null;
				var ifccolourrgb = DiffuseColour as PresentationResource.IfcColourRgb;
				if (ifccolourrgb != null) 
					return ifccolourrgb;
				if (DiffuseColour is MeasureResource.IfcNormalisedRatioMeasure) 
					return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((MeasureResource.IfcNormalisedRatioMeasure)DiffuseColour);
				return null;
			} 
			set
			{
				if (value == null)
				{
					DiffuseColour = null;
					return;
				}	
				var ifccolourrgb = value as PresentationResource.IfcColourRgb;
				if (ifccolourrgb != null) 
				{
					DiffuseColour = ifccolourrgb;
					return;
				}
				if (value is Ifc4.MeasureResource.IfcNormalisedRatioMeasure) 
				{
					DiffuseColour = new MeasureResource.IfcNormalisedRatioMeasure((Ifc4.MeasureResource.IfcNormalisedRatioMeasure)value);
					return;
				}
				
			}
		}
		IIfcColourOrFactor IIfcSurfaceStyleRendering.TransmissionColour 
		{ 
			get
			{
				if (TransmissionColour == null) return null;
				var ifccolourrgb = TransmissionColour as PresentationResource.IfcColourRgb;
				if (ifccolourrgb != null) 
					return ifccolourrgb;
				if (TransmissionColour is MeasureResource.IfcNormalisedRatioMeasure) 
					return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((MeasureResource.IfcNormalisedRatioMeasure)TransmissionColour);
				return null;
			} 
			set
			{
				if (value == null)
				{
					TransmissionColour = null;
					return;
				}	
				var ifccolourrgb = value as PresentationResource.IfcColourRgb;
				if (ifccolourrgb != null) 
				{
					TransmissionColour = ifccolourrgb;
					return;
				}
				if (value is Ifc4.MeasureResource.IfcNormalisedRatioMeasure) 
				{
					TransmissionColour = new MeasureResource.IfcNormalisedRatioMeasure((Ifc4.MeasureResource.IfcNormalisedRatioMeasure)value);
					return;
				}
				
			}
		}
		IIfcColourOrFactor IIfcSurfaceStyleRendering.DiffuseTransmissionColour 
		{ 
			get
			{
				if (DiffuseTransmissionColour == null) return null;
				var ifccolourrgb = DiffuseTransmissionColour as PresentationResource.IfcColourRgb;
				if (ifccolourrgb != null) 
					return ifccolourrgb;
				if (DiffuseTransmissionColour is MeasureResource.IfcNormalisedRatioMeasure) 
					return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((MeasureResource.IfcNormalisedRatioMeasure)DiffuseTransmissionColour);
				return null;
			} 
			set
			{
				if (value == null)
				{
					DiffuseTransmissionColour = null;
					return;
				}	
				var ifccolourrgb = value as PresentationResource.IfcColourRgb;
				if (ifccolourrgb != null) 
				{
					DiffuseTransmissionColour = ifccolourrgb;
					return;
				}
				if (value is Ifc4.MeasureResource.IfcNormalisedRatioMeasure) 
				{
					DiffuseTransmissionColour = new MeasureResource.IfcNormalisedRatioMeasure((Ifc4.MeasureResource.IfcNormalisedRatioMeasure)value);
					return;
				}
				
			}
		}
		IIfcColourOrFactor IIfcSurfaceStyleRendering.ReflectionColour 
		{ 
			get
			{
				if (ReflectionColour == null) return null;
				var ifccolourrgb = ReflectionColour as PresentationResource.IfcColourRgb;
				if (ifccolourrgb != null) 
					return ifccolourrgb;
				if (ReflectionColour is MeasureResource.IfcNormalisedRatioMeasure) 
					return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((MeasureResource.IfcNormalisedRatioMeasure)ReflectionColour);
				return null;
			} 
			set
			{
				if (value == null)
				{
					ReflectionColour = null;
					return;
				}	
				var ifccolourrgb = value as PresentationResource.IfcColourRgb;
				if (ifccolourrgb != null) 
				{
					ReflectionColour = ifccolourrgb;
					return;
				}
				if (value is Ifc4.MeasureResource.IfcNormalisedRatioMeasure) 
				{
					ReflectionColour = new MeasureResource.IfcNormalisedRatioMeasure((Ifc4.MeasureResource.IfcNormalisedRatioMeasure)value);
					return;
				}
				
			}
		}
		IIfcColourOrFactor IIfcSurfaceStyleRendering.SpecularColour 
		{ 
			get
			{
				if (SpecularColour == null) return null;
				var ifccolourrgb = SpecularColour as PresentationResource.IfcColourRgb;
				if (ifccolourrgb != null) 
					return ifccolourrgb;
				if (SpecularColour is MeasureResource.IfcNormalisedRatioMeasure) 
					return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((MeasureResource.IfcNormalisedRatioMeasure)SpecularColour);
				return null;
			} 
			set
			{
				if (value == null)
				{
					SpecularColour = null;
					return;
				}	
				var ifccolourrgb = value as PresentationResource.IfcColourRgb;
				if (ifccolourrgb != null) 
				{
					SpecularColour = ifccolourrgb;
					return;
				}
				if (value is Ifc4.MeasureResource.IfcNormalisedRatioMeasure) 
				{
					SpecularColour = new MeasureResource.IfcNormalisedRatioMeasure((Ifc4.MeasureResource.IfcNormalisedRatioMeasure)value);
					return;
				}
				
			}
		}
		IIfcSpecularHighlightSelect IIfcSurfaceStyleRendering.SpecularHighlight 
		{ 
			get
			{
				if (SpecularHighlight == null) return null;
				if (SpecularHighlight is IfcSpecularExponent) 
					return new Ifc4.PresentationAppearanceResource.IfcSpecularExponent((IfcSpecularExponent)SpecularHighlight);
				if (SpecularHighlight is IfcSpecularRoughness) 
					return new Ifc4.PresentationAppearanceResource.IfcSpecularRoughness((IfcSpecularRoughness)SpecularHighlight);
				return null;
			} 
			set
			{
				if (value == null)
				{
					SpecularHighlight = null;
					return;
				}	
				if (value is Ifc4.PresentationAppearanceResource.IfcSpecularExponent) 
				{
					SpecularHighlight = new IfcSpecularExponent((Ifc4.PresentationAppearanceResource.IfcSpecularExponent)value);
					return;
				}
				if (value is Ifc4.PresentationAppearanceResource.IfcSpecularRoughness) 
				{
					SpecularHighlight = new IfcSpecularRoughness((Ifc4.PresentationAppearanceResource.IfcSpecularRoughness)value);
					return;
				}
				
			}
		}
		Ifc4.Interfaces.IfcReflectanceMethodEnum IIfcSurfaceStyleRendering.ReflectanceMethod 
		{ 
			get
			{
				switch (ReflectanceMethod)
				{
					case IfcReflectanceMethodEnum.BLINN:
						return Ifc4.Interfaces.IfcReflectanceMethodEnum.BLINN;
					
					case IfcReflectanceMethodEnum.FLAT:
						return Ifc4.Interfaces.IfcReflectanceMethodEnum.FLAT;
					
					case IfcReflectanceMethodEnum.GLASS:
						return Ifc4.Interfaces.IfcReflectanceMethodEnum.GLASS;
					
					case IfcReflectanceMethodEnum.MATT:
						return Ifc4.Interfaces.IfcReflectanceMethodEnum.MATT;
					
					case IfcReflectanceMethodEnum.METAL:
						return Ifc4.Interfaces.IfcReflectanceMethodEnum.METAL;
					
					case IfcReflectanceMethodEnum.MIRROR:
						return Ifc4.Interfaces.IfcReflectanceMethodEnum.MIRROR;
					
					case IfcReflectanceMethodEnum.PHONG:
						return Ifc4.Interfaces.IfcReflectanceMethodEnum.PHONG;
					
					case IfcReflectanceMethodEnum.PLASTIC:
						return Ifc4.Interfaces.IfcReflectanceMethodEnum.PLASTIC;
					
					case IfcReflectanceMethodEnum.STRAUSS:
						return Ifc4.Interfaces.IfcReflectanceMethodEnum.STRAUSS;
					
					case IfcReflectanceMethodEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcReflectanceMethodEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
	//## Custom code
	//##
	}
}