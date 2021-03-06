// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ocmgtk {
    
    
    public partial class CorrectedCoordinatesDlg {
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment GtkAlignment3;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label1;
        
        private Gtk.Label origLabel;
        
        private Gtk.Label GtkLabel4;
        
        private Gtk.Frame frame3;
        
        private Gtk.Alignment GtkAlignment4;
        
        private ocmgtk.LocationWidget coordEntry;
        
        private Gtk.Label GtkLabel5;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button resetButton;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.CorrectedCoordinatesDlg
            this.Name = "ocmgtk.CorrectedCoordinatesDlg";
            this.Title = Mono.Unix.Catalog.GetString("Corrected Coordinates");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.BorderWidth = ((uint)(6));
            this.Resizable = false;
            this.AllowGrow = false;
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Internal child ocmgtk.CorrectedCoordinatesDlg.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame1.Gtk.Container+ContainerChild
            this.GtkAlignment3 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment3.Name = "GtkAlignment3";
            this.GtkAlignment3.LeftPadding = ((uint)(12));
            // Container child GtkAlignment3.Gtk.Container+ContainerChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Coodinate:");
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.origLabel = new Gtk.Label();
            this.origLabel.Name = "origLabel";
            this.origLabel.Xalign = 0F;
            this.origLabel.LabelProp = "<unknown>";
            this.hbox1.Add(this.origLabel);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.origLabel]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            this.GtkAlignment3.Add(this.hbox1);
            this.frame1.Add(this.GtkAlignment3);
            this.GtkLabel4 = new Gtk.Label();
            this.GtkLabel4.Name = "GtkLabel4";
            this.GtkLabel4.LabelProp = Mono.Unix.Catalog.GetString("<b>Original Location</b>");
            this.GtkLabel4.UseMarkup = true;
            this.frame1.LabelWidget = this.GtkLabel4;
            w1.Add(this.frame1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(w1[this.frame1]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.frame3 = new Gtk.Frame();
            this.frame3.Name = "frame3";
            this.frame3.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame3.Gtk.Container+ContainerChild
            this.GtkAlignment4 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment4.Name = "GtkAlignment4";
            this.GtkAlignment4.LeftPadding = ((uint)(12));
            // Container child GtkAlignment4.Gtk.Container+ContainerChild
            this.coordEntry = new ocmgtk.LocationWidget();
            this.coordEntry.Events = ((Gdk.EventMask)(256));
            this.coordEntry.Name = "coordEntry";
            this.coordEntry.Latitude = 0;
            this.coordEntry.Longitude = 0;
            this.GtkAlignment4.Add(this.coordEntry);
            this.frame3.Add(this.GtkAlignment4);
            this.GtkLabel5 = new Gtk.Label();
            this.GtkLabel5.Name = "GtkLabel5";
            this.GtkLabel5.LabelProp = Mono.Unix.Catalog.GetString("<b>Corrected Location</b>");
            this.GtkLabel5.UseMarkup = true;
            this.frame3.LabelWidget = this.GtkLabel5;
            w1.Add(this.frame3);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(w1[this.frame3]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            // Internal child ocmgtk.CorrectedCoordinatesDlg.ActionArea
            Gtk.HButtonBox w10 = this.ActionArea;
            w10.Name = "dialog1_ActionArea";
            w10.Spacing = 10;
            w10.BorderWidth = ((uint)(5));
            w10.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonCancel]));
            w11.Expand = false;
            w11.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.resetButton = new Gtk.Button();
            this.resetButton.Sensitive = false;
            this.resetButton.CanFocus = true;
            this.resetButton.Name = "resetButton";
            this.resetButton.UseUnderline = true;
            this.resetButton.Label = Mono.Unix.Catalog.GetString("Reset");
            w10.Add(this.resetButton);
            Gtk.ButtonBox.ButtonBoxChild w12 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.resetButton]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w13 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonOk]));
            w13.Position = 2;
            w13.Expand = false;
            w13.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 433;
            this.DefaultHeight = 231;
            this.Show();
            this.buttonCancel.Clicked += new System.EventHandler(this.OnCancelClick);
            this.resetButton.Clicked += new System.EventHandler(this.OnResetClick);
            this.buttonOk.Clicked += new System.EventHandler(this.OnOKClick);
        }
    }
}
