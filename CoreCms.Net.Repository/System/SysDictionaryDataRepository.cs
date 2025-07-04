
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreCms.Net.Configuration;
using CoreCms.Net.IRepository;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.Basics;
using CoreCms.Net.IRepository.UnitOfWork;

namespace CoreCms.Net.Repository
{
    /// <summary>
    /// 数据字典项表 接口实现
    /// </summary>
    public class SysDictionaryDataRepository : BaseRepository<SysDictionaryData>, ISysDictionaryDataRepository
    {
        public SysDictionaryDataRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

       
    }
}
