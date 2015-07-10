using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.Bootstrapper
{
    public static class ServiceFactory
    {

        public static bool IsRegistered<T>()
        {
            try
            {
                ServiceLocator.Current.GetInstance<T>();
                return true;
            }
            catch (ActivationException ae)
            {
                //DO NOTHING with this; false will be returned
            }
            catch (Exception ex)
            {
                //ExceptionManager.Notify(new ApplicationException("Checking Registration", ex), _log);
            }
            return false;
        }

        public static T Create<T>(bool throwException = false)
        {
            try
            {
                return ServiceLocator.Current.GetInstance<T>();
            }
            catch (Exception ex)
            {
                var msg = ex.GetBaseException().Message;
                if (throwException) throw;
                //ExceptionManager.Warn(new ApplicationException(string.Format("Get Instance<{0}>", typeof(T).FullName), ex), _log);
            }
            return default(T);
        }

        public static object Create(Type type, bool throwException = false)
        {
            try
            {
                return ServiceLocator.Current.GetInstance(type);
            }
            catch (Exception ex)
            {
                if (throwException) throw;
                //ExceptionManager.Warn(new ApplicationException(string.Format("Get Instance of type `{0}`", type.FullName), ex), _log);
            }
            return null;
        }

        public static IEnumerable<T> GetAll<T>(bool throwException = false)
        {
            try
            {
                return ServiceLocator.Current.GetAllInstances<T>();
            }
            catch (Exception ex)
            {
                if (throwException) throw;
                //ExceptionManager.Warn(new ApplicationException(string.Format("Get All Instances<{0}>", typeof(T).FullName), ex), _log);
            }
            return new List<T>();
        }

        public static IEnumerable<object> GetAll(Type type, bool throwException = false)
        {
            try
            {
                return ServiceLocator.Current.GetAllInstances(type);
            }
            catch (Exception ex)
            {
                if (throwException) throw;
                //ExceptionManager.Warn(new ApplicationException(string.Format("Get All Instances of type `{0}`", type.FullName), ex), _log);
            }
            return new List<object>();
        }

        public static IEnumerable<object> GetAll(IEnumerable<Type> types, bool throwException = false)
        {
            try
            {
                return types.ToList().Select(t => Create(t, throwException)).ToList();
            }
            catch (Exception ex)
            {
                if (throwException) throw;
                //ExceptionManager.Warn(new ApplicationException(string.Format("Get All Instances - {0} types", types.Count()), ex), _log);
            }
            return new List<object>();
        }
    }
}
