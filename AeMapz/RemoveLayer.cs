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
    /// <summary>
    /// 删除图层
    /// </summary>
    public sealed class RemoveLayer : BaseCommand
    {
        private IMapControl3 m_mapControl;
        public RemoveLayer()
        {
            base.m_caption = "Remove Laye";
        }

        public override void OnClick()
        {
            ILayer layer = (ILayer)m_mapControl.CustomProperty;
            m_mapControl.Map.DeleteLayer(layer);
            //base.OnClick();
        }

        public override void OnCreate(object hook)
        {
            m_mapControl = (IMapControl3)hook;
            //throw new NotImplementedException();
        }
    }
}
