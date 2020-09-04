using CompetitionSystem.IDAL.IBasesService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.BasesTable;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionSystem.DAL.BasesService
{
    //添加引用:
    //浏览:EntityFramework,EntityFramework.sqlserver
    //程序集:System.ComponentModel.DataAnnotations
    public class BaseService<T> : IBaseService<T> where T : BaseEntity, new()
    {
        /// <summary>
        /// readonly:只读字段
        /// </summary>
        private readonly CompetitionSystemDB _db;

        /// <summary>
        /// 上下文,构造函数接收有关数据库的数据
        /// </summary>
        public BaseService(CompetitionSystemDB db)
        {
            this._db = db;
        }

        public async Task CreateAsync(T model, bool saved = true)
        {
            //关闭数据库的校验判断
            _db.Configuration.ValidateOnSaveEnabled = false;
            //添加数据
            _db.Set<T>().Add(model);
            //判断是否保存
            if (saved)
            {
                await _db.SaveChangesAsync();
                //打开数据库的校验判断
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task EditAsync(T model, bool saved = true)
        {
            //关闭数据库的校验判断
            _db.Configuration.ValidateOnSaveEnabled = false;
            //修改数据
            _db.Entry(model).State = EntityState.Modified;
            //判断是否保存
            if (saved)
            {
                await _db.SaveChangesAsync();
                //打开数据库的校验判断
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>().Where(m => !m.IsRemoved).AsNoTracking();
        }

        public IQueryable<T> GetAllByPageOrderTime(bool asc, int pageIndex, int pageSize)
        {
            return GetAllOrderTime(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<T> GetAllOrderTime(bool asc)
        {
            var datas = GetAll();
            datas = asc ? datas.OrderBy(m => m.CreateTime) : datas.OrderByDescending(m => m.CreateTime);
            return datas;
        }

        public async Task<T> GetOneByIdAsync(Guid id)
        {
            return await GetAll().FirstAsync(m => m.Id == id);
        }

        public async Task PseudoRemoveAsync(Guid id, bool saved = true)
        {
            //关闭数据库的校验判断
            _db.Configuration.ValidateOnSaveEnabled = false;
            //获取数据库中的数据
            var t = new T() { Id = id };
            //删除数据 EntityState.Deleted:真删除
            _db.Entry(t).State = EntityState.Unchanged;
            t.IsRemoved = true;
            //判断是否保存
            if (saved)
            {
                await _db.SaveChangesAsync();
                //打开数据库的校验判断
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public async Task RealRemoveAsync(Guid id, bool saved = true)
        {
            //关闭数据库的校验判断
            _db.Configuration.ValidateOnSaveEnabled = false;
            //获取数据库中的数据
            var t = new T() { Id = id };
            //删除数据 EntityState.Deleted:真删除
            _db.Entry(t).State = EntityState.Deleted;
            t.IsRemoved = true;
            //判断是否保存
            if (saved)
            {
                await _db.SaveChangesAsync();
                //打开数据库的校验判断
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
            //打开数据库的校验判断
            _db.Configuration.ValidateOnSaveEnabled = true;
        }
    }
}
