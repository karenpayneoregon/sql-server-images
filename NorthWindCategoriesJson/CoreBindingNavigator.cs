﻿
namespace NorthWindCategoriesJson;


public sealed class CoreBindingNavigator : BindingNavigator
{
    public CoreBindingNavigator()
    {
        AddStandardItems();
        AddNewItem.Visible = false;
        DeleteItem.Visible = false;
    }
}