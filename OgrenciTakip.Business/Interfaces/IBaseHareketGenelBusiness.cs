using OgrenciYazilim.Model.Entities.Base;
using System.Collections.Generic;

namespace OgrenciTakip.Business.Interfaces
{
	public interface IBaseHareketGenelBusiness
	{
		bool Insert(IList<BaseHareketEntity> entities);

		bool Update(IList<BaseHareketEntity> entities);

		bool Delete(IList<BaseHareketEntity> entities);
	}
}