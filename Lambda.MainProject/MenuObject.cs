using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.MainProject
{
    public class MenuObject
    {
        #region GetItems
        public List<Item> GetItems(bool isNullCreateNew = true)
        {
            var result = new List<Item>();
            for (int i = 0; i < Pages.Count; i++)
            {
                var pageItem = GetItem(Pages[i], null, isNullCreateNew);
                if (pageItem != null)
                {
                    result.Add(pageItem);
                }
                for (int j = 0; j < Pages[i].Groups.Count; j++)
                {
                    var groupItem = GetItem(Pages[i].Groups[j], pageItem, isNullCreateNew);
                    if (groupItem != null)
                    {
                        result.Add(groupItem);
                    }
                    for (int k = 0; k < Pages[i].Groups[j].ItemLinks.Count; k++)
                    {
                        var barItem = Pages[i].Groups[j].ItemLinks[k].Item;// as BarSubItem;
                        var item = GetItem(barItem, groupItem, isNullCreateNew);
                        if (item != null)
                        {
                            result.Add(item);
                        }
                        if (barItem is BarSubItem)
                        {
                            var barSubItem = barItem as BarSubItem;
                            for (int l = 0; l < barSubItem.ItemLinks.Count; l++)
                            {
                                var subItem = GetItem(barSubItem.ItemLinks[l].Item, item, isNullCreateNew);
                                if (subItem != null)
                                {
                                    result.Add(subItem);
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        private Item GetItem(BarItem obj, Item ItemCha, bool isNullCreateNew)
        {
            var item = obj.Tag as Item;
            if (item == null && isNullCreateNew == true)
            {
                Guid? ItemChaId = null;
                if (ItemCha != null)
                {
                    ItemChaId = ItemCha.ItemId;
                }
                item = new Item { ItemChaId = ItemChaId, Text = obj.Caption, ObjectTypeName = obj.GetType().FullName,ImageWin = obj.Glyph,LargeImageWin = obj.LargeGlyph };
                obj.Tag = item;
            }
            return item;
        }
        private Item GetItem(RibbonPageGroup obj, Item ItemCha, bool isNullCreateNew)
        {
            var item = obj.Tag as Item;
            if (item == null && isNullCreateNew == true)
            {
                Guid? ItemChaId = null;
                if (ItemCha != null)
                {
                    ItemChaId = ItemCha.ItemId;
                }
                item = new Item { ItemChaId = ItemChaId, Text = obj.Text, ObjectTypeName = obj.GetType().FullName };
                obj.Tag = item;
            }
            return item;
        }
        private Item GetItem(RibbonPage obj, Item ItemCha, bool isNullCreateNew)
        {
            var item = obj.Tag as Item;
            if (item == null && isNullCreateNew == true)
            {
                Guid? ItemChaId = null;
                if (ItemCha != null)
                {
                    ItemChaId = ItemCha.ItemId;
                }
                item = new Item { ItemChaId = ItemChaId, Text = obj.Text, ObjectTypeName = obj.GetType().FullName,ImageWin = obj.Image };
                obj.Tag = item;
            }
            return item;
        }
        #endregion

        public virtual event RibbonPageGroupEventHandler CaptionButtonClick;
        public event ItemClickEventHandler ItemClick;
        string ItemContainerName = "DevExpress.XtraBars.BarSubItem";
        
        RibbonPageCollection Pages;

        public void SetPages(RibbonPageCollection Pages)
        {
            this.Pages = Pages;
        }
        public void SetRibbonEvent()
        {
            for (int i = 0; i < Pages.Count; i++)
            {
                for (int j = 0; j < Pages[i].Groups.Count; j++)
                {
                    Pages[i].Groups[j].CaptionButtonClick -= CaptionButtonClick;
                    Pages[i].Groups[j].CaptionButtonClick += CaptionButtonClick;
                    var groups = Pages[i].Groups;
                    for (int k = 0; k < groups[j].ItemLinks.Count; k++)
                    {
                        var barItem = groups[j].ItemLinks[k].Item;
                        if (!(barItem is BarSubItem))
                        {
                            barItem.ItemClick -= ItemClick;
                            barItem.ItemClick += ItemClick;
                        }
                        else
                        {
                            var barSubItem = barItem as BarSubItem;
                            for (int l = 0; l < barSubItem.ItemLinks.Count; l++)
                            {
                                barSubItem.ItemLinks[l].Item.ItemClick -= ItemClick;
                                barSubItem.ItemLinks[l].Item.ItemClick += ItemClick;
                            }
                        }
                    }
                }
            }
        }

        void Add(ref List<Item> sortItems, ref List<Item> tmpItems)
        {
            int count = sortItems.Count;
            if (tmpItems.Count == 0)
                return;
            for (int j = 0; j < sortItems.Count; j++)
            {
                for (int i = tmpItems.Count - 1; i >= 0; i--)
                {
                    if (tmpItems[i].ItemChaId == sortItems[j].ItemId)
                    {
                        sortItems.Add(tmpItems[i]);
                        tmpItems.Remove(tmpItems[i]);
                        if (tmpItems.Count == 0)
                            return;
                    }
                }
            }
            if (sortItems.Count == count)
                return;
            Add(ref sortItems, ref tmpItems);
        }
        List<Item> SortItems(List<Item> items)
        {
            var sortItems = new List<Item>();
            var tmpItems = new List<Item>(items);
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemChaId == null)
                {
                    sortItems.Add(items[i]);
                    tmpItems.Remove(items[i]);
                }
            }
            tmpItems.Reverse();
            Add(ref sortItems, ref tmpItems);
            return sortItems;
        }
        public void AddItem(List<Item> items)
        {
            var newList = new List<Item>(items);
            newList.Sort(new Comparison<Item>(ThutuSort));
            var sortItems = SortItems(newList);
            for (int i = 0; i < sortItems.Count; i++)
            {
                AddItem(sortItems[i]);
            }
        }

        private int ThutuSort(Item x, Item y)
        {
            return string.Compare(x.Thutu, y.Thutu);
        }
        public void AddItem(Item item)
        {
            if (item.TypeName == "Page")
            {
                AddRibbonPage(item);
                return;
            }
            if (item.TypeName == "Group")
            {
                AddRibbonPageGroup(item);
                return;
            }
            if (item.TypeName == "Item")
            {
                AddButtonItem(item);
                return;
            }
            if (item.TypeName == "SubItem")
            {
                AddSubButtonItem(item);
                return;
            }
        }

        private bool AddSubButtonItem(Item item)
        {
            for (int i = 0; i < Pages.Count; i++)
            {
                for (int j = 0; j < Pages[i].Groups.Count; j++)
                {
                    for (int k = 0; k < Pages[i].Groups[j].ItemLinks.Count; k++)
                    {
                        var tmpItem = Pages[i].Groups[j].ItemLinks[k].Item.Tag as Item;
                        if (tmpItem != null && tmpItem.ItemId == item.ItemChaId && tmpItem.ObjectTypeName == ItemContainerName)
                        {
                            var barSubItem = Pages[i].Groups[j].ItemLinks[k].Item as BarSubItem;
                            for (int l = 0; l < barSubItem.ItemLinks.Count; l++)
                            {
                                var tmp = barSubItem.ItemLinks[l].Item.Tag as Item;
                                if (tmp.ItemId == item.ItemId)
                                {
                                    Set(barSubItem.ItemLinks[l].Item, item);
                                    return false;
                                }
                            }
                            var barItem = CreateObjectItem(item.ObjectTypeName);
                            Set(barItem, item);
                            barSubItem.ItemLinks.Add(barItem);
                            return true;
                        }
                    }

                }

            }
            return false;
        }
        private bool AddButtonItem(Item item)
        {
            for (int i = 0; i < Pages.Count; i++)
            {
                for (int j = 0; j < Pages[i].Groups.Count; j++)
                {
                    var tmpGroup = Pages[i].Groups[j].Tag as Item;
                    if (tmpGroup != null && tmpGroup.ItemId == item.ItemChaId)
                    {
                        for (int k = 0; k < Pages[i].Groups[j].ItemLinks.Count; k++)
                        {
                            var tmp = Pages[i].Groups[j].ItemLinks[k].Item.Tag as Item;
                            if (tmp != null && tmp.ItemId == item.ItemId)
                            {
                                Set(Pages[i].Groups[j].ItemLinks[k].Item, item);
                                return false;
                            }
                        }
                        var barItem = CreateObjectItem(item.ObjectTypeName);
                        Set(barItem, item);
                        Pages[i].Groups[j].ItemLinks.Add(barItem);
                        return true;
                    }
                }
            }
            return false;
        }
        private BarItem CreateObjectItem(string ObjectTypeName)
        {
            Type type = DynamicLoad.DynaInvoke.GetType(ObjectTypeName);
            var obj = Activator.CreateInstance(type) as BarItem;
            return obj;
        }
        
        private void Set(BarItem barItem, Item item)
        {
            barItem.Name = item.Name;
            barItem.Caption = item.Text;
            barItem.LargeWidth = barItem.Width = item.Width.Value;
            var bt = barItem as DevExpress.XtraBars.BarButtonItem;
            //bt.BeginGroup = true;

            if (item.ShowImage == true)
            {
                if (item.IsLarge == true)
                {
                    barItem.LargeGlyph = item.LargeImageWin;
                    barItem.Glyph = null;
                    if (barItem.LargeGlyph == null)
                        barItem.LargeGlyph = item.ImageWin;
                }
                else
                {
                    barItem.LargeGlyph = null;
                    barItem.Glyph = item.ImageWin;
                    if (barItem.Glyph == null)
                    {
                        barItem.Glyph = item.LargeImageWin;
                    }
                }
            }
            else
            {
                barItem.LargeGlyph = null;
                barItem.Glyph = null;
            }
            barItem.Tag = item;
        }
        private bool AddRibbonPageGroup(Item item)
        {
            for (int i = 0; i < Pages.Count; i++)
            {
                var tmpPage = Pages[i].Tag as Item;
                if (tmpPage != null && tmpPage.ItemId == item.ItemChaId)
                {
                    for (int j = 0; j < Pages[i].Groups.Count; j++)
                    {
                        var tmp = Pages[i].Groups[j].Tag as Item;
                        if (tmp.ItemId == item.ItemId)
                        {
                            Set(Pages[i].Groups[j], item);
                            return false;
                        }
                    }
                    var group = new RibbonPageGroup();
                    Set(group, item);
                    Pages[i].Groups.Add(group);
                    return true;
                }
            }
            return false;
        }
        private void Set(RibbonPageGroup group, Item item)
        {
            group.Name = item.Name;
            group.Text = item.Text;
            if (item.ShowImage == true)
            {
                if (item.IsLarge == true)
                {
                    group.Glyph = ImageConvert.ConvertToImage(item.LargeImage);
                    if (group.Glyph == null)
                        group.Glyph = ImageConvert.ConvertToImage(item.Image);
                }
                else
                {
                    group.Glyph = ImageConvert.ConvertToImage(item.Image);
                    if (group.Glyph == null)
                        group.Glyph = ImageConvert.ConvertToImage(item.LargeImage);
                }
            }
            else
            {
                group.Glyph = null;
            }
            group.Tag = item;
        }
        private bool AddRibbonPage(Item item)
        {
            for (int i = 0; i < Pages.Count; i++)
            {
                var tmp = Pages[i].Tag as Item;
                if (tmp != null && tmp.ItemId == item.ItemId)
                {
                    Set(Pages[i], item);
                    return false;
                }
            }
            var page = new RibbonPage();
            Set(page, item);
            Pages.Add(page);
            return true;
        }
        private void Set(RibbonPage page, Item item)
        {
            page.Name = item.Name;
            page.Text = item.Text;
            if (item.ShowImage == true)
            {
                if (item.IsLarge == true)
                {
                    page.Image = ImageConvert.ConvertToImage(item.LargeImage);
                    if (page.Image == null)
                        page.Image = ImageConvert.ConvertToImage(item.Image);
                }
                else
                {
                    page.Image = ImageConvert.ConvertToImage(item.Image);
                    if (page.Image == null)
                        page.Image = ImageConvert.ConvertToImage(item.LargeImage);
                }
            }
            else
            {
                page.Image = null;
            }
            page.Tag = item;
        }
    }
}
