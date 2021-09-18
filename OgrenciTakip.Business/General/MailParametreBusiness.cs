using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class MailParametreBusiness : BaseGenelBusiness<MailParametre>, IBaseGenelBusiness, IBaseCommonBusiness
	{
        public MailParametreBusiness()
        {
        }

        public MailParametreBusiness(Control control) : base(control)
        {
        }
    }
}
