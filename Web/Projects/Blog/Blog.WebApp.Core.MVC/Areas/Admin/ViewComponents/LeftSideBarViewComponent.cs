using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApp.Core.MVC.Areas.Admin.ViewComponents
{/// <summary>
/// Controllere oxsa sa da View component daha ferqlidir. View componentin icinde bir nece action yaratmaq mumkun deyil
/// Viewcomponentin isi odur ki, her hansi bir parti goturur ve onun icerisinde dinamik emeliyyatlar aparir.
/// Sadece 1 metodu olur
/// </summary>
    public class LeftSideBarViewComponent:ViewComponent
    {
        #region fields

        #endregion

        #region ctor
        public LeftSideBarViewComponent()
        {

        }
        #endregion


    }
}
