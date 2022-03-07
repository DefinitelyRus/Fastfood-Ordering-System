using System;

namespace FastfoodOrderingSystem
{
    internal static class MasterClass
    {
        /*
         * to-do:
         * - menu item constructor thru console input
         * - object to JSON parser
         * - display all contents to data grids*
         * - display menu item content upon row select*
         * - save cart contents as its own linked list
         * - update cart data grid upon "add to cart"*
         * - make cart item quantity changeable (+1 & -1) when selected, then hide buttons when not*
         * - display total price when no cart item is selected*
         * - flush all cart contents upon "place order"*
         * 
         * all tasks marked with (*) are supposed to be yours.
         * ill do them anyway but i wont use the code i made unless you're still unable to.
         * otherwise, i'll use them as guide material when teaching you the ropes
         */

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new formUI());
        }
    }
}