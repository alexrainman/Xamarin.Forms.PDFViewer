using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Joanzapata.Pdfview.Util {

	[Register ("com/joanzapata/pdfview/util/Constants$Cache")]
	public abstract class ConstantsCache {

		internal ConstantsCache ()
		{
		}

		static IntPtr CACHE_SIZE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants.Cache']/field[@name='CACHE_SIZE']"
		[Register ("CACHE_SIZE")]
		public static int CacheSize {
			get {
				if (CACHE_SIZE_jfieldId == IntPtr.Zero)
					CACHE_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE_SIZE", "I");
				return JNIEnv.GetStaticIntField (class_ref, CACHE_SIZE_jfieldId);
			}
			set {
				if (CACHE_SIZE_jfieldId == IntPtr.Zero)
					CACHE_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE_SIZE", "I");
				JNIEnv.SetStaticField (class_ref, CACHE_SIZE_jfieldId, value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants.Cache']/field[@name='THUMBNAILS_CACHE_SIZE']"
		[Register ("THUMBNAILS_CACHE_SIZE")]
		public const int ThumbnailsCacheSize = (int) 4;

		static IntPtr class_ref = JNIEnv.FindClass ("com/joanzapata/pdfview/util/Constants$Cache");
	}

	[System.Obsolete ("Use the 'ConstantsCache' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class ConstantsCacheConsts : ConstantsCache {

		private ConstantsCacheConsts ()
		{
		}
	}


	[Register ("com/joanzapata/pdfview/util/Constants$Pinch")]
	public abstract class ConstantsPinch {

		internal ConstantsPinch ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants.Pinch']/field[@name='MAXIMUM_ZOOM']"
		[Register ("MAXIMUM_ZOOM")]
		public const float MaximumZoom = (float) 10.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants.Pinch']/field[@name='MINIMUM_ZOOM']"
		[Register ("MINIMUM_ZOOM")]
		public const float MinimumZoom = (float) 1.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants.Pinch']/field[@name='QUICK_MOVE_THRESHOLD_DISTANCE']"
		[Register ("QUICK_MOVE_THRESHOLD_DISTANCE")]
		public const int QuickMoveThresholdDistance = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants.Pinch']/field[@name='QUICK_MOVE_THRESHOLD_TIME']"
		[Register ("QUICK_MOVE_THRESHOLD_TIME")]
		public const int QuickMoveThresholdTime = (int) 250;
	}

	[System.Obsolete ("Use the 'ConstantsPinch' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class ConstantsPinchConsts : ConstantsPinch {

		private ConstantsPinchConsts ()
		{
		}
	}


	[Register ("com/joanzapata/pdfview/util/Constants")]
	public abstract class Constants {

		internal Constants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants']/field[@name='DEBUG_MODE']"
		[Register ("DEBUG_MODE")]
		public const bool DebugMode = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants']/field[@name='GRID_SIZE']"
		[Register ("GRID_SIZE")]
		public const int GridSize = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants']/field[@name='LOADED_SIZE']"
		[Register ("LOADED_SIZE")]
		public const int LoadedSize = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants']/field[@name='MASK_ALPHA']"
		[Register ("MASK_ALPHA")]
		public const int MaskAlpha = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants']/field[@name='MINIMAP_MAX_SIZE']"
		[Register ("MINIMAP_MAX_SIZE")]
		public const float MinimapMaxSize = (float) 200.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants']/field[@name='PART_SIZE']"
		[Register ("PART_SIZE")]
		public const float PartSize = (float) 256.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='Constants']/field[@name='THUMBNAIL_RATIO']"
		[Register ("THUMBNAIL_RATIO")]
		public const float ThumbnailRatio = (float) 0.200000;
	}

	[System.Obsolete ("Use the 'Constants' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class ConstantsConsts : Constants {

		private ConstantsConsts ()
		{
		}
	}

}
