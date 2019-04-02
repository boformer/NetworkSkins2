﻿using ColossalFramework.UI;
using UnityEngine;

namespace NetworkSkins.GUI
{
    public abstract class ListPanelBase<TListBase, VPrefabInfo> : ListPanelBase
        where TListBase : ListBase<VPrefabInfo> 
        where VPrefabInfo : PrefabInfo
    {
        protected TListBase list;

        protected override void CreateList() {
            list = AddUIComponent<TListBase>();
            list.Build(new Layout(new Vector2(390.0f, 0.0f), true, LayoutDirection.Vertical, LayoutStart.TopLeft, 0));
        }
    }
}
