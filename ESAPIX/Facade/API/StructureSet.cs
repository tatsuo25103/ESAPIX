using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using X = ESAPIX.Facade.XContext;

namespace ESAPIX.Facade.API
{
    public class StructureSet : ESAPIX.Facade.API.ApiDataObject
    {
        public StructureSet() { }
        public StructureSet(dynamic client) { _client = client; }
        public IEnumerable<ESAPIX.Facade.API.Structure> Structures
        {
            get
            {
                IEnumerator enumerator = null;
                X.Instance.CurrentContext.Thread.Invoke(() =>
                {
                    var asEnum = (IEnumerable)_client.Structures;
                    enumerator = asEnum.GetEnumerator();
                });
                while (X.Instance.CurrentContext.GetValue<bool>(sc => enumerator.MoveNext()))
                {
                    var facade = new ESAPIX.Facade.API.Structure();
                    X.Instance.CurrentContext.Thread.Invoke(() =>
                    {
                        var vms = enumerator.Current;
                        if (vms != null)
                        {
                            facade._client = vms;
                        }
                    });
                    if (facade._client != null)
                    { yield return facade; }
                }
            }
        }
        public ESAPIX.Facade.API.Image Image
        {
            get
            {
                var local = this;
                return new ESAPIX.Facade.API.Image(local._client.Image);
            }
        }
        public System.String UID
        {
            get
            {
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.String>((sc) => { return local._client.UID; });
            }
        }
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            var local = this;
            X.Instance.CurrentContext.Thread.Invoke(() =>
            {
                local._client.WriteXml(writer);
            });

        }
        public ESAPIX.Facade.API.Structure AddStructure(System.String dicomType, System.String id)
        {
            var local = this;
            var retVal = X.Instance.CurrentContext.GetValue((sc) => { return new ESAPIX.Facade.API.Structure(local._client.AddStructure(dicomType, id)); });
            return retVal;

        }
        public System.Boolean CanAddStructure(System.String dicomType, System.String id)
        {
            var local = this;
            var retVal = X.Instance.CurrentContext.GetValue((sc) => { return local._client.CanAddStructure(dicomType, id); });
            return retVal;

        }
        public System.Boolean CanRemoveStructure(ESAPIX.Facade.API.Structure structure)
        {
            var local = this;
            var retVal = X.Instance.CurrentContext.GetValue((sc) => { return local._client.CanRemoveStructure(structure._client); });
            return retVal;

        }
        public void RemoveStructure(ESAPIX.Facade.API.Structure structure)
        {
            var local = this;
            X.Instance.CurrentContext.Thread.Invoke(() =>
            {
                local._client.RemoveStructure(structure._client);
            });

        }
    }
}