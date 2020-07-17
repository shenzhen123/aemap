using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;

namespace AeMapz
{
    public sealed class ZoomToLayer : BaseCommand
    {
        private IMapControl3 m_mapControl;
        public ZoomToLayer()
        {
            base.m_caption = "Zoom To Layer";
        }

        public override void OnClick()
        {
            ILayer layer = (ILayer)m_mapControl.CustomProperty;
            m_mapControl.Extent = layer.AreaOfInterest;
            //base.OnClick();
        }

        public override void OnCreate(object hook)
        {
            m_mapControl = (IMapControl3)hook;
            //throw new NotImplementedException();
        }
    }
}
