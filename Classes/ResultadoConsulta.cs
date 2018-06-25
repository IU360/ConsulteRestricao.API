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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Resultado-Consulta-Score", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ResultadoConsultaScore : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cnpj cnpjconsultadoField;

        private Cpf cpfconsultadoField;

        private object spcscore12mesesField;

        private object spcscore3mesesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cnpj-consultado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cnpj cnpjconsultado
        {
            get
            {
                return this.cnpjconsultadoField;
            }
            set
            {
                this.cnpjconsultadoField = value;
                this.RaisePropertyChanged("cnpjconsultado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cpf-consultado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Cpf cpfconsultado
        {
            get
            {
                return this.cpfconsultadoField;
            }
            set
            {
                this.cpfconsultadoField = value;
                this.RaisePropertyChanged("cpfconsultado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("spc-score-12-meses", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public object spcscore12meses
        {
            get
            {
                return this.spcscore12mesesField;
            }
            set
            {
                this.spcscore12mesesField = value;
                this.RaisePropertyChanged("spcscore12meses");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("spc-score-3-meses", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public object spcscore3meses
        {
            get
            {
                return this.spcscore3mesesField;
            }
            set
            {
                this.spcscore3mesesField = value;
                this.RaisePropertyChanged("spcscore3meses");
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
    public partial class Cnpj : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string numeroField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
                this.RaisePropertyChanged("numero");
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
    public partial class Cpf : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string regiaoorigemField;

        private string numeroField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("regiao-origem")]
        public string regiaoorigem
        {
            get
            {
                return this.regiaoorigemField;
            }
            set
            {
                this.regiaoorigemField = value;
                this.RaisePropertyChanged("regiaoorigem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
                this.RaisePropertyChanged("numero");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Filtro-Consulta-Score", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class FiltroConsultaScore : object, System.ComponentModel.INotifyPropertyChanged
    {

        private long numeroprotocoloField;

        private bool numeroprotocoloFieldSpecified;

        private string numerodocumentoField;

        private long codigoprodutoprincipalField;

        private bool codigoprodutoprincipalFieldSpecified;

        private string tipopessoaField;

        private long[] horizontescoreField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numero-protocolo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public long numeroprotocolo
        {
            get
            {
                return this.numeroprotocoloField;
            }
            set
            {
                this.numeroprotocoloField = value;
                this.RaisePropertyChanged("numeroprotocolo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroprotocoloSpecified
        {
            get
            {
                return this.numeroprotocoloFieldSpecified;
            }
            set
            {
                this.numeroprotocoloFieldSpecified = value;
                this.RaisePropertyChanged("numeroprotocoloSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numero-documento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string numerodocumento
        {
            get
            {
                return this.numerodocumentoField;
            }
            set
            {
                this.numerodocumentoField = value;
                this.RaisePropertyChanged("numerodocumento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("codigo-produto-principal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public long codigoprodutoprincipal
        {
            get
            {
                return this.codigoprodutoprincipalField;
            }
            set
            {
                this.codigoprodutoprincipalField = value;
                this.RaisePropertyChanged("codigoprodutoprincipal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoprodutoprincipalSpecified
        {
            get
            {
                return this.codigoprodutoprincipalFieldSpecified;
            }
            set
            {
                this.codigoprodutoprincipalFieldSpecified = value;
                this.RaisePropertyChanged("codigoprodutoprincipalSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipo-pessoa", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string tipopessoa
        {
            get
            {
                return this.tipopessoaField;
            }
            set
            {
                this.tipopessoaField = value;
                this.RaisePropertyChanged("tipopessoa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("horizonte-score", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public long[] horizontescore
        {
            get
            {
                return this.horizontescoreField;
            }
            set
            {
                this.horizontescoreField = value;
                this.RaisePropertyChanged("horizontescore");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Filtro-Consulta-Complementar", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class FiltroConsultaComplementar : object, System.ComponentModel.INotifyPropertyChanged
    {

        private long numeroprotocoloField;

        private bool numeroprotocoloFieldSpecified;

        private string numerodocumentosocioField;

        private long codigoprodutoprincipalField;

        private bool codigoprodutoprincipalFieldSpecified;

        private string tipopessoaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numero-protocolo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public long numeroprotocolo
        {
            get
            {
                return this.numeroprotocoloField;
            }
            set
            {
                this.numeroprotocoloField = value;
                this.RaisePropertyChanged("numeroprotocolo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroprotocoloSpecified
        {
            get
            {
                return this.numeroprotocoloFieldSpecified;
            }
            set
            {
                this.numeroprotocoloFieldSpecified = value;
                this.RaisePropertyChanged("numeroprotocoloSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numero-documento-socio", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string numerodocumentosocio
        {
            get
            {
                return this.numerodocumentosocioField;
            }
            set
            {
                this.numerodocumentosocioField = value;
                this.RaisePropertyChanged("numerodocumentosocio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("codigo-produto-principal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public long codigoprodutoprincipal
        {
            get
            {
                return this.codigoprodutoprincipalField;
            }
            set
            {
                this.codigoprodutoprincipalField = value;
                this.RaisePropertyChanged("codigoprodutoprincipal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoprodutoprincipalSpecified
        {
            get
            {
                return this.codigoprodutoprincipalFieldSpecified;
            }
            set
            {
                this.codigoprodutoprincipalFieldSpecified = value;
                this.RaisePropertyChanged("codigoprodutoprincipalSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipo-pessoa", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string tipopessoa
        {
            get
            {
                return this.tipopessoaField;
            }
            set
            {
                this.tipopessoaField = value;
                this.RaisePropertyChanged("tipopessoa");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Mensagem-Complementar", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class MensagemComplementar : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] mensagemField;

        private string origemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mensagem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string[] mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
                this.RaisePropertyChanged("origem");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Mensagem-Indice-Relacionamento-Mercado-PJ", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class MensagemIndiceRelacionamentoMercadoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string retornoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string retorno
        {
            get
            {
                return this.retornoField;
            }
            set
            {
                this.retornoField = value;
                this.RaisePropertyChanged("retorno");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Indice-Relacionamento-Mercado-PJ", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoIndiceRelacionamentoMercadoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private MensagemIndiceRelacionamentoMercadoPJ mensagemField;

        private string valorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public MensagemIndiceRelacionamentoMercadoPJ mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Mensagem-Indice-Relacionamento-Mercado-PF", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class MensagemIndiceRelacionamentoMercadoPF : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string retornoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string retorno
        {
            get
            {
                return this.retornoField;
            }
            set
            {
                this.retornoField = value;
                this.RaisePropertyChanged("retorno");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Indice-Relacionamento-Mercado-PF", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoIndiceRelacionamentoMercadoPF : object, System.ComponentModel.INotifyPropertyChanged
    {

        private MensagemIndiceRelacionamentoMercadoPF mensagemField;

        private string valorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public MensagemIndiceRelacionamentoMercadoPF mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Mensagem-Gasto-Estimado-PF", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class MensagemGastoEstimadoPF : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string retornoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string retorno
        {
            get
            {
                return this.retornoField;
            }
            set
            {
                this.retornoField = value;
                this.RaisePropertyChanged("retorno");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Gasto-Estimado-PF", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoGastoEstimadoPF : object, System.ComponentModel.INotifyPropertyChanged
    {

        private MensagemGastoEstimadoPF mensagemField;

        private string valorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public MensagemGastoEstimadoPF mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
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
    public partial class SemRestricao : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string descricaoField;

        private string mensagemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
                this.RaisePropertyChanged("descricao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
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
    public partial class Restricao : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime dataUltimaOcorrenciaField;

        private bool dataUltimaOcorrenciaFieldSpecified;

        private string descricaoField;

        private int quantidadeOcorrenciasField;

        private bool quantidadeOcorrenciasFieldSpecified;

        private string valorTotalOcorrenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime dataUltimaOcorrencia
        {
            get
            {
                return this.dataUltimaOcorrenciaField;
            }
            set
            {
                this.dataUltimaOcorrenciaField = value;
                this.RaisePropertyChanged("dataUltimaOcorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataUltimaOcorrenciaSpecified
        {
            get
            {
                return this.dataUltimaOcorrenciaFieldSpecified;
            }
            set
            {
                this.dataUltimaOcorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataUltimaOcorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
                this.RaisePropertyChanged("descricao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int quantidadeOcorrencias
        {
            get
            {
                return this.quantidadeOcorrenciasField;
            }
            set
            {
                this.quantidadeOcorrenciasField = value;
                this.RaisePropertyChanged("quantidadeOcorrencias");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadeOcorrenciasSpecified
        {
            get
            {
                return this.quantidadeOcorrenciasFieldSpecified;
            }
            set
            {
                this.quantidadeOcorrenciasFieldSpecified = value;
                this.RaisePropertyChanged("quantidadeOcorrenciasSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valorTotalOcorrencia
        {
            get
            {
                return this.valorTotalOcorrenciaField;
            }
            set
            {
                this.valorTotalOcorrenciaField = value;
                this.RaisePropertyChanged("valorTotalOcorrencia");
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
    public partial class InformacoesAdicionais3Socios : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nomeField;

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
    public partial class InformacoesAdicionais2Socios : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string logradouroField;

        private string bairroField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string logradouro
        {
            get
            {
                return this.logradouroField;
            }
            set
            {
                this.logradouroField = value;
                this.RaisePropertyChanged("logradouro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
                this.RaisePropertyChanged("bairro");
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
    public partial class InformacoesAdicionais1Socios : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string cidadeField;

        private System.DateTime dataNascimentoField;

        private bool dataNascimentoFieldSpecified;

        private string documentoField;

        private string cepField;

        private string rgField;

        private string dddField;

        private string ufField;

        private string vinculoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
                this.RaisePropertyChanged("cidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime dataNascimento
        {
            get
            {
                return this.dataNascimentoField;
            }
            set
            {
                this.dataNascimentoField = value;
                this.RaisePropertyChanged("dataNascimento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataNascimentoSpecified
        {
            get
            {
                return this.dataNascimentoFieldSpecified;
            }
            set
            {
                this.dataNascimentoFieldSpecified = value;
                this.RaisePropertyChanged("dataNascimentoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
                this.RaisePropertyChanged("documento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cep
        {
            get
            {
                return this.cepField;
            }
            set
            {
                this.cepField = value;
                this.RaisePropertyChanged("cep");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rg
        {
            get
            {
                return this.rgField;
            }
            set
            {
                this.rgField = value;
                this.RaisePropertyChanged("rg");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ddd
        {
            get
            {
                return this.dddField;
            }
            set
            {
                this.dddField = value;
                this.RaisePropertyChanged("ddd");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
                this.RaisePropertyChanged("uf");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vinculo
        {
            get
            {
                return this.vinculoField;
            }
            set
            {
                this.vinculoField = value;
                this.RaisePropertyChanged("vinculo");
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
    public partial class QuadroAdministrativoQuadroSocialMaisCompletoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string cargoField;

        private string documentoField;

        private string nacionalidadeField;

        private string nomeField;

        private string tipoPessoaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cargo
        {
            get
            {
                return this.cargoField;
            }
            set
            {
                this.cargoField = value;
                this.RaisePropertyChanged("cargo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
                this.RaisePropertyChanged("documento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nacionalidade
        {
            get
            {
                return this.nacionalidadeField;
            }
            set
            {
                this.nacionalidadeField = value;
                this.RaisePropertyChanged("nacionalidade");
            }
        }

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
        public string tipoPessoa
        {
            get
            {
                return this.tipoPessoaField;
            }
            set
            {
                this.tipoPessoaField = value;
                this.RaisePropertyChanged("tipoPessoa");
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
    public partial class Detalhe2QuadroSocialMaisCompletoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private double percentualCapitalVotanteField;

        private bool percentualCapitalVotanteFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double percentualCapitalVotante
        {
            get
            {
                return this.percentualCapitalVotanteField;
            }
            set
            {
                this.percentualCapitalVotanteField = value;
                this.RaisePropertyChanged("percentualCapitalVotante");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentualCapitalVotanteSpecified
        {
            get
            {
                return this.percentualCapitalVotanteFieldSpecified;
            }
            set
            {
                this.percentualCapitalVotanteFieldSpecified = value;
                this.RaisePropertyChanged("percentualCapitalVotanteSpecified");
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
    public partial class Detalhe1QuadroSocialMaisCompletoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime dataEntradaField;

        private bool dataEntradaFieldSpecified;

        private string documentoField;

        private string nacionalidadeField;

        private string nomeField;

        private double percentualField;

        private bool percentualFieldSpecified;

        private string tipoPessoaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime dataEntrada
        {
            get
            {
                return this.dataEntradaField;
            }
            set
            {
                this.dataEntradaField = value;
                this.RaisePropertyChanged("dataEntrada");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataEntradaSpecified
        {
            get
            {
                return this.dataEntradaFieldSpecified;
            }
            set
            {
                this.dataEntradaFieldSpecified = value;
                this.RaisePropertyChanged("dataEntradaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
                this.RaisePropertyChanged("documento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nacionalidade
        {
            get
            {
                return this.nacionalidadeField;
            }
            set
            {
                this.nacionalidadeField = value;
                this.RaisePropertyChanged("nacionalidade");
            }
        }

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
        public double percentual
        {
            get
            {
                return this.percentualField;
            }
            set
            {
                this.percentualField = value;
                this.RaisePropertyChanged("percentual");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentualSpecified
        {
            get
            {
                return this.percentualFieldSpecified;
            }
            set
            {
                this.percentualFieldSpecified = value;
                this.RaisePropertyChanged("percentualSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tipoPessoa
        {
            get
            {
                return this.tipoPessoaField;
            }
            set
            {
                this.tipoPessoaField = value;
                this.RaisePropertyChanged("tipoPessoa");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Registro-Quadro-Social-Mais-Completo-PJ", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class RegistroQuadroSocialMaisCompletoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Detalhe1QuadroSocialMaisCompletoPJ detalhessocio1Field;

        private Detalhe2QuadroSocialMaisCompletoPJ detalhessocio2Field;

        private QuadroAdministrativoQuadroSocialMaisCompletoPJ administrativoField;

        private InformacoesAdicionais1Socios informacoesadicionais1Field;

        private InformacoesAdicionais2Socios informacoesadicionais2Field;

        private InformacoesAdicionais3Socios informacoesadicionais3Field;

        private Restricao[] restricoesField;

        private SemRestricao[] semrestricoesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("detalhes-socio-1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Detalhe1QuadroSocialMaisCompletoPJ detalhessocio1
        {
            get
            {
                return this.detalhessocio1Field;
            }
            set
            {
                this.detalhessocio1Field = value;
                this.RaisePropertyChanged("detalhessocio1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("detalhes-socio-2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Detalhe2QuadroSocialMaisCompletoPJ detalhessocio2
        {
            get
            {
                return this.detalhessocio2Field;
            }
            set
            {
                this.detalhessocio2Field = value;
                this.RaisePropertyChanged("detalhessocio2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public QuadroAdministrativoQuadroSocialMaisCompletoPJ administrativo
        {
            get
            {
                return this.administrativoField;
            }
            set
            {
                this.administrativoField = value;
                this.RaisePropertyChanged("administrativo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("informacoes-adicionais-1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public InformacoesAdicionais1Socios informacoesadicionais1
        {
            get
            {
                return this.informacoesadicionais1Field;
            }
            set
            {
                this.informacoesadicionais1Field = value;
                this.RaisePropertyChanged("informacoesadicionais1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("informacoes-adicionais-2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public InformacoesAdicionais2Socios informacoesadicionais2
        {
            get
            {
                return this.informacoesadicionais2Field;
            }
            set
            {
                this.informacoesadicionais2Field = value;
                this.RaisePropertyChanged("informacoesadicionais2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("informacoes-adicionais-3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public InformacoesAdicionais3Socios informacoesadicionais3
        {
            get
            {
                return this.informacoesadicionais3Field;
            }
            set
            {
                this.informacoesadicionais3Field = value;
                this.RaisePropertyChanged("informacoesadicionais3");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("restricoes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public Restricao[] restricoes
        {
            get
            {
                return this.restricoesField;
            }
            set
            {
                this.restricoesField = value;
                this.RaisePropertyChanged("restricoes");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sem-restricoes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public SemRestricao[] semrestricoes
        {
            get
            {
                return this.semrestricoesField;
            }
            set
            {
                this.semrestricoesField = value;
                this.RaisePropertyChanged("semrestricoes");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Quadro-Social-Mais-Completo-PJ", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoQuadroSocialMaisCompletoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private RegistroQuadroSocialMaisCompletoPJ[] controlesocietarioField;

        private string mensagemField;

        private RegistroQuadroSocialMaisCompletoPJ[] quadroadministrativoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("controle-societario", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public RegistroQuadroSocialMaisCompletoPJ[] controlesocietario
        {
            get
            {
                return this.controlesocietarioField;
            }
            set
            {
                this.controlesocietarioField = value;
                this.RaisePropertyChanged("controlesocietario");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quadro-administrativo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public RegistroQuadroSocialMaisCompletoPJ[] quadroadministrativo
        {
            get
            {
                return this.quadroadministrativoField;
            }
            set
            {
                this.quadroadministrativoField = value;
                this.RaisePropertyChanged("quadroadministrativo");
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
    public partial class perfilFinanceiroIndicesFinanceiroIntegrado : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string desCategoriaIndiceField;

        private string formatoDoIndiceField;

        private string indiceDoBalancoField;

        private string indiceDoBalancoPadraoField;

        private int qtdDecimalField;

        private bool qtdDecimalFieldSpecified;

        private int qtdInteiroField;

        private bool qtdInteiroFieldSpecified;

        private string sinalDoIndiceBalancoField;

        private string sinalDoIndiceBalancoPadraoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string desCategoriaIndice
        {
            get
            {
                return this.desCategoriaIndiceField;
            }
            set
            {
                this.desCategoriaIndiceField = value;
                this.RaisePropertyChanged("desCategoriaIndice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string formatoDoIndice
        {
            get
            {
                return this.formatoDoIndiceField;
            }
            set
            {
                this.formatoDoIndiceField = value;
                this.RaisePropertyChanged("formatoDoIndice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string indiceDoBalanco
        {
            get
            {
                return this.indiceDoBalancoField;
            }
            set
            {
                this.indiceDoBalancoField = value;
                this.RaisePropertyChanged("indiceDoBalanco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string indiceDoBalancoPadrao
        {
            get
            {
                return this.indiceDoBalancoPadraoField;
            }
            set
            {
                this.indiceDoBalancoPadraoField = value;
                this.RaisePropertyChanged("indiceDoBalancoPadrao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public int qtdDecimal
        {
            get
            {
                return this.qtdDecimalField;
            }
            set
            {
                this.qtdDecimalField = value;
                this.RaisePropertyChanged("qtdDecimal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtdDecimalSpecified
        {
            get
            {
                return this.qtdDecimalFieldSpecified;
            }
            set
            {
                this.qtdDecimalFieldSpecified = value;
                this.RaisePropertyChanged("qtdDecimalSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public int qtdInteiro
        {
            get
            {
                return this.qtdInteiroField;
            }
            set
            {
                this.qtdInteiroField = value;
                this.RaisePropertyChanged("qtdInteiro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtdInteiroSpecified
        {
            get
            {
                return this.qtdInteiroFieldSpecified;
            }
            set
            {
                this.qtdInteiroFieldSpecified = value;
                this.RaisePropertyChanged("qtdInteiroSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string sinalDoIndiceBalanco
        {
            get
            {
                return this.sinalDoIndiceBalancoField;
            }
            set
            {
                this.sinalDoIndiceBalancoField = value;
                this.RaisePropertyChanged("sinalDoIndiceBalanco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string sinalDoIndiceBalancoPadrao
        {
            get
            {
                return this.sinalDoIndiceBalancoPadraoField;
            }
            set
            {
                this.sinalDoIndiceBalancoPadraoField = value;
                this.RaisePropertyChanged("sinalDoIndiceBalancoPadrao");
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
    public partial class perfilFinanceiroIdentificacaoBalanco : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string blocoField;

        private System.DateTime dataBalancoField;

        private bool dataBalancoFieldSpecified;

        private string descricaoUnidadeField;

        private string padraoContabilField;

        private string tipoDemonstrativoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string bloco
        {
            get
            {
                return this.blocoField;
            }
            set
            {
                this.blocoField = value;
                this.RaisePropertyChanged("bloco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public System.DateTime dataBalanco
        {
            get
            {
                return this.dataBalancoField;
            }
            set
            {
                this.dataBalancoField = value;
                this.RaisePropertyChanged("dataBalanco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataBalancoSpecified
        {
            get
            {
                return this.dataBalancoFieldSpecified;
            }
            set
            {
                this.dataBalancoFieldSpecified = value;
                this.RaisePropertyChanged("dataBalancoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string descricaoUnidade
        {
            get
            {
                return this.descricaoUnidadeField;
            }
            set
            {
                this.descricaoUnidadeField = value;
                this.RaisePropertyChanged("descricaoUnidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string padraoContabil
        {
            get
            {
                return this.padraoContabilField;
            }
            set
            {
                this.padraoContabilField = value;
                this.RaisePropertyChanged("padraoContabil");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string tipoDemonstrativo
        {
            get
            {
                return this.tipoDemonstrativoField;
            }
            set
            {
                this.tipoDemonstrativoField = value;
                this.RaisePropertyChanged("tipoDemonstrativo");
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
    public partial class perfilFinanceiroResultado : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string blocoField;

        private string codigoNivelContaField;

        private string nomeContaField;

        private string numeroContaField;

        private string sinalField;

        private int valorField;

        private bool valorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string bloco
        {
            get
            {
                return this.blocoField;
            }
            set
            {
                this.blocoField = value;
                this.RaisePropertyChanged("bloco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string codigoNivelConta
        {
            get
            {
                return this.codigoNivelContaField;
            }
            set
            {
                this.codigoNivelContaField = value;
                this.RaisePropertyChanged("codigoNivelConta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string nomeConta
        {
            get
            {
                return this.nomeContaField;
            }
            set
            {
                this.nomeContaField = value;
                this.RaisePropertyChanged("nomeConta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string numeroConta
        {
            get
            {
                return this.numeroContaField;
            }
            set
            {
                this.numeroContaField = value;
                this.RaisePropertyChanged("numeroConta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string sinal
        {
            get
            {
                return this.sinalField;
            }
            set
            {
                this.sinalField = value;
                this.RaisePropertyChanged("sinal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public int valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
                this.RaisePropertyChanged("valorSpecified");
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
    public partial class perfilFinanceiroContasPassivo : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string blocoField;

        private string codigoNivelContaField;

        private string nomeContaField;

        private string numeroContaField;

        private string sinalField;

        private int valorField;

        private bool valorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string bloco
        {
            get
            {
                return this.blocoField;
            }
            set
            {
                this.blocoField = value;
                this.RaisePropertyChanged("bloco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string codigoNivelConta
        {
            get
            {
                return this.codigoNivelContaField;
            }
            set
            {
                this.codigoNivelContaField = value;
                this.RaisePropertyChanged("codigoNivelConta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string nomeConta
        {
            get
            {
                return this.nomeContaField;
            }
            set
            {
                this.nomeContaField = value;
                this.RaisePropertyChanged("nomeConta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string numeroConta
        {
            get
            {
                return this.numeroContaField;
            }
            set
            {
                this.numeroContaField = value;
                this.RaisePropertyChanged("numeroConta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string sinal
        {
            get
            {
                return this.sinalField;
            }
            set
            {
                this.sinalField = value;
                this.RaisePropertyChanged("sinal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public int valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
                this.RaisePropertyChanged("valorSpecified");
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
    public partial class perfilFinanceiroContasAtivo : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string blocoField;

        private string clientesField;

        private string codigoNivelContaField;

        private string estoquesField;

        private string nomeContaField;

        private string numeroContaField;

        private string sinalField;

        private int valorField;

        private bool valorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string bloco
        {
            get
            {
                return this.blocoField;
            }
            set
            {
                this.blocoField = value;
                this.RaisePropertyChanged("bloco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string clientes
        {
            get
            {
                return this.clientesField;
            }
            set
            {
                this.clientesField = value;
                this.RaisePropertyChanged("clientes");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string codigoNivelConta
        {
            get
            {
                return this.codigoNivelContaField;
            }
            set
            {
                this.codigoNivelContaField = value;
                this.RaisePropertyChanged("codigoNivelConta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string estoques
        {
            get
            {
                return this.estoquesField;
            }
            set
            {
                this.estoquesField = value;
                this.RaisePropertyChanged("estoques");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string nomeConta
        {
            get
            {
                return this.nomeContaField;
            }
            set
            {
                this.nomeContaField = value;
                this.RaisePropertyChanged("nomeConta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string numeroConta
        {
            get
            {
                return this.numeroContaField;
            }
            set
            {
                this.numeroContaField = value;
                this.RaisePropertyChanged("numeroConta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string sinal
        {
            get
            {
                return this.sinalField;
            }
            set
            {
                this.sinalField = value;
                this.RaisePropertyChanged("sinal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public int valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
                this.RaisePropertyChanged("valorSpecified");
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
    public partial class perfilFinanceiroIdentificacaoEmpresa : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string blocoField;

        private string cnpjField;

        private System.DateTime dataAtualizacaoField;

        private bool dataAtualizacaoFieldSpecified;

        private string razaoSocialField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string bloco
        {
            get
            {
                return this.blocoField;
            }
            set
            {
                this.blocoField = value;
                this.RaisePropertyChanged("bloco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string cnpj
        {
            get
            {
                return this.cnpjField;
            }
            set
            {
                this.cnpjField = value;
                this.RaisePropertyChanged("cnpj");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public System.DateTime dataAtualizacao
        {
            get
            {
                return this.dataAtualizacaoField;
            }
            set
            {
                this.dataAtualizacaoField = value;
                this.RaisePropertyChanged("dataAtualizacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoSpecified
        {
            get
            {
                return this.dataAtualizacaoFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoFieldSpecified = value;
                this.RaisePropertyChanged("dataAtualizacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string razaoSocial
        {
            get
            {
                return this.razaoSocialField;
            }
            set
            {
                this.razaoSocialField = value;
                this.RaisePropertyChanged("razaoSocial");
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
    public partial class perfilFinanceiroFraseConclusao : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string blocoField;

        private string fraseConclusaoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string bloco
        {
            get
            {
                return this.blocoField;
            }
            set
            {
                this.blocoField = value;
                this.RaisePropertyChanged("bloco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string fraseConclusao
        {
            get
            {
                return this.fraseConclusaoField;
            }
            set
            {
                this.fraseConclusaoField = value;
                this.RaisePropertyChanged("fraseConclusao");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Perfil-Financeiro-PJ", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoPerfilFinanceiroPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private perfilFinanceiroFraseConclusao fraseconclusaoField;

        private perfilFinanceiroIdentificacaoEmpresa perfilfinanceiroidentificacaoempresaField;

        private perfilFinanceiroContasAtivo perfilfinanceirocontasativoField;

        private perfilFinanceiroContasAtivo[] perfilfinanceirocontasativosField;

        private perfilFinanceiroContasPassivo perfilfinanceirocontaspassivoField;

        private perfilFinanceiroContasPassivo[] perfilfinanceiroscontaspassivosField;

        private perfilFinanceiroResultado perfilfinanceiroresultadoField;

        private perfilFinanceiroResultado[] perfilfinanceiroresultadosField;

        private perfilFinanceiroIdentificacaoBalanco perfilfinanceiroidentificacaobalancoField;

        private perfilFinanceiroIndicesFinanceiroIntegrado perfilfinanceiroindicesintegradoField;

        private perfilFinanceiroIndicesFinanceiroIntegrado[] perfilfinanceiroindicesintegradosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("frase-conclusao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public perfilFinanceiroFraseConclusao fraseconclusao
        {
            get
            {
                return this.fraseconclusaoField;
            }
            set
            {
                this.fraseconclusaoField = value;
                this.RaisePropertyChanged("fraseconclusao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiro-identificacao-empresa", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public perfilFinanceiroIdentificacaoEmpresa perfilfinanceiroidentificacaoempresa
        {
            get
            {
                return this.perfilfinanceiroidentificacaoempresaField;
            }
            set
            {
                this.perfilfinanceiroidentificacaoempresaField = value;
                this.RaisePropertyChanged("perfilfinanceiroidentificacaoempresa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiro-contas-ativo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public perfilFinanceiroContasAtivo perfilfinanceirocontasativo
        {
            get
            {
                return this.perfilfinanceirocontasativoField;
            }
            set
            {
                this.perfilfinanceirocontasativoField = value;
                this.RaisePropertyChanged("perfilfinanceirocontasativo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiro-contas-ativos", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public perfilFinanceiroContasAtivo[] perfilfinanceirocontasativos
        {
            get
            {
                return this.perfilfinanceirocontasativosField;
            }
            set
            {
                this.perfilfinanceirocontasativosField = value;
                this.RaisePropertyChanged("perfilfinanceirocontasativos");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiro-contas-passivo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public perfilFinanceiroContasPassivo perfilfinanceirocontaspassivo
        {
            get
            {
                return this.perfilfinanceirocontaspassivoField;
            }
            set
            {
                this.perfilfinanceirocontaspassivoField = value;
                this.RaisePropertyChanged("perfilfinanceirocontaspassivo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiros-contas-passivos", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public perfilFinanceiroContasPassivo[] perfilfinanceiroscontaspassivos
        {
            get
            {
                return this.perfilfinanceiroscontaspassivosField;
            }
            set
            {
                this.perfilfinanceiroscontaspassivosField = value;
                this.RaisePropertyChanged("perfilfinanceiroscontaspassivos");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiro-resultado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public perfilFinanceiroResultado perfilfinanceiroresultado
        {
            get
            {
                return this.perfilfinanceiroresultadoField;
            }
            set
            {
                this.perfilfinanceiroresultadoField = value;
                this.RaisePropertyChanged("perfilfinanceiroresultado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiro-resultados", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public perfilFinanceiroResultado[] perfilfinanceiroresultados
        {
            get
            {
                return this.perfilfinanceiroresultadosField;
            }
            set
            {
                this.perfilfinanceiroresultadosField = value;
                this.RaisePropertyChanged("perfilfinanceiroresultados");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiro-identificacao-balanco", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public perfilFinanceiroIdentificacaoBalanco perfilfinanceiroidentificacaobalanco
        {
            get
            {
                return this.perfilfinanceiroidentificacaobalancoField;
            }
            set
            {
                this.perfilfinanceiroidentificacaobalancoField = value;
                this.RaisePropertyChanged("perfilfinanceiroidentificacaobalanco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiro-indices-integrado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public perfilFinanceiroIndicesFinanceiroIntegrado perfilfinanceiroindicesintegrado
        {
            get
            {
                return this.perfilfinanceiroindicesintegradoField;
            }
            set
            {
                this.perfilfinanceiroindicesintegradoField = value;
                this.RaisePropertyChanged("perfilfinanceiroindicesintegrado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiro-indices-integrados", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public perfilFinanceiroIndicesFinanceiroIntegrado[] perfilfinanceiroindicesintegrados
        {
            get
            {
                return this.perfilfinanceiroindicesintegradosField;
            }
            set
            {
                this.perfilfinanceiroindicesintegradosField = value;
                this.RaisePropertyChanged("perfilfinanceiroindicesintegrados");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Risco-Credito-PJ", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRiscoCreditoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int pontuacaoField;

        private bool pontuacaoFieldSpecified;

        private string probabilidadeInadimplenciaField;

        private string mensagemRetornoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int pontuacao
        {
            get
            {
                return this.pontuacaoField;
            }
            set
            {
                this.pontuacaoField = value;
                this.RaisePropertyChanged("pontuacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pontuacaoSpecified
        {
            get
            {
                return this.pontuacaoFieldSpecified;
            }
            set
            {
                this.pontuacaoFieldSpecified = value;
                this.RaisePropertyChanged("pontuacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string probabilidadeInadimplencia
        {
            get
            {
                return this.probabilidadeInadimplenciaField;
            }
            set
            {
                this.probabilidadeInadimplenciaField = value;
                this.RaisePropertyChanged("probabilidadeInadimplencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string mensagemRetorno
        {
            get
            {
                return this.mensagemRetornoField;
            }
            set
            {
                this.mensagemRetornoField = value;
                this.RaisePropertyChanged("mensagemRetorno");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Mensagem-Gasto-Estimado-PJ", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class MensagemGastoEstimadoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string retornoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string retorno
        {
            get
            {
                return this.retornoField;
            }
            set
            {
                this.retornoField = value;
                this.RaisePropertyChanged("retorno");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Gasto-Estimado-PJ", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoGastoEstimadoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private MensagemGastoEstimadoPJ mensagemField;

        private decimal valorField;

        private bool valorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public MensagemGastoEstimadoPJ mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
                this.RaisePropertyChanged("valorSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Faturamento-Presumido", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoFaturamentoPresumido : object, System.ComponentModel.INotifyPropertyChanged
    {

        private decimal valorfaturamentoField;

        private bool valorfaturamentoFieldSpecified;

        private string mensagemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-faturamento")]
        public decimal valorfaturamento
        {
            get
            {
                return this.valorfaturamentoField;
            }
            set
            {
                this.valorfaturamentoField = value;
                this.RaisePropertyChanged("valorfaturamento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorfaturamentoSpecified
        {
            get
            {
                return this.valorfaturamentoFieldSpecified;
            }
            set
            {
                this.valorfaturamentoFieldSpecified = value;
                this.RaisePropertyChanged("valorfaturamentoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Limite-Credito-PJ", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoLimiteCreditoPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime datacalculoField;

        private bool datacalculoFieldSpecified;

        private decimal valorlimitecreditoField;

        private bool valorlimitecreditoFieldSpecified;

        private string mensagemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-calculo")]
        public System.DateTime datacalculo
        {
            get
            {
                return this.datacalculoField;
            }
            set
            {
                this.datacalculoField = value;
                this.RaisePropertyChanged("datacalculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datacalculoSpecified
        {
            get
            {
                return this.datacalculoFieldSpecified;
            }
            set
            {
                this.datacalculoFieldSpecified = value;
                this.RaisePropertyChanged("datacalculoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-limite-credito")]
        public decimal valorlimitecredito
        {
            get
            {
                return this.valorlimitecreditoField;
            }
            set
            {
                this.valorlimitecreditoField = value;
                this.RaisePropertyChanged("valorlimitecredito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorlimitecreditoSpecified
        {
            get
            {
                return this.valorlimitecreditoFieldSpecified;
            }
            set
            {
                this.valorlimitecreditoFieldSpecified = value;
                this.RaisePropertyChanged("valorlimitecreditoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Alerta-Identidade", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoAlertaIdentidade : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string mensagemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Observacao-Alerta-Obito", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ObservacaoAlertaObito : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codigoalertaField;

        private string mensagemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("codigo-alerta")]
        public string codigoalerta
        {
            get
            {
                return this.codigoalertaField;
            }
            set
            {
                this.codigoalertaField = value;
                this.RaisePropertyChanged("codigoalerta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Alerta-Obito", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoAlertaObito : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ObservacaoAlertaObito[] alertasField;

        private string msgobitoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alertas", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public ObservacaoAlertaObito[] alertas
        {
            get
            {
                return this.alertasField;
            }
            set
            {
                this.alertasField = value;
                this.RaisePropertyChanged("alertas");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("msg-obito")]
        public string msgobito
        {
            get
            {
                return this.msgobitoField;
            }
            set
            {
                this.msgobitoField = value;
                this.RaisePropertyChanged("msgobito");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Telefone-Alternativo", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoTelefoneAlternativo : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Telefone telefoneField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Telefone telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
                this.RaisePropertyChanged("telefone");
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
    public partial class Telefone : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int numerodddField;

        private bool numerodddFieldSpecified;

        private long numeroField;

        private bool numeroFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-ddd")]
        public int numeroddd
        {
            get
            {
                return this.numerodddField;
            }
            set
            {
                this.numerodddField = value;
                this.RaisePropertyChanged("numeroddd");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numerodddSpecified
        {
            get
            {
                return this.numerodddFieldSpecified;
            }
            set
            {
                this.numerodddFieldSpecified = value;
                this.RaisePropertyChanged("numerodddSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
                this.RaisePropertyChanged("numero");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroSpecified
        {
            get
            {
                return this.numeroFieldSpecified;
            }
            set
            {
                this.numeroFieldSpecified = value;
                this.RaisePropertyChanged("numeroSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Informacoes-Complementares", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoInformacoesComplementares : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string numerofuncionariosField;

        private string porteempresaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-funcionarios")]
        public string numerofuncionarios
        {
            get
            {
                return this.numerofuncionariosField;
            }
            set
            {
                this.numerofuncionariosField = value;
                this.RaisePropertyChanged("numerofuncionarios");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("porte-empresa")]
        public string porteempresa
        {
            get
            {
                return this.porteempresaField;
            }
            set
            {
                this.porteempresaField = value;
                this.RaisePropertyChanged("porteempresa");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Ocupacao", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoOcupacao : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string escolaridadeField;

        private string profissaoField;

        private string cargoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string escolaridade
        {
            get
            {
                return this.escolaridadeField;
            }
            set
            {
                this.escolaridadeField = value;
                this.RaisePropertyChanged("escolaridade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string profissao
        {
            get
            {
                return this.profissaoField;
            }
            set
            {
                this.profissaoField = value;
                this.RaisePropertyChanged("profissao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cargo
        {
            get
            {
                return this.cargoField;
            }
            set
            {
                this.cargoField = value;
                this.RaisePropertyChanged("cargo");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Limite-Credito-Sugerido", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoLimiteCreditoSugerido : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string mensagemField;

        private decimal limitesugeridoField;

        private bool limitesugeridoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
                this.RaisePropertyChanged("mensagem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("limite-sugerido")]
        public decimal limitesugerido
        {
            get
            {
                return this.limitesugeridoField;
            }
            set
            {
                this.limitesugeridoField = value;
                this.RaisePropertyChanged("limitesugerido");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool limitesugeridoSpecified
        {
            get
            {
                return this.limitesugeridoFieldSpecified;
            }
            set
            {
                this.limitesugeridoFieldSpecified = value;
                this.RaisePropertyChanged("limitesugeridoSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "faixa-renda-presumida", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class faixarendapresumida : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codeField;

        private long idField;

        private bool idFieldSpecified;

        private string descricaoField;

        private double probabilidadeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
                this.RaisePropertyChanged("descricao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double probabilidade
        {
            get
            {
                return this.probabilidadeField;
            }
            set
            {
                this.probabilidadeField = value;
                this.RaisePropertyChanged("probabilidade");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Renda-Presumida-Spc", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRendaPresumidaSpc : object, System.ComponentModel.INotifyPropertyChanged
    {

        private faixarendapresumida[] faixarendaField;

        private string mensagemfornecedorField;

        private double medianaField;

        private bool medianaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("faixa-renda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public faixarendapresumida[] faixarenda
        {
            get
            {
                return this.faixarendaField;
            }
            set
            {
                this.faixarendaField = value;
                this.RaisePropertyChanged("faixarenda");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mensagem-fornecedor")]
        public string mensagemfornecedor
        {
            get
            {
                return this.mensagemfornecedorField;
            }
            set
            {
                this.mensagemfornecedorField = value;
                this.RaisePropertyChanged("mensagemfornecedor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double mediana
        {
            get
            {
                return this.medianaField;
            }
            set
            {
                this.medianaField = value;
                this.RaisePropertyChanged("mediana");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool medianaSpecified
        {
            get
            {
                return this.medianaFieldSpecified;
            }
            set
            {
                this.medianaFieldSpecified = value;
                this.RaisePropertyChanged("medianaSpecified");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoRouboFurto))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoSPCAutoLocaliza))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoGravame))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoDpvat))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoRenavamEstadual))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoRenavamFederal))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public abstract partial class abstractInsumoSPCAuto : object, System.ComponentModel.INotifyPropertyChanged
    {

        private long idAgenteGeradorField;

        private bool idAgenteGeradorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public long idAgenteGerador
        {
            get
            {
                return this.idAgenteGeradorField;
            }
            set
            {
                this.idAgenteGeradorField = value;
                this.RaisePropertyChanged("idAgenteGerador");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idAgenteGeradorSpecified
        {
            get
            {
                return this.idAgenteGeradorFieldSpecified;
            }
            set
            {
                this.idAgenteGeradorFieldSpecified = value;
                this.RaisePropertyChanged("idAgenteGeradorSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Roubo-Furto", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRouboFurto : abstractInsumoSPCAuto
    {

        private string chassiField;

        private string placaField;

        private string ufplacaField;

        private string municipioemplacamentoField;

        private string marcamodeloField;

        private string corveiculoField;

        private string anomodeloField;

        private string anofabricacaoField;

        private string ocorrenciaField;

        private string dataocorrenciaField;

        private string boletimocorrenciaField;

        private string anoocorrenciaField;

        private string ufocorrenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string chassi
        {
            get
            {
                return this.chassiField;
            }
            set
            {
                this.chassiField = value;
                this.RaisePropertyChanged("chassi");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string placa
        {
            get
            {
                return this.placaField;
            }
            set
            {
                this.placaField = value;
                this.RaisePropertyChanged("placa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("uf-placa")]
        public string ufplaca
        {
            get
            {
                return this.ufplacaField;
            }
            set
            {
                this.ufplacaField = value;
                this.RaisePropertyChanged("ufplaca");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("municipio-emplacamento")]
        public string municipioemplacamento
        {
            get
            {
                return this.municipioemplacamentoField;
            }
            set
            {
                this.municipioemplacamentoField = value;
                this.RaisePropertyChanged("municipioemplacamento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("marca-modelo")]
        public string marcamodelo
        {
            get
            {
                return this.marcamodeloField;
            }
            set
            {
                this.marcamodeloField = value;
                this.RaisePropertyChanged("marcamodelo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("cor-veiculo")]
        public string corveiculo
        {
            get
            {
                return this.corveiculoField;
            }
            set
            {
                this.corveiculoField = value;
                this.RaisePropertyChanged("corveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ano-modelo")]
        public string anomodelo
        {
            get
            {
                return this.anomodeloField;
            }
            set
            {
                this.anomodeloField = value;
                this.RaisePropertyChanged("anomodelo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ano-fabricacao")]
        public string anofabricacao
        {
            get
            {
                return this.anofabricacaoField;
            }
            set
            {
                this.anofabricacaoField = value;
                this.RaisePropertyChanged("anofabricacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ocorrencia
        {
            get
            {
                return this.ocorrenciaField;
            }
            set
            {
                this.ocorrenciaField = value;
                this.RaisePropertyChanged("ocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ocorrencia")]
        public string dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
                this.RaisePropertyChanged("dataocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("boletim-ocorrencia")]
        public string boletimocorrencia
        {
            get
            {
                return this.boletimocorrenciaField;
            }
            set
            {
                this.boletimocorrenciaField = value;
                this.RaisePropertyChanged("boletimocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ano-ocorrencia")]
        public string anoocorrencia
        {
            get
            {
                return this.anoocorrenciaField;
            }
            set
            {
                this.anoocorrenciaField = value;
                this.RaisePropertyChanged("anoocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("uf-ocorrencia")]
        public string ufocorrencia
        {
            get
            {
                return this.ufocorrenciaField;
            }
            set
            {
                this.ufocorrenciaField = value;
                this.RaisePropertyChanged("ufocorrencia");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-SPCAutoLocaliza", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoSPCAutoLocaliza : abstractInsumoSPCAuto
    {

        private string nomeproprietarioField;

        private string placaField;

        private int renavamField;

        private bool renavamFieldSpecified;

        private string chassiField;

        private int numerodutField;

        private bool numerodutFieldSpecified;

        private int anoexercicioField;

        private bool anoexercicioFieldSpecified;

        private string dataprocessamentoField;

        private int idpagamentodutField;

        private bool idpagamentodutFieldSpecified;

        private int numerobancoField;

        private bool numerobancoFieldSpecified;

        private string ufdutField;

        private string documentoField;

        private string dataemissaoguiaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-proprietario")]
        public string nomeproprietario
        {
            get
            {
                return this.nomeproprietarioField;
            }
            set
            {
                this.nomeproprietarioField = value;
                this.RaisePropertyChanged("nomeproprietario");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string placa
        {
            get
            {
                return this.placaField;
            }
            set
            {
                this.placaField = value;
                this.RaisePropertyChanged("placa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int renavam
        {
            get
            {
                return this.renavamField;
            }
            set
            {
                this.renavamField = value;
                this.RaisePropertyChanged("renavam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool renavamSpecified
        {
            get
            {
                return this.renavamFieldSpecified;
            }
            set
            {
                this.renavamFieldSpecified = value;
                this.RaisePropertyChanged("renavamSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string chassi
        {
            get
            {
                return this.chassiField;
            }
            set
            {
                this.chassiField = value;
                this.RaisePropertyChanged("chassi");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-dut")]
        public int numerodut
        {
            get
            {
                return this.numerodutField;
            }
            set
            {
                this.numerodutField = value;
                this.RaisePropertyChanged("numerodut");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numerodutSpecified
        {
            get
            {
                return this.numerodutFieldSpecified;
            }
            set
            {
                this.numerodutFieldSpecified = value;
                this.RaisePropertyChanged("numerodutSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ano-exercicio")]
        public int anoexercicio
        {
            get
            {
                return this.anoexercicioField;
            }
            set
            {
                this.anoexercicioField = value;
                this.RaisePropertyChanged("anoexercicio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool anoexercicioSpecified
        {
            get
            {
                return this.anoexercicioFieldSpecified;
            }
            set
            {
                this.anoexercicioFieldSpecified = value;
                this.RaisePropertyChanged("anoexercicioSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-processamento")]
        public string dataprocessamento
        {
            get
            {
                return this.dataprocessamentoField;
            }
            set
            {
                this.dataprocessamentoField = value;
                this.RaisePropertyChanged("dataprocessamento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id-pagamento-dut")]
        public int idpagamentodut
        {
            get
            {
                return this.idpagamentodutField;
            }
            set
            {
                this.idpagamentodutField = value;
                this.RaisePropertyChanged("idpagamentodut");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idpagamentodutSpecified
        {
            get
            {
                return this.idpagamentodutFieldSpecified;
            }
            set
            {
                this.idpagamentodutFieldSpecified = value;
                this.RaisePropertyChanged("idpagamentodutSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-banco")]
        public int numerobanco
        {
            get
            {
                return this.numerobancoField;
            }
            set
            {
                this.numerobancoField = value;
                this.RaisePropertyChanged("numerobanco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numerobancoSpecified
        {
            get
            {
                return this.numerobancoFieldSpecified;
            }
            set
            {
                this.numerobancoFieldSpecified = value;
                this.RaisePropertyChanged("numerobancoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("uf-dut")]
        public string ufdut
        {
            get
            {
                return this.ufdutField;
            }
            set
            {
                this.ufdutField = value;
                this.RaisePropertyChanged("ufdut");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
                this.RaisePropertyChanged("documento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-emissao-guia")]
        public string dataemissaoguia
        {
            get
            {
                return this.dataemissaoguiaField;
            }
            set
            {
                this.dataemissaoguiaField = value;
                this.RaisePropertyChanged("dataemissaoguia");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Gravame", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoGravame : abstractInsumoSPCAuto
    {

        private string chassiField;

        private string remarcacaochassiField;

        private int renavamField;

        private bool renavamFieldSpecified;

        private string statusveiculoField;

        private string ufplacaField;

        private string placaField;

        private string uflicenciamentoField;

        private string documentofinanciadoField;

        private string nomefinanciadoField;

        private string nomeagenteField;

        private string documentoagenteField;

        private string datainclusaogravameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string chassi
        {
            get
            {
                return this.chassiField;
            }
            set
            {
                this.chassiField = value;
                this.RaisePropertyChanged("chassi");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("remarcacao-chassi")]
        public string remarcacaochassi
        {
            get
            {
                return this.remarcacaochassiField;
            }
            set
            {
                this.remarcacaochassiField = value;
                this.RaisePropertyChanged("remarcacaochassi");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int renavam
        {
            get
            {
                return this.renavamField;
            }
            set
            {
                this.renavamField = value;
                this.RaisePropertyChanged("renavam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool renavamSpecified
        {
            get
            {
                return this.renavamFieldSpecified;
            }
            set
            {
                this.renavamFieldSpecified = value;
                this.RaisePropertyChanged("renavamSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("status-veiculo")]
        public string statusveiculo
        {
            get
            {
                return this.statusveiculoField;
            }
            set
            {
                this.statusveiculoField = value;
                this.RaisePropertyChanged("statusveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("uf-placa")]
        public string ufplaca
        {
            get
            {
                return this.ufplacaField;
            }
            set
            {
                this.ufplacaField = value;
                this.RaisePropertyChanged("ufplaca");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string placa
        {
            get
            {
                return this.placaField;
            }
            set
            {
                this.placaField = value;
                this.RaisePropertyChanged("placa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("uf-licenciamento")]
        public string uflicenciamento
        {
            get
            {
                return this.uflicenciamentoField;
            }
            set
            {
                this.uflicenciamentoField = value;
                this.RaisePropertyChanged("uflicenciamento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("documento-financiado")]
        public string documentofinanciado
        {
            get
            {
                return this.documentofinanciadoField;
            }
            set
            {
                this.documentofinanciadoField = value;
                this.RaisePropertyChanged("documentofinanciado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-financiado")]
        public string nomefinanciado
        {
            get
            {
                return this.nomefinanciadoField;
            }
            set
            {
                this.nomefinanciadoField = value;
                this.RaisePropertyChanged("nomefinanciado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-agente")]
        public string nomeagente
        {
            get
            {
                return this.nomeagenteField;
            }
            set
            {
                this.nomeagenteField = value;
                this.RaisePropertyChanged("nomeagente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("documento-agente")]
        public string documentoagente
        {
            get
            {
                return this.documentoagenteField;
            }
            set
            {
                this.documentoagenteField = value;
                this.RaisePropertyChanged("documentoagente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-inclusao-gravame")]
        public string datainclusaogravame
        {
            get
            {
                return this.datainclusaogravameField;
            }
            set
            {
                this.datainclusaogravameField = value;
                this.RaisePropertyChanged("datainclusaogravame");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Dpvat", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoDpvat : abstractInsumoSPCAuto
    {

        private string nomeproprietarioField;

        private string documentoField;

        private int renavamField;

        private bool renavamFieldSpecified;

        private int numerodutField;

        private bool numerodutFieldSpecified;

        private string ufField;

        private string placaField;

        private int exercicioField;

        private bool exercicioFieldSpecified;

        private string datapagamentoField;

        private string dataprocessamentoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-proprietario")]
        public string nomeproprietario
        {
            get
            {
                return this.nomeproprietarioField;
            }
            set
            {
                this.nomeproprietarioField = value;
                this.RaisePropertyChanged("nomeproprietario");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
                this.RaisePropertyChanged("documento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int renavam
        {
            get
            {
                return this.renavamField;
            }
            set
            {
                this.renavamField = value;
                this.RaisePropertyChanged("renavam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool renavamSpecified
        {
            get
            {
                return this.renavamFieldSpecified;
            }
            set
            {
                this.renavamFieldSpecified = value;
                this.RaisePropertyChanged("renavamSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-dut")]
        public int numerodut
        {
            get
            {
                return this.numerodutField;
            }
            set
            {
                this.numerodutField = value;
                this.RaisePropertyChanged("numerodut");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numerodutSpecified
        {
            get
            {
                return this.numerodutFieldSpecified;
            }
            set
            {
                this.numerodutFieldSpecified = value;
                this.RaisePropertyChanged("numerodutSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
                this.RaisePropertyChanged("uf");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string placa
        {
            get
            {
                return this.placaField;
            }
            set
            {
                this.placaField = value;
                this.RaisePropertyChanged("placa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int exercicio
        {
            get
            {
                return this.exercicioField;
            }
            set
            {
                this.exercicioField = value;
                this.RaisePropertyChanged("exercicio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exercicioSpecified
        {
            get
            {
                return this.exercicioFieldSpecified;
            }
            set
            {
                this.exercicioFieldSpecified = value;
                this.RaisePropertyChanged("exercicioSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-pagamento")]
        public string datapagamento
        {
            get
            {
                return this.datapagamentoField;
            }
            set
            {
                this.datapagamentoField = value;
                this.RaisePropertyChanged("datapagamento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-processamento")]
        public string dataprocessamento
        {
            get
            {
                return this.dataprocessamentoField;
            }
            set
            {
                this.dataprocessamentoField = value;
                this.RaisePropertyChanged("dataprocessamento");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Renavam-Estadual", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRenavamEstadual : abstractInsumoSPCAuto
    {

        private string chassiField;

        private string placaField;

        private string ufplacaField;

        private string motorField;

        private string caixacambioField;

        private int renavamField;

        private bool renavamFieldSpecified;

        private string municipioField;

        private string situacaoveiculoField;

        private string remarcacaochassiField;

        private string categoriaveiculoField;

        private string tipoveiculoField;

        private string marcamodeloField;

        private string especieveiculoField;

        private string tipocarroceriaField;

        private string corveiculoField;

        private int anomodeloField;

        private bool anomodeloFieldSpecified;

        private int anofabricacaoField;

        private bool anofabricacaoFieldSpecified;

        private int potenciaveiculoField;

        private bool potenciaveiculoFieldSpecified;

        private int cilindradasField;

        private bool cilindradasFieldSpecified;

        private string combustivelField;

        private decimal tracaoveiculoField;

        private bool tracaoveiculoFieldSpecified;

        private decimal pesobrutoveiculoField;

        private bool pesobrutoveiculoFieldSpecified;

        private decimal capacidadecargaField;

        private bool capacidadecargaFieldSpecified;

        private string procedenciaField;

        private string documentoproprietarioField;

        private string numerocarroceriaField;

        private int quantidadepassageirosField;

        private bool quantidadepassageirosFieldSpecified;

        private string restricao1Field;

        private string restricao2Field;

        private string restricao3Field;

        private string restricao4Field;

        private int numeroeixoField;

        private bool numeroeixoFieldSpecified;

        private string numeroeixotraseiroField;

        private string numeroeixoauxiliarField;

        private string nomeproprietarioField;

        private string debitoipvaField;

        private string descricaodebitoipvaField;

        private string debitomultasField;

        private string descricaodebitomultasField;

        private string datalimiteresttribField;

        private string dataultimaatualizacaoField;

        private string debitodpvatField;

        private string debitolicenciamentoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string chassi
        {
            get
            {
                return this.chassiField;
            }
            set
            {
                this.chassiField = value;
                this.RaisePropertyChanged("chassi");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string placa
        {
            get
            {
                return this.placaField;
            }
            set
            {
                this.placaField = value;
                this.RaisePropertyChanged("placa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("uf-placa")]
        public string ufplaca
        {
            get
            {
                return this.ufplacaField;
            }
            set
            {
                this.ufplacaField = value;
                this.RaisePropertyChanged("ufplaca");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string motor
        {
            get
            {
                return this.motorField;
            }
            set
            {
                this.motorField = value;
                this.RaisePropertyChanged("motor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("caixa-cambio")]
        public string caixacambio
        {
            get
            {
                return this.caixacambioField;
            }
            set
            {
                this.caixacambioField = value;
                this.RaisePropertyChanged("caixacambio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int renavam
        {
            get
            {
                return this.renavamField;
            }
            set
            {
                this.renavamField = value;
                this.RaisePropertyChanged("renavam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool renavamSpecified
        {
            get
            {
                return this.renavamFieldSpecified;
            }
            set
            {
                this.renavamFieldSpecified = value;
                this.RaisePropertyChanged("renavamSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string municipio
        {
            get
            {
                return this.municipioField;
            }
            set
            {
                this.municipioField = value;
                this.RaisePropertyChanged("municipio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("situacao-veiculo")]
        public string situacaoveiculo
        {
            get
            {
                return this.situacaoveiculoField;
            }
            set
            {
                this.situacaoveiculoField = value;
                this.RaisePropertyChanged("situacaoveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("remarcacao-chassi")]
        public string remarcacaochassi
        {
            get
            {
                return this.remarcacaochassiField;
            }
            set
            {
                this.remarcacaochassiField = value;
                this.RaisePropertyChanged("remarcacaochassi");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("categoria-veiculo")]
        public string categoriaveiculo
        {
            get
            {
                return this.categoriaveiculoField;
            }
            set
            {
                this.categoriaveiculoField = value;
                this.RaisePropertyChanged("categoriaveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-veiculo")]
        public string tipoveiculo
        {
            get
            {
                return this.tipoveiculoField;
            }
            set
            {
                this.tipoveiculoField = value;
                this.RaisePropertyChanged("tipoveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("marca-modelo")]
        public string marcamodelo
        {
            get
            {
                return this.marcamodeloField;
            }
            set
            {
                this.marcamodeloField = value;
                this.RaisePropertyChanged("marcamodelo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("especie-veiculo")]
        public string especieveiculo
        {
            get
            {
                return this.especieveiculoField;
            }
            set
            {
                this.especieveiculoField = value;
                this.RaisePropertyChanged("especieveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-carroceria")]
        public string tipocarroceria
        {
            get
            {
                return this.tipocarroceriaField;
            }
            set
            {
                this.tipocarroceriaField = value;
                this.RaisePropertyChanged("tipocarroceria");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("cor-veiculo")]
        public string corveiculo
        {
            get
            {
                return this.corveiculoField;
            }
            set
            {
                this.corveiculoField = value;
                this.RaisePropertyChanged("corveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ano-modelo")]
        public int anomodelo
        {
            get
            {
                return this.anomodeloField;
            }
            set
            {
                this.anomodeloField = value;
                this.RaisePropertyChanged("anomodelo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool anomodeloSpecified
        {
            get
            {
                return this.anomodeloFieldSpecified;
            }
            set
            {
                this.anomodeloFieldSpecified = value;
                this.RaisePropertyChanged("anomodeloSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ano-fabricacao")]
        public int anofabricacao
        {
            get
            {
                return this.anofabricacaoField;
            }
            set
            {
                this.anofabricacaoField = value;
                this.RaisePropertyChanged("anofabricacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool anofabricacaoSpecified
        {
            get
            {
                return this.anofabricacaoFieldSpecified;
            }
            set
            {
                this.anofabricacaoFieldSpecified = value;
                this.RaisePropertyChanged("anofabricacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("potencia-veiculo")]
        public int potenciaveiculo
        {
            get
            {
                return this.potenciaveiculoField;
            }
            set
            {
                this.potenciaveiculoField = value;
                this.RaisePropertyChanged("potenciaveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool potenciaveiculoSpecified
        {
            get
            {
                return this.potenciaveiculoFieldSpecified;
            }
            set
            {
                this.potenciaveiculoFieldSpecified = value;
                this.RaisePropertyChanged("potenciaveiculoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int cilindradas
        {
            get
            {
                return this.cilindradasField;
            }
            set
            {
                this.cilindradasField = value;
                this.RaisePropertyChanged("cilindradas");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cilindradasSpecified
        {
            get
            {
                return this.cilindradasFieldSpecified;
            }
            set
            {
                this.cilindradasFieldSpecified = value;
                this.RaisePropertyChanged("cilindradasSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string combustivel
        {
            get
            {
                return this.combustivelField;
            }
            set
            {
                this.combustivelField = value;
                this.RaisePropertyChanged("combustivel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tracao-veiculo")]
        public decimal tracaoveiculo
        {
            get
            {
                return this.tracaoveiculoField;
            }
            set
            {
                this.tracaoveiculoField = value;
                this.RaisePropertyChanged("tracaoveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tracaoveiculoSpecified
        {
            get
            {
                return this.tracaoveiculoFieldSpecified;
            }
            set
            {
                this.tracaoveiculoFieldSpecified = value;
                this.RaisePropertyChanged("tracaoveiculoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("peso-bruto-veiculo")]
        public decimal pesobrutoveiculo
        {
            get
            {
                return this.pesobrutoveiculoField;
            }
            set
            {
                this.pesobrutoveiculoField = value;
                this.RaisePropertyChanged("pesobrutoveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pesobrutoveiculoSpecified
        {
            get
            {
                return this.pesobrutoveiculoFieldSpecified;
            }
            set
            {
                this.pesobrutoveiculoFieldSpecified = value;
                this.RaisePropertyChanged("pesobrutoveiculoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("capacidade-carga")]
        public decimal capacidadecarga
        {
            get
            {
                return this.capacidadecargaField;
            }
            set
            {
                this.capacidadecargaField = value;
                this.RaisePropertyChanged("capacidadecarga");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool capacidadecargaSpecified
        {
            get
            {
                return this.capacidadecargaFieldSpecified;
            }
            set
            {
                this.capacidadecargaFieldSpecified = value;
                this.RaisePropertyChanged("capacidadecargaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string procedencia
        {
            get
            {
                return this.procedenciaField;
            }
            set
            {
                this.procedenciaField = value;
                this.RaisePropertyChanged("procedencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("documento-proprietario")]
        public string documentoproprietario
        {
            get
            {
                return this.documentoproprietarioField;
            }
            set
            {
                this.documentoproprietarioField = value;
                this.RaisePropertyChanged("documentoproprietario");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-carroceria")]
        public string numerocarroceria
        {
            get
            {
                return this.numerocarroceriaField;
            }
            set
            {
                this.numerocarroceriaField = value;
                this.RaisePropertyChanged("numerocarroceria");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-passageiros")]
        public int quantidadepassageiros
        {
            get
            {
                return this.quantidadepassageirosField;
            }
            set
            {
                this.quantidadepassageirosField = value;
                this.RaisePropertyChanged("quantidadepassageiros");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadepassageirosSpecified
        {
            get
            {
                return this.quantidadepassageirosFieldSpecified;
            }
            set
            {
                this.quantidadepassageirosFieldSpecified = value;
                this.RaisePropertyChanged("quantidadepassageirosSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string restricao1
        {
            get
            {
                return this.restricao1Field;
            }
            set
            {
                this.restricao1Field = value;
                this.RaisePropertyChanged("restricao1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string restricao2
        {
            get
            {
                return this.restricao2Field;
            }
            set
            {
                this.restricao2Field = value;
                this.RaisePropertyChanged("restricao2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string restricao3
        {
            get
            {
                return this.restricao3Field;
            }
            set
            {
                this.restricao3Field = value;
                this.RaisePropertyChanged("restricao3");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string restricao4
        {
            get
            {
                return this.restricao4Field;
            }
            set
            {
                this.restricao4Field = value;
                this.RaisePropertyChanged("restricao4");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-eixo")]
        public int numeroeixo
        {
            get
            {
                return this.numeroeixoField;
            }
            set
            {
                this.numeroeixoField = value;
                this.RaisePropertyChanged("numeroeixo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroeixoSpecified
        {
            get
            {
                return this.numeroeixoFieldSpecified;
            }
            set
            {
                this.numeroeixoFieldSpecified = value;
                this.RaisePropertyChanged("numeroeixoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-eixo-traseiro")]
        public string numeroeixotraseiro
        {
            get
            {
                return this.numeroeixotraseiroField;
            }
            set
            {
                this.numeroeixotraseiroField = value;
                this.RaisePropertyChanged("numeroeixotraseiro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-eixo-auxiliar")]
        public string numeroeixoauxiliar
        {
            get
            {
                return this.numeroeixoauxiliarField;
            }
            set
            {
                this.numeroeixoauxiliarField = value;
                this.RaisePropertyChanged("numeroeixoauxiliar");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-proprietario")]
        public string nomeproprietario
        {
            get
            {
                return this.nomeproprietarioField;
            }
            set
            {
                this.nomeproprietarioField = value;
                this.RaisePropertyChanged("nomeproprietario");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("debito-ipva")]
        public string debitoipva
        {
            get
            {
                return this.debitoipvaField;
            }
            set
            {
                this.debitoipvaField = value;
                this.RaisePropertyChanged("debitoipva");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("descricao-debito-ipva")]
        public string descricaodebitoipva
        {
            get
            {
                return this.descricaodebitoipvaField;
            }
            set
            {
                this.descricaodebitoipvaField = value;
                this.RaisePropertyChanged("descricaodebitoipva");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("debito-multas")]
        public string debitomultas
        {
            get
            {
                return this.debitomultasField;
            }
            set
            {
                this.debitomultasField = value;
                this.RaisePropertyChanged("debitomultas");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("descricao-debito-multas")]
        public string descricaodebitomultas
        {
            get
            {
                return this.descricaodebitomultasField;
            }
            set
            {
                this.descricaodebitomultasField = value;
                this.RaisePropertyChanged("descricaodebitomultas");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-limite-rest-trib")]
        public string datalimiteresttrib
        {
            get
            {
                return this.datalimiteresttribField;
            }
            set
            {
                this.datalimiteresttribField = value;
                this.RaisePropertyChanged("datalimiteresttrib");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ultima-atualizacao")]
        public string dataultimaatualizacao
        {
            get
            {
                return this.dataultimaatualizacaoField;
            }
            set
            {
                this.dataultimaatualizacaoField = value;
                this.RaisePropertyChanged("dataultimaatualizacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("debito-dpvat")]
        public string debitodpvat
        {
            get
            {
                return this.debitodpvatField;
            }
            set
            {
                this.debitodpvatField = value;
                this.RaisePropertyChanged("debitodpvat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("debito-licenciamento")]
        public string debitolicenciamento
        {
            get
            {
                return this.debitolicenciamentoField;
            }
            set
            {
                this.debitolicenciamentoField = value;
                this.RaisePropertyChanged("debitolicenciamento");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Renavam-Federal", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRenavamFederal : abstractInsumoSPCAuto
    {

        private string chassiField;

        private string placaField;

        private string ufplacaField;

        private string motorField;

        private string caixacambioField;

        private int renavamField;

        private bool renavamFieldSpecified;

        private string municipioField;

        private string situacaoveiculoField;

        private string remarcacaochassiField;

        private string tipomontagemField;

        private string tipoveiculoField;

        private string marcamodeloField;

        private string especieveiculoField;

        private string tipocarroceriaField;

        private string corveiculoField;

        private int anomodeloField;

        private bool anomodeloFieldSpecified;

        private int anofabricacaoField;

        private bool anofabricacaoFieldSpecified;

        private int potenciaveiculoField;

        private bool potenciaveiculoFieldSpecified;

        private int cilindradasField;

        private bool cilindradasFieldSpecified;

        private string combustivelField;

        private decimal tracaoveiculoField;

        private bool tracaoveiculoFieldSpecified;

        private decimal pesobrutoveiculoField;

        private bool pesobrutoveiculoFieldSpecified;

        private decimal capacidadecargaField;

        private bool capacidadecargaFieldSpecified;

        private string procedenciaField;

        private string documentoproprietarioField;

        private string nomeproprietarioField;

        private string numerocarroceriaField;

        private int quantidadepassageirosField;

        private bool quantidadepassageirosFieldSpecified;

        private string restricao1Field;

        private string restricao2Field;

        private string restricao3Field;

        private string restricao4Field;

        private int numeroeixoField;

        private bool numeroeixoFieldSpecified;

        private string numeroeixotraseiroField;

        private string numeroeixoauxiliarField;

        private string documentoimportadorField;

        private string nomeimportadorField;

        private string liberadopeloorgaoField;

        private string numeroredaaduaneiroField;

        private string numerodeclarimportacaoField;

        private string dataregistroaduaneiraField;

        private string numeroidfaturadoField;

        private string nomefaturadoField;

        private string ufdestfaturamentoField;

        private string datalimiteresttribField;

        private string tipooperacaoimpveiculoField;

        private string numeroprocessoimportacaoField;

        private string dataultimaatualizacaoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string chassi
        {
            get
            {
                return this.chassiField;
            }
            set
            {
                this.chassiField = value;
                this.RaisePropertyChanged("chassi");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string placa
        {
            get
            {
                return this.placaField;
            }
            set
            {
                this.placaField = value;
                this.RaisePropertyChanged("placa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("uf-placa")]
        public string ufplaca
        {
            get
            {
                return this.ufplacaField;
            }
            set
            {
                this.ufplacaField = value;
                this.RaisePropertyChanged("ufplaca");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string motor
        {
            get
            {
                return this.motorField;
            }
            set
            {
                this.motorField = value;
                this.RaisePropertyChanged("motor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("caixa-cambio")]
        public string caixacambio
        {
            get
            {
                return this.caixacambioField;
            }
            set
            {
                this.caixacambioField = value;
                this.RaisePropertyChanged("caixacambio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int renavam
        {
            get
            {
                return this.renavamField;
            }
            set
            {
                this.renavamField = value;
                this.RaisePropertyChanged("renavam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool renavamSpecified
        {
            get
            {
                return this.renavamFieldSpecified;
            }
            set
            {
                this.renavamFieldSpecified = value;
                this.RaisePropertyChanged("renavamSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string municipio
        {
            get
            {
                return this.municipioField;
            }
            set
            {
                this.municipioField = value;
                this.RaisePropertyChanged("municipio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("situacao-veiculo")]
        public string situacaoveiculo
        {
            get
            {
                return this.situacaoveiculoField;
            }
            set
            {
                this.situacaoveiculoField = value;
                this.RaisePropertyChanged("situacaoveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("remarcacao-chassi")]
        public string remarcacaochassi
        {
            get
            {
                return this.remarcacaochassiField;
            }
            set
            {
                this.remarcacaochassiField = value;
                this.RaisePropertyChanged("remarcacaochassi");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-montagem")]
        public string tipomontagem
        {
            get
            {
                return this.tipomontagemField;
            }
            set
            {
                this.tipomontagemField = value;
                this.RaisePropertyChanged("tipomontagem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-veiculo")]
        public string tipoveiculo
        {
            get
            {
                return this.tipoveiculoField;
            }
            set
            {
                this.tipoveiculoField = value;
                this.RaisePropertyChanged("tipoveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("marca-modelo")]
        public string marcamodelo
        {
            get
            {
                return this.marcamodeloField;
            }
            set
            {
                this.marcamodeloField = value;
                this.RaisePropertyChanged("marcamodelo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("especie-veiculo")]
        public string especieveiculo
        {
            get
            {
                return this.especieveiculoField;
            }
            set
            {
                this.especieveiculoField = value;
                this.RaisePropertyChanged("especieveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-carroceria")]
        public string tipocarroceria
        {
            get
            {
                return this.tipocarroceriaField;
            }
            set
            {
                this.tipocarroceriaField = value;
                this.RaisePropertyChanged("tipocarroceria");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("cor-veiculo")]
        public string corveiculo
        {
            get
            {
                return this.corveiculoField;
            }
            set
            {
                this.corveiculoField = value;
                this.RaisePropertyChanged("corveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ano-modelo")]
        public int anomodelo
        {
            get
            {
                return this.anomodeloField;
            }
            set
            {
                this.anomodeloField = value;
                this.RaisePropertyChanged("anomodelo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool anomodeloSpecified
        {
            get
            {
                return this.anomodeloFieldSpecified;
            }
            set
            {
                this.anomodeloFieldSpecified = value;
                this.RaisePropertyChanged("anomodeloSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ano-fabricacao")]
        public int anofabricacao
        {
            get
            {
                return this.anofabricacaoField;
            }
            set
            {
                this.anofabricacaoField = value;
                this.RaisePropertyChanged("anofabricacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool anofabricacaoSpecified
        {
            get
            {
                return this.anofabricacaoFieldSpecified;
            }
            set
            {
                this.anofabricacaoFieldSpecified = value;
                this.RaisePropertyChanged("anofabricacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("potencia-veiculo")]
        public int potenciaveiculo
        {
            get
            {
                return this.potenciaveiculoField;
            }
            set
            {
                this.potenciaveiculoField = value;
                this.RaisePropertyChanged("potenciaveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool potenciaveiculoSpecified
        {
            get
            {
                return this.potenciaveiculoFieldSpecified;
            }
            set
            {
                this.potenciaveiculoFieldSpecified = value;
                this.RaisePropertyChanged("potenciaveiculoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int cilindradas
        {
            get
            {
                return this.cilindradasField;
            }
            set
            {
                this.cilindradasField = value;
                this.RaisePropertyChanged("cilindradas");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cilindradasSpecified
        {
            get
            {
                return this.cilindradasFieldSpecified;
            }
            set
            {
                this.cilindradasFieldSpecified = value;
                this.RaisePropertyChanged("cilindradasSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string combustivel
        {
            get
            {
                return this.combustivelField;
            }
            set
            {
                this.combustivelField = value;
                this.RaisePropertyChanged("combustivel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tracao-veiculo")]
        public decimal tracaoveiculo
        {
            get
            {
                return this.tracaoveiculoField;
            }
            set
            {
                this.tracaoveiculoField = value;
                this.RaisePropertyChanged("tracaoveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tracaoveiculoSpecified
        {
            get
            {
                return this.tracaoveiculoFieldSpecified;
            }
            set
            {
                this.tracaoveiculoFieldSpecified = value;
                this.RaisePropertyChanged("tracaoveiculoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("peso-bruto-veiculo")]
        public decimal pesobrutoveiculo
        {
            get
            {
                return this.pesobrutoveiculoField;
            }
            set
            {
                this.pesobrutoveiculoField = value;
                this.RaisePropertyChanged("pesobrutoveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pesobrutoveiculoSpecified
        {
            get
            {
                return this.pesobrutoveiculoFieldSpecified;
            }
            set
            {
                this.pesobrutoveiculoFieldSpecified = value;
                this.RaisePropertyChanged("pesobrutoveiculoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("capacidade-carga")]
        public decimal capacidadecarga
        {
            get
            {
                return this.capacidadecargaField;
            }
            set
            {
                this.capacidadecargaField = value;
                this.RaisePropertyChanged("capacidadecarga");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool capacidadecargaSpecified
        {
            get
            {
                return this.capacidadecargaFieldSpecified;
            }
            set
            {
                this.capacidadecargaFieldSpecified = value;
                this.RaisePropertyChanged("capacidadecargaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string procedencia
        {
            get
            {
                return this.procedenciaField;
            }
            set
            {
                this.procedenciaField = value;
                this.RaisePropertyChanged("procedencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("documento-proprietario")]
        public string documentoproprietario
        {
            get
            {
                return this.documentoproprietarioField;
            }
            set
            {
                this.documentoproprietarioField = value;
                this.RaisePropertyChanged("documentoproprietario");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-proprietario")]
        public string nomeproprietario
        {
            get
            {
                return this.nomeproprietarioField;
            }
            set
            {
                this.nomeproprietarioField = value;
                this.RaisePropertyChanged("nomeproprietario");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-carroceria")]
        public string numerocarroceria
        {
            get
            {
                return this.numerocarroceriaField;
            }
            set
            {
                this.numerocarroceriaField = value;
                this.RaisePropertyChanged("numerocarroceria");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-passageiros")]
        public int quantidadepassageiros
        {
            get
            {
                return this.quantidadepassageirosField;
            }
            set
            {
                this.quantidadepassageirosField = value;
                this.RaisePropertyChanged("quantidadepassageiros");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadepassageirosSpecified
        {
            get
            {
                return this.quantidadepassageirosFieldSpecified;
            }
            set
            {
                this.quantidadepassageirosFieldSpecified = value;
                this.RaisePropertyChanged("quantidadepassageirosSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string restricao1
        {
            get
            {
                return this.restricao1Field;
            }
            set
            {
                this.restricao1Field = value;
                this.RaisePropertyChanged("restricao1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string restricao2
        {
            get
            {
                return this.restricao2Field;
            }
            set
            {
                this.restricao2Field = value;
                this.RaisePropertyChanged("restricao2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string restricao3
        {
            get
            {
                return this.restricao3Field;
            }
            set
            {
                this.restricao3Field = value;
                this.RaisePropertyChanged("restricao3");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string restricao4
        {
            get
            {
                return this.restricao4Field;
            }
            set
            {
                this.restricao4Field = value;
                this.RaisePropertyChanged("restricao4");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-eixo")]
        public int numeroeixo
        {
            get
            {
                return this.numeroeixoField;
            }
            set
            {
                this.numeroeixoField = value;
                this.RaisePropertyChanged("numeroeixo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroeixoSpecified
        {
            get
            {
                return this.numeroeixoFieldSpecified;
            }
            set
            {
                this.numeroeixoFieldSpecified = value;
                this.RaisePropertyChanged("numeroeixoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-eixo-traseiro")]
        public string numeroeixotraseiro
        {
            get
            {
                return this.numeroeixotraseiroField;
            }
            set
            {
                this.numeroeixotraseiroField = value;
                this.RaisePropertyChanged("numeroeixotraseiro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-eixo-auxiliar")]
        public string numeroeixoauxiliar
        {
            get
            {
                return this.numeroeixoauxiliarField;
            }
            set
            {
                this.numeroeixoauxiliarField = value;
                this.RaisePropertyChanged("numeroeixoauxiliar");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("documento-importador")]
        public string documentoimportador
        {
            get
            {
                return this.documentoimportadorField;
            }
            set
            {
                this.documentoimportadorField = value;
                this.RaisePropertyChanged("documentoimportador");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-importador")]
        public string nomeimportador
        {
            get
            {
                return this.nomeimportadorField;
            }
            set
            {
                this.nomeimportadorField = value;
                this.RaisePropertyChanged("nomeimportador");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("liberado-pelo-orgao")]
        public string liberadopeloorgao
        {
            get
            {
                return this.liberadopeloorgaoField;
            }
            set
            {
                this.liberadopeloorgaoField = value;
                this.RaisePropertyChanged("liberadopeloorgao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-reda-aduaneiro")]
        public string numeroredaaduaneiro
        {
            get
            {
                return this.numeroredaaduaneiroField;
            }
            set
            {
                this.numeroredaaduaneiroField = value;
                this.RaisePropertyChanged("numeroredaaduaneiro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-declar-importacao")]
        public string numerodeclarimportacao
        {
            get
            {
                return this.numerodeclarimportacaoField;
            }
            set
            {
                this.numerodeclarimportacaoField = value;
                this.RaisePropertyChanged("numerodeclarimportacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-registro-aduaneira")]
        public string dataregistroaduaneira
        {
            get
            {
                return this.dataregistroaduaneiraField;
            }
            set
            {
                this.dataregistroaduaneiraField = value;
                this.RaisePropertyChanged("dataregistroaduaneira");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-id-faturado")]
        public string numeroidfaturado
        {
            get
            {
                return this.numeroidfaturadoField;
            }
            set
            {
                this.numeroidfaturadoField = value;
                this.RaisePropertyChanged("numeroidfaturado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-faturado")]
        public string nomefaturado
        {
            get
            {
                return this.nomefaturadoField;
            }
            set
            {
                this.nomefaturadoField = value;
                this.RaisePropertyChanged("nomefaturado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("uf-dest-faturamento")]
        public string ufdestfaturamento
        {
            get
            {
                return this.ufdestfaturamentoField;
            }
            set
            {
                this.ufdestfaturamentoField = value;
                this.RaisePropertyChanged("ufdestfaturamento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-limite-rest-trib")]
        public string datalimiteresttrib
        {
            get
            {
                return this.datalimiteresttribField;
            }
            set
            {
                this.datalimiteresttribField = value;
                this.RaisePropertyChanged("datalimiteresttrib");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-operacao-imp-veiculo")]
        public string tipooperacaoimpveiculo
        {
            get
            {
                return this.tipooperacaoimpveiculoField;
            }
            set
            {
                this.tipooperacaoimpveiculoField = value;
                this.RaisePropertyChanged("tipooperacaoimpveiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-processo-importacao")]
        public string numeroprocessoimportacao
        {
            get
            {
                return this.numeroprocessoimportacaoField;
            }
            set
            {
                this.numeroprocessoimportacaoField = value;
                this.RaisePropertyChanged("numeroprocessoimportacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ultima-atualizacao")]
        public string dataultimaatualizacao
        {
            get
            {
                return this.dataultimaatualizacaoField;
            }
            set
            {
                this.dataultimaatualizacaoField = value;
                this.RaisePropertyChanged("dataultimaatualizacao");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Rg", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRg : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string fotoField;

        private string municipioField;

        private string nomepaiField;

        private string nomemaeField;

        private System.DateTime datanascimentorgField;

        private bool datanascimentorgFieldSpecified;

        private string nomeField;

        private string ufemissaorgField;

        private string numerorgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string foto
        {
            get
            {
                return this.fotoField;
            }
            set
            {
                this.fotoField = value;
                this.RaisePropertyChanged("foto");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string municipio
        {
            get
            {
                return this.municipioField;
            }
            set
            {
                this.municipioField = value;
                this.RaisePropertyChanged("municipio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-pai")]
        public string nomepai
        {
            get
            {
                return this.nomepaiField;
            }
            set
            {
                this.nomepaiField = value;
                this.RaisePropertyChanged("nomepai");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-mae")]
        public string nomemae
        {
            get
            {
                return this.nomemaeField;
            }
            set
            {
                this.nomemaeField = value;
                this.RaisePropertyChanged("nomemae");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-nascimento-rg")]
        public System.DateTime datanascimentorg
        {
            get
            {
                return this.datanascimentorgField;
            }
            set
            {
                this.datanascimentorgField = value;
                this.RaisePropertyChanged("datanascimentorg");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datanascimentorgSpecified
        {
            get
            {
                return this.datanascimentorgFieldSpecified;
            }
            set
            {
                this.datanascimentorgFieldSpecified = value;
                this.RaisePropertyChanged("datanascimentorgSpecified");
            }
        }

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
        [System.Xml.Serialization.XmlAttributeAttribute("uf-emissao-rg")]
        public string ufemissaorg
        {
            get
            {
                return this.ufemissaorgField;
            }
            set
            {
                this.ufemissaorgField = value;
                this.RaisePropertyChanged("ufemissaorg");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-rg")]
        public string numerorg
        {
            get
            {
                return this.numerorgField;
            }
            set
            {
                this.numerorgField = value;
                this.RaisePropertyChanged("numerorg");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Cartorio-Obito", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class CartorioObito : object, System.ComponentModel.INotifyPropertyChanged
    {

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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Obito", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoObito : object, System.ComponentModel.INotifyPropertyChanged
    {

        private CartorioObito cartorioobitoField;

        private System.DateTime dataobitoField;

        private bool dataobitoFieldSpecified;

        private string msgobitoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cartorio-obito", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public CartorioObito cartorioobito
        {
            get
            {
                return this.cartorioobitoField;
            }
            set
            {
                this.cartorioobitoField = value;
                this.RaisePropertyChanged("cartorioobito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-obito")]
        public System.DateTime dataobito
        {
            get
            {
                return this.dataobitoField;
            }
            set
            {
                this.dataobitoField = value;
                this.RaisePropertyChanged("dataobito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataobitoSpecified
        {
            get
            {
                return this.dataobitoFieldSpecified;
            }
            set
            {
                this.dataobitoFieldSpecified = value;
                this.RaisePropertyChanged("dataobitoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("msg-obito")]
        public string msgobito
        {
            get
            {
                return this.msgobitoField;
            }
            set
            {
                this.msgobitoField = value;
                this.RaisePropertyChanged("msgobito");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-SPC-Score-12-Meses", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoSPCScore12Meses : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string classeField;

        private int horizonteField;

        private string mesageminterpretativascoreField;

        private string mesageminterpretativaprobabilidadeField;

        private string mesagemsemaforoField;

        private double probabilidadeField;

        private bool probabilidadeFieldSpecified;

        private int scoreField;

        private TipoClienteScore tipoclientescoreField;

        private bool tipoclientescoreFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string classe
        {
            get
            {
                return this.classeField;
            }
            set
            {
                this.classeField = value;
                this.RaisePropertyChanged("classe");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int horizonte
        {
            get
            {
                return this.horizonteField;
            }
            set
            {
                this.horizonteField = value;
                this.RaisePropertyChanged("horizonte");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mesagem-interpretativa-score")]
        public string mesageminterpretativascore
        {
            get
            {
                return this.mesageminterpretativascoreField;
            }
            set
            {
                this.mesageminterpretativascoreField = value;
                this.RaisePropertyChanged("mesageminterpretativascore");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mesagem-interpretativa-probabilidade")]
        public string mesageminterpretativaprobabilidade
        {
            get
            {
                return this.mesageminterpretativaprobabilidadeField;
            }
            set
            {
                this.mesageminterpretativaprobabilidadeField = value;
                this.RaisePropertyChanged("mesageminterpretativaprobabilidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mesagem-semaforo")]
        public string mesagemsemaforo
        {
            get
            {
                return this.mesagemsemaforoField;
            }
            set
            {
                this.mesagemsemaforoField = value;
                this.RaisePropertyChanged("mesagemsemaforo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double probabilidade
        {
            get
            {
                return this.probabilidadeField;
            }
            set
            {
                this.probabilidadeField = value;
                this.RaisePropertyChanged("probabilidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool probabilidadeSpecified
        {
            get
            {
                return this.probabilidadeFieldSpecified;
            }
            set
            {
                this.probabilidadeFieldSpecified = value;
                this.RaisePropertyChanged("probabilidadeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
                this.RaisePropertyChanged("score");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-cliente-score")]
        public TipoClienteScore tipoclientescore
        {
            get
            {
                return this.tipoclientescoreField;
            }
            set
            {
                this.tipoclientescoreField = value;
                this.RaisePropertyChanged("tipoclientescore");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoclientescoreSpecified
        {
            get
            {
                return this.tipoclientescoreFieldSpecified;
            }
            set
            {
                this.tipoclientescoreFieldSpecified = value;
                this.RaisePropertyChanged("tipoclientescoreSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Tipo-Cliente-Score", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public enum TipoClienteScore
    {

        /// <remarks/>
        NAO_RESTRITO,

        /// <remarks/>
        NOVO,

        /// <remarks/>
        RESTRITO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-SPC-Score-3-Meses", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoSPCScore3Meses : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string classeField;

        private int horizonteField;

        private string mesageminterpretativascoreField;

        private string mesageminterpretativaprobabilidadeField;

        private string mesagemsemaforoField;

        private double probabilidadeField;

        private bool probabilidadeFieldSpecified;

        private int scoreField;

        private TipoClienteScore tipoclientescoreField;

        private bool tipoclientescoreFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string classe
        {
            get
            {
                return this.classeField;
            }
            set
            {
                this.classeField = value;
                this.RaisePropertyChanged("classe");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int horizonte
        {
            get
            {
                return this.horizonteField;
            }
            set
            {
                this.horizonteField = value;
                this.RaisePropertyChanged("horizonte");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mesagem-interpretativa-score")]
        public string mesageminterpretativascore
        {
            get
            {
                return this.mesageminterpretativascoreField;
            }
            set
            {
                this.mesageminterpretativascoreField = value;
                this.RaisePropertyChanged("mesageminterpretativascore");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mesagem-interpretativa-probabilidade")]
        public string mesageminterpretativaprobabilidade
        {
            get
            {
                return this.mesageminterpretativaprobabilidadeField;
            }
            set
            {
                this.mesageminterpretativaprobabilidadeField = value;
                this.RaisePropertyChanged("mesageminterpretativaprobabilidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mesagem-semaforo")]
        public string mesagemsemaforo
        {
            get
            {
                return this.mesagemsemaforoField;
            }
            set
            {
                this.mesagemsemaforoField = value;
                this.RaisePropertyChanged("mesagemsemaforo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double probabilidade
        {
            get
            {
                return this.probabilidadeField;
            }
            set
            {
                this.probabilidadeField = value;
                this.RaisePropertyChanged("probabilidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool probabilidadeSpecified
        {
            get
            {
                return this.probabilidadeFieldSpecified;
            }
            set
            {
                this.probabilidadeFieldSpecified = value;
                this.RaisePropertyChanged("probabilidadeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
                this.RaisePropertyChanged("score");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-cliente-score")]
        public TipoClienteScore tipoclientescore
        {
            get
            {
                return this.tipoclientescoreField;
            }
            set
            {
                this.tipoclientescoreField = value;
                this.RaisePropertyChanged("tipoclientescore");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoclientescoreSpecified
        {
            get
            {
                return this.tipoclientescoreFieldSpecified;
            }
            set
            {
                this.tipoclientescoreFieldSpecified = value;
                this.RaisePropertyChanged("tipoclientescoreSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Principais-Produtos", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoPrincipaisProdutos : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string descricaoprincipaisprodutosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("descricao-principais-produtos")]
        public string descricaoprincipaisprodutos
        {
            get
            {
                return this.descricaoprincipaisprodutosField;
            }
            set
            {
                this.descricaoprincipaisprodutosField = value;
                this.RaisePropertyChanged("descricaoprincipaisprodutos");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Incorporacao-Fusao-Cisao", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoIncorporacaoFusaoCisao : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime dataatualizacaoField;

        private bool dataatualizacaoFieldSpecified;

        private string mensagemobservacoesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-atualizacao")]
        public System.DateTime dataatualizacao
        {
            get
            {
                return this.dataatualizacaoField;
            }
            set
            {
                this.dataatualizacaoField = value;
                this.RaisePropertyChanged("dataatualizacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataatualizacaoSpecified
        {
            get
            {
                return this.dataatualizacaoFieldSpecified;
            }
            set
            {
                this.dataatualizacaoFieldSpecified = value;
                this.RaisePropertyChanged("dataatualizacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mensagem-observacoes")]
        public string mensagemobservacoes
        {
            get
            {
                return this.mensagemobservacoesField;
            }
            set
            {
                this.mensagemobservacoesField = value;
                this.RaisePropertyChanged("mensagemobservacoes");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Informacoes-Adicionais", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoInformacoesAdicionais : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string frasestatusempresaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("frase-status-empresa")]
        public string frasestatusempresa
        {
            get
            {
                return this.frasestatusempresaField;
            }
            set
            {
                this.frasestatusempresaField = value;
                this.RaisePropertyChanged("frasestatusempresa");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Filial", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoFilial : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codigoembratelField;

        private string nomefilialField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("codigo-embratel")]
        public string codigoembratel
        {
            get
            {
                return this.codigoembratelField;
            }
            set
            {
                this.codigoembratelField = value;
                this.RaisePropertyChanged("codigoembratel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-filial")]
        public string nomefilial
        {
            get
            {
                return this.nomefilialField;
            }
            set
            {
                this.nomefilialField = value;
                this.RaisePropertyChanged("nomefilial");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Atividade-Empresa", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoAtividadeEmpresa : object, System.ComponentModel.INotifyPropertyChanged
    {

        private RamoAtividade ramoatividadeField;

        private RamoAtividade[] atividadeseconomicassecundariasField;

        private string numerocnaeField;

        private double percentualcompraField;

        private bool percentualcompraFieldSpecified;

        private double percentualvendasField;

        private bool percentualvendasFieldSpecified;

        private int quantidadeempregadosField;

        private bool quantidadeempregadosFieldSpecified;

        private int quantidadefiliaisField;

        private bool quantidadefiliaisFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ramo-atividade", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public RamoAtividade ramoatividade
        {
            get
            {
                return this.ramoatividadeField;
            }
            set
            {
                this.ramoatividadeField = value;
                this.RaisePropertyChanged("ramoatividade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("atividades-economicas-secundarias", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public RamoAtividade[] atividadeseconomicassecundarias
        {
            get
            {
                return this.atividadeseconomicassecundariasField;
            }
            set
            {
                this.atividadeseconomicassecundariasField = value;
                this.RaisePropertyChanged("atividadeseconomicassecundarias");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-cnae")]
        public string numerocnae
        {
            get
            {
                return this.numerocnaeField;
            }
            set
            {
                this.numerocnaeField = value;
                this.RaisePropertyChanged("numerocnae");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("percentual-compra")]
        public double percentualcompra
        {
            get
            {
                return this.percentualcompraField;
            }
            set
            {
                this.percentualcompraField = value;
                this.RaisePropertyChanged("percentualcompra");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentualcompraSpecified
        {
            get
            {
                return this.percentualcompraFieldSpecified;
            }
            set
            {
                this.percentualcompraFieldSpecified = value;
                this.RaisePropertyChanged("percentualcompraSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("percentual-vendas")]
        public double percentualvendas
        {
            get
            {
                return this.percentualvendasField;
            }
            set
            {
                this.percentualvendasField = value;
                this.RaisePropertyChanged("percentualvendas");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentualvendasSpecified
        {
            get
            {
                return this.percentualvendasFieldSpecified;
            }
            set
            {
                this.percentualvendasFieldSpecified = value;
                this.RaisePropertyChanged("percentualvendasSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-empregados")]
        public int quantidadeempregados
        {
            get
            {
                return this.quantidadeempregadosField;
            }
            set
            {
                this.quantidadeempregadosField = value;
                this.RaisePropertyChanged("quantidadeempregados");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadeempregadosSpecified
        {
            get
            {
                return this.quantidadeempregadosFieldSpecified;
            }
            set
            {
                this.quantidadeempregadosFieldSpecified = value;
                this.RaisePropertyChanged("quantidadeempregadosSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-filiais")]
        public int quantidadefiliais
        {
            get
            {
                return this.quantidadefiliaisField;
            }
            set
            {
                this.quantidadefiliaisField = value;
                this.RaisePropertyChanged("quantidadefiliais");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadefiliaisSpecified
        {
            get
            {
                return this.quantidadefiliaisFieldSpecified;
            }
            set
            {
                this.quantidadefiliaisFieldSpecified = value;
                this.RaisePropertyChanged("quantidadefiliaisSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Ramo-Atividade", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class RamoAtividade : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string descricaoField;

        private long codigoField;

        private bool codigoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
                this.RaisePropertyChanged("descricao");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Antecessora", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoAntecessora : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime datamotivoField;

        private bool datamotivoFieldSpecified;

        private string razaosocialanteriorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-motivo")]
        public System.DateTime datamotivo
        {
            get
            {
                return this.datamotivoField;
            }
            set
            {
                this.datamotivoField = value;
                this.RaisePropertyChanged("datamotivo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datamotivoSpecified
        {
            get
            {
                return this.datamotivoFieldSpecified;
            }
            set
            {
                this.datamotivoFieldSpecified = value;
                this.RaisePropertyChanged("datamotivoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("razao-social-anterior")]
        public string razaosocialanterior
        {
            get
            {
                return this.razaosocialanteriorField;
            }
            set
            {
                this.razaosocialanteriorField = value;
                this.RaisePropertyChanged("razaosocialanterior");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Capital-Social", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoCapitalSocial : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nacionalidadeField;

        private string naturezaField;

        private string origemField;

        private System.DateTime dataultimaatualizacaoField;

        private bool dataultimaatualizacaoFieldSpecified;

        private decimal valorcapitalautorizadoField;

        private bool valorcapitalautorizadoFieldSpecified;

        private decimal valorcapitalrealizadoField;

        private bool valorcapitalrealizadoFieldSpecified;

        private decimal valorcapitalsocialField;

        private bool valorcapitalsocialFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nacionalidade
        {
            get
            {
                return this.nacionalidadeField;
            }
            set
            {
                this.nacionalidadeField = value;
                this.RaisePropertyChanged("nacionalidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string natureza
        {
            get
            {
                return this.naturezaField;
            }
            set
            {
                this.naturezaField = value;
                this.RaisePropertyChanged("natureza");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
                this.RaisePropertyChanged("origem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ultima-atualizacao")]
        public System.DateTime dataultimaatualizacao
        {
            get
            {
                return this.dataultimaatualizacaoField;
            }
            set
            {
                this.dataultimaatualizacaoField = value;
                this.RaisePropertyChanged("dataultimaatualizacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataultimaatualizacaoSpecified
        {
            get
            {
                return this.dataultimaatualizacaoFieldSpecified;
            }
            set
            {
                this.dataultimaatualizacaoFieldSpecified = value;
                this.RaisePropertyChanged("dataultimaatualizacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-capital-autorizado")]
        public decimal valorcapitalautorizado
        {
            get
            {
                return this.valorcapitalautorizadoField;
            }
            set
            {
                this.valorcapitalautorizadoField = value;
                this.RaisePropertyChanged("valorcapitalautorizado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorcapitalautorizadoSpecified
        {
            get
            {
                return this.valorcapitalautorizadoFieldSpecified;
            }
            set
            {
                this.valorcapitalautorizadoFieldSpecified = value;
                this.RaisePropertyChanged("valorcapitalautorizadoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-capital-realizado")]
        public decimal valorcapitalrealizado
        {
            get
            {
                return this.valorcapitalrealizadoField;
            }
            set
            {
                this.valorcapitalrealizadoField = value;
                this.RaisePropertyChanged("valorcapitalrealizado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorcapitalrealizadoSpecified
        {
            get
            {
                return this.valorcapitalrealizadoFieldSpecified;
            }
            set
            {
                this.valorcapitalrealizadoFieldSpecified = value;
                this.RaisePropertyChanged("valorcapitalrealizadoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-capital-social")]
        public decimal valorcapitalsocial
        {
            get
            {
                return this.valorcapitalsocialField;
            }
            set
            {
                this.valorcapitalsocialField = value;
                this.RaisePropertyChanged("valorcapitalsocial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorcapitalsocialSpecified
        {
            get
            {
                return this.valorcapitalsocialFieldSpecified;
            }
            set
            {
                this.valorcapitalsocialFieldSpecified = value;
                this.RaisePropertyChanged("valorcapitalsocialSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Ultimas-Consultas", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoUltimasConsultas : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string cnpjclienteField;

        private System.DateTime dataconsultaField;

        private bool dataconsultaFieldSpecified;

        private string nomeclienteconsultanteField;

        private int quantidadeconsultaField;

        private bool quantidadeconsultaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("cnpj-cliente")]
        public string cnpjcliente
        {
            get
            {
                return this.cnpjclienteField;
            }
            set
            {
                this.cnpjclienteField = value;
                this.RaisePropertyChanged("cnpjcliente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-consulta")]
        public System.DateTime dataconsulta
        {
            get
            {
                return this.dataconsultaField;
            }
            set
            {
                this.dataconsultaField = value;
                this.RaisePropertyChanged("dataconsulta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataconsultaSpecified
        {
            get
            {
                return this.dataconsultaFieldSpecified;
            }
            set
            {
                this.dataconsultaFieldSpecified = value;
                this.RaisePropertyChanged("dataconsultaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-cliente-consultante")]
        public string nomeclienteconsultante
        {
            get
            {
                return this.nomeclienteconsultanteField;
            }
            set
            {
                this.nomeclienteconsultanteField = value;
                this.RaisePropertyChanged("nomeclienteconsultante");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-consulta")]
        public int quantidadeconsulta
        {
            get
            {
                return this.quantidadeconsultaField;
            }
            set
            {
                this.quantidadeconsultaField = value;
                this.RaisePropertyChanged("quantidadeconsulta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadeconsultaSpecified
        {
            get
            {
                return this.quantidadeconsultaFieldSpecified;
            }
            set
            {
                this.quantidadeconsultaFieldSpecified = value;
                this.RaisePropertyChanged("quantidadeconsultaSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Registro-Consultas", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRegistroConsultas : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime dataconsultaField;

        private bool dataconsultaFieldSpecified;

        private int quantidadeconsultabancoField;

        private bool quantidadeconsultabancoFieldSpecified;

        private int quantidadeconsultaempresaField;

        private bool quantidadeconsultaempresaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-consulta")]
        public System.DateTime dataconsulta
        {
            get
            {
                return this.dataconsultaField;
            }
            set
            {
                this.dataconsultaField = value;
                this.RaisePropertyChanged("dataconsulta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataconsultaSpecified
        {
            get
            {
                return this.dataconsultaFieldSpecified;
            }
            set
            {
                this.dataconsultaFieldSpecified = value;
                this.RaisePropertyChanged("dataconsultaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-consulta-banco")]
        public int quantidadeconsultabanco
        {
            get
            {
                return this.quantidadeconsultabancoField;
            }
            set
            {
                this.quantidadeconsultabancoField = value;
                this.RaisePropertyChanged("quantidadeconsultabanco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadeconsultabancoSpecified
        {
            get
            {
                return this.quantidadeconsultabancoFieldSpecified;
            }
            set
            {
                this.quantidadeconsultabancoFieldSpecified = value;
                this.RaisePropertyChanged("quantidadeconsultabancoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-consulta-empresa")]
        public int quantidadeconsultaempresa
        {
            get
            {
                return this.quantidadeconsultaempresaField;
            }
            set
            {
                this.quantidadeconsultaempresaField = value;
                this.RaisePropertyChanged("quantidadeconsultaempresa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadeconsultaempresaSpecified
        {
            get
            {
                return this.quantidadeconsultaempresaFieldSpecified;
            }
            set
            {
                this.quantidadeconsultaempresaFieldSpecified = value;
                this.RaisePropertyChanged("quantidadeconsultaempresaSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Relacionamento-Mais-Antigo-Com-Fornecedores", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRelacionamentoMaisAntigoComFornecedores : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime datarelacionamentomaisantigoField;

        private bool datarelacionamentomaisantigoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-relacionamento-mais-antigo")]
        public System.DateTime datarelacionamentomaisantigo
        {
            get
            {
                return this.datarelacionamentomaisantigoField;
            }
            set
            {
                this.datarelacionamentomaisantigoField = value;
                this.RaisePropertyChanged("datarelacionamentomaisantigo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datarelacionamentomaisantigoSpecified
        {
            get
            {
                return this.datarelacionamentomaisantigoFieldSpecified;
            }
            set
            {
                this.datarelacionamentomaisantigoFieldSpecified = value;
                this.RaisePropertyChanged("datarelacionamentomaisantigoSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Historico-Conta-Corrente", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoHistoricoContaCorrente : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cheque ultimochequeconsultadoField;

        private System.DateTime dataconsultamaisantigaField;

        private bool dataconsultamaisantigaFieldSpecified;

        private System.DateTime dataconsultamaisrecenteField;

        private bool dataconsultamaisrecenteFieldSpecified;

        private int quantidadeconsultasField;

        private bool quantidadeconsultasFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ultimo-cheque-consultado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cheque ultimochequeconsultado
        {
            get
            {
                return this.ultimochequeconsultadoField;
            }
            set
            {
                this.ultimochequeconsultadoField = value;
                this.RaisePropertyChanged("ultimochequeconsultado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-consulta-mais-antiga")]
        public System.DateTime dataconsultamaisantiga
        {
            get
            {
                return this.dataconsultamaisantigaField;
            }
            set
            {
                this.dataconsultamaisantigaField = value;
                this.RaisePropertyChanged("dataconsultamaisantiga");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataconsultamaisantigaSpecified
        {
            get
            {
                return this.dataconsultamaisantigaFieldSpecified;
            }
            set
            {
                this.dataconsultamaisantigaFieldSpecified = value;
                this.RaisePropertyChanged("dataconsultamaisantigaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-consulta-mais-recente")]
        public System.DateTime dataconsultamaisrecente
        {
            get
            {
                return this.dataconsultamaisrecenteField;
            }
            set
            {
                this.dataconsultamaisrecenteField = value;
                this.RaisePropertyChanged("dataconsultamaisrecente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataconsultamaisrecenteSpecified
        {
            get
            {
                return this.dataconsultamaisrecenteFieldSpecified;
            }
            set
            {
                this.dataconsultamaisrecenteFieldSpecified = value;
                this.RaisePropertyChanged("dataconsultamaisrecenteSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-consultas")]
        public int quantidadeconsultas
        {
            get
            {
                return this.quantidadeconsultasField;
            }
            set
            {
                this.quantidadeconsultasField = value;
                this.RaisePropertyChanged("quantidadeconsultas");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadeconsultasSpecified
        {
            get
            {
                return this.quantidadeconsultasFieldSpecified;
            }
            set
            {
                this.quantidadeconsultasFieldSpecified = value;
                this.RaisePropertyChanged("quantidadeconsultasSpecified");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChequeContraOrdem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChequeFinal))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChequeLojista))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class Cheque : object, System.ComponentModel.INotifyPropertyChanged
    {

        private DadosBancarios dadosbancariosField;

        private int numeroField;

        private bool numeroFieldSpecified;

        private int digitoField;

        private bool digitoFieldSpecified;

        private decimal valorField;

        private bool valorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dados-bancarios", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public DadosBancarios dadosbancarios
        {
            get
            {
                return this.dadosbancariosField;
            }
            set
            {
                this.dadosbancariosField = value;
                this.RaisePropertyChanged("dadosbancarios");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
                this.RaisePropertyChanged("numero");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroSpecified
        {
            get
            {
                return this.numeroFieldSpecified;
            }
            set
            {
                this.numeroFieldSpecified = value;
                this.RaisePropertyChanged("numeroSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int digito
        {
            get
            {
                return this.digitoField;
            }
            set
            {
                this.digitoField = value;
                this.RaisePropertyChanged("digito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool digitoSpecified
        {
            get
            {
                return this.digitoFieldSpecified;
            }
            set
            {
                this.digitoFieldSpecified = value;
                this.RaisePropertyChanged("digitoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
                this.RaisePropertyChanged("valorSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Dados-Bancarios", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class DadosBancarios : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Endereco enderecoField;

        private Banco bancoField;

        private Telefone telefoneField;

        private Telefone faxField;

        private int numeroagenciaField;

        private bool numeroagenciaFieldSpecified;

        private string nomeagenciaField;

        private string numerocontacorrenteField;

        private string digitocontacorrenteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Endereco endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
                this.RaisePropertyChanged("endereco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Banco banco
        {
            get
            {
                return this.bancoField;
            }
            set
            {
                this.bancoField = value;
                this.RaisePropertyChanged("banco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public Telefone telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
                this.RaisePropertyChanged("telefone");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Telefone fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
                this.RaisePropertyChanged("fax");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-agencia")]
        public int numeroagencia
        {
            get
            {
                return this.numeroagenciaField;
            }
            set
            {
                this.numeroagenciaField = value;
                this.RaisePropertyChanged("numeroagencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroagenciaSpecified
        {
            get
            {
                return this.numeroagenciaFieldSpecified;
            }
            set
            {
                this.numeroagenciaFieldSpecified = value;
                this.RaisePropertyChanged("numeroagenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-agencia")]
        public string nomeagencia
        {
            get
            {
                return this.nomeagenciaField;
            }
            set
            {
                this.nomeagenciaField = value;
                this.RaisePropertyChanged("nomeagencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-conta-corrente")]
        public string numerocontacorrente
        {
            get
            {
                return this.numerocontacorrenteField;
            }
            set
            {
                this.numerocontacorrenteField = value;
                this.RaisePropertyChanged("numerocontacorrente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("digito-conta-corrente")]
        public string digitocontacorrente
        {
            get
            {
                return this.digitocontacorrenteField;
            }
            set
            {
                this.digitocontacorrenteField = value;
                this.RaisePropertyChanged("digitocontacorrente");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnderecoOcorrenciaConsumidor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnderecoAssinanteTelefone))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class Endereco : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cidade cidadeField;

        private string logradouroField;

        private string numeroField;

        private string complementoField;

        private string bairroField;

        private int cepField;

        private bool cepFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cidade cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
                this.RaisePropertyChanged("cidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string logradouro
        {
            get
            {
                return this.logradouroField;
            }
            set
            {
                this.logradouroField = value;
                this.RaisePropertyChanged("logradouro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
                this.RaisePropertyChanged("numero");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
                this.RaisePropertyChanged("complemento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
                this.RaisePropertyChanged("bairro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int cep
        {
            get
            {
                return this.cepField;
            }
            set
            {
                this.cepField = value;
                this.RaisePropertyChanged("cep");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cepSpecified
        {
            get
            {
                return this.cepFieldSpecified;
            }
            set
            {
                this.cepFieldSpecified = value;
                this.RaisePropertyChanged("cepSpecified");
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
    public partial class Cidade : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Estado estadoField;

        private string nomeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Estado estado
        {
            get
            {
                return this.estadoField;
            }
            set
            {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }

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
    public partial class Estado : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string siglaufField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("sigla-uf")]
        public string siglauf
        {
            get
            {
                return this.siglaufField;
            }
            set
            {
                this.siglaufField = value;
                this.RaisePropertyChanged("siglauf");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Endereco-Ocorrencia-Consumidor", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class EnderecoOcorrenciaConsumidor : Endereco
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Endereco-Assinante-Telefone", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class EnderecoAssinanteTelefone : Endereco
    {

        private string tipologradouroField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-logradouro")]
        public string tipologradouro
        {
            get
            {
                return this.tipologradouroField;
            }
            set
            {
                this.tipologradouroField = value;
                this.RaisePropertyChanged("tipologradouro");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class Banco : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int codigoField;

        private bool codigoFieldSpecified;

        private string nomeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int codigo
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Cheque-Contra-Ordem", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ChequeContraOrdem : Cheque
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Cheque-Final", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ChequeFinal : Cheque
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Cheque-Lojista", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ChequeLojista : Cheque
    {

        private System.DateTime dataemissaoField;

        private bool dataemissaoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-emissao")]
        public System.DateTime dataemissao
        {
            get
            {
                return this.dataemissaoField;
            }
            set
            {
                this.dataemissaoField = value;
                this.RaisePropertyChanged("dataemissao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataemissaoSpecified
        {
            get
            {
                return this.dataemissaoFieldSpecified;
            }
            set
            {
                this.dataemissaoFieldSpecified = value;
                this.RaisePropertyChanged("dataemissaoSpecified");
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoHistoricoChequeDocumentoDiferente))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Historico-Cheque", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoHistoricoCheque : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cheque chequeconsultadoField;

        private System.DateTime dataconsultamaisantigaField;

        private bool dataconsultamaisantigaFieldSpecified;

        private System.DateTime dataconsultamaisrecenteField;

        private bool dataconsultamaisrecenteFieldSpecified;

        private string nomeempresaultimaconsultaField;

        private int quantidadeconsultasField;

        private bool quantidadeconsultasFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-consultado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cheque chequeconsultado
        {
            get
            {
                return this.chequeconsultadoField;
            }
            set
            {
                this.chequeconsultadoField = value;
                this.RaisePropertyChanged("chequeconsultado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-consulta-mais-antiga")]
        public System.DateTime dataconsultamaisantiga
        {
            get
            {
                return this.dataconsultamaisantigaField;
            }
            set
            {
                this.dataconsultamaisantigaField = value;
                this.RaisePropertyChanged("dataconsultamaisantiga");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataconsultamaisantigaSpecified
        {
            get
            {
                return this.dataconsultamaisantigaFieldSpecified;
            }
            set
            {
                this.dataconsultamaisantigaFieldSpecified = value;
                this.RaisePropertyChanged("dataconsultamaisantigaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-consulta-mais-recente")]
        public System.DateTime dataconsultamaisrecente
        {
            get
            {
                return this.dataconsultamaisrecenteField;
            }
            set
            {
                this.dataconsultamaisrecenteField = value;
                this.RaisePropertyChanged("dataconsultamaisrecente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataconsultamaisrecenteSpecified
        {
            get
            {
                return this.dataconsultamaisrecenteFieldSpecified;
            }
            set
            {
                this.dataconsultamaisrecenteFieldSpecified = value;
                this.RaisePropertyChanged("dataconsultamaisrecenteSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-empresa-ultima-consulta")]
        public string nomeempresaultimaconsulta
        {
            get
            {
                return this.nomeempresaultimaconsultaField;
            }
            set
            {
                this.nomeempresaultimaconsultaField = value;
                this.RaisePropertyChanged("nomeempresaultimaconsulta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-consultas")]
        public int quantidadeconsultas
        {
            get
            {
                return this.quantidadeconsultasField;
            }
            set
            {
                this.quantidadeconsultasField = value;
                this.RaisePropertyChanged("quantidadeconsultas");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadeconsultasSpecified
        {
            get
            {
                return this.quantidadeconsultasFieldSpecified;
            }
            set
            {
                this.quantidadeconsultasFieldSpecified = value;
                this.RaisePropertyChanged("quantidadeconsultasSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Historico-Cheque-Documento-Diferente", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoHistoricoChequeDocumentoDiferente : InsumoHistoricoCheque
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Historico-Pagamento", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoHistoricoPagamento : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string descricaoperiodoField;

        private int percentualperiodoField;

        private bool percentualperiodoFieldSpecified;

        private int quantidadefontesField;

        private bool quantidadefontesFieldSpecified;

        private int quantidadeperiodoField;

        private bool quantidadeperiodoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("descricao-periodo")]
        public string descricaoperiodo
        {
            get
            {
                return this.descricaoperiodoField;
            }
            set
            {
                this.descricaoperiodoField = value;
                this.RaisePropertyChanged("descricaoperiodo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("percentual-periodo")]
        public int percentualperiodo
        {
            get
            {
                return this.percentualperiodoField;
            }
            set
            {
                this.percentualperiodoField = value;
                this.RaisePropertyChanged("percentualperiodo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentualperiodoSpecified
        {
            get
            {
                return this.percentualperiodoFieldSpecified;
            }
            set
            {
                this.percentualperiodoFieldSpecified = value;
                this.RaisePropertyChanged("percentualperiodoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-fontes")]
        public int quantidadefontes
        {
            get
            {
                return this.quantidadefontesField;
            }
            set
            {
                this.quantidadefontesField = value;
                this.RaisePropertyChanged("quantidadefontes");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadefontesSpecified
        {
            get
            {
                return this.quantidadefontesFieldSpecified;
            }
            set
            {
                this.quantidadefontesFieldSpecified = value;
                this.RaisePropertyChanged("quantidadefontesSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-periodo")]
        public int quantidadeperiodo
        {
            get
            {
                return this.quantidadeperiodoField;
            }
            set
            {
                this.quantidadeperiodoField = value;
                this.RaisePropertyChanged("quantidadeperiodo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadeperiodoSpecified
        {
            get
            {
                return this.quantidadeperiodoFieldSpecified;
            }
            set
            {
                this.quantidadeperiodoFieldSpecified = value;
                this.RaisePropertyChanged("quantidadeperiodoSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Referenciais-Negocios", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoReferenciaisNegocios : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime datapotencialField;

        private bool datapotencialFieldSpecified;

        private string descricaonegocioField;

        private decimal mediapotencialField;

        private bool mediapotencialFieldSpecified;

        private decimal valorpotencialField;

        private bool valorpotencialFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-potencial")]
        public System.DateTime datapotencial
        {
            get
            {
                return this.datapotencialField;
            }
            set
            {
                this.datapotencialField = value;
                this.RaisePropertyChanged("datapotencial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datapotencialSpecified
        {
            get
            {
                return this.datapotencialFieldSpecified;
            }
            set
            {
                this.datapotencialFieldSpecified = value;
                this.RaisePropertyChanged("datapotencialSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("descricao-negocio")]
        public string descricaonegocio
        {
            get
            {
                return this.descricaonegocioField;
            }
            set
            {
                this.descricaonegocioField = value;
                this.RaisePropertyChanged("descricaonegocio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("media-potencial")]
        public decimal mediapotencial
        {
            get
            {
                return this.mediapotencialField;
            }
            set
            {
                this.mediapotencialField = value;
                this.RaisePropertyChanged("mediapotencial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mediapotencialSpecified
        {
            get
            {
                return this.mediapotencialFieldSpecified;
            }
            set
            {
                this.mediapotencialFieldSpecified = value;
                this.RaisePropertyChanged("mediapotencialSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-potencial")]
        public decimal valorpotencial
        {
            get
            {
                return this.valorpotencialField;
            }
            set
            {
                this.valorpotencialField = value;
                this.RaisePropertyChanged("valorpotencial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorpotencialSpecified
        {
            get
            {
                return this.valorpotencialFieldSpecified;
            }
            set
            {
                this.valorpotencialFieldSpecified = value;
                this.RaisePropertyChanged("valorpotencialSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Referencia-Comercial", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ReferenciaComercial : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime dataconsultachequeField;

        private bool dataconsultachequeFieldSpecified;

        private string nomeempresaconsultanteField;

        private int ordemconsultaField;

        private bool ordemconsultaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-consulta-cheque")]
        public System.DateTime dataconsultacheque
        {
            get
            {
                return this.dataconsultachequeField;
            }
            set
            {
                this.dataconsultachequeField = value;
                this.RaisePropertyChanged("dataconsultacheque");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataconsultachequeSpecified
        {
            get
            {
                return this.dataconsultachequeFieldSpecified;
            }
            set
            {
                this.dataconsultachequeFieldSpecified = value;
                this.RaisePropertyChanged("dataconsultachequeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-empresa-consultante")]
        public string nomeempresaconsultante
        {
            get
            {
                return this.nomeempresaconsultanteField;
            }
            set
            {
                this.nomeempresaconsultanteField = value;
                this.RaisePropertyChanged("nomeempresaconsultante");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ordem-consulta")]
        public int ordemconsulta
        {
            get
            {
                return this.ordemconsultaField;
            }
            set
            {
                this.ordemconsultaField = value;
                this.RaisePropertyChanged("ordemconsulta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ordemconsultaSpecified
        {
            get
            {
                return this.ordemconsultaFieldSpecified;
            }
            set
            {
                this.ordemconsultaFieldSpecified = value;
                this.RaisePropertyChanged("ordemconsultaSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Consulta-Realizada-Cheque", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoConsultaRealizadaCheque : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ReferenciaComercial[] referenciacomercialField;

        private System.DateTime dataemissaoprimeirochequeField;

        private bool dataemissaoprimeirochequeFieldSpecified;

        private System.DateTime dataemissaoultimochequeField;

        private bool dataemissaoultimochequeFieldSpecified;

        private int totalchequesaprazoemitidosField;

        private bool totalchequesaprazoemitidosFieldSpecified;

        private int totalchequesaprazoentre31e60diasField;

        private bool totalchequesaprazoentre31e60diasFieldSpecified;

        private int totalchequesaprazoentre61e90diasField;

        private bool totalchequesaprazoentre61e90diasFieldSpecified;

        private int totalchequesaprazoultimos30diasField;

        private bool totalchequesaprazoultimos30diasFieldSpecified;

        private int totalchequesavistaField;

        private bool totalchequesavistaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("referencia-comercial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public ReferenciaComercial[] referenciacomercial
        {
            get
            {
                return this.referenciacomercialField;
            }
            set
            {
                this.referenciacomercialField = value;
                this.RaisePropertyChanged("referenciacomercial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-emissao-primeiro-cheque")]
        public System.DateTime dataemissaoprimeirocheque
        {
            get
            {
                return this.dataemissaoprimeirochequeField;
            }
            set
            {
                this.dataemissaoprimeirochequeField = value;
                this.RaisePropertyChanged("dataemissaoprimeirocheque");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataemissaoprimeirochequeSpecified
        {
            get
            {
                return this.dataemissaoprimeirochequeFieldSpecified;
            }
            set
            {
                this.dataemissaoprimeirochequeFieldSpecified = value;
                this.RaisePropertyChanged("dataemissaoprimeirochequeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-emissao-ultimo-cheque")]
        public System.DateTime dataemissaoultimocheque
        {
            get
            {
                return this.dataemissaoultimochequeField;
            }
            set
            {
                this.dataemissaoultimochequeField = value;
                this.RaisePropertyChanged("dataemissaoultimocheque");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataemissaoultimochequeSpecified
        {
            get
            {
                return this.dataemissaoultimochequeFieldSpecified;
            }
            set
            {
                this.dataemissaoultimochequeFieldSpecified = value;
                this.RaisePropertyChanged("dataemissaoultimochequeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("total-cheques-a-prazo-emitidos")]
        public int totalchequesaprazoemitidos
        {
            get
            {
                return this.totalchequesaprazoemitidosField;
            }
            set
            {
                this.totalchequesaprazoemitidosField = value;
                this.RaisePropertyChanged("totalchequesaprazoemitidos");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalchequesaprazoemitidosSpecified
        {
            get
            {
                return this.totalchequesaprazoemitidosFieldSpecified;
            }
            set
            {
                this.totalchequesaprazoemitidosFieldSpecified = value;
                this.RaisePropertyChanged("totalchequesaprazoemitidosSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("total-cheques-a-prazo-entre-31-e-60dias")]
        public int totalchequesaprazoentre31e60dias
        {
            get
            {
                return this.totalchequesaprazoentre31e60diasField;
            }
            set
            {
                this.totalchequesaprazoentre31e60diasField = value;
                this.RaisePropertyChanged("totalchequesaprazoentre31e60dias");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalchequesaprazoentre31e60diasSpecified
        {
            get
            {
                return this.totalchequesaprazoentre31e60diasFieldSpecified;
            }
            set
            {
                this.totalchequesaprazoentre31e60diasFieldSpecified = value;
                this.RaisePropertyChanged("totalchequesaprazoentre31e60diasSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("total-cheques-a-prazo-entre-61-e-90dias")]
        public int totalchequesaprazoentre61e90dias
        {
            get
            {
                return this.totalchequesaprazoentre61e90diasField;
            }
            set
            {
                this.totalchequesaprazoentre61e90diasField = value;
                this.RaisePropertyChanged("totalchequesaprazoentre61e90dias");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalchequesaprazoentre61e90diasSpecified
        {
            get
            {
                return this.totalchequesaprazoentre61e90diasFieldSpecified;
            }
            set
            {
                this.totalchequesaprazoentre61e90diasFieldSpecified = value;
                this.RaisePropertyChanged("totalchequesaprazoentre61e90diasSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("total-cheques-a-prazo-ultimos-30dias")]
        public int totalchequesaprazoultimos30dias
        {
            get
            {
                return this.totalchequesaprazoultimos30diasField;
            }
            set
            {
                this.totalchequesaprazoultimos30diasField = value;
                this.RaisePropertyChanged("totalchequesaprazoultimos30dias");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalchequesaprazoultimos30diasSpecified
        {
            get
            {
                return this.totalchequesaprazoultimos30diasFieldSpecified;
            }
            set
            {
                this.totalchequesaprazoultimos30diasFieldSpecified = value;
                this.RaisePropertyChanged("totalchequesaprazoultimos30diasSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("total-cheques-a-vista")]
        public int totalchequesavista
        {
            get
            {
                return this.totalchequesavistaField;
            }
            set
            {
                this.totalchequesavistaField = value;
                this.RaisePropertyChanged("totalchequesavista");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalchequesavistaSpecified
        {
            get
            {
                return this.totalchequesavistaFieldSpecified;
            }
            set
            {
                this.totalchequesavistaFieldSpecified = value;
                this.RaisePropertyChanged("totalchequesavistaSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Ocorrencia-Recheque-Online", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class OcorrenciaRechequeOnline : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string bancoparticipacaorechequeonlineField;

        private string mensagemindisponibilidadeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("banco-participacao-recheque-online")]
        public string bancoparticipacaorechequeonline
        {
            get
            {
                return this.bancoparticipacaorechequeonlineField;
            }
            set
            {
                this.bancoparticipacaorechequeonlineField = value;
                this.RaisePropertyChanged("bancoparticipacaorechequeonline");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mensagem-indisponibilidade")]
        public string mensagemindisponibilidade
        {
            get
            {
                return this.mensagemindisponibilidadeField;
            }
            set
            {
                this.mensagemindisponibilidadeField = value;
                this.RaisePropertyChanged("mensagemindisponibilidade");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Cheque-Consulta-Online-SRS", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoChequeConsultaOnlineSRS : object, System.ComponentModel.INotifyPropertyChanged
    {

        private OcorrenciaRechequeOnline ocorrenciarechequeonlineField;

        private System.DateTime datasituacaocontacorrenteField;

        private bool datasituacaocontacorrenteFieldSpecified;

        private string mensagemsituacaocontacorrenteField;

        private string tipodocumentoidentificacaoField;

        private string tipopessoarechequeonlineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ocorrencia-recheque-online", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public OcorrenciaRechequeOnline ocorrenciarechequeonline
        {
            get
            {
                return this.ocorrenciarechequeonlineField;
            }
            set
            {
                this.ocorrenciarechequeonlineField = value;
                this.RaisePropertyChanged("ocorrenciarechequeonline");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-situacao-conta-corrente")]
        public System.DateTime datasituacaocontacorrente
        {
            get
            {
                return this.datasituacaocontacorrenteField;
            }
            set
            {
                this.datasituacaocontacorrenteField = value;
                this.RaisePropertyChanged("datasituacaocontacorrente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datasituacaocontacorrenteSpecified
        {
            get
            {
                return this.datasituacaocontacorrenteFieldSpecified;
            }
            set
            {
                this.datasituacaocontacorrenteFieldSpecified = value;
                this.RaisePropertyChanged("datasituacaocontacorrenteSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mensagem-situacao-conta-corrente")]
        public string mensagemsituacaocontacorrente
        {
            get
            {
                return this.mensagemsituacaocontacorrenteField;
            }
            set
            {
                this.mensagemsituacaocontacorrenteField = value;
                this.RaisePropertyChanged("mensagemsituacaocontacorrente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-documento-identificacao")]
        public string tipodocumentoidentificacao
        {
            get
            {
                return this.tipodocumentoidentificacaoField;
            }
            set
            {
                this.tipodocumentoidentificacaoField = value;
                this.RaisePropertyChanged("tipodocumentoidentificacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-pessoa-recheque-online")]
        public string tipopessoarechequeonline
        {
            get
            {
                return this.tipopessoarechequeonlineField;
            }
            set
            {
                this.tipopessoarechequeonlineField = value;
                this.RaisePropertyChanged("tipopessoarechequeonline");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Cheque-Sem-Fundo-Varejo", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoChequeSemFundoVarejo : object, System.ComponentModel.INotifyPropertyChanged
    {

        private DadosBancarios dadosbancariosField;

        private Cidade cidadeocorrenciaField;

        private System.DateTime dataocorrenciamaisrecenteField;

        private bool dataocorrenciamaisrecenteFieldSpecified;

        private int numerolojaField;

        private bool numerolojaFieldSpecified;

        private string origemocorrenciamaisrecenteField;

        private int quantidadechequesField;

        private bool quantidadechequesFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dados-bancarios", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public DadosBancarios dadosbancarios
        {
            get
            {
                return this.dadosbancariosField;
            }
            set
            {
                this.dadosbancariosField = value;
                this.RaisePropertyChanged("dadosbancarios");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cidade-ocorrencia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Cidade cidadeocorrencia
        {
            get
            {
                return this.cidadeocorrenciaField;
            }
            set
            {
                this.cidadeocorrenciaField = value;
                this.RaisePropertyChanged("cidadeocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ocorrencia-mais-recente")]
        public System.DateTime dataocorrenciamaisrecente
        {
            get
            {
                return this.dataocorrenciamaisrecenteField;
            }
            set
            {
                this.dataocorrenciamaisrecenteField = value;
                this.RaisePropertyChanged("dataocorrenciamaisrecente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataocorrenciamaisrecenteSpecified
        {
            get
            {
                return this.dataocorrenciamaisrecenteFieldSpecified;
            }
            set
            {
                this.dataocorrenciamaisrecenteFieldSpecified = value;
                this.RaisePropertyChanged("dataocorrenciamaisrecenteSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-loja")]
        public int numeroloja
        {
            get
            {
                return this.numerolojaField;
            }
            set
            {
                this.numerolojaField = value;
                this.RaisePropertyChanged("numeroloja");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numerolojaSpecified
        {
            get
            {
                return this.numerolojaFieldSpecified;
            }
            set
            {
                this.numerolojaFieldSpecified = value;
                this.RaisePropertyChanged("numerolojaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("origem-ocorrencia-mais-recente")]
        public string origemocorrenciamaisrecente
        {
            get
            {
                return this.origemocorrenciamaisrecenteField;
            }
            set
            {
                this.origemocorrenciamaisrecenteField = value;
                this.RaisePropertyChanged("origemocorrenciamaisrecente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-cheques")]
        public int quantidadecheques
        {
            get
            {
                return this.quantidadechequesField;
            }
            set
            {
                this.quantidadechequesField = value;
                this.RaisePropertyChanged("quantidadecheques");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadechequesSpecified
        {
            get
            {
                return this.quantidadechequesFieldSpecified;
            }
            set
            {
                this.quantidadechequesFieldSpecified = value;
                this.RaisePropertyChanged("quantidadechequesSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Pendencia-Financeira", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoPendenciaFinanceira : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Moeda moedaField;

        private NaturezaAnotacao naturezaanotacaoField;

        private Subjudice subjudiceField;

        private Cidade cidadeField;

        private bool avalistaField;

        private bool avalistaFieldSpecified;

        private string contratoField;

        private System.DateTime dataocorrenciaField;

        private bool dataocorrenciaFieldSpecified;

        private string filialField;

        private bool indicadorsubjudiceField;

        private bool indicadorsubjudiceFieldSpecified;

        private string origemField;

        private string tituloocorrenciaField;

        private decimal valorpendenciaField;

        private bool valorpendenciaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Moeda moeda
        {
            get
            {
                return this.moedaField;
            }
            set
            {
                this.moedaField = value;
                this.RaisePropertyChanged("moeda");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("natureza-anotacao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public NaturezaAnotacao naturezaanotacao
        {
            get
            {
                return this.naturezaanotacaoField;
            }
            set
            {
                this.naturezaanotacaoField = value;
                this.RaisePropertyChanged("naturezaanotacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public Subjudice subjudice
        {
            get
            {
                return this.subjudiceField;
            }
            set
            {
                this.subjudiceField = value;
                this.RaisePropertyChanged("subjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Cidade cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
                this.RaisePropertyChanged("cidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool avalista
        {
            get
            {
                return this.avalistaField;
            }
            set
            {
                this.avalistaField = value;
                this.RaisePropertyChanged("avalista");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool avalistaSpecified
        {
            get
            {
                return this.avalistaFieldSpecified;
            }
            set
            {
                this.avalistaFieldSpecified = value;
                this.RaisePropertyChanged("avalistaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contrato
        {
            get
            {
                return this.contratoField;
            }
            set
            {
                this.contratoField = value;
                this.RaisePropertyChanged("contrato");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ocorrencia")]
        public System.DateTime dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
                this.RaisePropertyChanged("dataocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataocorrenciaSpecified
        {
            get
            {
                return this.dataocorrenciaFieldSpecified;
            }
            set
            {
                this.dataocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataocorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filial
        {
            get
            {
                return this.filialField;
            }
            set
            {
                this.filialField = value;
                this.RaisePropertyChanged("filial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("indicador-subjudice")]
        public bool indicadorsubjudice
        {
            get
            {
                return this.indicadorsubjudiceField;
            }
            set
            {
                this.indicadorsubjudiceField = value;
                this.RaisePropertyChanged("indicadorsubjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indicadorsubjudiceSpecified
        {
            get
            {
                return this.indicadorsubjudiceFieldSpecified;
            }
            set
            {
                this.indicadorsubjudiceFieldSpecified = value;
                this.RaisePropertyChanged("indicadorsubjudiceSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
                this.RaisePropertyChanged("origem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("titulo-ocorrencia")]
        public string tituloocorrencia
        {
            get
            {
                return this.tituloocorrenciaField;
            }
            set
            {
                this.tituloocorrenciaField = value;
                this.RaisePropertyChanged("tituloocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-pendencia")]
        public decimal valorpendencia
        {
            get
            {
                return this.valorpendenciaField;
            }
            set
            {
                this.valorpendenciaField = value;
                this.RaisePropertyChanged("valorpendencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorpendenciaSpecified
        {
            get
            {
                return this.valorpendenciaFieldSpecified;
            }
            set
            {
                this.valorpendenciaFieldSpecified = value;
                this.RaisePropertyChanged("valorpendenciaSpecified");
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
    public partial class Moeda : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string simboloField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string simbolo
        {
            get
            {
                return this.simboloField;
            }
            set
            {
                this.simboloField = value;
                this.RaisePropertyChanged("simbolo");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Natureza-Anotacao", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class NaturezaAnotacao : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string descricaonaturezaanotacaoField;

        private string descricaocomplementarnaturezaanotacaoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("descricao-natureza-anotacao")]
        public string descricaonaturezaanotacao
        {
            get
            {
                return this.descricaonaturezaanotacaoField;
            }
            set
            {
                this.descricaonaturezaanotacaoField = value;
                this.RaisePropertyChanged("descricaonaturezaanotacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("descricao-complementar-natureza-anotacao")]
        public string descricaocomplementarnaturezaanotacao
        {
            get
            {
                return this.descricaocomplementarnaturezaanotacaoField;
            }
            set
            {
                this.descricaocomplementarnaturezaanotacaoField = value;
                this.RaisePropertyChanged("descricaocomplementarnaturezaanotacao");
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
    public partial class Subjudice : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string pracasubjudiceField;

        private string distritosubjudiceField;

        private string varasubjudiceField;

        private System.DateTime datasubjudiceField;

        private bool datasubjudiceFieldSpecified;

        private string processosubjudiceField;

        private string mensagemsubjudiceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("praca-subjudice")]
        public string pracasubjudice
        {
            get
            {
                return this.pracasubjudiceField;
            }
            set
            {
                this.pracasubjudiceField = value;
                this.RaisePropertyChanged("pracasubjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("distrito-subjudice")]
        public string distritosubjudice
        {
            get
            {
                return this.distritosubjudiceField;
            }
            set
            {
                this.distritosubjudiceField = value;
                this.RaisePropertyChanged("distritosubjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("vara-subjudice")]
        public string varasubjudice
        {
            get
            {
                return this.varasubjudiceField;
            }
            set
            {
                this.varasubjudiceField = value;
                this.RaisePropertyChanged("varasubjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-subjudice")]
        public System.DateTime datasubjudice
        {
            get
            {
                return this.datasubjudiceField;
            }
            set
            {
                this.datasubjudiceField = value;
                this.RaisePropertyChanged("datasubjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datasubjudiceSpecified
        {
            get
            {
                return this.datasubjudiceFieldSpecified;
            }
            set
            {
                this.datasubjudiceFieldSpecified = value;
                this.RaisePropertyChanged("datasubjudiceSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("processo-subjudice")]
        public string processosubjudice
        {
            get
            {
                return this.processosubjudiceField;
            }
            set
            {
                this.processosubjudiceField = value;
                this.RaisePropertyChanged("processosubjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mensagem-subjudice")]
        public string mensagemsubjudice
        {
            get
            {
                return this.mensagemsubjudiceField;
            }
            set
            {
                this.mensagemsubjudiceField = value;
                this.RaisePropertyChanged("mensagemsubjudice");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Restricao-Financeira", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRestricaoFinanceira : object, System.ComponentModel.INotifyPropertyChanged
    {

        private NaturezaAnotacao naturezaanotacaoField;

        private Subjudice subjudiceField;

        private DadosBancarios dadosbancariosField;

        private Cidade cidadeField;

        private bool avalistaField;

        private bool avalistaFieldSpecified;

        private string contratoField;

        private System.DateTime dataocorrenciaField;

        private bool dataocorrenciaFieldSpecified;

        private string filialField;

        private bool indicadorsubjudiceField;

        private bool indicadorsubjudiceFieldSpecified;

        private string origemField;

        private string tituloocorrenciaField;

        private decimal valorpendenciaField;

        private bool valorpendenciaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("natureza-anotacao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public NaturezaAnotacao naturezaanotacao
        {
            get
            {
                return this.naturezaanotacaoField;
            }
            set
            {
                this.naturezaanotacaoField = value;
                this.RaisePropertyChanged("naturezaanotacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Subjudice subjudice
        {
            get
            {
                return this.subjudiceField;
            }
            set
            {
                this.subjudiceField = value;
                this.RaisePropertyChanged("subjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dados-bancarios", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public DadosBancarios dadosbancarios
        {
            get
            {
                return this.dadosbancariosField;
            }
            set
            {
                this.dadosbancariosField = value;
                this.RaisePropertyChanged("dadosbancarios");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Cidade cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
                this.RaisePropertyChanged("cidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool avalista
        {
            get
            {
                return this.avalistaField;
            }
            set
            {
                this.avalistaField = value;
                this.RaisePropertyChanged("avalista");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool avalistaSpecified
        {
            get
            {
                return this.avalistaFieldSpecified;
            }
            set
            {
                this.avalistaFieldSpecified = value;
                this.RaisePropertyChanged("avalistaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contrato
        {
            get
            {
                return this.contratoField;
            }
            set
            {
                this.contratoField = value;
                this.RaisePropertyChanged("contrato");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ocorrencia")]
        public System.DateTime dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
                this.RaisePropertyChanged("dataocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataocorrenciaSpecified
        {
            get
            {
                return this.dataocorrenciaFieldSpecified;
            }
            set
            {
                this.dataocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataocorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filial
        {
            get
            {
                return this.filialField;
            }
            set
            {
                this.filialField = value;
                this.RaisePropertyChanged("filial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("indicador-subjudice")]
        public bool indicadorsubjudice
        {
            get
            {
                return this.indicadorsubjudiceField;
            }
            set
            {
                this.indicadorsubjudiceField = value;
                this.RaisePropertyChanged("indicadorsubjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indicadorsubjudiceSpecified
        {
            get
            {
                return this.indicadorsubjudiceFieldSpecified;
            }
            set
            {
                this.indicadorsubjudiceFieldSpecified = value;
                this.RaisePropertyChanged("indicadorsubjudiceSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
                this.RaisePropertyChanged("origem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("titulo-ocorrencia")]
        public string tituloocorrencia
        {
            get
            {
                return this.tituloocorrenciaField;
            }
            set
            {
                this.tituloocorrenciaField = value;
                this.RaisePropertyChanged("tituloocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-pendencia")]
        public decimal valorpendencia
        {
            get
            {
                return this.valorpendenciaField;
            }
            set
            {
                this.valorpendenciaField = value;
                this.RaisePropertyChanged("valorpendencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorpendenciaSpecified
        {
            get
            {
                return this.valorpendenciaFieldSpecified;
            }
            set
            {
                this.valorpendenciaFieldSpecified = value;
                this.RaisePropertyChanged("valorpendenciaSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Divida-Vencida", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoDividaVencida : object, System.ComponentModel.INotifyPropertyChanged
    {

        private NaturezaAnotacao naturezaanotacaoField;

        private Moeda moedaField;

        private Subjudice subjudiceField;

        private System.DateTime dataocorrenciaField;

        private bool dataocorrenciaFieldSpecified;

        private string instituicaofinanceiraField;

        private string localField;

        private string modalidadeField;

        private string tituloField;

        private decimal valordividaField;

        private bool valordividaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("natureza-anotacao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public NaturezaAnotacao naturezaanotacao
        {
            get
            {
                return this.naturezaanotacaoField;
            }
            set
            {
                this.naturezaanotacaoField = value;
                this.RaisePropertyChanged("naturezaanotacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Moeda moeda
        {
            get
            {
                return this.moedaField;
            }
            set
            {
                this.moedaField = value;
                this.RaisePropertyChanged("moeda");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public Subjudice subjudice
        {
            get
            {
                return this.subjudiceField;
            }
            set
            {
                this.subjudiceField = value;
                this.RaisePropertyChanged("subjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ocorrencia")]
        public System.DateTime dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
                this.RaisePropertyChanged("dataocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataocorrenciaSpecified
        {
            get
            {
                return this.dataocorrenciaFieldSpecified;
            }
            set
            {
                this.dataocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataocorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("instituicao-financeira")]
        public string instituicaofinanceira
        {
            get
            {
                return this.instituicaofinanceiraField;
            }
            set
            {
                this.instituicaofinanceiraField = value;
                this.RaisePropertyChanged("instituicaofinanceira");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string local
        {
            get
            {
                return this.localField;
            }
            set
            {
                this.localField = value;
                this.RaisePropertyChanged("local");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modalidade
        {
            get
            {
                return this.modalidadeField;
            }
            set
            {
                this.modalidadeField = value;
                this.RaisePropertyChanged("modalidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string titulo
        {
            get
            {
                return this.tituloField;
            }
            set
            {
                this.tituloField = value;
                this.RaisePropertyChanged("titulo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-divida")]
        public decimal valordivida
        {
            get
            {
                return this.valordividaField;
            }
            set
            {
                this.valordividaField = value;
                this.RaisePropertyChanged("valordivida");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valordividaSpecified
        {
            get
            {
                return this.valordividaFieldSpecified;
            }
            set
            {
                this.valordividaFieldSpecified = value;
                this.RaisePropertyChanged("valordividaSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Participacao-Falencia", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoParticipacaoFalencia : object, System.ComponentModel.INotifyPropertyChanged
    {

        private TipoAcao tipoacaoField;

        private NaturezaAnotacao naturezaanotacaoField;

        private Vara varacivelField;

        private System.DateTime dataacaoField;

        private bool dataacaoFieldSpecified;

        private string descricaotipoparticipacaoField;

        private string empresaparticipacaoField;

        private string qualificacaoparticipanteempresafalidaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipo-acao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public TipoAcao tipoacao
        {
            get
            {
                return this.tipoacaoField;
            }
            set
            {
                this.tipoacaoField = value;
                this.RaisePropertyChanged("tipoacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("natureza-anotacao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public NaturezaAnotacao naturezaanotacao
        {
            get
            {
                return this.naturezaanotacaoField;
            }
            set
            {
                this.naturezaanotacaoField = value;
                this.RaisePropertyChanged("naturezaanotacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vara-civel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public Vara varacivel
        {
            get
            {
                return this.varacivelField;
            }
            set
            {
                this.varacivelField = value;
                this.RaisePropertyChanged("varacivel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-acao")]
        public System.DateTime dataacao
        {
            get
            {
                return this.dataacaoField;
            }
            set
            {
                this.dataacaoField = value;
                this.RaisePropertyChanged("dataacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataacaoSpecified
        {
            get
            {
                return this.dataacaoFieldSpecified;
            }
            set
            {
                this.dataacaoFieldSpecified = value;
                this.RaisePropertyChanged("dataacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("descricao-tipo-participacao")]
        public string descricaotipoparticipacao
        {
            get
            {
                return this.descricaotipoparticipacaoField;
            }
            set
            {
                this.descricaotipoparticipacaoField = value;
                this.RaisePropertyChanged("descricaotipoparticipacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("empresa-participacao")]
        public string empresaparticipacao
        {
            get
            {
                return this.empresaparticipacaoField;
            }
            set
            {
                this.empresaparticipacaoField = value;
                this.RaisePropertyChanged("empresaparticipacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("qualificacao-participante-empresa-falida")]
        public string qualificacaoparticipanteempresafalida
        {
            get
            {
                return this.qualificacaoparticipanteempresafalidaField;
            }
            set
            {
                this.qualificacaoparticipanteempresafalidaField = value;
                this.RaisePropertyChanged("qualificacaoparticipanteempresafalida");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Tipo-Acao", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class TipoAcao : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string descricaoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
                this.RaisePropertyChanged("descricao");
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
    public partial class Vara : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cidade comarcaField;

        private string nomeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cidade comarca
        {
            get
            {
                return this.comarcaField;
            }
            set
            {
                this.comarcaField = value;
                this.RaisePropertyChanged("comarca");
            }
        }

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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoChequeOutrasOcorrenciasSRS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoContraOrdemSRS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoContraOrdemDocumentoDiferenteSRS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Contumacia-SRS", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoContumaciaSRS : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cheque chequeinicialField;

        private Cheque chequefinalField;

        private System.DateTime dataocorrenciaField;

        private bool dataocorrenciaFieldSpecified;

        private string motivoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cheque chequeinicial
        {
            get
            {
                return this.chequeinicialField;
            }
            set
            {
                this.chequeinicialField = value;
                this.RaisePropertyChanged("chequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-final", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Cheque chequefinal
        {
            get
            {
                return this.chequefinalField;
            }
            set
            {
                this.chequefinalField = value;
                this.RaisePropertyChanged("chequefinal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ocorrencia")]
        public System.DateTime dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
                this.RaisePropertyChanged("dataocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataocorrenciaSpecified
        {
            get
            {
                return this.dataocorrenciaFieldSpecified;
            }
            set
            {
                this.dataocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataocorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string motivo
        {
            get
            {
                return this.motivoField;
            }
            set
            {
                this.motivoField = value;
                this.RaisePropertyChanged("motivo");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Cheque-Outras-Ocorrencias-SRS", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoChequeOutrasOcorrenciasSRS : InsumoContumaciaSRS
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoContraOrdemDocumentoDiferenteSRS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Contra-Ordem-SRS", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoContraOrdemSRS : InsumoContumaciaSRS
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Contra-Ordem-Documento-Diferente-SRS", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoContraOrdemDocumentoDiferenteSRS : InsumoContraOrdemSRS
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Cheque-Sem-Fundo-Achei-CCF", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoChequeSemFundoAcheiCCF : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cheque chequeField;

        private Cidade cidadeField;

        private NaturezaAnotacao naturezaanotacaoField;

        private System.DateTime dataocorrenciaField;

        private bool dataocorrenciaFieldSpecified;

        private string numerochequeField;

        private int quantidadebancoField;

        private bool quantidadebancoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cheque cheque
        {
            get
            {
                return this.chequeField;
            }
            set
            {
                this.chequeField = value;
                this.RaisePropertyChanged("cheque");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Cidade cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
                this.RaisePropertyChanged("cidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("natureza-anotacao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public NaturezaAnotacao naturezaanotacao
        {
            get
            {
                return this.naturezaanotacaoField;
            }
            set
            {
                this.naturezaanotacaoField = value;
                this.RaisePropertyChanged("naturezaanotacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ocorrencia")]
        public System.DateTime dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
                this.RaisePropertyChanged("dataocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataocorrenciaSpecified
        {
            get
            {
                return this.dataocorrenciaFieldSpecified;
            }
            set
            {
                this.dataocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataocorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-cheque")]
        public string numerocheque
        {
            get
            {
                return this.numerochequeField;
            }
            set
            {
                this.numerochequeField = value;
                this.RaisePropertyChanged("numerocheque");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-banco")]
        public int quantidadebanco
        {
            get
            {
                return this.quantidadebancoField;
            }
            set
            {
                this.quantidadebancoField = value;
                this.RaisePropertyChanged("quantidadebanco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadebancoSpecified
        {
            get
            {
                return this.quantidadebancoFieldSpecified;
            }
            set
            {
                this.quantidadebancoFieldSpecified = value;
                this.RaisePropertyChanged("quantidadebancoSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Cheque-Sem-Fundo-Achei", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoChequeSemFundoAchei : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cheque chequeField;

        private Cidade cidadeField;

        private NaturezaAnotacao naturezaanotacaoField;

        private Alinea alineaField;

        private Moeda moedaField;

        private System.DateTime dataocorrenciaField;

        private bool dataocorrenciaFieldSpecified;

        private int quantidadebancoField;

        private bool quantidadebancoFieldSpecified;

        private string titularidadecontacorrenteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cheque cheque
        {
            get
            {
                return this.chequeField;
            }
            set
            {
                this.chequeField = value;
                this.RaisePropertyChanged("cheque");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Cidade cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
                this.RaisePropertyChanged("cidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("natureza-anotacao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public NaturezaAnotacao naturezaanotacao
        {
            get
            {
                return this.naturezaanotacaoField;
            }
            set
            {
                this.naturezaanotacaoField = value;
                this.RaisePropertyChanged("naturezaanotacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Alinea alinea
        {
            get
            {
                return this.alineaField;
            }
            set
            {
                this.alineaField = value;
                this.RaisePropertyChanged("alinea");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public Moeda moeda
        {
            get
            {
                return this.moedaField;
            }
            set
            {
                this.moedaField = value;
                this.RaisePropertyChanged("moeda");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ocorrencia")]
        public System.DateTime dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
                this.RaisePropertyChanged("dataocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataocorrenciaSpecified
        {
            get
            {
                return this.dataocorrenciaFieldSpecified;
            }
            set
            {
                this.dataocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataocorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-banco")]
        public int quantidadebanco
        {
            get
            {
                return this.quantidadebancoField;
            }
            set
            {
                this.quantidadebancoField = value;
                this.RaisePropertyChanged("quantidadebanco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadebancoSpecified
        {
            get
            {
                return this.quantidadebancoFieldSpecified;
            }
            set
            {
                this.quantidadebancoFieldSpecified = value;
                this.RaisePropertyChanged("quantidadebancoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("titularidade-conta-corrente")]
        public string titularidadecontacorrente
        {
            get
            {
                return this.titularidadecontacorrenteField;
            }
            set
            {
                this.titularidadecontacorrenteField = value;
                this.RaisePropertyChanged("titularidadecontacorrente");
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
    public partial class Alinea : object, System.ComponentModel.INotifyPropertyChanged
    {

        private long codigoField;

        private bool codigoFieldSpecified;

        private string descricaoField;

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
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
                this.RaisePropertyChanged("descricao");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Mensagem-Riskscoring", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class MensagemRiskscoring : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime datamensagemriskscoringField;

        private bool datamensagemriskscoringFieldSpecified;

        private string textomensagemriskscoringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-mensagem-riskscoring")]
        public System.DateTime datamensagemriskscoring
        {
            get
            {
                return this.datamensagemriskscoringField;
            }
            set
            {
                this.datamensagemriskscoringField = value;
                this.RaisePropertyChanged("datamensagemriskscoring");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datamensagemriskscoringSpecified
        {
            get
            {
                return this.datamensagemriskscoringFieldSpecified;
            }
            set
            {
                this.datamensagemriskscoringFieldSpecified = value;
                this.RaisePropertyChanged("datamensagemriskscoringSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("texto-mensagem-riskscoring")]
        public string textomensagemriskscoring
        {
            get
            {
                return this.textomensagemriskscoringField;
            }
            set
            {
                this.textomensagemriskscoringField = value;
                this.RaisePropertyChanged("textomensagemriskscoring");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoRiskscoring12Meses))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Riskscoring-6-Meses", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRiskscoring6Meses : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int horizontetempoField;

        private bool horizontetempoFieldSpecified;

        private string mensageminterpretacaoField;

        private string mensagemprinadField;

        private MensagemRiskscoring[] mensagemriskscoringField;

        private System.DateTime datafatorField;

        private bool datafatorFieldSpecified;

        private decimal fatorprinadField;

        private bool fatorprinadFieldSpecified;

        private decimal fatorriskscoringField;

        private bool fatorriskscoringFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("horizonte-tempo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int horizontetempo
        {
            get
            {
                return this.horizontetempoField;
            }
            set
            {
                this.horizontetempoField = value;
                this.RaisePropertyChanged("horizontetempo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horizontetempoSpecified
        {
            get
            {
                return this.horizontetempoFieldSpecified;
            }
            set
            {
                this.horizontetempoFieldSpecified = value;
                this.RaisePropertyChanged("horizontetempoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mensagem-interpretacao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string mensageminterpretacao
        {
            get
            {
                return this.mensageminterpretacaoField;
            }
            set
            {
                this.mensageminterpretacaoField = value;
                this.RaisePropertyChanged("mensageminterpretacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mensagem-prinad", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string mensagemprinad
        {
            get
            {
                return this.mensagemprinadField;
            }
            set
            {
                this.mensagemprinadField = value;
                this.RaisePropertyChanged("mensagemprinad");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mensagem-riskscoring", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public MensagemRiskscoring[] mensagemriskscoring
        {
            get
            {
                return this.mensagemriskscoringField;
            }
            set
            {
                this.mensagemriskscoringField = value;
                this.RaisePropertyChanged("mensagemriskscoring");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-fator")]
        public System.DateTime datafator
        {
            get
            {
                return this.datafatorField;
            }
            set
            {
                this.datafatorField = value;
                this.RaisePropertyChanged("datafator");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datafatorSpecified
        {
            get
            {
                return this.datafatorFieldSpecified;
            }
            set
            {
                this.datafatorFieldSpecified = value;
                this.RaisePropertyChanged("datafatorSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("fator-prinad")]
        public decimal fatorprinad
        {
            get
            {
                return this.fatorprinadField;
            }
            set
            {
                this.fatorprinadField = value;
                this.RaisePropertyChanged("fatorprinad");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fatorprinadSpecified
        {
            get
            {
                return this.fatorprinadFieldSpecified;
            }
            set
            {
                this.fatorprinadFieldSpecified = value;
                this.RaisePropertyChanged("fatorprinadSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("fator-riskscoring")]
        public decimal fatorriskscoring
        {
            get
            {
                return this.fatorriskscoringField;
            }
            set
            {
                this.fatorriskscoringField = value;
                this.RaisePropertyChanged("fatorriskscoring");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fatorriskscoringSpecified
        {
            get
            {
                return this.fatorriskscoringFieldSpecified;
            }
            set
            {
                this.fatorriskscoringFieldSpecified = value;
                this.RaisePropertyChanged("fatorriskscoringSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Riskscoring-12-Meses", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoRiskscoring12Meses : InsumoRiskscoring6Meses
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Informacao-Poder-Judiciario", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoInformacaoPoderJudiciario : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Vara varaField;

        private System.DateTime datadocumentoField;

        private bool datadocumentoFieldSpecified;

        private System.DateTime datainclusaoField;

        private bool datainclusaoFieldSpecified;

        private System.DateTime datavencimentoField;

        private bool datavencimentoFieldSpecified;

        private string entidadeorigemField;

        private string numeroprocessoField;

        private decimal valorField;

        private bool valorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Vara vara
        {
            get
            {
                return this.varaField;
            }
            set
            {
                this.varaField = value;
                this.RaisePropertyChanged("vara");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-documento")]
        public System.DateTime datadocumento
        {
            get
            {
                return this.datadocumentoField;
            }
            set
            {
                this.datadocumentoField = value;
                this.RaisePropertyChanged("datadocumento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datadocumentoSpecified
        {
            get
            {
                return this.datadocumentoFieldSpecified;
            }
            set
            {
                this.datadocumentoFieldSpecified = value;
                this.RaisePropertyChanged("datadocumentoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-inclusao")]
        public System.DateTime datainclusao
        {
            get
            {
                return this.datainclusaoField;
            }
            set
            {
                this.datainclusaoField = value;
                this.RaisePropertyChanged("datainclusao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datainclusaoSpecified
        {
            get
            {
                return this.datainclusaoFieldSpecified;
            }
            set
            {
                this.datainclusaoFieldSpecified = value;
                this.RaisePropertyChanged("datainclusaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-vencimento")]
        public System.DateTime datavencimento
        {
            get
            {
                return this.datavencimentoField;
            }
            set
            {
                this.datavencimentoField = value;
                this.RaisePropertyChanged("datavencimento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datavencimentoSpecified
        {
            get
            {
                return this.datavencimentoFieldSpecified;
            }
            set
            {
                this.datavencimentoFieldSpecified = value;
                this.RaisePropertyChanged("datavencimentoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("entidade-origem")]
        public string entidadeorigem
        {
            get
            {
                return this.entidadeorigemField;
            }
            set
            {
                this.entidadeorigemField = value;
                this.RaisePropertyChanged("entidadeorigem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-processo")]
        public string numeroprocesso
        {
            get
            {
                return this.numeroprocessoField;
            }
            set
            {
                this.numeroprocessoField = value;
                this.RaisePropertyChanged("numeroprocesso");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
                this.RaisePropertyChanged("valorSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Ocorrencia-Consumidor", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoOcorrenciaConsumidor : object, System.ComponentModel.INotifyPropertyChanged
    {

        private EnderecoOcorrenciaConsumidor enderecoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public EnderecoOcorrenciaConsumidor endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
                this.RaisePropertyChanged("endereco");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Telefone-Consultado", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoTelefoneConsultado : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Telefone telefoneField;

        private System.DateTime dataprimeiraconsultaField;

        private bool dataprimeiraconsultaFieldSpecified;

        private System.DateTime dataultimaconsultaField;

        private bool dataultimaconsultaFieldSpecified;

        private long quantidadeconsultaField;

        private bool quantidadeconsultaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Telefone telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
                this.RaisePropertyChanged("telefone");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-primeira-consulta")]
        public System.DateTime dataprimeiraconsulta
        {
            get
            {
                return this.dataprimeiraconsultaField;
            }
            set
            {
                this.dataprimeiraconsultaField = value;
                this.RaisePropertyChanged("dataprimeiraconsulta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataprimeiraconsultaSpecified
        {
            get
            {
                return this.dataprimeiraconsultaFieldSpecified;
            }
            set
            {
                this.dataprimeiraconsultaFieldSpecified = value;
                this.RaisePropertyChanged("dataprimeiraconsultaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ultima-consulta")]
        public System.DateTime dataultimaconsulta
        {
            get
            {
                return this.dataultimaconsultaField;
            }
            set
            {
                this.dataultimaconsultaField = value;
                this.RaisePropertyChanged("dataultimaconsulta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataultimaconsultaSpecified
        {
            get
            {
                return this.dataultimaconsultaFieldSpecified;
            }
            set
            {
                this.dataultimaconsultaFieldSpecified = value;
                this.RaisePropertyChanged("dataultimaconsultaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-consulta")]
        public long quantidadeconsulta
        {
            get
            {
                return this.quantidadeconsultaField;
            }
            set
            {
                this.quantidadeconsultaField = value;
                this.RaisePropertyChanged("quantidadeconsulta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadeconsultaSpecified
        {
            get
            {
                return this.quantidadeconsultaFieldSpecified;
            }
            set
            {
                this.quantidadeconsultaFieldSpecified = value;
                this.RaisePropertyChanged("quantidadeconsultaSpecified");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoTelefoneVinculadoAssinanteConsultado))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Telefone-Vinculado-Consumidor", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoTelefoneVinculadoConsumidor : object, System.ComponentModel.INotifyPropertyChanged
    {

        private AssinanteTelefone assinanteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public AssinanteTelefone assinante
        {
            get
            {
                return this.assinanteField;
            }
            set
            {
                this.assinanteField = value;
                this.RaisePropertyChanged("assinante");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Assinante-Telefone", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class AssinanteTelefone : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Telefone telefoneField;

        private EnderecoAssinanteTelefone enderecoField;

        private string nomeField;

        private string tempoinstalacaoField;

        private TipoAssinanteTelefone tipotelefoneField;

        private bool tipotelefoneFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Telefone telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
                this.RaisePropertyChanged("telefone");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public EnderecoAssinanteTelefone endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
                this.RaisePropertyChanged("endereco");
            }
        }

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
        [System.Xml.Serialization.XmlAttributeAttribute("tempo-instalacao")]
        public string tempoinstalacao
        {
            get
            {
                return this.tempoinstalacaoField;
            }
            set
            {
                this.tempoinstalacaoField = value;
                this.RaisePropertyChanged("tempoinstalacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-telefone")]
        public TipoAssinanteTelefone tipotelefone
        {
            get
            {
                return this.tipotelefoneField;
            }
            set
            {
                this.tipotelefoneField = value;
                this.RaisePropertyChanged("tipotelefone");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipotelefoneSpecified
        {
            get
            {
                return this.tipotelefoneFieldSpecified;
            }
            set
            {
                this.tipotelefoneFieldSpecified = value;
                this.RaisePropertyChanged("tipotelefoneSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Tipo-Assinante-Telefone", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public enum TipoAssinanteTelefone
    {

        /// <remarks/>
        Celular,

        /// <remarks/>
        Fixo,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Telefone-Vinculado-Assinante-Consultado", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoTelefoneVinculadoAssinanteConsultado : InsumoTelefoneVinculadoConsumidor
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Dados-Telefone-Consultado", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoDadosTelefoneConsultado : object, System.ComponentModel.INotifyPropertyChanged
    {

        private AssinanteTelefone assinanteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public AssinanteTelefone assinante
        {
            get
            {
                return this.assinanteField;
            }
            set
            {
                this.assinanteField = value;
                this.RaisePropertyChanged("assinante");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Endereco-CEP-Consultado", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoEnderecoCEPConsultado : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Endereco enderecoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Endereco endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
                this.RaisePropertyChanged("endereco");
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
    public partial class Pais : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nomeField;

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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoQuadroAdministrativo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoParticipacaoEmpresas))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Quadro-Societario", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoQuadroSocietario : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Pais nacionalidadeField;

        private Estado estadoEMBRATELField;

        private string cargoadministracaoField;

        private string cargodirecaoField;

        private string condicaoField;

        private System.DateTime dataentradaField;

        private bool dataentradaFieldSpecified;

        private System.DateTime datasaidaField;

        private bool datasaidaFieldSpecified;

        private string documentoField;

        private string municipioEMBRATELField;

        private string nomeField;

        private decimal porcentualparticipacaoField;

        private bool porcentualparticipacaoFieldSpecified;

        private string situacaodocumentoField;

        private string tiporelacionamentoField;

        private System.DateTime dataultimaatualizacaoField;

        private bool dataultimaatualizacaoFieldSpecified;

        private decimal valorparticipacaoField;

        private bool valorparticipacaoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Pais nacionalidade
        {
            get
            {
                return this.nacionalidadeField;
            }
            set
            {
                this.nacionalidadeField = value;
                this.RaisePropertyChanged("nacionalidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estado-EMBRATEL", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Estado estadoEMBRATEL
        {
            get
            {
                return this.estadoEMBRATELField;
            }
            set
            {
                this.estadoEMBRATELField = value;
                this.RaisePropertyChanged("estadoEMBRATEL");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("cargo-administracao")]
        public string cargoadministracao
        {
            get
            {
                return this.cargoadministracaoField;
            }
            set
            {
                this.cargoadministracaoField = value;
                this.RaisePropertyChanged("cargoadministracao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("cargo-direcao")]
        public string cargodirecao
        {
            get
            {
                return this.cargodirecaoField;
            }
            set
            {
                this.cargodirecaoField = value;
                this.RaisePropertyChanged("cargodirecao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string condicao
        {
            get
            {
                return this.condicaoField;
            }
            set
            {
                this.condicaoField = value;
                this.RaisePropertyChanged("condicao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-entrada")]
        public System.DateTime dataentrada
        {
            get
            {
                return this.dataentradaField;
            }
            set
            {
                this.dataentradaField = value;
                this.RaisePropertyChanged("dataentrada");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataentradaSpecified
        {
            get
            {
                return this.dataentradaFieldSpecified;
            }
            set
            {
                this.dataentradaFieldSpecified = value;
                this.RaisePropertyChanged("dataentradaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-saida")]
        public System.DateTime datasaida
        {
            get
            {
                return this.datasaidaField;
            }
            set
            {
                this.datasaidaField = value;
                this.RaisePropertyChanged("datasaida");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datasaidaSpecified
        {
            get
            {
                return this.datasaidaFieldSpecified;
            }
            set
            {
                this.datasaidaFieldSpecified = value;
                this.RaisePropertyChanged("datasaidaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
                this.RaisePropertyChanged("documento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("municipio-EMBRATEL")]
        public string municipioEMBRATEL
        {
            get
            {
                return this.municipioEMBRATELField;
            }
            set
            {
                this.municipioEMBRATELField = value;
                this.RaisePropertyChanged("municipioEMBRATEL");
            }
        }

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
        [System.Xml.Serialization.XmlAttributeAttribute("porcentual-participacao")]
        public decimal porcentualparticipacao
        {
            get
            {
                return this.porcentualparticipacaoField;
            }
            set
            {
                this.porcentualparticipacaoField = value;
                this.RaisePropertyChanged("porcentualparticipacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool porcentualparticipacaoSpecified
        {
            get
            {
                return this.porcentualparticipacaoFieldSpecified;
            }
            set
            {
                this.porcentualparticipacaoFieldSpecified = value;
                this.RaisePropertyChanged("porcentualparticipacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("situacao-documento")]
        public string situacaodocumento
        {
            get
            {
                return this.situacaodocumentoField;
            }
            set
            {
                this.situacaodocumentoField = value;
                this.RaisePropertyChanged("situacaodocumento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tipo-relacionamento")]
        public string tiporelacionamento
        {
            get
            {
                return this.tiporelacionamentoField;
            }
            set
            {
                this.tiporelacionamentoField = value;
                this.RaisePropertyChanged("tiporelacionamento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ultima-atualizacao")]
        public System.DateTime dataultimaatualizacao
        {
            get
            {
                return this.dataultimaatualizacaoField;
            }
            set
            {
                this.dataultimaatualizacaoField = value;
                this.RaisePropertyChanged("dataultimaatualizacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataultimaatualizacaoSpecified
        {
            get
            {
                return this.dataultimaatualizacaoFieldSpecified;
            }
            set
            {
                this.dataultimaatualizacaoFieldSpecified = value;
                this.RaisePropertyChanged("dataultimaatualizacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-participacao")]
        public decimal valorparticipacao
        {
            get
            {
                return this.valorparticipacaoField;
            }
            set
            {
                this.valorparticipacaoField = value;
                this.RaisePropertyChanged("valorparticipacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorparticipacaoSpecified
        {
            get
            {
                return this.valorparticipacaoFieldSpecified;
            }
            set
            {
                this.valorparticipacaoFieldSpecified = value;
                this.RaisePropertyChanged("valorparticipacaoSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Quadro-Administrativo", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoQuadroAdministrativo : InsumoQuadroSocietario
    {

        private string estadocivilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("estado-civil")]
        public string estadocivil
        {
            get
            {
                return this.estadocivilField;
            }
            set
            {
                this.estadocivilField = value;
                this.RaisePropertyChanged("estadocivil");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Participacao-Empresas", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoParticipacaoEmpresas : InsumoQuadroSocietario
    {

        private InsumoQuadroSocietario[] participanteField;

        private bool indicadorrestricaoField;

        private bool indicadorrestricaoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("participante", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public InsumoQuadroSocietario[] participante
        {
            get
            {
                return this.participanteField;
            }
            set
            {
                this.participanteField = value;
                this.RaisePropertyChanged("participante");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("indicador-restricao")]
        public bool indicadorrestricao
        {
            get
            {
                return this.indicadorrestricaoField;
            }
            set
            {
                this.indicadorrestricaoField = value;
                this.RaisePropertyChanged("indicadorrestricao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indicadorrestricaoSpecified
        {
            get
            {
                return this.indicadorrestricaoFieldSpecified;
            }
            set
            {
                this.indicadorrestricaoFieldSpecified = value;
                this.RaisePropertyChanged("indicadorrestricaoSpecified");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class Cartorio : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cidade cidadeField;

        private string nomeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cidade cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
                this.RaisePropertyChanged("cidade");
            }
        }

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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Protesto", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoProtesto : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cartorio cartorioField;

        private NaturezaAnotacao naturezaanotacaoField;

        private Subjudice subjudiceField;

        private Moeda moedaField;

        private CartaAnuencia cartaanuenciaField;

        private bool cartaanuenciaFieldSpecified;

        private System.DateTime datacartaanuenciaField;

        private bool datacartaanuenciaFieldSpecified;

        private System.DateTime datainclusaoField;

        private bool datainclusaoFieldSpecified;

        private System.DateTime dataprotestoField;

        private bool dataprotestoFieldSpecified;

        private string requerentecredorField;

        private string numeroprotestoField;

        private decimal valorField;

        private bool valorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cartorio cartorio
        {
            get
            {
                return this.cartorioField;
            }
            set
            {
                this.cartorioField = value;
                this.RaisePropertyChanged("cartorio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("natureza-anotacao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public NaturezaAnotacao naturezaanotacao
        {
            get
            {
                return this.naturezaanotacaoField;
            }
            set
            {
                this.naturezaanotacaoField = value;
                this.RaisePropertyChanged("naturezaanotacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public Subjudice subjudice
        {
            get
            {
                return this.subjudiceField;
            }
            set
            {
                this.subjudiceField = value;
                this.RaisePropertyChanged("subjudice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Moeda moeda
        {
            get
            {
                return this.moedaField;
            }
            set
            {
                this.moedaField = value;
                this.RaisePropertyChanged("moeda");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("carta-anuencia")]
        public CartaAnuencia cartaanuencia
        {
            get
            {
                return this.cartaanuenciaField;
            }
            set
            {
                this.cartaanuenciaField = value;
                this.RaisePropertyChanged("cartaanuencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cartaanuenciaSpecified
        {
            get
            {
                return this.cartaanuenciaFieldSpecified;
            }
            set
            {
                this.cartaanuenciaFieldSpecified = value;
                this.RaisePropertyChanged("cartaanuenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-carta-anuencia")]
        public System.DateTime datacartaanuencia
        {
            get
            {
                return this.datacartaanuenciaField;
            }
            set
            {
                this.datacartaanuenciaField = value;
                this.RaisePropertyChanged("datacartaanuencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datacartaanuenciaSpecified
        {
            get
            {
                return this.datacartaanuenciaFieldSpecified;
            }
            set
            {
                this.datacartaanuenciaFieldSpecified = value;
                this.RaisePropertyChanged("datacartaanuenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-inclusao")]
        public System.DateTime datainclusao
        {
            get
            {
                return this.datainclusaoField;
            }
            set
            {
                this.datainclusaoField = value;
                this.RaisePropertyChanged("datainclusao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datainclusaoSpecified
        {
            get
            {
                return this.datainclusaoFieldSpecified;
            }
            set
            {
                this.datainclusaoFieldSpecified = value;
                this.RaisePropertyChanged("datainclusaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-protesto")]
        public System.DateTime dataprotesto
        {
            get
            {
                return this.dataprotestoField;
            }
            set
            {
                this.dataprotestoField = value;
                this.RaisePropertyChanged("dataprotesto");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataprotestoSpecified
        {
            get
            {
                return this.dataprotestoFieldSpecified;
            }
            set
            {
                this.dataprotestoFieldSpecified = value;
                this.RaisePropertyChanged("dataprotestoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("requerente-credor")]
        public string requerentecredor
        {
            get
            {
                return this.requerentecredorField;
            }
            set
            {
                this.requerentecredorField = value;
                this.RaisePropertyChanged("requerentecredor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-protesto")]
        public string numeroprotesto
        {
            get
            {
                return this.numeroprotestoField;
            }
            set
            {
                this.numeroprotestoField = value;
                this.RaisePropertyChanged("numeroprotesto");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
                this.RaisePropertyChanged("valorSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Carta-Anuencia", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public enum CartaAnuencia
    {

        /// <remarks/>
        CREDOR,

        /// <remarks/>
        CREDOR_ELETRONICA,

        /// <remarks/>
        DEVEDOR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Acao", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoAcao : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Vara varaField;

        private TipoAcao tipoacaoField;

        private System.DateTime dataacaoField;

        private bool dataacaoFieldSpecified;

        private System.DateTime datainclusaoField;

        private bool datainclusaoFieldSpecified;

        private string distritoField;

        private string nomeautorField;

        private decimal valoracaoField;

        private bool valoracaoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Vara vara
        {
            get
            {
                return this.varaField;
            }
            set
            {
                this.varaField = value;
                this.RaisePropertyChanged("vara");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipo-acao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public TipoAcao tipoacao
        {
            get
            {
                return this.tipoacaoField;
            }
            set
            {
                this.tipoacaoField = value;
                this.RaisePropertyChanged("tipoacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-acao")]
        public System.DateTime dataacao
        {
            get
            {
                return this.dataacaoField;
            }
            set
            {
                this.dataacaoField = value;
                this.RaisePropertyChanged("dataacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataacaoSpecified
        {
            get
            {
                return this.dataacaoFieldSpecified;
            }
            set
            {
                this.dataacaoFieldSpecified = value;
                this.RaisePropertyChanged("dataacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-inclusao")]
        public System.DateTime datainclusao
        {
            get
            {
                return this.datainclusaoField;
            }
            set
            {
                this.datainclusaoField = value;
                this.RaisePropertyChanged("datainclusao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datainclusaoSpecified
        {
            get
            {
                return this.datainclusaoFieldSpecified;
            }
            set
            {
                this.datainclusaoFieldSpecified = value;
                this.RaisePropertyChanged("datainclusaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string distrito
        {
            get
            {
                return this.distritoField;
            }
            set
            {
                this.distritoField = value;
                this.RaisePropertyChanged("distrito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-autor")]
        public string nomeautor
        {
            get
            {
                return this.nomeautorField;
            }
            set
            {
                this.nomeautorField = value;
                this.RaisePropertyChanged("nomeautor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-acao")]
        public decimal valoracao
        {
            get
            {
                return this.valoracaoField;
            }
            set
            {
                this.valoracaoField = value;
                this.RaisePropertyChanged("valoracao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valoracaoSpecified
        {
            get
            {
                return this.valoracaoFieldSpecified;
            }
            set
            {
                this.valoracaoFieldSpecified = value;
                this.RaisePropertyChanged("valoracaoSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Tipo-Documento-Alerta", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class TipoDocumentoAlerta : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nomeField;

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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Alerta-Documento", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoAlertaDocumento : object, System.ComponentModel.INotifyPropertyChanged
    {

        private TipoDocumentoAlerta[] tipodocumentoalertaField;

        private System.DateTime datainclusaoField;

        private bool datainclusaoFieldSpecified;

        private System.DateTime dataocorrenciaField;

        private bool dataocorrenciaFieldSpecified;

        private string entidadeorigemField;

        private string motivoField;

        private string observacaoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipo-documento-alerta", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public TipoDocumentoAlerta[] tipodocumentoalerta
        {
            get
            {
                return this.tipodocumentoalertaField;
            }
            set
            {
                this.tipodocumentoalertaField = value;
                this.RaisePropertyChanged("tipodocumentoalerta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-inclusao")]
        public System.DateTime datainclusao
        {
            get
            {
                return this.datainclusaoField;
            }
            set
            {
                this.datainclusaoField = value;
                this.RaisePropertyChanged("datainclusao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datainclusaoSpecified
        {
            get
            {
                return this.datainclusaoFieldSpecified;
            }
            set
            {
                this.datainclusaoFieldSpecified = value;
                this.RaisePropertyChanged("datainclusaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ocorrencia")]
        public System.DateTime dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
                this.RaisePropertyChanged("dataocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataocorrenciaSpecified
        {
            get
            {
                return this.dataocorrenciaFieldSpecified;
            }
            set
            {
                this.dataocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataocorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("entidade-origem")]
        public string entidadeorigem
        {
            get
            {
                return this.entidadeorigemField;
            }
            set
            {
                this.entidadeorigemField = value;
                this.RaisePropertyChanged("entidadeorigem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string motivo
        {
            get
            {
                return this.motivoField;
            }
            set
            {
                this.motivoField = value;
                this.RaisePropertyChanged("motivo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string observacao
        {
            get
            {
                return this.observacaoField;
            }
            set
            {
                this.observacaoField = value;
                this.RaisePropertyChanged("observacao");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Credito-Concedido", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoCreditoConcedido : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string numero_contratoField;

        private int anovencimentoField;

        private bool anovencimentoFieldSpecified;

        private int mesvencimentoField;

        private bool mesvencimentoFieldSpecified;

        private int quantidadecreditoField;

        private bool quantidadecreditoFieldSpecified;

        private decimal valorField;

        private bool valorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string numero_contrato
        {
            get
            {
                return this.numero_contratoField;
            }
            set
            {
                this.numero_contratoField = value;
                this.RaisePropertyChanged("numero_contrato");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ano-vencimento")]
        public int anovencimento
        {
            get
            {
                return this.anovencimentoField;
            }
            set
            {
                this.anovencimentoField = value;
                this.RaisePropertyChanged("anovencimento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool anovencimentoSpecified
        {
            get
            {
                return this.anovencimentoFieldSpecified;
            }
            set
            {
                this.anovencimentoFieldSpecified = value;
                this.RaisePropertyChanged("anovencimentoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mes-vencimento")]
        public int mesvencimento
        {
            get
            {
                return this.mesvencimentoField;
            }
            set
            {
                this.mesvencimentoField = value;
                this.RaisePropertyChanged("mesvencimento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mesvencimentoSpecified
        {
            get
            {
                return this.mesvencimentoFieldSpecified;
            }
            set
            {
                this.mesvencimentoFieldSpecified = value;
                this.RaisePropertyChanged("mesvencimentoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-credito")]
        public int quantidadecredito
        {
            get
            {
                return this.quantidadecreditoField;
            }
            set
            {
                this.quantidadecreditoField = value;
                this.RaisePropertyChanged("quantidadecredito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadecreditoSpecified
        {
            get
            {
                return this.quantidadecreditoFieldSpecified;
            }
            set
            {
                this.quantidadecreditoFieldSpecified = value;
                this.RaisePropertyChanged("quantidadecreditoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
                this.RaisePropertyChanged("valorSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Consulta-Realizada", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoConsultaRealizada : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cidade origemassociadoField;

        private string nomeassociadoField;

        private System.DateTime dataconsultaField;

        private bool dataconsultaFieldSpecified;

        private string nomeentidadeorigemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("origem-associado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cidade origemassociado
        {
            get
            {
                return this.origemassociadoField;
            }
            set
            {
                this.origemassociadoField = value;
                this.RaisePropertyChanged("origemassociado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-associado")]
        public string nomeassociado
        {
            get
            {
                return this.nomeassociadoField;
            }
            set
            {
                this.nomeassociadoField = value;
                this.RaisePropertyChanged("nomeassociado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-consulta")]
        public System.DateTime dataconsulta
        {
            get
            {
                return this.dataconsultaField;
            }
            set
            {
                this.dataconsultaField = value;
                this.RaisePropertyChanged("dataconsulta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataconsultaSpecified
        {
            get
            {
                return this.dataconsultaFieldSpecified;
            }
            set
            {
                this.dataconsultaFieldSpecified = value;
                this.RaisePropertyChanged("dataconsultaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-entidade-origem")]
        public string nomeentidadeorigem
        {
            get
            {
                return this.nomeentidadeorigemField;
            }
            set
            {
                this.nomeentidadeorigemField = value;
                this.RaisePropertyChanged("nomeentidadeorigem");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Agencia-Conta-Documento-Diferente", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class AgenciaContaDocumentoDiferente : object, System.ComponentModel.INotifyPropertyChanged
    {

        private DadosBancarios dadosbancariosField;

        private string documentoField;

        private string origemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dados-bancarios", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public DadosBancarios dadosbancarios
        {
            get
            {
                return this.dadosbancariosField;
            }
            set
            {
                this.dadosbancariosField = value;
                this.RaisePropertyChanged("dadosbancarios");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
                this.RaisePropertyChanged("documento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
                this.RaisePropertyChanged("origem");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Dados-Agencia-Bancaria", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class DadosAgenciaBancaria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private DadosBancarios dadosbancariosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dados-bancarios", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public DadosBancarios dadosbancarios
        {
            get
            {
                return this.dadosbancariosField;
            }
            set
            {
                this.dadosbancariosField = value;
                this.RaisePropertyChanged("dadosbancarios");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoContumacia))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoContraOrdemDocumentoDiferente))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoContraOrdemAgenciaDiferente))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoContraOrdemAgenciaContaDiferente))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Contra-Ordem", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoContraOrdem : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Alinea motivoField;

        private ChequeContraOrdem chequeinicialField;

        private ChequeFinal chequefinalField;

        private System.DateTime datainclusaoField;

        private bool datainclusaoFieldSpecified;

        private System.DateTime dataocorrenciaField;

        private bool dataocorrenciaFieldSpecified;

        private string origemField;

        private string informanteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Alinea motivo
        {
            get
            {
                return this.motivoField;
            }
            set
            {
                this.motivoField = value;
                this.RaisePropertyChanged("motivo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public ChequeContraOrdem chequeinicial
        {
            get
            {
                return this.chequeinicialField;
            }
            set
            {
                this.chequeinicialField = value;
                this.RaisePropertyChanged("chequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-final", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public ChequeFinal chequefinal
        {
            get
            {
                return this.chequefinalField;
            }
            set
            {
                this.chequefinalField = value;
                this.RaisePropertyChanged("chequefinal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-inclusao")]
        public System.DateTime datainclusao
        {
            get
            {
                return this.datainclusaoField;
            }
            set
            {
                this.datainclusaoField = value;
                this.RaisePropertyChanged("datainclusao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datainclusaoSpecified
        {
            get
            {
                return this.datainclusaoFieldSpecified;
            }
            set
            {
                this.datainclusaoFieldSpecified = value;
                this.RaisePropertyChanged("datainclusaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ocorrencia")]
        public System.DateTime dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
                this.RaisePropertyChanged("dataocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataocorrenciaSpecified
        {
            get
            {
                return this.dataocorrenciaFieldSpecified;
            }
            set
            {
                this.dataocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataocorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
                this.RaisePropertyChanged("origem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string informante
        {
            get
            {
                return this.informanteField;
            }
            set
            {
                this.informanteField = value;
                this.RaisePropertyChanged("informante");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Contumacia", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoContumacia : InsumoContraOrdem
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoContraOrdemAgenciaDiferente))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsumoContraOrdemAgenciaContaDiferente))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Contra-Ordem-Documento-Diferente", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoContraOrdemDocumentoDiferente : InsumoContraOrdem
    {

        private string documentoField;

        private int codigotipodocumentoField;

        private bool codigotipodocumentoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
                this.RaisePropertyChanged("documento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("codigo-tipo-documento")]
        public int codigotipodocumento
        {
            get
            {
                return this.codigotipodocumentoField;
            }
            set
            {
                this.codigotipodocumentoField = value;
                this.RaisePropertyChanged("codigotipodocumento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigotipodocumentoSpecified
        {
            get
            {
                return this.codigotipodocumentoFieldSpecified;
            }
            set
            {
                this.codigotipodocumentoFieldSpecified = value;
                this.RaisePropertyChanged("codigotipodocumentoSpecified");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Contra-Ordem-Agencia-Diferente", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoContraOrdemAgenciaDiferente : InsumoContraOrdemDocumentoDiferente
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Contra-Ordem-Agencia-Conta-Diferente", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoContraOrdemAgenciaContaDiferente : InsumoContraOrdemDocumentoDiferente
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-CCF", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoCCF : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Alinea motivoField;

        private Cheque ultimochequeField;

        private System.DateTime dataultimochequeField;

        private bool dataultimochequeFieldSpecified;

        private string origemField;

        private int quantidadeField;

        private bool quantidadeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Alinea motivo
        {
            get
            {
                return this.motivoField;
            }
            set
            {
                this.motivoField = value;
                this.RaisePropertyChanged("motivo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ultimo-cheque", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Cheque ultimocheque
        {
            get
            {
                return this.ultimochequeField;
            }
            set
            {
                this.ultimochequeField = value;
                this.RaisePropertyChanged("ultimocheque");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ultimo-cheque")]
        public System.DateTime dataultimocheque
        {
            get
            {
                return this.dataultimochequeField;
            }
            set
            {
                this.dataultimochequeField = value;
                this.RaisePropertyChanged("dataultimocheque");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataultimochequeSpecified
        {
            get
            {
                return this.dataultimochequeFieldSpecified;
            }
            set
            {
                this.dataultimochequeFieldSpecified = value;
                this.RaisePropertyChanged("dataultimochequeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
                this.RaisePropertyChanged("origem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int quantidade
        {
            get
            {
                return this.quantidadeField;
            }
            set
            {
                this.quantidadeField = value;
                this.RaisePropertyChanged("quantidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadeSpecified
        {
            get
            {
                return this.quantidadeFieldSpecified;
            }
            set
            {
                this.quantidadeFieldSpecified = value;
                this.RaisePropertyChanged("quantidadeSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-Cheque-Lojista", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoChequeLojista : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Alinea alineaField;

        private ChequeLojista chequeinicialField;

        private ChequeFinal chequefinalField;

        private Cidade cidadeassociadoField;

        private Telefone telefoneassociadoField;

        private string nomeassociadoField;

        private long codigoentidadeField;

        private bool codigoentidadeFieldSpecified;

        private System.DateTime datainclusaoField;

        private bool datainclusaoFieldSpecified;

        private string nomeentidadeField;

        private string informanteField;

        private string origemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Alinea alinea
        {
            get
            {
                return this.alineaField;
            }
            set
            {
                this.alineaField = value;
                this.RaisePropertyChanged("alinea");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public ChequeLojista chequeinicial
        {
            get
            {
                return this.chequeinicialField;
            }
            set
            {
                this.chequeinicialField = value;
                this.RaisePropertyChanged("chequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-final", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public ChequeFinal chequefinal
        {
            get
            {
                return this.chequefinalField;
            }
            set
            {
                this.chequefinalField = value;
                this.RaisePropertyChanged("chequefinal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cidade-associado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Cidade cidadeassociado
        {
            get
            {
                return this.cidadeassociadoField;
            }
            set
            {
                this.cidadeassociadoField = value;
                this.RaisePropertyChanged("cidadeassociado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telefone-associado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public Telefone telefoneassociado
        {
            get
            {
                return this.telefoneassociadoField;
            }
            set
            {
                this.telefoneassociadoField = value;
                this.RaisePropertyChanged("telefoneassociado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-associado")]
        public string nomeassociado
        {
            get
            {
                return this.nomeassociadoField;
            }
            set
            {
                this.nomeassociadoField = value;
                this.RaisePropertyChanged("nomeassociado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("codigo-entidade")]
        public long codigoentidade
        {
            get
            {
                return this.codigoentidadeField;
            }
            set
            {
                this.codigoentidadeField = value;
                this.RaisePropertyChanged("codigoentidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoentidadeSpecified
        {
            get
            {
                return this.codigoentidadeFieldSpecified;
            }
            set
            {
                this.codigoentidadeFieldSpecified = value;
                this.RaisePropertyChanged("codigoentidadeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-inclusao")]
        public System.DateTime datainclusao
        {
            get
            {
                return this.datainclusaoField;
            }
            set
            {
                this.datainclusaoField = value;
                this.RaisePropertyChanged("datainclusao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datainclusaoSpecified
        {
            get
            {
                return this.datainclusaoFieldSpecified;
            }
            set
            {
                this.datainclusaoFieldSpecified = value;
                this.RaisePropertyChanged("datainclusaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-entidade")]
        public string nomeentidade
        {
            get
            {
                return this.nomeentidadeField;
            }
            set
            {
                this.nomeentidadeField = value;
                this.RaisePropertyChanged("nomeentidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string informante
        {
            get
            {
                return this.informanteField;
            }
            set
            {
                this.informanteField = value;
                this.RaisePropertyChanged("informante");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
                this.RaisePropertyChanged("origem");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Insumo-SPC", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class InsumoSPC : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cidade cidadeassociadoField;

        private Telefone telefoneassociadoField;

        private string nomeassociadoField;

        private long codigoentidadeField;

        private bool codigoentidadeFieldSpecified;

        private string contacontratoField;

        private System.DateTime datainclusaoField;

        private bool datainclusaoFieldSpecified;

        private System.DateTime datavencimentoField;

        private bool datavencimentoFieldSpecified;

        private string reservadoField;

        private string nomeentidadeField;

        private string contratoField;

        private simNao registroinstituicaofinanceiraField;

        private bool registroinstituicaofinanceiraFieldSpecified;

        private simNao registrorelevanteField;

        private bool registrorelevanteFieldSpecified;

        private string compradorfiadoravalistaField;

        private decimal valorField;

        private bool valorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cidade-associado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cidade cidadeassociado
        {
            get
            {
                return this.cidadeassociadoField;
            }
            set
            {
                this.cidadeassociadoField = value;
                this.RaisePropertyChanged("cidadeassociado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telefone-associado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Telefone telefoneassociado
        {
            get
            {
                return this.telefoneassociadoField;
            }
            set
            {
                this.telefoneassociadoField = value;
                this.RaisePropertyChanged("telefoneassociado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-associado")]
        public string nomeassociado
        {
            get
            {
                return this.nomeassociadoField;
            }
            set
            {
                this.nomeassociadoField = value;
                this.RaisePropertyChanged("nomeassociado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("codigo-entidade")]
        public long codigoentidade
        {
            get
            {
                return this.codigoentidadeField;
            }
            set
            {
                this.codigoentidadeField = value;
                this.RaisePropertyChanged("codigoentidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoentidadeSpecified
        {
            get
            {
                return this.codigoentidadeFieldSpecified;
            }
            set
            {
                this.codigoentidadeFieldSpecified = value;
                this.RaisePropertyChanged("codigoentidadeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("conta-contrato")]
        public string contacontrato
        {
            get
            {
                return this.contacontratoField;
            }
            set
            {
                this.contacontratoField = value;
                this.RaisePropertyChanged("contacontrato");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-inclusao")]
        public System.DateTime datainclusao
        {
            get
            {
                return this.datainclusaoField;
            }
            set
            {
                this.datainclusaoField = value;
                this.RaisePropertyChanged("datainclusao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datainclusaoSpecified
        {
            get
            {
                return this.datainclusaoFieldSpecified;
            }
            set
            {
                this.datainclusaoFieldSpecified = value;
                this.RaisePropertyChanged("datainclusaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-vencimento")]
        public System.DateTime datavencimento
        {
            get
            {
                return this.datavencimentoField;
            }
            set
            {
                this.datavencimentoField = value;
                this.RaisePropertyChanged("datavencimento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datavencimentoSpecified
        {
            get
            {
                return this.datavencimentoFieldSpecified;
            }
            set
            {
                this.datavencimentoFieldSpecified = value;
                this.RaisePropertyChanged("datavencimentoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reservado
        {
            get
            {
                return this.reservadoField;
            }
            set
            {
                this.reservadoField = value;
                this.RaisePropertyChanged("reservado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-entidade")]
        public string nomeentidade
        {
            get
            {
                return this.nomeentidadeField;
            }
            set
            {
                this.nomeentidadeField = value;
                this.RaisePropertyChanged("nomeentidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contrato
        {
            get
            {
                return this.contratoField;
            }
            set
            {
                this.contratoField = value;
                this.RaisePropertyChanged("contrato");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("registro-instituicao-financeira")]
        public simNao registroinstituicaofinanceira
        {
            get
            {
                return this.registroinstituicaofinanceiraField;
            }
            set
            {
                this.registroinstituicaofinanceiraField = value;
                this.RaisePropertyChanged("registroinstituicaofinanceira");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool registroinstituicaofinanceiraSpecified
        {
            get
            {
                return this.registroinstituicaofinanceiraFieldSpecified;
            }
            set
            {
                this.registroinstituicaofinanceiraFieldSpecified = value;
                this.RaisePropertyChanged("registroinstituicaofinanceiraSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("registro-relevante")]
        public simNao registrorelevante
        {
            get
            {
                return this.registrorelevanteField;
            }
            set
            {
                this.registrorelevanteField = value;
                this.RaisePropertyChanged("registrorelevante");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool registrorelevanteSpecified
        {
            get
            {
                return this.registrorelevanteFieldSpecified;
            }
            set
            {
                this.registrorelevanteFieldSpecified = value;
                this.RaisePropertyChanged("registrorelevanteSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("comprador-fiador-avalista")]
        public string compradorfiadoravalista
        {
            get
            {
                return this.compradorfiadoravalistaField;
            }
            set
            {
                this.compradorfiadoravalistaField = value;
                this.RaisePropertyChanged("compradorfiadoravalista");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
                this.RaisePropertyChanged("valor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
                this.RaisePropertyChanged("valorSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public enum simNao
    {

        /// <remarks/>
        SIM,

        /// <remarks/>
        NAO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Grafia-PJ", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class GrafiaPJ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string razaosocialField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("razao-social")]
        public string razaosocial
        {
            get
            {
                return this.razaosocialField;
            }
            set
            {
                this.razaosocialField = value;
                this.RaisePropertyChanged("razaosocial");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Resumo-Insumo", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ResumoInsumo : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int quantidadetotalField;

        private bool quantidadetotalFieldSpecified;

        private string mesanoprimeiraocorrenciaField;

        private string mesanoultimaocorrenciaField;

        private System.DateTime dataprimeiraocorrenciaField;

        private bool dataprimeiraocorrenciaFieldSpecified;

        private System.DateTime dataultimaocorrenciaField;

        private bool dataultimaocorrenciaFieldSpecified;

        private decimal valortotalField;

        private bool valortotalFieldSpecified;

        private decimal valorultimaocorrenciaField;

        private bool valorultimaocorrenciaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-total")]
        public int quantidadetotal
        {
            get
            {
                return this.quantidadetotalField;
            }
            set
            {
                this.quantidadetotalField = value;
                this.RaisePropertyChanged("quantidadetotal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadetotalSpecified
        {
            get
            {
                return this.quantidadetotalFieldSpecified;
            }
            set
            {
                this.quantidadetotalFieldSpecified = value;
                this.RaisePropertyChanged("quantidadetotalSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mesano-primeira-ocorrencia")]
        public string mesanoprimeiraocorrencia
        {
            get
            {
                return this.mesanoprimeiraocorrenciaField;
            }
            set
            {
                this.mesanoprimeiraocorrenciaField = value;
                this.RaisePropertyChanged("mesanoprimeiraocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mesano-ultima-ocorrencia")]
        public string mesanoultimaocorrencia
        {
            get
            {
                return this.mesanoultimaocorrenciaField;
            }
            set
            {
                this.mesanoultimaocorrenciaField = value;
                this.RaisePropertyChanged("mesanoultimaocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-primeira-ocorrencia")]
        public System.DateTime dataprimeiraocorrencia
        {
            get
            {
                return this.dataprimeiraocorrenciaField;
            }
            set
            {
                this.dataprimeiraocorrenciaField = value;
                this.RaisePropertyChanged("dataprimeiraocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataprimeiraocorrenciaSpecified
        {
            get
            {
                return this.dataprimeiraocorrenciaFieldSpecified;
            }
            set
            {
                this.dataprimeiraocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataprimeiraocorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-ultima-ocorrencia")]
        public System.DateTime dataultimaocorrencia
        {
            get
            {
                return this.dataultimaocorrenciaField;
            }
            set
            {
                this.dataultimaocorrenciaField = value;
                this.RaisePropertyChanged("dataultimaocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataultimaocorrenciaSpecified
        {
            get
            {
                return this.dataultimaocorrenciaFieldSpecified;
            }
            set
            {
                this.dataultimaocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("dataultimaocorrenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-total")]
        public decimal valortotal
        {
            get
            {
                return this.valortotalField;
            }
            set
            {
                this.valortotalField = value;
                this.RaisePropertyChanged("valortotal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valortotalSpecified
        {
            get
            {
                return this.valortotalFieldSpecified;
            }
            set
            {
                this.valortotalFieldSpecified = value;
                this.RaisePropertyChanged("valortotalSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-ultima-ocorrencia")]
        public decimal valorultimaocorrencia
        {
            get
            {
                return this.valorultimaocorrenciaField;
            }
            set
            {
                this.valorultimaocorrenciaField = value;
                this.RaisePropertyChanged("valorultimaocorrencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorultimaocorrenciaSpecified
        {
            get
            {
                return this.valorultimaocorrenciaFieldSpecified;
            }
            set
            {
                this.valorultimaocorrenciaFieldSpecified = value;
                this.RaisePropertyChanged("valorultimaocorrenciaSpecified");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResultadoInsumoConsultaRealizada))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResultadoInsumoContumacia))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResultadoInsumoContraOrdem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Resultado-Insumo", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ResultadoInsumo : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ResumoInsumo resumoField;

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public ResumoInsumo resumo
        {
            get
            {
                return this.resumoField;
            }
            set
            {
                this.resumoField = value;
                this.RaisePropertyChanged("resumo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("detalhe-acao", typeof(InsumoAcao), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-administrador", typeof(InsumoQuadroAdministrativo), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-alerta-documento", typeof(InsumoAlertaDocumento), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-alerta-identidade", typeof(InsumoAlertaIdentidade), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-alerta-obito", typeof(InsumoAlertaObito), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-antecessora", typeof(InsumoAntecessora), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-atividade-empresa", typeof(InsumoAtividadeEmpresa), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-banco-agencia-conta-documento-diferente", typeof(AgenciaContaDocumentoDiferente), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-capital-social", typeof(InsumoCapitalSocial), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-ccf", typeof(InsumoCCF), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-cheque-consulta-online-srs", typeof(InsumoChequeConsultaOnlineSRS), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-cheque-lojista", typeof(InsumoChequeLojista), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-cheque-outras-ocorrencias-srs", typeof(InsumoChequeOutrasOcorrenciasSRS), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-cheque-sem-fundo-achei", typeof(InsumoChequeSemFundoAchei), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-cheque-sem-fundo-achei-ccf", typeof(InsumoChequeSemFundoAcheiCCF), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-cheque-sem-fundo-varejo", typeof(InsumoChequeSemFundoVarejo), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-confirmacao-rg", typeof(InsumoRg), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-consulta-realizada", typeof(InsumoConsultaRealizada), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-consulta-realizada-cheque", typeof(InsumoConsultaRealizadaCheque), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-contra-ordem", typeof(InsumoContraOrdem), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-contra-ordem-agencia-conta-diferente", typeof(InsumoContraOrdemAgenciaContaDiferente), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-contra-ordem-agencia-diferente", typeof(InsumoContraOrdemAgenciaDiferente), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-contra-ordem-documento-diferente", typeof(InsumoContraOrdemDocumentoDiferente), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-contra-ordem-documento-diferente-srs", typeof(InsumoContraOrdemDocumentoDiferenteSRS), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-contra-ordem-srs", typeof(InsumoContraOrdemSRS), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-contumacia", typeof(InsumoContumacia), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-contumacia-srs", typeof(InsumoContumaciaSRS), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-credito-concedido", typeof(InsumoCreditoConcedido), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-dados-agencia-bancaria", typeof(DadosAgenciaBancaria), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-divida-vencida", typeof(InsumoDividaVencida), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-dpvat", typeof(InsumoDpvat), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-endereco-cep-consultado", typeof(InsumoEnderecoCEPConsultado), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-faturamento-presumido", typeof(InsumoFaturamentoPresumido), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-filial", typeof(InsumoFilial), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-gasto-estimado-pf", typeof(InsumoGastoEstimadoPF), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-gasto-estimado-pj", typeof(InsumoGastoEstimadoPJ), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-grafia-pj", typeof(GrafiaPJ), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-gravame", typeof(InsumoGravame), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-historico-cheque", typeof(InsumoHistoricoCheque), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-historico-cheque-documento-diferente", typeof(InsumoHistoricoChequeDocumentoDiferente), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-historico-conta-corrente", typeof(InsumoHistoricoContaCorrente), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-historico-pagamento", typeof(InsumoHistoricoPagamento), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-incorporacao-fusao-cisao", typeof(InsumoIncorporacaoFusaoCisao), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-indice-relacionamento-mercado-pf", typeof(InsumoIndiceRelacionamentoMercadoPF), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-indice-relacionamento-mercado-pj", typeof(InsumoIndiceRelacionamentoMercadoPJ), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-informacao-poder-judiciario", typeof(InsumoInformacaoPoderJudiciario), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-informacoes-adicionais", typeof(InsumoInformacoesAdicionais), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-informacoes-complementares", typeof(InsumoInformacoesComplementares), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-limite-credito-pj", typeof(InsumoLimiteCreditoPJ), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-limite-credito-sugerido", typeof(InsumoLimiteCreditoSugerido), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-localizaVeiculo", typeof(InsumoSPCAutoLocaliza), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-ocupacao", typeof(InsumoOcupacao), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-participacao-empresa", typeof(InsumoParticipacaoEmpresas), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-participacao-falencia", typeof(InsumoParticipacaoFalencia), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-pendencia-financeira", typeof(InsumoPendenciaFinanceira), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-perfil-financeiro-pj", typeof(InsumoPerfilFinanceiroPJ), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-principais-produtos", typeof(InsumoPrincipaisProdutos), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-protesto", typeof(InsumoProtesto), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-quadro-social-mais-completo-pj", typeof(InsumoQuadroSocialMaisCompletoPJ), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-referenciais-negocios", typeof(InsumoReferenciaisNegocios), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-registro-consulta", typeof(InsumoRegistroConsultas), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-relacionamento-mais-antigo-com-fornecedores", typeof(InsumoRelacionamentoMaisAntigoComFornecedores), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-renavam-estadual", typeof(InsumoRenavamEstadual), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-renavam-federal", typeof(InsumoRenavamFederal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-renda-presumida-spc", typeof(InsumoRendaPresumidaSpc), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-restricao-financeira", typeof(InsumoRestricaoFinanceira), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-risco-credito-pj", typeof(InsumoRiscoCreditoPJ), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-riskscoring-12-meses", typeof(InsumoRiskscoring12Meses), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-riskscoring-6-meses", typeof(InsumoRiskscoring6Meses), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-roubo-furto", typeof(InsumoRouboFurto), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-socio", typeof(InsumoQuadroSocietario), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-spc", typeof(InsumoSPC), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-spc-obito", typeof(InsumoObito), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-spc-score-12-meses", typeof(InsumoSPCScore12Meses), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-spc-score-3-meses", typeof(InsumoSPCScore3Meses), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-telefone-alternativo", typeof(InsumoTelefoneAlternativo), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-telefone-consultado", typeof(InsumoDadosTelefoneConsultado), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-telefone-vinculado-assinante-consultado", typeof(InsumoTelefoneVinculadoAssinanteConsultado), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-telefone-vinculado-consumidor", typeof(InsumoTelefoneVinculadoConsumidor), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-ultimas-consultas", typeof(InsumoUltimasConsultas), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-ultimo-endereco-informado", typeof(InsumoOcorrenciaConsumidor), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("detalhe-ultimo-telefone-informado", typeof(InsumoTelefoneConsultado), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Resultado-Insumo-Consulta-Realizada", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ResultadoInsumoConsultaRealizada : ResultadoInsumo
    {

        private int quantidadediasconsultadosField;

        private bool quantidadediasconsultadosFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-dias-consultados")]
        public int quantidadediasconsultados
        {
            get
            {
                return this.quantidadediasconsultadosField;
            }
            set
            {
                this.quantidadediasconsultadosField = value;
                this.RaisePropertyChanged("quantidadediasconsultados");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadediasconsultadosSpecified
        {
            get
            {
                return this.quantidadediasconsultadosFieldSpecified;
            }
            set
            {
                this.quantidadediasconsultadosFieldSpecified = value;
                this.RaisePropertyChanged("quantidadediasconsultadosSpecified");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Resultado-Insumo-Contumacia", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ResultadoInsumoContumacia : ResultadoInsumo
    {

        private System.DateTime datafinalperiodoconsultadoField;

        private bool datafinalperiodoconsultadoFieldSpecified;

        private System.DateTime datainicialperiodoconsultadoField;

        private bool datainicialperiodoconsultadoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-final-periodo-consultado")]
        public System.DateTime datafinalperiodoconsultado
        {
            get
            {
                return this.datafinalperiodoconsultadoField;
            }
            set
            {
                this.datafinalperiodoconsultadoField = value;
                this.RaisePropertyChanged("datafinalperiodoconsultado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datafinalperiodoconsultadoSpecified
        {
            get
            {
                return this.datafinalperiodoconsultadoFieldSpecified;
            }
            set
            {
                this.datafinalperiodoconsultadoFieldSpecified = value;
                this.RaisePropertyChanged("datafinalperiodoconsultadoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-inicial-periodo-consultado")]
        public System.DateTime datainicialperiodoconsultado
        {
            get
            {
                return this.datainicialperiodoconsultadoField;
            }
            set
            {
                this.datainicialperiodoconsultadoField = value;
                this.RaisePropertyChanged("datainicialperiodoconsultado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datainicialperiodoconsultadoSpecified
        {
            get
            {
                return this.datainicialperiodoconsultadoFieldSpecified;
            }
            set
            {
                this.datainicialperiodoconsultadoFieldSpecified = value;
                this.RaisePropertyChanged("datainicialperiodoconsultadoSpecified");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Resultado-Insumo-Contra-Ordem", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ResultadoInsumoContraOrdem : ResultadoInsumo
    {

        private int quantidadetaloescontraordenadosField;

        private bool quantidadetaloescontraordenadosFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("quantidade-taloes-contra-ordenados")]
        public int quantidadetaloescontraordenados
        {
            get
            {
                return this.quantidadetaloescontraordenadosField;
            }
            set
            {
                this.quantidadetaloescontraordenadosField = value;
                this.RaisePropertyChanged("quantidadetaloescontraordenados");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadetaloescontraordenadosSpecified
        {
            get
            {
                return this.quantidadetaloescontraordenadosFieldSpecified;
            }
            set
            {
                this.quantidadetaloescontraordenadosFieldSpecified = value;
                this.RaisePropertyChanged("quantidadetaloescontraordenadosSpecified");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Natureza-Juridica", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class NaturezaJuridica : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string descricaoField;

        private long codigoField;

        private bool codigoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
                this.RaisePropertyChanged("descricao");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Pessoa-Juridica", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class PessoaJuridica : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cnpj cnpjField;

        private SituacaoDocumentoWS situacaocnpjField;

        private SituacaoDocumentoWS situacaoinscricaoestadualField;

        private Endereco enderecoField;

        private Telefone telefoneField;

        private Telefone faxField;

        private NaturezaJuridica naturezajuridicaField;

        private RamoAtividade atividadeeconomicaprincipalField;

        private RamoAtividade[] atividadeeconomicasecundariaField;

        private System.DateTime datafundacaoField;

        private bool datafundacaoFieldSpecified;

        private string emailField;

        private string homepageField;

        private long inscricaoestadualField;

        private bool inscricaoestadualFieldSpecified;

        private string nomecomercialField;

        private long numeroNIRENIRCField;

        private bool numeroNIRENIRCFieldSpecified;

        private string razaosocialField;

        private string razaosocialanteriorField;

        private decimal valorcapitalsocialField;

        private bool valorcapitalsocialFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cnpj cnpj
        {
            get
            {
                return this.cnpjField;
            }
            set
            {
                this.cnpjField = value;
                this.RaisePropertyChanged("cnpj");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("situacao-cnpj", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public SituacaoDocumentoWS situacaocnpj
        {
            get
            {
                return this.situacaocnpjField;
            }
            set
            {
                this.situacaocnpjField = value;
                this.RaisePropertyChanged("situacaocnpj");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("situacao-inscricao-estadual", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public SituacaoDocumentoWS situacaoinscricaoestadual
        {
            get
            {
                return this.situacaoinscricaoestadualField;
            }
            set
            {
                this.situacaoinscricaoestadualField = value;
                this.RaisePropertyChanged("situacaoinscricaoestadual");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Endereco endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
                this.RaisePropertyChanged("endereco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public Telefone telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
                this.RaisePropertyChanged("telefone");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public Telefone fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
                this.RaisePropertyChanged("fax");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("natureza-juridica", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public NaturezaJuridica naturezajuridica
        {
            get
            {
                return this.naturezajuridicaField;
            }
            set
            {
                this.naturezajuridicaField = value;
                this.RaisePropertyChanged("naturezajuridica");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("atividade-economica-principal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public RamoAtividade atividadeeconomicaprincipal
        {
            get
            {
                return this.atividadeeconomicaprincipalField;
            }
            set
            {
                this.atividadeeconomicaprincipalField = value;
                this.RaisePropertyChanged("atividadeeconomicaprincipal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("atividade-economica-secundaria", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public RamoAtividade[] atividadeeconomicasecundaria
        {
            get
            {
                return this.atividadeeconomicasecundariaField;
            }
            set
            {
                this.atividadeeconomicasecundariaField = value;
                this.RaisePropertyChanged("atividadeeconomicasecundaria");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-fundacao")]
        public System.DateTime datafundacao
        {
            get
            {
                return this.datafundacaoField;
            }
            set
            {
                this.datafundacaoField = value;
                this.RaisePropertyChanged("datafundacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datafundacaoSpecified
        {
            get
            {
                return this.datafundacaoFieldSpecified;
            }
            set
            {
                this.datafundacaoFieldSpecified = value;
                this.RaisePropertyChanged("datafundacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
                this.RaisePropertyChanged("email");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("home-page")]
        public string homepage
        {
            get
            {
                return this.homepageField;
            }
            set
            {
                this.homepageField = value;
                this.RaisePropertyChanged("homepage");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("inscricao-estadual")]
        public long inscricaoestadual
        {
            get
            {
                return this.inscricaoestadualField;
            }
            set
            {
                this.inscricaoestadualField = value;
                this.RaisePropertyChanged("inscricaoestadual");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inscricaoestadualSpecified
        {
            get
            {
                return this.inscricaoestadualFieldSpecified;
            }
            set
            {
                this.inscricaoestadualFieldSpecified = value;
                this.RaisePropertyChanged("inscricaoestadualSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-comercial")]
        public string nomecomercial
        {
            get
            {
                return this.nomecomercialField;
            }
            set
            {
                this.nomecomercialField = value;
                this.RaisePropertyChanged("nomecomercial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-NIRE-NIRC")]
        public long numeroNIRENIRC
        {
            get
            {
                return this.numeroNIRENIRCField;
            }
            set
            {
                this.numeroNIRENIRCField = value;
                this.RaisePropertyChanged("numeroNIRENIRC");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroNIRENIRCSpecified
        {
            get
            {
                return this.numeroNIRENIRCFieldSpecified;
            }
            set
            {
                this.numeroNIRENIRCFieldSpecified = value;
                this.RaisePropertyChanged("numeroNIRENIRCSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("razao-social")]
        public string razaosocial
        {
            get
            {
                return this.razaosocialField;
            }
            set
            {
                this.razaosocialField = value;
                this.RaisePropertyChanged("razaosocial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("razao-social-anterior")]
        public string razaosocialanterior
        {
            get
            {
                return this.razaosocialanteriorField;
            }
            set
            {
                this.razaosocialanteriorField = value;
                this.RaisePropertyChanged("razaosocialanterior");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("valor-capital-social")]
        public decimal valorcapitalsocial
        {
            get
            {
                return this.valorcapitalsocialField;
            }
            set
            {
                this.valorcapitalsocialField = value;
                this.RaisePropertyChanged("valorcapitalsocial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorcapitalsocialSpecified
        {
            get
            {
                return this.valorcapitalsocialFieldSpecified;
            }
            set
            {
                this.valorcapitalsocialFieldSpecified = value;
                this.RaisePropertyChanged("valorcapitalsocialSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Situacao-Documento-WS", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class SituacaoDocumentoWS : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string descricaosituacaoField;

        private System.DateTime datasituacaoField;

        private bool datasituacaoFieldSpecified;

        private string ufField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("descricao-situacao")]
        public string descricaosituacao
        {
            get
            {
                return this.descricaosituacaoField;
            }
            set
            {
                this.descricaosituacaoField = value;
                this.RaisePropertyChanged("descricaosituacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-situacao")]
        public System.DateTime datasituacao
        {
            get
            {
                return this.datasituacaoField;
            }
            set
            {
                this.datasituacaoField = value;
                this.RaisePropertyChanged("datasituacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datasituacaoSpecified
        {
            get
            {
                return this.datasituacaoFieldSpecified;
            }
            set
            {
                this.datasituacaoFieldSpecified = value;
                this.RaisePropertyChanged("datasituacaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
                this.RaisePropertyChanged("uf");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Pessoa-Fisica", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class PessoaFisica : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Cpf cpfField;

        private SituacaoDocumentoWS situacaocpfField;

        private Estado estadorgField;

        private Endereco enderecoField;

        private Telefone telefoneresidencialField;

        private Telefone telefonecelularField;

        private Telefone telefonecomercialField;

        private Telefone faxField;

        private System.DateTime datanascimentoField;

        private bool datanascimentoFieldSpecified;

        private string emailField;

        private EstadoCivil estadocivilField;

        private bool estadocivilFieldSpecified;

        private int idadeField;

        private bool idadeFieldSpecified;

        private string nomeField;

        private string nomemaeField;

        private string nomepaiField;

        private string numerorgField;

        private long numerotituloeleitorField;

        private bool numerotituloeleitorFieldSpecified;

        private Sexo sexoField;

        private bool sexoFieldSpecified;

        private Signo signoField;

        private bool signoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cpf cpf
        {
            get
            {
                return this.cpfField;
            }
            set
            {
                this.cpfField = value;
                this.RaisePropertyChanged("cpf");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("situacao-cpf", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public SituacaoDocumentoWS situacaocpf
        {
            get
            {
                return this.situacaocpfField;
            }
            set
            {
                this.situacaocpfField = value;
                this.RaisePropertyChanged("situacaocpf");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estado-rg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public Estado estadorg
        {
            get
            {
                return this.estadorgField;
            }
            set
            {
                this.estadorgField = value;
                this.RaisePropertyChanged("estadorg");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Endereco endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
                this.RaisePropertyChanged("endereco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telefone-residencial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public Telefone telefoneresidencial
        {
            get
            {
                return this.telefoneresidencialField;
            }
            set
            {
                this.telefoneresidencialField = value;
                this.RaisePropertyChanged("telefoneresidencial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telefone-celular", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public Telefone telefonecelular
        {
            get
            {
                return this.telefonecelularField;
            }
            set
            {
                this.telefonecelularField = value;
                this.RaisePropertyChanged("telefonecelular");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telefone-comercial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public Telefone telefonecomercial
        {
            get
            {
                return this.telefonecomercialField;
            }
            set
            {
                this.telefonecomercialField = value;
                this.RaisePropertyChanged("telefonecomercial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public Telefone fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
                this.RaisePropertyChanged("fax");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("data-nascimento")]
        public System.DateTime datanascimento
        {
            get
            {
                return this.datanascimentoField;
            }
            set
            {
                this.datanascimentoField = value;
                this.RaisePropertyChanged("datanascimento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datanascimentoSpecified
        {
            get
            {
                return this.datanascimentoFieldSpecified;
            }
            set
            {
                this.datanascimentoFieldSpecified = value;
                this.RaisePropertyChanged("datanascimentoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
                this.RaisePropertyChanged("email");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("estado-civil")]
        public EstadoCivil estadocivil
        {
            get
            {
                return this.estadocivilField;
            }
            set
            {
                this.estadocivilField = value;
                this.RaisePropertyChanged("estadocivil");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estadocivilSpecified
        {
            get
            {
                return this.estadocivilFieldSpecified;
            }
            set
            {
                this.estadocivilFieldSpecified = value;
                this.RaisePropertyChanged("estadocivilSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int idade
        {
            get
            {
                return this.idadeField;
            }
            set
            {
                this.idadeField = value;
                this.RaisePropertyChanged("idade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idadeSpecified
        {
            get
            {
                return this.idadeFieldSpecified;
            }
            set
            {
                this.idadeFieldSpecified = value;
                this.RaisePropertyChanged("idadeSpecified");
            }
        }

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
        [System.Xml.Serialization.XmlAttributeAttribute("nome-mae")]
        public string nomemae
        {
            get
            {
                return this.nomemaeField;
            }
            set
            {
                this.nomemaeField = value;
                this.RaisePropertyChanged("nomemae");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nome-pai")]
        public string nomepai
        {
            get
            {
                return this.nomepaiField;
            }
            set
            {
                this.nomepaiField = value;
                this.RaisePropertyChanged("nomepai");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-rg")]
        public string numerorg
        {
            get
            {
                return this.numerorgField;
            }
            set
            {
                this.numerorgField = value;
                this.RaisePropertyChanged("numerorg");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("numero-titulo-eleitor")]
        public long numerotituloeleitor
        {
            get
            {
                return this.numerotituloeleitorField;
            }
            set
            {
                this.numerotituloeleitorField = value;
                this.RaisePropertyChanged("numerotituloeleitor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numerotituloeleitorSpecified
        {
            get
            {
                return this.numerotituloeleitorFieldSpecified;
            }
            set
            {
                this.numerotituloeleitorFieldSpecified = value;
                this.RaisePropertyChanged("numerotituloeleitorSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Sexo sexo
        {
            get
            {
                return this.sexoField;
            }
            set
            {
                this.sexoField = value;
                this.RaisePropertyChanged("sexo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sexoSpecified
        {
            get
            {
                return this.sexoFieldSpecified;
            }
            set
            {
                this.sexoFieldSpecified = value;
                this.RaisePropertyChanged("sexoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Signo signo
        {
            get
            {
                return this.signoField;
            }
            set
            {
                this.signoField = value;
                this.RaisePropertyChanged("signo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool signoSpecified
        {
            get
            {
                return this.signoFieldSpecified;
            }
            set
            {
                this.signoFieldSpecified = value;
                this.RaisePropertyChanged("signoSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Estado-Civil", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public enum EstadoCivil
    {

        /// <remarks/>
        SOLTEIRO,

        /// <remarks/>
        CASADO,

        /// <remarks/>
        SEPARADO_JUDICIALMENTE,

        /// <remarks/>
        DIVORCIADO,

        /// <remarks/>
        VIUVO,

        /// <remarks/>
        UNIAO_ESTAVEL,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public enum Sexo
    {

        /// <remarks/>
        MASCULINO,

        /// <remarks/>
        FEMININO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public enum Signo
    {

        /// <remarks/>
        CAPRICORNIO,

        /// <remarks/>
        AQUARIO,

        /// <remarks/>
        PEIXES,

        /// <remarks/>
        ARIES,

        /// <remarks/>
        TOURO,

        /// <remarks/>
        GEMEOS,

        /// <remarks/>
        CANCER,

        /// <remarks/>
        LEAO,

        /// <remarks/>
        VIRGEM,

        /// <remarks/>
        LIBRA,

        /// <remarks/>
        ESCORPIAO,

        /// <remarks/>
        SAGITARIO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Resultado-Consumidor", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ResultadoConsumidor : object, System.ComponentModel.INotifyPropertyChanged
    {

        private PessoaFisica consumidorpessoafisicaField;

        private PessoaJuridica consumidorpessoajuridicaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consumidor-pessoa-fisica", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public PessoaFisica consumidorpessoafisica
        {
            get
            {
                return this.consumidorpessoafisicaField;
            }
            set
            {
                this.consumidorpessoafisicaField = value;
                this.RaisePropertyChanged("consumidorpessoafisica");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consumidor-pessoa-juridica", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public PessoaJuridica consumidorpessoajuridica
        {
            get
            {
                return this.consumidorpessoajuridicaField;
            }
            set
            {
                this.consumidorpessoajuridicaField = value;
                this.RaisePropertyChanged("consumidorpessoajuridica");
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
    public partial class mensagemBaseExterna : object, System.ComponentModel.INotifyPropertyChanged
    {

        private baseExternaAgente origembaseexternaField;

        private bool origembaseexternaFieldSpecified;

        private string mensagembaseexternaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("origem-base-externa")]
        public baseExternaAgente origembaseexterna
        {
            get
            {
                return this.origembaseexternaField;
            }
            set
            {
                this.origembaseexternaField = value;
                this.RaisePropertyChanged("origembaseexterna");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool origembaseexternaSpecified
        {
            get
            {
                return this.origembaseexternaFieldSpecified;
            }
            set
            {
                this.origembaseexternaFieldSpecified = value;
                this.RaisePropertyChanged("origembaseexternaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mensagem-base-externa")]
        public string mensagembaseexterna
        {
            get
            {
                return this.mensagembaseexternaField;
            }
            set
            {
                this.mensagembaseexternaField = value;
                this.RaisePropertyChanged("mensagembaseexterna");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public enum baseExternaAgente
    {

        /// <remarks/>
        SRF,

        /// <remarks/>
        RENIC,

        /// <remarks/>
        USEFN,

        /// <remarks/>
        ACSP,

        /// <remarks/>
        EQUIF,

        /// <remarks/>
        SRASA_TRADUTOR_CONCENTRE,

        /// <remarks/>
        SRASA_RELATO,

        /// <remarks/>
        SRASA_CHEQUENET,

        /// <remarks/>
        SRASA_CONCTR,

        /// <remarks/>
        FORNECEDOR_INTEGRACAO,

        /// <remarks/>
        FORNECEDOR_INTEGRACAO_CHEQUE,

        /// <remarks/>
        SSPDSCE,

        /// <remarks/>
        CHECKAUTO,

        /// <remarks/>
        SRASA_CREDNET,

        /// <remarks/>
        SRASA_CREDIT_BUREAU,

        /// <remarks/>
        ASSECC_FONE,

        /// <remarks/>
        FIBER_RENDA_PRESUMIDA,

        /// <remarks/>
        IBOPE,

        /// <remarks/>
        RENDA_PRESUMIDA,

        /// <remarks/>
        CARFACTS,

        /// <remarks/>
        UNICHECK,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class Operador : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codigoField;

        private string nomeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Protocolo-Consulta", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ProtocoloConsulta : object, System.ComponentModel.INotifyPropertyChanged
    {

        private long numeroField;

        private bool numeroFieldSpecified;

        private int digitoField;

        private bool digitoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
                this.RaisePropertyChanged("numero");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroSpecified
        {
            get
            {
                return this.numeroFieldSpecified;
            }
            set
            {
                this.numeroFieldSpecified = value;
                this.RaisePropertyChanged("numeroSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int digito
        {
            get
            {
                return this.digitoField;
            }
            set
            {
                this.digitoField = value;
                this.RaisePropertyChanged("digito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool digitoSpecified
        {
            get
            {
                return this.digitoFieldSpecified;
            }
            set
            {
                this.digitoFieldSpecified = value;
                this.RaisePropertyChanged("digitoSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Resultado-Consulta", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ResultadoConsulta : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ProtocoloConsulta protocoloField;

        private Operador operadorField;

        private mensagemBaseExterna[] mensagembaseexternaField;

        private string[] baseinoperanteField;

        private ResultadoConsumidor consumidorField;

        private ResultadoInsumo grafiapjField;

        private ResultadoInsumo enderecocepconsultadoField;

        private ResultadoInsumo telefoneconsultadoField;

        private ResultadoInsumo telefonevinculadoconsumidorField;

        private ResultadoInsumo telefonevinculadoassinanteconsultadoField;

        private ResultadoInsumo ultimotelefoneinformadoField;

        private ResultadoInsumo ultimoenderecoinformadoField;

        private ResultadoInsumo participacaoempresaField;

        private ResultadoInsumo socioField;

        private ResultadoInsumo administradorField;

        private ResultadoInsumo alertadocumentoField;

        private ResultadoInsumo spcField;

        private ResultadoInsumo chequelojistaField;

        private ResultadoInsumo ccfField;

        private ResultadoInsumoContraOrdem contraordemdocumentodiferenteField;

        private ResultadoInsumoContraOrdem contraordemagenciadiferenteField;

        private ResultadoInsumoContraOrdem contraordemagenciacontadiferenteField;

        private ResultadoInsumo acaoField;

        private ResultadoInsumo protestoField;

        private ResultadoInsumoContraOrdem contraordemField;

        private ResultadoInsumoContumacia contumaciaField;

        private ResultadoInsumo creditoconcedidoField;

        private ResultadoInsumo bancoagenciacontadocumentodiferenteField;

        private ResultadoInsumo dadosagenciabancariaField;

        private ResultadoInsumoConsultaRealizada consultarealizadaField;

        private ResultadoInsumo informacaopoderjudiciarioField;

        private ResultadoInsumo riskscoring6mesesField;

        private ResultadoInsumo riskscoring12mesesField;

        private ResultadoInsumo chequesemfundoacheiField;

        private ResultadoInsumo chequesemfundoacheiccfField;

        private ResultadoInsumo contumaciasrsField;

        private ResultadoInsumo participacaofalenciaField;

        private ResultadoInsumo restricaofinanceiraField;

        private ResultadoInsumo pendenciafinanceiraField;

        private ResultadoInsumo chequesemfundovarejoField;

        private ResultadoInsumo contraordemsrsField;

        private ResultadoInsumo contraordemdocumentodiferentesrsField;

        private ResultadoInsumo chequeoutrasocorrenciassrsField;

        private ResultadoInsumo chequeconsultaonlinesrsField;

        private ResultadoInsumo consultarealizadachequeField;

        private ResultadoInsumo referenciaisnegociosField;

        private ResultadoInsumo historicopagamentoField;

        private ResultadoInsumo relacionamentomaisantigocomfornecedoresField;

        private ResultadoInsumo registroconsultaField;

        private ResultadoInsumo ultimasconsultasField;

        private ResultadoInsumo capitalsocialField;

        private ResultadoInsumo antecessoraField;

        private ResultadoInsumo atividadeempresaField;

        private ResultadoInsumo filialField;

        private ResultadoInsumo informacoesadicionaisField;

        private ResultadoInsumo incorporacaofusaocisaoField;

        private ResultadoInsumo principaisprodutosField;

        private MensagemComplementar[] mensagemcomplementarField;

        private ResultadoInsumo spcscore3mesesField;

        private ResultadoInsumo spcscore12mesesField;

        private ResultadoInsumo spcobitoField;

        private ResultadoInsumo confirmacaorgField;

        private ResultadoInsumo renavamfederalField;

        private ResultadoInsumo roubofurtoField;

        private ResultadoInsumo dpvatField;

        private ResultadoInsumo gravameField;

        private ResultadoInsumo renavamestadualField;

        private ResultadoInsumo localizaVeiculoField;

        private ResultadoInsumo rendapresumidaspcField;

        private ResultadoInsumo limitecreditosugeridoField;

        private ResultadoInsumo ocupacaoField;

        private ResultadoInsumo informacoescomplementaresField;

        private ResultadoInsumo telefonealternativoField;

        private ResultadoInsumo alertaobitoField;

        private ResultadoInsumo alertaidentidadeField;

        private ResultadoInsumo faturamentopresumidoField;

        private ResultadoInsumo limitecreditopjField;

        private ResultadoInsumo gastoestimadopjField;

        private ResultadoInsumo quadrosocialmaiscompletopjField;

        private ResultadoInsumo riscocreditopjField;

        private ResultadoInsumo perfilfinanceiropjField;

        private ResultadoInsumo gastoestimadopfField;

        private ResultadoInsumo indicerelacionamentomercadopfField;

        private ResultadoInsumo indicerelacionamentomercadopjField;

        private bool restricaoField;

        private bool restricaoFieldSpecified;

        private System.DateTime dataField;

        private bool dataFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public ProtocoloConsulta protocolo
        {
            get
            {
                return this.protocoloField;
            }
            set
            {
                this.protocoloField = value;
                this.RaisePropertyChanged("protocolo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Operador operador
        {
            get
            {
                return this.operadorField;
            }
            set
            {
                this.operadorField = value;
                this.RaisePropertyChanged("operador");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mensagem-base-externa", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public mensagemBaseExterna[] mensagembaseexterna
        {
            get
            {
                return this.mensagembaseexternaField;
            }
            set
            {
                this.mensagembaseexternaField = value;
                this.RaisePropertyChanged("mensagembaseexterna");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("base-inoperante", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string[] baseinoperante
        {
            get
            {
                return this.baseinoperanteField;
            }
            set
            {
                this.baseinoperanteField = value;
                this.RaisePropertyChanged("baseinoperante");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public ResultadoConsumidor consumidor
        {
            get
            {
                return this.consumidorField;
            }
            set
            {
                this.consumidorField = value;
                this.RaisePropertyChanged("consumidor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("grafia-pj", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public ResultadoInsumo grafiapj
        {
            get
            {
                return this.grafiapjField;
            }
            set
            {
                this.grafiapjField = value;
                this.RaisePropertyChanged("grafiapj");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endereco-cep-consultado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public ResultadoInsumo enderecocepconsultado
        {
            get
            {
                return this.enderecocepconsultadoField;
            }
            set
            {
                this.enderecocepconsultadoField = value;
                this.RaisePropertyChanged("enderecocepconsultado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telefone-consultado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public ResultadoInsumo telefoneconsultado
        {
            get
            {
                return this.telefoneconsultadoField;
            }
            set
            {
                this.telefoneconsultadoField = value;
                this.RaisePropertyChanged("telefoneconsultado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telefone-vinculado-consumidor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public ResultadoInsumo telefonevinculadoconsumidor
        {
            get
            {
                return this.telefonevinculadoconsumidorField;
            }
            set
            {
                this.telefonevinculadoconsumidorField = value;
                this.RaisePropertyChanged("telefonevinculadoconsumidor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telefone-vinculado-assinante-consultado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public ResultadoInsumo telefonevinculadoassinanteconsultado
        {
            get
            {
                return this.telefonevinculadoassinanteconsultadoField;
            }
            set
            {
                this.telefonevinculadoassinanteconsultadoField = value;
                this.RaisePropertyChanged("telefonevinculadoassinanteconsultado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ultimo-telefone-informado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public ResultadoInsumo ultimotelefoneinformado
        {
            get
            {
                return this.ultimotelefoneinformadoField;
            }
            set
            {
                this.ultimotelefoneinformadoField = value;
                this.RaisePropertyChanged("ultimotelefoneinformado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ultimo-endereco-informado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public ResultadoInsumo ultimoenderecoinformado
        {
            get
            {
                return this.ultimoenderecoinformadoField;
            }
            set
            {
                this.ultimoenderecoinformadoField = value;
                this.RaisePropertyChanged("ultimoenderecoinformado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("participacao-empresa", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public ResultadoInsumo participacaoempresa
        {
            get
            {
                return this.participacaoempresaField;
            }
            set
            {
                this.participacaoempresaField = value;
                this.RaisePropertyChanged("participacaoempresa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public ResultadoInsumo socio
        {
            get
            {
                return this.socioField;
            }
            set
            {
                this.socioField = value;
                this.RaisePropertyChanged("socio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public ResultadoInsumo administrador
        {
            get
            {
                return this.administradorField;
            }
            set
            {
                this.administradorField = value;
                this.RaisePropertyChanged("administrador");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alerta-documento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public ResultadoInsumo alertadocumento
        {
            get
            {
                return this.alertadocumentoField;
            }
            set
            {
                this.alertadocumentoField = value;
                this.RaisePropertyChanged("alertadocumento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public ResultadoInsumo spc
        {
            get
            {
                return this.spcField;
            }
            set
            {
                this.spcField = value;
                this.RaisePropertyChanged("spc");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-lojista", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public ResultadoInsumo chequelojista
        {
            get
            {
                return this.chequelojistaField;
            }
            set
            {
                this.chequelojistaField = value;
                this.RaisePropertyChanged("chequelojista");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public ResultadoInsumo ccf
        {
            get
            {
                return this.ccfField;
            }
            set
            {
                this.ccfField = value;
                this.RaisePropertyChanged("ccf");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contra-ordem-documento-diferente", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public ResultadoInsumoContraOrdem contraordemdocumentodiferente
        {
            get
            {
                return this.contraordemdocumentodiferenteField;
            }
            set
            {
                this.contraordemdocumentodiferenteField = value;
                this.RaisePropertyChanged("contraordemdocumentodiferente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contra-ordem-agencia-diferente", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
        public ResultadoInsumoContraOrdem contraordemagenciadiferente
        {
            get
            {
                return this.contraordemagenciadiferenteField;
            }
            set
            {
                this.contraordemagenciadiferenteField = value;
                this.RaisePropertyChanged("contraordemagenciadiferente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contra-ordem-agencia-conta-diferente", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
        public ResultadoInsumoContraOrdem contraordemagenciacontadiferente
        {
            get
            {
                return this.contraordemagenciacontadiferenteField;
            }
            set
            {
                this.contraordemagenciacontadiferenteField = value;
                this.RaisePropertyChanged("contraordemagenciacontadiferente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 22)]
        public ResultadoInsumo acao
        {
            get
            {
                return this.acaoField;
            }
            set
            {
                this.acaoField = value;
                this.RaisePropertyChanged("acao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 23)]
        public ResultadoInsumo protesto
        {
            get
            {
                return this.protestoField;
            }
            set
            {
                this.protestoField = value;
                this.RaisePropertyChanged("protesto");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contra-ordem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 24)]
        public ResultadoInsumoContraOrdem contraordem
        {
            get
            {
                return this.contraordemField;
            }
            set
            {
                this.contraordemField = value;
                this.RaisePropertyChanged("contraordem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 25)]
        public ResultadoInsumoContumacia contumacia
        {
            get
            {
                return this.contumaciaField;
            }
            set
            {
                this.contumaciaField = value;
                this.RaisePropertyChanged("contumacia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("credito-concedido", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 26)]
        public ResultadoInsumo creditoconcedido
        {
            get
            {
                return this.creditoconcedidoField;
            }
            set
            {
                this.creditoconcedidoField = value;
                this.RaisePropertyChanged("creditoconcedido");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("banco-agencia-conta-documento-diferente", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 27)]
        public ResultadoInsumo bancoagenciacontadocumentodiferente
        {
            get
            {
                return this.bancoagenciacontadocumentodiferenteField;
            }
            set
            {
                this.bancoagenciacontadocumentodiferenteField = value;
                this.RaisePropertyChanged("bancoagenciacontadocumentodiferente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dados-agencia-bancaria", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 28)]
        public ResultadoInsumo dadosagenciabancaria
        {
            get
            {
                return this.dadosagenciabancariaField;
            }
            set
            {
                this.dadosagenciabancariaField = value;
                this.RaisePropertyChanged("dadosagenciabancaria");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consulta-realizada", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 29)]
        public ResultadoInsumoConsultaRealizada consultarealizada
        {
            get
            {
                return this.consultarealizadaField;
            }
            set
            {
                this.consultarealizadaField = value;
                this.RaisePropertyChanged("consultarealizada");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("informacao-poder-judiciario", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 30)]
        public ResultadoInsumo informacaopoderjudiciario
        {
            get
            {
                return this.informacaopoderjudiciarioField;
            }
            set
            {
                this.informacaopoderjudiciarioField = value;
                this.RaisePropertyChanged("informacaopoderjudiciario");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("riskscoring-6-meses", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 31)]
        public ResultadoInsumo riskscoring6meses
        {
            get
            {
                return this.riskscoring6mesesField;
            }
            set
            {
                this.riskscoring6mesesField = value;
                this.RaisePropertyChanged("riskscoring6meses");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("riskscoring-12-meses", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 32)]
        public ResultadoInsumo riskscoring12meses
        {
            get
            {
                return this.riskscoring12mesesField;
            }
            set
            {
                this.riskscoring12mesesField = value;
                this.RaisePropertyChanged("riskscoring12meses");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-sem-fundo-achei", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 33)]
        public ResultadoInsumo chequesemfundoachei
        {
            get
            {
                return this.chequesemfundoacheiField;
            }
            set
            {
                this.chequesemfundoacheiField = value;
                this.RaisePropertyChanged("chequesemfundoachei");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-sem-fundo-achei-ccf", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 34)]
        public ResultadoInsumo chequesemfundoacheiccf
        {
            get
            {
                return this.chequesemfundoacheiccfField;
            }
            set
            {
                this.chequesemfundoacheiccfField = value;
                this.RaisePropertyChanged("chequesemfundoacheiccf");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contumacia-srs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 35)]
        public ResultadoInsumo contumaciasrs
        {
            get
            {
                return this.contumaciasrsField;
            }
            set
            {
                this.contumaciasrsField = value;
                this.RaisePropertyChanged("contumaciasrs");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("participacao-falencia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 36)]
        public ResultadoInsumo participacaofalencia
        {
            get
            {
                return this.participacaofalenciaField;
            }
            set
            {
                this.participacaofalenciaField = value;
                this.RaisePropertyChanged("participacaofalencia");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("restricao-financeira", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 37)]
        public ResultadoInsumo restricaofinanceira
        {
            get
            {
                return this.restricaofinanceiraField;
            }
            set
            {
                this.restricaofinanceiraField = value;
                this.RaisePropertyChanged("restricaofinanceira");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pendencia-financeira", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 38)]
        public ResultadoInsumo pendenciafinanceira
        {
            get
            {
                return this.pendenciafinanceiraField;
            }
            set
            {
                this.pendenciafinanceiraField = value;
                this.RaisePropertyChanged("pendenciafinanceira");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-sem-fundo-varejo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 39)]
        public ResultadoInsumo chequesemfundovarejo
        {
            get
            {
                return this.chequesemfundovarejoField;
            }
            set
            {
                this.chequesemfundovarejoField = value;
                this.RaisePropertyChanged("chequesemfundovarejo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contra-ordem-srs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 40)]
        public ResultadoInsumo contraordemsrs
        {
            get
            {
                return this.contraordemsrsField;
            }
            set
            {
                this.contraordemsrsField = value;
                this.RaisePropertyChanged("contraordemsrs");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contra-ordem-documento-diferente-srs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 41)]
        public ResultadoInsumo contraordemdocumentodiferentesrs
        {
            get
            {
                return this.contraordemdocumentodiferentesrsField;
            }
            set
            {
                this.contraordemdocumentodiferentesrsField = value;
                this.RaisePropertyChanged("contraordemdocumentodiferentesrs");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-outras-ocorrencias-srs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 42)]
        public ResultadoInsumo chequeoutrasocorrenciassrs
        {
            get
            {
                return this.chequeoutrasocorrenciassrsField;
            }
            set
            {
                this.chequeoutrasocorrenciassrsField = value;
                this.RaisePropertyChanged("chequeoutrasocorrenciassrs");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-consulta-online-srs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 43)]
        public ResultadoInsumo chequeconsultaonlinesrs
        {
            get
            {
                return this.chequeconsultaonlinesrsField;
            }
            set
            {
                this.chequeconsultaonlinesrsField = value;
                this.RaisePropertyChanged("chequeconsultaonlinesrs");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consulta-realizada-cheque", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 44)]
        public ResultadoInsumo consultarealizadacheque
        {
            get
            {
                return this.consultarealizadachequeField;
            }
            set
            {
                this.consultarealizadachequeField = value;
                this.RaisePropertyChanged("consultarealizadacheque");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("referenciais-negocios", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 45)]
        public ResultadoInsumo referenciaisnegocios
        {
            get
            {
                return this.referenciaisnegociosField;
            }
            set
            {
                this.referenciaisnegociosField = value;
                this.RaisePropertyChanged("referenciaisnegocios");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("historico-pagamento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 46)]
        public ResultadoInsumo historicopagamento
        {
            get
            {
                return this.historicopagamentoField;
            }
            set
            {
                this.historicopagamentoField = value;
                this.RaisePropertyChanged("historicopagamento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relacionamento-mais-antigo-com-fornecedores", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 47)]
        public ResultadoInsumo relacionamentomaisantigocomfornecedores
        {
            get
            {
                return this.relacionamentomaisantigocomfornecedoresField;
            }
            set
            {
                this.relacionamentomaisantigocomfornecedoresField = value;
                this.RaisePropertyChanged("relacionamentomaisantigocomfornecedores");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("registro-consulta", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 48)]
        public ResultadoInsumo registroconsulta
        {
            get
            {
                return this.registroconsultaField;
            }
            set
            {
                this.registroconsultaField = value;
                this.RaisePropertyChanged("registroconsulta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ultimas-consultas", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 49)]
        public ResultadoInsumo ultimasconsultas
        {
            get
            {
                return this.ultimasconsultasField;
            }
            set
            {
                this.ultimasconsultasField = value;
                this.RaisePropertyChanged("ultimasconsultas");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("capital-social", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 50)]
        public ResultadoInsumo capitalsocial
        {
            get
            {
                return this.capitalsocialField;
            }
            set
            {
                this.capitalsocialField = value;
                this.RaisePropertyChanged("capitalsocial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 51)]
        public ResultadoInsumo antecessora
        {
            get
            {
                return this.antecessoraField;
            }
            set
            {
                this.antecessoraField = value;
                this.RaisePropertyChanged("antecessora");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("atividade-empresa", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 52)]
        public ResultadoInsumo atividadeempresa
        {
            get
            {
                return this.atividadeempresaField;
            }
            set
            {
                this.atividadeempresaField = value;
                this.RaisePropertyChanged("atividadeempresa");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 53)]
        public ResultadoInsumo filial
        {
            get
            {
                return this.filialField;
            }
            set
            {
                this.filialField = value;
                this.RaisePropertyChanged("filial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("informacoes-adicionais", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 54)]
        public ResultadoInsumo informacoesadicionais
        {
            get
            {
                return this.informacoesadicionaisField;
            }
            set
            {
                this.informacoesadicionaisField = value;
                this.RaisePropertyChanged("informacoesadicionais");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("incorporacao-fusao-cisao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 55)]
        public ResultadoInsumo incorporacaofusaocisao
        {
            get
            {
                return this.incorporacaofusaocisaoField;
            }
            set
            {
                this.incorporacaofusaocisaoField = value;
                this.RaisePropertyChanged("incorporacaofusaocisao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("principais-produtos", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 56)]
        public ResultadoInsumo principaisprodutos
        {
            get
            {
                return this.principaisprodutosField;
            }
            set
            {
                this.principaisprodutosField = value;
                this.RaisePropertyChanged("principaisprodutos");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mensagem-complementar", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 57)]
        public MensagemComplementar[] mensagemcomplementar
        {
            get
            {
                return this.mensagemcomplementarField;
            }
            set
            {
                this.mensagemcomplementarField = value;
                this.RaisePropertyChanged("mensagemcomplementar");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("spc-score-3-meses", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 58)]
        public ResultadoInsumo spcscore3meses
        {
            get
            {
                return this.spcscore3mesesField;
            }
            set
            {
                this.spcscore3mesesField = value;
                this.RaisePropertyChanged("spcscore3meses");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("spc-score-12-meses", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 59)]
        public ResultadoInsumo spcscore12meses
        {
            get
            {
                return this.spcscore12mesesField;
            }
            set
            {
                this.spcscore12mesesField = value;
                this.RaisePropertyChanged("spcscore12meses");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("spc-obito", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 60)]
        public ResultadoInsumo spcobito
        {
            get
            {
                return this.spcobitoField;
            }
            set
            {
                this.spcobitoField = value;
                this.RaisePropertyChanged("spcobito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("confirmacao-rg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 61)]
        public ResultadoInsumo confirmacaorg
        {
            get
            {
                return this.confirmacaorgField;
            }
            set
            {
                this.confirmacaorgField = value;
                this.RaisePropertyChanged("confirmacaorg");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("renavam-federal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 62)]
        public ResultadoInsumo renavamfederal
        {
            get
            {
                return this.renavamfederalField;
            }
            set
            {
                this.renavamfederalField = value;
                this.RaisePropertyChanged("renavamfederal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("roubo-furto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 63)]
        public ResultadoInsumo roubofurto
        {
            get
            {
                return this.roubofurtoField;
            }
            set
            {
                this.roubofurtoField = value;
                this.RaisePropertyChanged("roubofurto");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 64)]
        public ResultadoInsumo dpvat
        {
            get
            {
                return this.dpvatField;
            }
            set
            {
                this.dpvatField = value;
                this.RaisePropertyChanged("dpvat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 65)]
        public ResultadoInsumo gravame
        {
            get
            {
                return this.gravameField;
            }
            set
            {
                this.gravameField = value;
                this.RaisePropertyChanged("gravame");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("renavam-estadual", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 66)]
        public ResultadoInsumo renavamestadual
        {
            get
            {
                return this.renavamestadualField;
            }
            set
            {
                this.renavamestadualField = value;
                this.RaisePropertyChanged("renavamestadual");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 67)]
        public ResultadoInsumo localizaVeiculo
        {
            get
            {
                return this.localizaVeiculoField;
            }
            set
            {
                this.localizaVeiculoField = value;
                this.RaisePropertyChanged("localizaVeiculo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("renda-presumida-spc", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 68)]
        public ResultadoInsumo rendapresumidaspc
        {
            get
            {
                return this.rendapresumidaspcField;
            }
            set
            {
                this.rendapresumidaspcField = value;
                this.RaisePropertyChanged("rendapresumidaspc");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("limite-credito-sugerido", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 69)]
        public ResultadoInsumo limitecreditosugerido
        {
            get
            {
                return this.limitecreditosugeridoField;
            }
            set
            {
                this.limitecreditosugeridoField = value;
                this.RaisePropertyChanged("limitecreditosugerido");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 70)]
        public ResultadoInsumo ocupacao
        {
            get
            {
                return this.ocupacaoField;
            }
            set
            {
                this.ocupacaoField = value;
                this.RaisePropertyChanged("ocupacao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("informacoes-complementares", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 71)]
        public ResultadoInsumo informacoescomplementares
        {
            get
            {
                return this.informacoescomplementaresField;
            }
            set
            {
                this.informacoescomplementaresField = value;
                this.RaisePropertyChanged("informacoescomplementares");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telefone-alternativo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 72)]
        public ResultadoInsumo telefonealternativo
        {
            get
            {
                return this.telefonealternativoField;
            }
            set
            {
                this.telefonealternativoField = value;
                this.RaisePropertyChanged("telefonealternativo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alerta-obito", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 73)]
        public ResultadoInsumo alertaobito
        {
            get
            {
                return this.alertaobitoField;
            }
            set
            {
                this.alertaobitoField = value;
                this.RaisePropertyChanged("alertaobito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alerta-identidade", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 74)]
        public ResultadoInsumo alertaidentidade
        {
            get
            {
                return this.alertaidentidadeField;
            }
            set
            {
                this.alertaidentidadeField = value;
                this.RaisePropertyChanged("alertaidentidade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("faturamento-presumido", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 75)]
        public ResultadoInsumo faturamentopresumido
        {
            get
            {
                return this.faturamentopresumidoField;
            }
            set
            {
                this.faturamentopresumidoField = value;
                this.RaisePropertyChanged("faturamentopresumido");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("limite-credito-pj", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 76)]
        public ResultadoInsumo limitecreditopj
        {
            get
            {
                return this.limitecreditopjField;
            }
            set
            {
                this.limitecreditopjField = value;
                this.RaisePropertyChanged("limitecreditopj");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gasto-estimado-pj", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 77)]
        public ResultadoInsumo gastoestimadopj
        {
            get
            {
                return this.gastoestimadopjField;
            }
            set
            {
                this.gastoestimadopjField = value;
                this.RaisePropertyChanged("gastoestimadopj");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quadro-social-mais-completo-pj", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 78)]
        public ResultadoInsumo quadrosocialmaiscompletopj
        {
            get
            {
                return this.quadrosocialmaiscompletopjField;
            }
            set
            {
                this.quadrosocialmaiscompletopjField = value;
                this.RaisePropertyChanged("quadrosocialmaiscompletopj");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("risco-credito-pj", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 79)]
        public ResultadoInsumo riscocreditopj
        {
            get
            {
                return this.riscocreditopjField;
            }
            set
            {
                this.riscocreditopjField = value;
                this.RaisePropertyChanged("riscocreditopj");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("perfil-financeiro-pj", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 80)]
        public ResultadoInsumo perfilfinanceiropj
        {
            get
            {
                return this.perfilfinanceiropjField;
            }
            set
            {
                this.perfilfinanceiropjField = value;
                this.RaisePropertyChanged("perfilfinanceiropj");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gasto-estimado-pf", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 81)]
        public ResultadoInsumo gastoestimadopf
        {
            get
            {
                return this.gastoestimadopfField;
            }
            set
            {
                this.gastoestimadopfField = value;
                this.RaisePropertyChanged("gastoestimadopf");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("indice-relacionamento-mercado-pf", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 82)]
        public ResultadoInsumo indicerelacionamentomercadopf
        {
            get
            {
                return this.indicerelacionamentomercadopfField;
            }
            set
            {
                this.indicerelacionamentomercadopfField = value;
                this.RaisePropertyChanged("indicerelacionamentomercadopf");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("indice-relacionamento-mercado-pj", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 83)]
        public ResultadoInsumo indicerelacionamentomercadopj
        {
            get
            {
                return this.indicerelacionamentomercadopjField;
            }
            set
            {
                this.indicerelacionamentomercadopjField = value;
                this.RaisePropertyChanged("indicerelacionamentomercadopj");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool restricao
        {
            get
            {
                return this.restricaoField;
            }
            set
            {
                this.restricaoField = value;
                this.RaisePropertyChanged("restricao");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restricaoSpecified
        {
            get
            {
                return this.restricaoFieldSpecified;
            }
            set
            {
                this.restricaoFieldSpecified = value;
                this.RaisePropertyChanged("restricaoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
                this.RaisePropertyChanged("data");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataSpecified
        {
            get
            {
                return this.dataFieldSpecified;
            }
            set
            {
                this.dataFieldSpecified = value;
                this.RaisePropertyChanged("dataSpecified");
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
