using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoToggl
{
    public class FormProvider
    {
        private static Menu _menu;
        //private static QuickText _quickText;

        public static Menu Menu
        {
            get {
                if (_menu == null || _menu.IsDisposed) {
                    _menu = new Menu();
                }
                _menu.Activate();
                return _menu;
            }
        }
        //public static QuickText QuickText
        //{
        //    get {
        //        if (_quickText == null || _quickText.IsDisposed) {
        //            _quickText = new QuickText();
        //        }
        //        _quickText.Activate();
        //        return _quickText;
        //    }
        //}
    }
}
