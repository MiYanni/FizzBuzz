using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FizzBuzz
{
    class InitializeControlProblem
    {
        /// <summary>
        /// Method initializes the control by reading the database to get the textual information
        /// necessary for the control.
        /// </summary>
        //public void InitializeControl()
        //{
        //    DataTable acrFlags = Lookup.GetDataTableLookup(__ACRControlFlag.SPReadAcrControlFlag);
        //    for (int index = 0; index < acrFlags.Rows.Count; index++)
        //    {
        //        DataRow rowCurrent = acrFlags.Rows[index];
        //        if (index == 0)
        //        {
        //            _Label1.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox1.Tag = ACR.ConvertFromDatabaseInt16(
        //                Convert.ToInt16(rowCurrent[__ACRControlFlag.ColumnAcrControlFlag]));
        //        }
        //        if (index == 1)
        //        {
        //            _Label2.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox2.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 2)
        //        {
        //            _Label3.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox3.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 3)
        //        {
        //            _Label4.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox4.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 4)
        //        {
        //            _Label5.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox5.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 5)
        //        {
        //            _Label6.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox6.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 6)
        //        {
        //            _Label7.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox7.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 7)
        //        {
        //            _Label8.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox8.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 8)
        //        {
        //            _Label9.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox9.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 9)
        //        {
        //            _Label10.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox10.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 10)
        //        {
        //            _Label11.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox11.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 11)
        //        {
        //            _Label12.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox12.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 12)
        //        {
        //            _Label13.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox13.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 13)
        //        {
        //            _Label14.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox14.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 14)
        //        {
        //            _Label15.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox15.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //        if (index == 15)
        //        {
        //            _Label16.Text = rowCurrent[__ACRControlFlag.ColumnName].ToString();
        //            _CheckBox16.Tag = rowCurrent[__ACRControlFlag.ColumnAcrControlFlag];
        //        }
        //    }
        //}

        //// Iteration 1
        //public void InitializeControl()
        //{
        //    var acrFlags = Lookup.GetDataTableLookup(__ACRControlFlag.SPReadAcrControlFlag);
        //    var controls = new[]
        //    {
        //        new { Label = _Label1, CheckBox = _CheckBox1 },
        //        new { Label = _Label2, CheckBox = _CheckBox2 },
        //        new { Label = _Label3, CheckBox = _CheckBox3 },
        //        new { Label = _Label4, CheckBox = _CheckBox4 },
        //        new { Label = _Label5, CheckBox = _CheckBox5 },
        //        new { Label = _Label6, CheckBox = _CheckBox6 },
        //        new { Label = _Label7, CheckBox = _CheckBox7 },
        //        new { Label = _Label8, CheckBox = _CheckBox8 },
        //        new { Label = _Label9, CheckBox = _CheckBox9 },
        //        new { Label = _Label10, CheckBox = _CheckBox10 },
        //        new { Label = _Label11, CheckBox = _CheckBox11 },
        //        new { Label = _Label12, CheckBox = _CheckBox12 },
        //        new { Label = _Label13, CheckBox = _CheckBox13 },
        //        new { Label = _Label14, CheckBox = _CheckBox14 },
        //        new { Label = _Label15, CheckBox = _CheckBox15 },
        //        new { Label = _Label16, CheckBox = _CheckBox16 }
        //    };

        //    for(var i = 0; i < acrFlags.Rows.Count; ++i)
        //    {
        //        var acr = acrFlags.Rows[i];
        //        var control = controls[i];
        //        control.Label.Text = acr[__ACRControlFlag.ColumnName].ToString();
        //        control.CheckBox.Tag = (i == 0)
        //            ? ACR.ConvertFromDatabaseInt16(Convert.ToInt16(acr[__ACRControlFlag.ColumnAcrControlFlag]))
        //            : acr[__ACRControlFlag.ColumnAcrControlFlag];
        //    }
        //}

        //// Iteration 2
        //public void InitializeControl()
        //{
        //    var acrFlags = Lookup.GetDataTableLookup(__ACRControlFlag.SPReadAcrControlFlag);
        //    var labels = Controls.OfType<Label>().OrderBy(l => l.Name).ToArray();
        //    var checkBoxes = Controls.OfType<CheckBox>().OrderBy(cb => cb.Name).ToArray();

        //    for (var i = 0; i < acrFlags.Rows.Count; ++i)
        //    {
        //        var acr = acrFlags.Rows[i];
        //        labels[i].Text = acr[__ACRControlFlag.ColumnName].ToString();
        //        checkBoxes[i].Tag = (i == 0)
        //            ? ACR.ConvertFromDatabaseInt16(Convert.ToInt16(acr[__ACRControlFlag.ColumnAcrControlFlag]))
        //            : acr[__ACRControlFlag.ColumnAcrControlFlag];
        //    }
        //}

        //// Iteration 3 - Note: This is worse than Iteration 2.
        //public void InitializeControl()
        //{
        //    var acrFlags = Lookup.GetDataTableLookup(__ACRControlFlag.SPReadAcrControlFlag);
        //    // Note: Cast just does boxing, so the types Label and CheckBox are preserved.
        //    var controls = Controls.Cast<Control>().Where(c => c is CheckBox || c is Label).OrderBy(l => l.Name)
        //        .GroupBy(c => c.GetType()).OrderBy(g => g.Key.Name)
        //        .Select(g => g.ToArray()).ToArray();

        //    for (var i = 0; i < acrFlags.Rows.Count; ++i)
        //    {
        //        var acr = acrFlags.Rows[i];
        //        controls[1][i].Text = acr[__ACRControlFlag.ColumnName].ToString();
        //        controls[0][i].Tag = (i == 0)
        //            ? ACR.ConvertFromDatabaseInt16(Convert.ToInt16(acr[__ACRControlFlag.ColumnAcrControlFlag]))
        //            : acr[__ACRControlFlag.ColumnAcrControlFlag];
        //    }
        //}

        //// Iteration 4
        //private object ConvertIfNeeded(object data, int index)
        //{
        //    return (index == 0) ? ACR.ConvertFromDatabaseInt16(Convert.ToInt16(data)) : data;
        //}

        //public void InitializeControl()
        //{
        //    var textTagIndices =  Lookup.GetDataTableLookup(__ACRControlFlag.SPReadAcrControlFlag).Rows.Cast<DataRow>().Select((dr, i) => new 
        //        { 
        //            Text = dr[__ACRControlFlag.ColumnName].ToString(),
        //            Tag = ConvertIfNeeded(dr[__ACRControlFlag.ColumnAcrControlFlag], i),
        //            Index = i
        //        }).ToArray();
        //    var labels = Controls.OfType<Label>().OrderBy(l => l.Name).ToArray();
        //    var checkBoxes = Controls.OfType<CheckBox>().OrderBy(cb => cb.Name).ToArray();

        //    foreach (var textTagIndex in textTagIndices)
        //    {
        //        labels[textTagIndex.Index].Text = textTagIndex.Text;
        //        checkBoxes[textTagIndex.Index].Tag = textTagIndex.Tag;
        //    }
        //}

        //// Iteration 5
        //private static object ConvertIfNeeded(object data, int index)
        //{
        //    return (index == 0) ? ACR.ConvertFromDatabaseInt16(Convert.ToInt16(data)) : data;
        //}

        //private class ControlIndex
        //{
        //    public Control Control { get; set; }
        //    public int Index { get; set; }
        //}

        //private static ControlIndex[] ConvertToControlIndex<TCtrl>(IEnumerable controls) where TCtrl : Control
        //{
        //    return controls.OfType<TCtrl>().OrderBy(c => c.Name).Select((c, i) => new ControlIndex { Control = c, Index = i }).ToArray();
        //}

        //public void InitializeControl()
        //{
        //    var textTagIndices = Lookup.GetDataTableLookup(__ACRControlFlag.SPReadAcrControlFlag).Rows.Cast<DataRow>().Select((dr, i) => new
        //    {
        //        Text = dr[__ACRControlFlag.ColumnName].ToString(),
        //        Tag = ConvertIfNeeded(dr[__ACRControlFlag.ColumnAcrControlFlag], i),
        //        Index = i
        //    }).ToArray();
        //    var labels = ConvertToControlIndex<Label>(Controls);
        //    var checkBoxes = ConvertToControlIndex<CheckBox>(Controls);

        //    foreach (var textTagIndex in textTagIndices)
        //    {
        //        labels[textTagIndex.Index].Control.Text = textTagIndex.Text;
        //        checkBoxes[textTagIndex.Index].Control.Tag = textTagIndex.Tag;
        //    }
        //}

        //// Iteration 6
        //private class TextTag
        //{
        //    public string Text { get; set; }
        //    public object Tag { get; set; }
        //}

        //private static TCtrl[] CreateOrderedControlArray<TCtrl>(IEnumerable controls) where TCtrl : Control
        //{
        //    return controls.OfType<TCtrl>().OrderBy(c => c.Name).ToArray();
        //}

        //private static object ConvertDataIfNeeded(object data, int index)
        //{
        //    return (index == 0) ? ACR.ConvertFromDatabaseInt16(Convert.ToInt16(data)) : data;
        //}

        //private static TextTag[] GetAcrFlagTextTags()
        //{
        //    return Lookup.GetDataTableLookup(__ACRControlFlag.SPReadAcrControlFlag).Rows.Cast<DataRow>().Select((dr, i) => new TextTag
        //    {
        //        Text = dr[__ACRControlFlag.ColumnName].ToString(),
        //        Tag = ConvertDataIfNeeded(dr[__ACRControlFlag.ColumnAcrControlFlag], i)
        //    }).ToArray();
        //}

        //public void InitializeControl()
        //{
        //    var acrFlags = GetAcrFlagTextTags();
        //    var labels = CreateOrderedControlArray<Label>(Controls);
        //    var checkBoxes = CreateOrderedControlArray<CheckBox>(Controls);

        //    for (var i = 0; i < acrFlags.Count(); ++i)
        //    {
        //        labels[i].Text = acrFlags[i].Text;
        //        checkBoxes[i].Tag = acrFlags[i].Tag;
        //    }
        //}
    }
}
