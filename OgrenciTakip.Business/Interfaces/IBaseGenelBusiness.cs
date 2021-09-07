using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Business.Interfaces
{
	public interface IBaseGenelBusiness
	{
		bool Insert(BaseEntity entity);
		bool Update(BaseEntity oldEntity, BaseEntity currentEntity);
		string YeniKodVer();
	}
}
