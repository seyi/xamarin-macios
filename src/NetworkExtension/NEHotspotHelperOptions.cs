#if !MONOMAC
	
using XamCore.Foundation;

namespace XamCore.NetworkExtension {

	public class NEHotspotHelperOptions : DictionaryContainer {

#if !COREBUILD
		public NEHotspotHelperOptions () : base (new NSMutableDictionary ()) {}
		public NEHotspotHelperOptions (NSDictionary dictionary) : base (dictionary) {}

		public NSString DisplayName {
			get {
				return GetNSStringValue (NEHotspotHelperOptionInternal.DisplayName);
			}
			set {
				SetStringValue (NEHotspotHelperOptionInternal.DisplayName, value);
			}
		}
#endif
	}
}

#endif // !MONOMAC
