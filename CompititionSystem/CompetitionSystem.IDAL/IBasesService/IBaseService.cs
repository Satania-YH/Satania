using CompetitionSystem.Model.BasesTable;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionSystem.IDAL.IBasesService
{
    public interface IBaseService<T> : IDisposable where T : BaseEntity
    {
        /// <summary>
        /// 创建
        /// </summary>
        /// <returns></returns>
        Task CreateAsync(T model, bool saved = true);

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        Task EditAsync(T model, bool saved = true);

        /// <summary>
        /// 伪、真删除
        /// </summary>
        /// <returns></returns>
        Task PseudoRemoveAsync(Guid id, bool saved = true);
        Task RealRemoveAsync(Guid id, bool saved = true);

        /// <summary>
        /// 保存方式
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();

        /// <summary>
        /// 获取一个
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetOneByIdAsync(Guid id);

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();
        IQueryable<T> GetAllOrderTime(bool asc);
        IQueryable<T> GetAllByPageOrderTime(bool asc, int pageIndex, int pageSize);
    }
}
