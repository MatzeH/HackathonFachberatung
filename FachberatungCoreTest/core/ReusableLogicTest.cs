using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COPRA.COPRA6.FachberatungCore.core;
using System.Linq;
using COPRA.COPRA6.Base;
using COPRA.COPRA6.Data;
using Object = COPRA.COPRA6.Data.Object;

namespace COPRA.COPRA6.FachberatungCoreTest.core
{
    [TestClass]
    public class ReusableLogicTest
    {
        private ReusableLogic tested;

        [TestInitialize]
        public void Setup()
        {
            tested = new ReusableLogic();
        }


        [TestMethod]
        public void FirstUnitTestForFB()
        {
            var trx = new TestTransaction();

            var result = tested.GetAllUser(null, trx);

            Assert.IsTrue((bool)result.First());
        }

        private class TestTransaction : ITransaction
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool IsInTree(ITransaction transaction)
            {
                throw new NotImplementedException();
            }

            public void RegisterObject(Object obj)
            {
                throw new NotImplementedException();
            }

            public void UnregisterObject(Object obj)
            {
                throw new NotImplementedException();
            }

            public void UnregisterObject(Variable variable)
            {
                throw new NotImplementedException();
            }

            public void UnregisterObjects()
            {
                throw new NotImplementedException();
            }

            public Object GetRegistredObject(Variable variable)
            {
                throw new NotImplementedException();
            }

            public IObject GetRegistredObject(IVariable variable)
            {
                throw new NotImplementedException();
            }

            public void Commit()
            {
                throw new NotImplementedException();
            }

            public void CommitWithParallelTransactions()
            {
                throw new NotImplementedException();
            }

            public void Rollback()
            {
                throw new NotImplementedException();
            }

            public ITransaction CreateNew()
            {
                throw new NotImplementedException();
            }

            public void Remove(ITransaction value)
            {
                throw new NotImplementedException();
            }

            public T Modify<T>(T value) where T : IBaseData
            {
                throw new NotImplementedException();
            }

            public bool HasModifiedData(Object obj, bool recursive)
            {
                throw new NotImplementedException();
            }

            public bool IsModified(IBaseData data)
            {
                throw new NotImplementedException();
            }

            public void SaveData(List<BaseData> data)
            {
                throw new NotImplementedException();
            }

            public void SaveData(BaseData data)
            {
                throw new NotImplementedException();
            }

            public BaseData Get(DataId id, Variable variable)
            {
                throw new NotImplementedException();
            }

            public T Get<T>(DataId id, Variable variable) where T : BaseData
            {
                throw new NotImplementedException();
            }

            public BaseData Get(DataId id, IVariable variable)
            {
                throw new NotImplementedException();
            }

            public T Get<T>(DataId id, IVariable variable) where T : BaseData
            {
                throw new NotImplementedException();
            }

            public T GetI<T>(DataId id, IVariable variable) where T : IBaseData
            {
                throw new NotImplementedException();
            }

            public BaseData Get(DataId id, Variable variable, bool force_cache_usage)
            {
                throw new NotImplementedException();
            }

            public BaseData Get(DataId id, IVariable variable, bool force_cache_usage)
            {
                throw new NotImplementedException();
            }

            public List<BaseData> Get(Variable variable)
            {
                throw new NotImplementedException();
            }

            public List<T> GetGen<T>(Variable variable, BaseData parent) where T : BaseData
            {
                throw new NotImplementedException();
            }

            public List<T> SearchGen<T>(Object parent, string sql, SortedList parameters) where T : BaseData
            {
                throw new NotImplementedException();
            }

            public List<T> SearchGen<T>(Variable variable, Object parent, string sql, SortedList parameters) where T : BaseData
            {
                throw new NotImplementedException();
            }

            public BaseValue GetLastValue(Variable variable, Object parent, DateTime @from, DateTime to)
            {
                throw new NotImplementedException();
            }

            public BaseValue GetLastValue(Variable variable, Object parent, DateTime @from, DateTime to, bool with_deleted)
            {
                throw new NotImplementedException();
            }

            public BaseValue GetLastValue(Variable variable, Object parent)
            {
                throw new NotImplementedException();
            }

            public BaseValue GetLastValue(Variable variable, Object parent, bool with_deleted)
            {
                throw new NotImplementedException();
            }

            public IBaseValue GetLastValue(IVariable variable, IObject parent, bool with_deleted)
            {
                throw new NotImplementedException();
            }

            public List<T> GetValues<T>(string sql, Variable variable, Object parent, DateTime start, DateTime end, bool with_deleted) where T : IBaseValue
            {
                throw new NotImplementedException();
            }

            public List<T> GetValues<T>(Variable variable, Object parent) where T : IBaseValue
            {
                throw new NotImplementedException();
            }

            public List<T> GetValues<T>(Variable variable, Object parent, DateTime start, DateTime end) where T : IBaseValue
            {
                throw new NotImplementedException();
            }

            public List<T> GetValues<T>(Variable variable, Object parent, DateTime start, DateTime end, bool with_deleted) where T : IBaseValue
            {
                throw new NotImplementedException();
            }

            public List<T> GetValues<T>(Variable variable, string sql, SortedList p) where T : IBaseValue
            {
                throw new NotImplementedException();
            }

            public BaseValue GetFirstValue(Variable variable, Object parent, DateTime @from)
            {
                throw new NotImplementedException();
            }

            public BaseValue GetFirstValue(Variable variable, Object parent, DateTime @from, DateTime to, bool with_deleted)
            {
                throw new NotImplementedException();
            }

            public IObservable<IObject> ObjektRegistriert { get; }
            public IObservable<IObject> ObjektDeregistriert { get; }
            public IEnumerable<Object> RegisteredObjects { get; }
            public bool IsReadOnly { get; set; }
            public bool IsRoot { get; }
            public ITransaction SuperiorTransaction { get; set; }
            public ITransaction[] SubordinatedTransactions { get; }
            public bool IsInTransaction { get; }
            public bool InheritsRegisteredObjects { get; set; }
            public bool IsDisposed { get; }
            public ILoadData Load { get; }
            public event EventHandler Disposed;
            public event EventHandler<EventArgs<DataReference>> ObjectRegistered;
            public event EventHandler<EventArgs<DataReference>> ObjectUnregistered;
        }
    }
}
