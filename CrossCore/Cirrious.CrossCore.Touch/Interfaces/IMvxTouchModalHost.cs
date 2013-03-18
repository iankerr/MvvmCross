// IMvxTouchModalHost.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using MonoTouch.UIKit;

namespace Cirrious.CrossCore.Touch.Interfaces
{
    public interface IMvxTouchModalHost
    {
        bool PresentModalViewController(UIViewController controller, bool animated);
        void NativeModalViewControllerDisappearedOnItsOwn();
    }
}