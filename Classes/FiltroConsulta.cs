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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Filtro-Consulta", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class FiltroConsulta : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codigoprodutoField;

        private TipoPessoa tipoconsumidorField;

        private bool tipoconsumidorFieldSpecified;

        private string documentoconsumidorField;

        private string cepconsumidorField;

        private TelefoneFiltro telefoneconsultarField;

        private bool utilizaCMC7Field;

        private bool utilizaCMC7FieldSpecified;

        private int bancochequeinicialField;

        private bool bancochequeinicialFieldSpecified;

        private int agenciachequeinicialField;

        private bool agenciachequeinicialFieldSpecified;

        private long contacorrentechequeinicialField;

        private bool contacorrentechequeinicialFieldSpecified;

        private string digitocontacorrentechequeinicialField;

        private int numerochequeinicialField;

        private bool numerochequeinicialFieldSpecified;

        private int digitochequeinicialField;

        private bool digitochequeinicialFieldSpecified;

        private string cmc71chequeinicialField;

        private string cmc72chequeinicialField;

        private string cmc73chequeinicialField;

        private int quantidadechequeField;

        private bool quantidadechequeFieldSpecified;

        private ChequeFiltro[] chequedetalhadoField;

        private long[] codigoinsumoopcionalField;

        private string ceporigemField;

        private string codigoestacaoconsultanteField;

        private string numerorgField;

        private System.DateTime datanascimentorgField;

        private bool datanascimentorgFieldSpecified;

        private string ufemissaorgField;

        private string chassiField;

        private string renavamField;

        private string motorField;

        private string numerocaixacambioField;

        private string placaField;

        private string siglaestadualautoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("codigo-produto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string codigoproduto
        {
            get
            {
                return this.codigoprodutoField;
            }
            set
            {
                this.codigoprodutoField = value;
                this.RaisePropertyChanged("codigoproduto");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipo-consumidor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public TipoPessoa tipoconsumidor
        {
            get
            {
                return this.tipoconsumidorField;
            }
            set
            {
                this.tipoconsumidorField = value;
                this.RaisePropertyChanged("tipoconsumidor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoconsumidorSpecified
        {
            get
            {
                return this.tipoconsumidorFieldSpecified;
            }
            set
            {
                this.tipoconsumidorFieldSpecified = value;
                this.RaisePropertyChanged("tipoconsumidorSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documento-consumidor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string documentoconsumidor
        {
            get
            {
                return this.documentoconsumidorField;
            }
            set
            {
                this.documentoconsumidorField = value;
                this.RaisePropertyChanged("documentoconsumidor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cep-consumidor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string cepconsumidor
        {
            get
            {
                return this.cepconsumidorField;
            }
            set
            {
                this.cepconsumidorField = value;
                this.RaisePropertyChanged("cepconsumidor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telefone-consultar", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public TelefoneFiltro telefoneconsultar
        {
            get
            {
                return this.telefoneconsultarField;
            }
            set
            {
                this.telefoneconsultarField = value;
                this.RaisePropertyChanged("telefoneconsultar");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("utiliza-CMC7", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public bool utilizaCMC7
        {
            get
            {
                return this.utilizaCMC7Field;
            }
            set
            {
                this.utilizaCMC7Field = value;
                this.RaisePropertyChanged("utilizaCMC7");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool utilizaCMC7Specified
        {
            get
            {
                return this.utilizaCMC7FieldSpecified;
            }
            set
            {
                this.utilizaCMC7FieldSpecified = value;
                this.RaisePropertyChanged("utilizaCMC7Specified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("banco-cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public int bancochequeinicial
        {
            get
            {
                return this.bancochequeinicialField;
            }
            set
            {
                this.bancochequeinicialField = value;
                this.RaisePropertyChanged("bancochequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bancochequeinicialSpecified
        {
            get
            {
                return this.bancochequeinicialFieldSpecified;
            }
            set
            {
                this.bancochequeinicialFieldSpecified = value;
                this.RaisePropertyChanged("bancochequeinicialSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("agencia-cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public int agenciachequeinicial
        {
            get
            {
                return this.agenciachequeinicialField;
            }
            set
            {
                this.agenciachequeinicialField = value;
                this.RaisePropertyChanged("agenciachequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool agenciachequeinicialSpecified
        {
            get
            {
                return this.agenciachequeinicialFieldSpecified;
            }
            set
            {
                this.agenciachequeinicialFieldSpecified = value;
                this.RaisePropertyChanged("agenciachequeinicialSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("conta-corrente-cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public long contacorrentechequeinicial
        {
            get
            {
                return this.contacorrentechequeinicialField;
            }
            set
            {
                this.contacorrentechequeinicialField = value;
                this.RaisePropertyChanged("contacorrentechequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool contacorrentechequeinicialSpecified
        {
            get
            {
                return this.contacorrentechequeinicialFieldSpecified;
            }
            set
            {
                this.contacorrentechequeinicialFieldSpecified = value;
                this.RaisePropertyChanged("contacorrentechequeinicialSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("digito-conta-corrente-cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string digitocontacorrentechequeinicial
        {
            get
            {
                return this.digitocontacorrentechequeinicialField;
            }
            set
            {
                this.digitocontacorrentechequeinicialField = value;
                this.RaisePropertyChanged("digitocontacorrentechequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numero-cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public int numerochequeinicial
        {
            get
            {
                return this.numerochequeinicialField;
            }
            set
            {
                this.numerochequeinicialField = value;
                this.RaisePropertyChanged("numerochequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numerochequeinicialSpecified
        {
            get
            {
                return this.numerochequeinicialFieldSpecified;
            }
            set
            {
                this.numerochequeinicialFieldSpecified = value;
                this.RaisePropertyChanged("numerochequeinicialSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("digito-cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public int digitochequeinicial
        {
            get
            {
                return this.digitochequeinicialField;
            }
            set
            {
                this.digitochequeinicialField = value;
                this.RaisePropertyChanged("digitochequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool digitochequeinicialSpecified
        {
            get
            {
                return this.digitochequeinicialFieldSpecified;
            }
            set
            {
                this.digitochequeinicialFieldSpecified = value;
                this.RaisePropertyChanged("digitochequeinicialSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cmc71-cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string cmc71chequeinicial
        {
            get
            {
                return this.cmc71chequeinicialField;
            }
            set
            {
                this.cmc71chequeinicialField = value;
                this.RaisePropertyChanged("cmc71chequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cmc72-cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string cmc72chequeinicial
        {
            get
            {
                return this.cmc72chequeinicialField;
            }
            set
            {
                this.cmc72chequeinicialField = value;
                this.RaisePropertyChanged("cmc72chequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cmc73-cheque-inicial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string cmc73chequeinicial
        {
            get
            {
                return this.cmc73chequeinicialField;
            }
            set
            {
                this.cmc73chequeinicialField = value;
                this.RaisePropertyChanged("cmc73chequeinicial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantidade-cheque", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public int quantidadecheque
        {
            get
            {
                return this.quantidadechequeField;
            }
            set
            {
                this.quantidadechequeField = value;
                this.RaisePropertyChanged("quantidadecheque");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantidadechequeSpecified
        {
            get
            {
                return this.quantidadechequeFieldSpecified;
            }
            set
            {
                this.quantidadechequeFieldSpecified = value;
                this.RaisePropertyChanged("quantidadechequeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cheque-detalhado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public ChequeFiltro[] chequedetalhado
        {
            get
            {
                return this.chequedetalhadoField;
            }
            set
            {
                this.chequedetalhadoField = value;
                this.RaisePropertyChanged("chequedetalhado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("codigo-insumo-opcional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public long[] codigoinsumoopcional
        {
            get
            {
                return this.codigoinsumoopcionalField;
            }
            set
            {
                this.codigoinsumoopcionalField = value;
                this.RaisePropertyChanged("codigoinsumoopcional");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cep-origem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public string ceporigem
        {
            get
            {
                return this.ceporigemField;
            }
            set
            {
                this.ceporigemField = value;
                this.RaisePropertyChanged("ceporigem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("codigo-estacao-consultante", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public string codigoestacaoconsultante
        {
            get
            {
                return this.codigoestacaoconsultanteField;
            }
            set
            {
                this.codigoestacaoconsultanteField = value;
                this.RaisePropertyChanged("codigoestacaoconsultante");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numero-rg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
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
        [System.Xml.Serialization.XmlElementAttribute("data-nascimento-rg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
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
        [System.Xml.Serialization.XmlElementAttribute("uf-emissao-rg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 22)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 23)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 24)]
        public string renavam
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 25)]
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
        [System.Xml.Serialization.XmlElementAttribute("numero-caixa-cambio", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 26)]
        public string numerocaixacambio
        {
            get
            {
                return this.numerocaixacambioField;
            }
            set
            {
                this.numerocaixacambioField = value;
                this.RaisePropertyChanged("numerocaixacambio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 27)]
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
        [System.Xml.Serialization.XmlElementAttribute("sigla-estadual-auto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 28)]
        public string siglaestadualauto
        {
            get
            {
                return this.siglaestadualautoField;
            }
            set
            {
                this.siglaestadualautoField = value;
                this.RaisePropertyChanged("siglaestadualauto");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Tipo-Pessoa", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public enum TipoPessoa
    {

        /// <remarks/>
        F,

        /// <remarks/>
        J,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Telefone-Filtro", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class TelefoneFiltro : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int dddField;

        private int numeroField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int ddd
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Cheque-Filtro", Namespace = "http://webservice.consulta.spcjava.spcbrasil.org/")]
    public partial class ChequeFiltro : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int numeroField;

        private int digitoField;

        private System.DateTime datadepositoField;

        private decimal valorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute("data-deposito", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public System.DateTime datadeposito
        {
            get
            {
                return this.datadepositoField;
            }
            set
            {
                this.datadepositoField = value;
                this.RaisePropertyChanged("datadeposito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
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
