using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"org/vudroid/core/events",
					},
					new Converter<string, Type>[]{
						lookup_org_vudroid_core_events_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_org_vudroid_core_events_mappings;
		static Type lookup_org_vudroid_core_events_package (string klass)
		{
			if (package_org_vudroid_core_events_mappings == null) {
				package_org_vudroid_core_events_mappings = new string[]{
					"org/vudroid/core/events/CurrentPageListener$CurrentPageChangedEvent:Org.Vudroid.Core.Events.CurrentPageListenerCurrentPageChangedEvent",
					"org/vudroid/core/events/DecodingProgressListener$DecodingProgressEvent:Org.Vudroid.Core.Events.DecodingProgressListenerDecodingProgressEvent",
					"org/vudroid/core/events/ZoomListener$CommitZoomEvent:Org.Vudroid.Core.Events.ZoomListenerCommitZoomEvent",
				};
			}

			return Lookup (package_org_vudroid_core_events_mappings, klass);
		}
	}
}
