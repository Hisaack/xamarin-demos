#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleBrowser.SfDiagram
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNote : ContentPage
    {
        MindMap MindMap;
        public AddNote(MindMap mindMap)
        {
            InitializeComponent();
            MindMap = mindMap;
        }
        private void AddNodeNote(object sender, EventArgs e)
        {
            MindMap.SelectedNode.Content = note.Text;
            Navigation.PopAsync();
        }
        private void CancelNote(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        protected override void OnAppearing()
        {
            note.Focus();
            if (MindMap.SelectedNode.Content != null)
            {
                note.Text = MindMap.SelectedNode.Content.ToString();
            }
            base.OnAppearing();
        }
    }
}