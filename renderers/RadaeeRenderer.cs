
using YourNamespace;
using YourNamespace.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using PCLStorage;
using System;
using Com.Radaee.Pdf;
using Com.Radaee.Reader;

[assembly:ExportRenderer(typeof(PdfViewer), typeof(RadaeeRenderer))]

namespace YourNamespace
{
	public class RadaeeRenderer : ViewRenderer<PdfViewer, ReaderController>
	{
	
		ReaderController m_vPDF = null;
		Com.Radaee.Pdf.Document doc = new Com.Radaee.Pdf.Document();

		protected override void OnElementChanged (ElementChangedEventArgs<PdfViewer> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement != null || this.Element == null)
				return;

			Global.Init((Android.App.Activity)Context);

			Global.ActiveStandard ((Android.App.Activity)Context, "Company", "Email","key");

			m_vPDF = new ReaderController(Context);
			doc.Close ();

			// PCLstorage to get app files folder
			// you can use you own implementation here to get filepath
			var rootFolder = FileSystem.Current.LocalStorage.Path;
			var path = System.IO.Path.Combine (rootFolder, "filename");

			int ret = doc.Open( path, null);

			switch (ret)
			{
				case -1://need input password
					break;
				case -2://unknown encryption
					break;
				case -3://damaged or invalid format
					break;
				case -10://access denied or invalid file path
					break;
				case 0://succeeded, and continue
					break;
				default://unknown error
					break;
			}

			m_vPDF.Open(doc);

			if (Control == null)
			    SetNativeControl (m_vPDF);
		}

		protected override void Dispose(bool disposing)
		{
			if (m_vPDF != null)
			{
				m_vPDF.Close ();
				m_vPDF = null;
			}
				
			if (doc != null) {
				doc.Close ();
				doc = null;
			}

			Global.RemoveTmp ();

			try
			{
				base.Dispose(disposing);
			}
			catch(Exception ex)
			{
				return;
			}
		}
	}
}

