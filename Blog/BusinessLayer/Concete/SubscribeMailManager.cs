﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concete
{
    public class SubscribeMailManager
    {
        Repository<SubscribeMail> reposubscribemail = new Repository<SubscribeMail>();
        public int BLAdd(SubscribeMail p)
        {
            if (p.Mail.Length <= 11 || p.Mail.Length >= 50)
            {
                return -1;
            }
            return reposubscribemail.Insert(p);
        }
    }
}
