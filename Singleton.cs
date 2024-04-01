using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Reflection;

namespace BasicFacebookFeatures
{
    public static class Singelton<T>
    {
        private static T s_Instance;

        private static object s_LockObj = new object();

        static Singelton() { }

        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            Type typeOfT = typeof(T);
                            ConstructorInfo constructorInfo = typeOfT.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null);

                            if (constructorInfo != null)
                            {
                                s_Instance = (T)constructorInfo.Invoke(null);
                            }
                        }
                    }
                }

                return s_Instance;
            }
        }
    }
}
