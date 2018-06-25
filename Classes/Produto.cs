using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsulteRestricao.Api
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Produto", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoProduto : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nomeField;

        private long codigoField;

        private bool codigoFieldSpecified;

        private bool opcionalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
                this.RaisePropertyChanged("nome");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoSpecified
        {
            get
            {
                return this.codigoFieldSpecified;
            }
            set
            {
                this.codigoFieldSpecified = value;
                this.RaisePropertyChanged("codigoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool opcional
        {
            get
            {
                return this.opcionalField;
            }
            set
            {
                this.opcionalField = value;
                this.RaisePropertyChanged("opcional");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Parametro-Produto", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ParametroProduto : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nomeField;

        private bool obrigatorioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
                this.RaisePropertyChanged("nome");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool obrigatorio
        {
            get
            {
                return this.obrigatorioField;
            }
            set
            {
                this.obrigatorioField = value;
                this.RaisePropertyChanged("obrigatorio");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class Produto : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codigoField;

        private string nomeField;

        private ParametroProduto[] parametroField;

        private InsumoProduto[] insumoopcionalField;

        private InsumoProduto[] insumoretornoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
                this.RaisePropertyChanged("nome");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parametro", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public ParametroProduto[] parametro
        {
            get
            {
                return this.parametroField;
            }
            set
            {
                this.parametroField = value;
                this.RaisePropertyChanged("parametro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("insumo-opcional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public InsumoProduto[] insumoopcional
        {
            get
            {
                return this.insumoopcionalField;
            }
            set
            {
                this.insumoopcionalField = value;
                this.RaisePropertyChanged("insumoopcional");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("insumo-retorno", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public InsumoProduto[] insumoretorno
        {
            get
            {
                return this.insumoretornoField;
            }
            set
            {
                this.insumoretornoField = value;
                this.RaisePropertyChanged("insumoretorno");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
