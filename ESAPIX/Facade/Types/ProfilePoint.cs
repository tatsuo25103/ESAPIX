using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Dynamic;
using X = ESAPIX.Facade.XContext;

namespace ESAPIX.Facade.Types
{
    public class ProfilePoint
    {
        internal dynamic _client;
        public ProfilePoint() { _client = new ExpandoObject(); }
        public ProfilePoint(dynamic client) { _client = client; }
        public ProfilePoint(ESAPIX.Facade.Types.VVector position, System.Double value)
        {
            if (X.Instance.CurrentContext != null)
                X.Instance.CurrentContext.Thread.Invoke(() => { _client = VMSConstructor.ConstructProfilePoint(position, value); });
            else
            {
                _client = new ExpandoObject();
                _client.Position = position;
                _client.Value = value;
            }
        }
        public ESAPIX.Facade.Types.VVector Position
        {
            get
            {
                if (_client is ExpandoObject) { return _client.Position; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<ESAPIX.Facade.Types.VVector>((sc) => { return new ESAPIX.Facade.Types.VVector(local._client.Position); });
            }
            set
            {
                if (_client is ExpandoObject) { _client.Position = value; }
            }
        }
        public System.Double Value
        {
            get
            {
                if (_client is ExpandoObject) { return _client.Value; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Double>((sc) => { return local._client.Value; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.Value = value; }
            }
        }
    }
}