// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace CodeFramework.iOS.Cells
{
	[Register ("RepositoryCellView")]
	partial class RepositoryCellView
	{
		[Outlet]
		MonoTouch.UIKit.UILabel CaptionLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel ContentLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView FollowersImageVIew { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel FollowersLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView ForksImageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel ForksLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView OwnerImageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView UserImageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel UserLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (OwnerImageView != null) {
				OwnerImageView.Dispose ();
				OwnerImageView = null;
			}

			if (CaptionLabel != null) {
				CaptionLabel.Dispose ();
				CaptionLabel = null;
			}

			if (ContentLabel != null) {
				ContentLabel.Dispose ();
				ContentLabel = null;
			}

			if (FollowersImageVIew != null) {
				FollowersImageVIew.Dispose ();
				FollowersImageVIew = null;
			}

			if (FollowersLabel != null) {
				FollowersLabel.Dispose ();
				FollowersLabel = null;
			}

			if (ForksImageView != null) {
				ForksImageView.Dispose ();
				ForksImageView = null;
			}

			if (ForksLabel != null) {
				ForksLabel.Dispose ();
				ForksLabel = null;
			}

			if (UserImageView != null) {
				UserImageView.Dispose ();
				UserImageView = null;
			}

			if (UserLabel != null) {
				UserLabel.Dispose ();
				UserLabel = null;
			}
		}
	}
}
