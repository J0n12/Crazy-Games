
// This file has been generated by the GUI designer. Do not modify.
namespace Stetic
{
	internal class Gui
	{
		private static bool initialized;
		
		internal static void Initialize (Gtk.Widget iconRenderer)
		{
			if ((Stetic.Gui.initialized == false)) {
				Stetic.Gui.initialized = true;
				global::Gtk.IconFactory w1 = new global::Gtk.IconFactory ();
				global::Gtk.IconSet w2 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.page_white_add.png"));
				w1.Add ("page-white-add", w2);
				global::Gtk.IconSet w3 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.folder_add.png"));
				w1.Add ("folder-add", w3);
				global::Gtk.IconSet w4 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.page_white_delete.png"));
				w1.Add ("page-white-delete", w4);
				global::Gtk.IconSet w5 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.page_white_copy.png"));
				w1.Add ("page-white-copy", w5);
				global::Gtk.IconSet w6 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.folder_delete.png"));
				w1.Add ("folder-delete", w6);
				global::Gtk.IconSet w7 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.page_white_zip.png"));
				w1.Add ("page-white-zip", w7);
				global::Gtk.IconSet w8 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.page_white_stack.png"));
				w1.Add ("page-white-stack", w8);
				global::Gtk.IconSet w9 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.package.png"));
				w1.Add ("package", w9);
				global::Gtk.IconSet w10 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.package_add.png"));
				w1.Add ("package-add", w10);
				global::Gtk.IconSet w11 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.package_delete.png"));
				w1.Add ("package-delete", w11);
				global::Gtk.IconSet w12 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.folder.png"));
				w1.Add ("folder", w12);
				global::Gtk.IconSet w13 = new global::Gtk.IconSet (global::Gdk.Pixbuf.LoadFromResource ("DCPPacker.resources.disk.png"));
				w1.Add ("disk", w13);
				w1.AddDefault ();
			}
		}
	}
	
	internal class ActionGroups
	{
		public static Gtk.ActionGroup GetActionGroup (System.Type type)
		{
			return Stetic.ActionGroups.GetActionGroup (type.FullName);
		}
		
		public static Gtk.ActionGroup GetActionGroup (string name)
		{
			return null;
		}
	}
}