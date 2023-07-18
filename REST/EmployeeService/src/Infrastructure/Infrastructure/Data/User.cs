using Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    //Lazy loading example
    //public class User
    //{
    //    ILazyLoader _lazyLoader;
    //    public User(ILazyLoader lazyLoader)
    //    {
    //        _lazyLoader = lazyLoader;
    //    }

    //    Contact contact;
    //    public Contact Contact
    //    {
    //        get
    //        {
    //            if (contact == null)
    //            {
    //                _lazyLoader.Load(this, ref contact, "Contact");
    //            }
    //            return contact;
    //        }
    //        set
    //        {

    //        }
    //    }
    //}
}
