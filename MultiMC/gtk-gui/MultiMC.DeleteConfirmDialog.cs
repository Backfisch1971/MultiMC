
// This file has been generated by the GUI designer. Do not modify.
namespace MultiMC
{
	public partial class DeleteConfirmDialog
	{
		private global::Gtk.Alignment contentAlignment;
		private global::Gtk.VBox vboxContent;
		private global::Gtk.TextView textviewMessage;
		private global::Gtk.Entry entryConfirm;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MultiMC.DeleteConfirmDialog
			this.WidthRequest = 400;
			this.HeightRequest = 200;
			this.Name = "MultiMC.DeleteConfirmDialog";
			this.Title = "Really delete this instance?";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			// Internal child MultiMC.DeleteConfirmDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.contentAlignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.contentAlignment.Name = "contentAlignment";
			this.contentAlignment.BorderWidth = ((uint)(10));
			// Container child contentAlignment.Gtk.Container+ContainerChild
			this.vboxContent = new global::Gtk.VBox ();
			this.vboxContent.Name = "vboxContent";
			this.vboxContent.Spacing = 6;
			// Container child vboxContent.Gtk.Box+BoxChild
			this.textviewMessage = new global::Gtk.TextView ();
			this.textviewMessage.Buffer.Text = @"Are you sure you want to delete this instance? If you delete an instance, all of its mods, saves, texture packs, and anything else in its folder will be lost <b>forever</b>.
If you really want to do this, type DELETE in all caps in the text box below, then click OK.";
			this.textviewMessage.Sensitive = false;
			this.textviewMessage.CanFocus = true;
			this.textviewMessage.Name = "textviewMessage";
			this.textviewMessage.Editable = false;
			this.textviewMessage.CursorVisible = false;
			this.textviewMessage.WrapMode = ((global::Gtk.WrapMode)(2));
			this.vboxContent.Add (this.textviewMessage);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxContent [this.textviewMessage]));
			w2.Position = 0;
			// Container child vboxContent.Gtk.Box+BoxChild
			this.entryConfirm = new global::Gtk.Entry ();
			this.entryConfirm.CanFocus = true;
			this.entryConfirm.Name = "entryConfirm";
			this.entryConfirm.IsEditable = true;
			this.entryConfirm.InvisibleChar = '●';
			this.vboxContent.Add (this.entryConfirm);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vboxContent [this.entryConfirm]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.contentAlignment.Add (this.vboxContent);
			w1.Add (this.contentAlignment);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(w1 [this.contentAlignment]));
			w5.Position = 0;
			// Internal child MultiMC.DeleteConfirmDialog.ActionArea
			global::Gtk.HButtonBox w6 = this.ActionArea;
			w6.Name = "dialog1_ActionArea";
			w6.Spacing = 10;
			w6.BorderWidth = ((uint)(5));
			w6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w6 [this.buttonCancel]));
			w7.Expand = false;
			w7.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w6 [this.buttonOk]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 432;
			this.DefaultHeight = 205;
			this.Show ();
		}
	}
}
