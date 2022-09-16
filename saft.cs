namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Saft
    {
        [JsonProperty("?xml")]
        public string Xml { get; set; }

        [JsonProperty("AuditFile")]
        public AuditFile AuditFile { get; set; }
    }

    public partial class AuditFile
    {
        [JsonProperty("Header")]
        public Header Header { get; set; }

        [JsonProperty("MasterFiles")]
        public MasterFiles MasterFiles { get; set; }

        [JsonProperty("GeneralLedgerEntries")]
        public GeneralLedgerEntries GeneralLedgerEntries { get; set; }

        [JsonProperty("SourceDocuments")]
        public SourceDocuments SourceDocuments { get; set; }
    }

    public partial class GeneralLedgerEntries
    {
        [JsonProperty("NumberOfEntries")]
        public long NumberOfEntries { get; set; }

        [JsonProperty("TotalDebit")]
        public double TotalDebit { get; set; }

        [JsonProperty("TotalCredit")]
        public double TotalCredit { get; set; }

        [JsonProperty("Journal", NullValueHandling = NullValueHandling.Ignore)]
        public Journal[] Journal { get; set; }

        [JsonProperty("Payment", NullValueHandling = NullValueHandling.Ignore)]
        public Payment[] Payment { get; set; }
    }

    public partial class Journal
    {
        [JsonProperty("JournalID")]
        public long JournalId { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Transaction", NullValueHandling = NullValueHandling.Ignore)]
        public Transaction[] Transaction { get; set; }
    }

    public partial class Transaction
    {
        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }

        [JsonProperty("Period")]
        public long Period { get; set; }

        [JsonProperty("TransactionDate")]
        public DateTimeOffset TransactionDate { get; set; }

        [JsonProperty("SourceID")]
        public SourceId SourceId { get; set; }

        [JsonProperty("Description")]
        public Description Description { get; set; }

        [JsonProperty("DocArchivalNumber")]
        public long DocArchivalNumber { get; set; }

        [JsonProperty("TransactionType")]
        public PaymentStatus TransactionType { get; set; }

        [JsonProperty("GLPostingDate")]
        public DateTimeOffset GlPostingDate { get; set; }

        [JsonProperty("Lines")]
        public Lines Lines { get; set; }

        [JsonProperty("SupplierID", NullValueHandling = NullValueHandling.Ignore)]
        public long? SupplierId { get; set; }

        [JsonProperty("CustomerID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CustomerId { get; set; }
    }

    public partial class Lines
    {
        [JsonProperty("DebitLine")]
        public ItLine[] DebitLine { get; set; }

        [JsonProperty("CreditLine")]
        public ItLine[] CreditLine { get; set; }
    }

    public partial class ItLine
    {
        [JsonProperty("RecordID")]
        public long RecordId { get; set; }

        [JsonProperty("AccountID")]
        public long AccountId { get; set; }

        [JsonProperty("SystemEntryDate")]
        public DateTimeOffset SystemEntryDate { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("CreditAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? CreditAmount { get; set; }

        [JsonProperty("SourceDocumentID", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDocumentId { get; set; }

        [JsonProperty("DebitAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? DebitAmount { get; set; }
    }

    public partial class Payment
    {
        [JsonProperty("PaymentRefNo")]
        public string PaymentRefNo { get; set; }

        [JsonProperty("ATCUD")]
        public long Atcud { get; set; }

        [JsonProperty("Period")]
        public long Period { get; set; }

        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }

        [JsonProperty("TransactionDate")]
        public DateTimeOffset TransactionDate { get; set; }

        [JsonProperty("PaymentType")]
        public PaymentType PaymentType { get; set; }

        [JsonProperty("DocumentStatus")]
        public DocumentStatus DocumentStatus { get; set; }

        [JsonProperty("SourceID")]
        public SourceId SourceId { get; set; }

        [JsonProperty("SystemEntryDate")]
        public DateTimeOffset SystemEntryDate { get; set; }

        [JsonProperty("CustomerID")]
        public long CustomerId { get; set; }

        [JsonProperty("Line")]
        public Line[] Line { get; set; }

        [JsonProperty("DocumentTotals")]
        public DocumentTotals DocumentTotals { get; set; }
    }

    public partial class DocumentStatus
    {
        [JsonProperty("PaymentStatus")]
        public PaymentStatus PaymentStatus { get; set; }

        [JsonProperty("PaymentStatusDate")]
        public DateTimeOffset PaymentStatusDate { get; set; }

        [JsonProperty("SourceID")]
        public SourceId SourceId { get; set; }

        [JsonProperty("SourcePayment")]
        public SourcePayment SourcePayment { get; set; }
    }

    public partial class DocumentTotals
    {
        [JsonProperty("TaxPayable")]
        public long TaxPayable { get; set; }

        [JsonProperty("NetTotal")]
        public double NetTotal { get; set; }

        [JsonProperty("GrossTotal")]
        public double GrossTotal { get; set; }

        [JsonProperty("Settlement")]
        public Settlement Settlement { get; set; }
    }

    public partial class Settlement
    {
        [JsonProperty("SettlementAmount")]
        public long SettlementAmount { get; set; }
    }

    public partial class Line
    {
        [JsonProperty("LineNumber")]
        public long LineNumber { get; set; }

        [JsonProperty("SourceDocumentID")]
        public SourceDocumentId SourceDocumentId { get; set; }

        [JsonProperty("SettlementAmount")]
        public long SettlementAmount { get; set; }

        [JsonProperty("CreditAmount")]
        public double CreditAmount { get; set; }
    }

    public partial class SourceDocumentId
    {
        [JsonProperty("OriginatingON")]
        public string OriginatingOn { get; set; }

        [JsonProperty("InvoiceDate")]
        public DateTimeOffset InvoiceDate { get; set; }

        [JsonProperty("Description")]
        public Description Description { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("AuditFileVersion")]
        public string AuditFileVersion { get; set; }

        [JsonProperty("CompanyID")]
        public string CompanyId { get; set; }

        [JsonProperty("TaxRegistrationNumber")]
        public long TaxRegistrationNumber { get; set; }

        [JsonProperty("TaxAccountingBasis")]
        public string TaxAccountingBasis { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("BusinessName")]
        public string BusinessName { get; set; }

        [JsonProperty("CompanyAddress")]
        public CompanyAddress CompanyAddress { get; set; }

        [JsonProperty("FiscalYear")]
        public long FiscalYear { get; set; }

        [JsonProperty("StartDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("EndDate")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("CurrencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("DateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("TaxEntity")]
        public string TaxEntity { get; set; }

        [JsonProperty("ProductCompanyTaxID")]
        public long ProductCompanyTaxId { get; set; }

        [JsonProperty("SoftwareCertificateNumber")]
        public long SoftwareCertificateNumber { get; set; }

        [JsonProperty("ProductID")]
        public string ProductId { get; set; }

        [JsonProperty("ProductVersion")]
        public long ProductVersion { get; set; }

        [JsonProperty("Telephone")]
        public long Telephone { get; set; }

        [JsonProperty("Fax")]
        public long Fax { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Website")]
        public string Website { get; set; }
    }

    public partial class CompanyAddress
    {
        [JsonProperty("AddressDetail")]
        public string AddressDetail { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("Country")]
        public Country Country { get; set; }
    }

    public partial class MasterFiles
    {
        [JsonProperty("GeneralLedgerAccounts")]
        public GeneralLedgerAccounts GeneralLedgerAccounts { get; set; }

        [JsonProperty("Customer")]
        public Customer[] Customer { get; set; }

        [JsonProperty("Supplier")]
        public Customer[] Supplier { get; set; }

        [JsonProperty("TaxTable")]
        public TaxTable TaxTable { get; set; }
    }

    public partial class Customer
    {
        [JsonProperty("CustomerID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CustomerId { get; set; }

        [JsonProperty("AccountID")]
        public long AccountId { get; set; }

        [JsonProperty("CustomerTaxID", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerTaxId? CustomerTaxId { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("BillingAddress")]
        public BillingAddress BillingAddress { get; set; }

        [JsonProperty("SelfBillingIndicator")]
        public long SelfBillingIndicator { get; set; }

        [JsonProperty("Telephone", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerTaxId? Telephone { get; set; }

        [JsonProperty("Fax", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerTaxId? Fax { get; set; }

        [JsonProperty("Website", NullValueHandling = NullValueHandling.Ignore)]
        public string Website { get; set; }

        [JsonProperty("Email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("Contact", NullValueHandling = NullValueHandling.Ignore)]
        public string Contact { get; set; }

        [JsonProperty("SupplierID", NullValueHandling = NullValueHandling.Ignore)]
        public long? SupplierId { get; set; }

        [JsonProperty("SupplierTaxID", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerTaxId? SupplierTaxId { get; set; }
    }

    public partial class BillingAddress
    {
        [JsonProperty("AddressDetail")]
        public string AddressDetail { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("PostalCode")]
        public CustomerTaxId PostalCode { get; set; }

        [JsonProperty("Country")]
        public Country Country { get; set; }
    }

    public partial class GeneralLedgerAccounts
    {
        [JsonProperty("TaxonomyReference")]
        public string TaxonomyReference { get; set; }

        [JsonProperty("Account")]
        public Account[] Account { get; set; }
    }

    public partial class Account
    {
        [JsonProperty("AccountID")]
        public long AccountId { get; set; }

        [JsonProperty("AccountDescription")]
        public string AccountDescription { get; set; }

        [JsonProperty("OpeningDebitBalance")]
        public double OpeningDebitBalance { get; set; }

        [JsonProperty("OpeningCreditBalance")]
        public double OpeningCreditBalance { get; set; }

        [JsonProperty("ClosingDebitBalance")]
        public double ClosingDebitBalance { get; set; }

        [JsonProperty("ClosingCreditBalance")]
        public double ClosingCreditBalance { get; set; }

        [JsonProperty("GroupingCategory")]
        public GroupingCategory GroupingCategory { get; set; }

        [JsonProperty("GroupingCode", NullValueHandling = NullValueHandling.Ignore)]
        public long? GroupingCode { get; set; }

        [JsonProperty("TaxonomyCode", NullValueHandling = NullValueHandling.Ignore)]
        public long? TaxonomyCode { get; set; }
    }

    public partial class TaxTable
    {
        [JsonProperty("TaxTableEntry")]
        public TaxTableEntry[] TaxTableEntry { get; set; }
    }

    public partial class TaxTableEntry
    {
        [JsonProperty("TaxType")]
        public string TaxType { get; set; }

        [JsonProperty("TaxCountryRegion")]
        public Country TaxCountryRegion { get; set; }

        [JsonProperty("TaxCode")]
        public string TaxCode { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("TaxPercentage")]
        public long TaxPercentage { get; set; }
    }

    public partial class SourceDocuments
    {
        [JsonProperty("Payments")]
        public GeneralLedgerEntries Payments { get; set; }
    }

    public enum Description { Amortizações, ApuramentoDeIva, ApuramentoIva, ApuramentoResultados, DevLançManual, Devolução, DevoluçãoRequisição, EntradaEmStock, Factura, FacturaDif, FacturaSub, Fatura, Imobilizado, LançamentosManuaisGfeSub, LançamentosManuaisMob, Liquidação, NotaDeCrédito, OperaçãoComCartãoCrédito, OperaçõesBancárias, OperaçõesDiversas, ProcessamentoDeSalários, ProcessoMercadoria, ProcessoObra, Recibo, Rectificações, ReqInternaProdução, RequisiçãoInterna };

    public enum SourceId { Armazem, Estela, Jdias, MRibeiro, Producao, Sec, XAlmeida };

    public enum PaymentStatus { A, N, R };

    public enum SourcePayment { P };

    public enum PaymentType { Rg };

    public enum Country { Ao, Be, Ca, Ch, Cn, Cz, De, Dk, Ee, Es, Fr, Hu, Id, Ie, It, Mt, Nl, Pl, Pt, Ro, Ru, Se, Si, Tn, Us };

    public enum GroupingCategory { Ga, Gm, Gr };

    public partial struct CustomerTaxId
    {
        public long? Integer;
        public string String;

        public static implicit operator CustomerTaxId(long Integer) => new CustomerTaxId { Integer = Integer };
        public static implicit operator CustomerTaxId(string String) => new CustomerTaxId { String = String };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                DescriptionConverter.Singleton,
                SourceIdConverter.Singleton,
                PaymentStatusConverter.Singleton,
                SourcePaymentConverter.Singleton,
                PaymentTypeConverter.Singleton,
                CountryConverter.Singleton,
                CustomerTaxIdConverter.Singleton,
                GroupingCategoryConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class DescriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Amortizações":
                    return Description.Amortizações;
                case "Apuramento IVA":
                    return Description.ApuramentoIva;
                case "Apuramento Resultados":
                    return Description.ApuramentoResultados;
                case "Apuramento de IVA":
                    return Description.ApuramentoDeIva;
                case "Dev.Lanç.Manual":
                    return Description.DevLançManual;
                case "Devolução":
                    return Description.Devolução;
                case "Devolução Requisição":
                    return Description.DevoluçãoRequisição;
                case "Entrada em stock":
                    return Description.EntradaEmStock;
                case "Factura":
                    return Description.Factura;
                case "Factura Dif.":
                    return Description.FacturaDif;
                case "Factura SUB":
                    return Description.FacturaSub;
                case "Fatura":
                    return Description.Fatura;
                case "Imobilizado":
                    return Description.Imobilizado;
                case "Lançamentos Manuais GFE/SUB":
                    return Description.LançamentosManuaisGfeSub;
                case "Lançamentos Manuais MOB":
                    return Description.LançamentosManuaisMob;
                case "Liquidação":
                    return Description.Liquidação;
                case "Nota de Crédito":
                    return Description.NotaDeCrédito;
                case "Operação com cartão crédito":
                    return Description.OperaçãoComCartãoCrédito;
                case "Operações bancárias":
                    return Description.OperaçõesBancárias;
                case "Operações diversas":
                    return Description.OperaçõesDiversas;
                case "Processamento de Salários":
                    return Description.ProcessamentoDeSalários;
                case "Processo Mercadoria":
                    return Description.ProcessoMercadoria;
                case "Processo Obra":
                    return Description.ProcessoObra;
                case "Recibo":
                    return Description.Recibo;
                case "Rectificações":
                    return Description.Rectificações;
                case "Req. Interna Produção":
                    return Description.ReqInternaProdução;
                case "Requisição Interna":
                    return Description.RequisiçãoInterna;
            }
            throw new Exception("Cannot unmarshal type Description");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Description)untypedValue;
            switch (value)
            {
                case Description.Amortizações:
                    serializer.Serialize(writer, "Amortizações");
                    return;
                case Description.ApuramentoIva:
                    serializer.Serialize(writer, "Apuramento IVA");
                    return;
                case Description.ApuramentoResultados:
                    serializer.Serialize(writer, "Apuramento Resultados");
                    return;
                case Description.ApuramentoDeIva:
                    serializer.Serialize(writer, "Apuramento de IVA");
                    return;
                case Description.DevLançManual:
                    serializer.Serialize(writer, "Dev.Lanç.Manual");
                    return;
                case Description.Devolução:
                    serializer.Serialize(writer, "Devolução");
                    return;
                case Description.DevoluçãoRequisição:
                    serializer.Serialize(writer, "Devolução Requisição");
                    return;
                case Description.EntradaEmStock:
                    serializer.Serialize(writer, "Entrada em stock");
                    return;
                case Description.Factura:
                    serializer.Serialize(writer, "Factura");
                    return;
                case Description.FacturaDif:
                    serializer.Serialize(writer, "Factura Dif.");
                    return;
                case Description.FacturaSub:
                    serializer.Serialize(writer, "Factura SUB");
                    return;
                case Description.Fatura:
                    serializer.Serialize(writer, "Fatura");
                    return;
                case Description.Imobilizado:
                    serializer.Serialize(writer, "Imobilizado");
                    return;
                case Description.LançamentosManuaisGfeSub:
                    serializer.Serialize(writer, "Lançamentos Manuais GFE/SUB");
                    return;
                case Description.LançamentosManuaisMob:
                    serializer.Serialize(writer, "Lançamentos Manuais MOB");
                    return;
                case Description.Liquidação:
                    serializer.Serialize(writer, "Liquidação");
                    return;
                case Description.NotaDeCrédito:
                    serializer.Serialize(writer, "Nota de Crédito");
                    return;
                case Description.OperaçãoComCartãoCrédito:
                    serializer.Serialize(writer, "Operação com cartão crédito");
                    return;
                case Description.OperaçõesBancárias:
                    serializer.Serialize(writer, "Operações bancárias");
                    return;
                case Description.OperaçõesDiversas:
                    serializer.Serialize(writer, "Operações diversas");
                    return;
                case Description.ProcessamentoDeSalários:
                    serializer.Serialize(writer, "Processamento de Salários");
                    return;
                case Description.ProcessoMercadoria:
                    serializer.Serialize(writer, "Processo Mercadoria");
                    return;
                case Description.ProcessoObra:
                    serializer.Serialize(writer, "Processo Obra");
                    return;
                case Description.Recibo:
                    serializer.Serialize(writer, "Recibo");
                    return;
                case Description.Rectificações:
                    serializer.Serialize(writer, "Rectificações");
                    return;
                case Description.ReqInternaProdução:
                    serializer.Serialize(writer, "Req. Interna Produção");
                    return;
                case Description.RequisiçãoInterna:
                    serializer.Serialize(writer, "Requisição Interna");
                    return;
            }
            throw new Exception("Cannot marshal type Description");
        }

        public static readonly DescriptionConverter Singleton = new DescriptionConverter();
    }

    internal class SourceIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SourceId) || t == typeof(SourceId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Armazem":
                    return SourceId.Armazem;
                case "Estela":
                    return SourceId.Estela;
                case "JDIAS":
                    return SourceId.Jdias;
                case "MRibeiro":
                    return SourceId.MRibeiro;
                case "Producao":
                    return SourceId.Producao;
                case "Sec":
                    return SourceId.Sec;
                case "XAlmeida":
                    return SourceId.XAlmeida;
            }
            throw new Exception("Cannot unmarshal type SourceId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SourceId)untypedValue;
            switch (value)
            {
                case SourceId.Armazem:
                    serializer.Serialize(writer, "Armazem");
                    return;
                case SourceId.Estela:
                    serializer.Serialize(writer, "Estela");
                    return;
                case SourceId.Jdias:
                    serializer.Serialize(writer, "JDIAS");
                    return;
                case SourceId.MRibeiro:
                    serializer.Serialize(writer, "MRibeiro");
                    return;
                case SourceId.Producao:
                    serializer.Serialize(writer, "Producao");
                    return;
                case SourceId.Sec:
                    serializer.Serialize(writer, "Sec");
                    return;
                case SourceId.XAlmeida:
                    serializer.Serialize(writer, "XAlmeida");
                    return;
            }
            throw new Exception("Cannot marshal type SourceId");
        }

        public static readonly SourceIdConverter Singleton = new SourceIdConverter();
    }

    internal class PaymentStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PaymentStatus) || t == typeof(PaymentStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "A":
                    return PaymentStatus.A;
                case "N":
                    return PaymentStatus.N;
                case "R":
                    return PaymentStatus.R;
            }
            throw new Exception("Cannot unmarshal type PaymentStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PaymentStatus)untypedValue;
            switch (value)
            {
                case PaymentStatus.A:
                    serializer.Serialize(writer, "A");
                    return;
                case PaymentStatus.N:
                    serializer.Serialize(writer, "N");
                    return;
                case PaymentStatus.R:
                    serializer.Serialize(writer, "R");
                    return;
            }
            throw new Exception("Cannot marshal type PaymentStatus");
        }

        public static readonly PaymentStatusConverter Singleton = new PaymentStatusConverter();
    }

    internal class SourcePaymentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SourcePayment) || t == typeof(SourcePayment?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "P")
            {
                return SourcePayment.P;
            }
            throw new Exception("Cannot unmarshal type SourcePayment");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SourcePayment)untypedValue;
            if (value == SourcePayment.P)
            {
                serializer.Serialize(writer, "P");
                return;
            }
            throw new Exception("Cannot marshal type SourcePayment");
        }

        public static readonly SourcePaymentConverter Singleton = new SourcePaymentConverter();
    }

    internal class PaymentTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PaymentType) || t == typeof(PaymentType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "RG")
            {
                return PaymentType.Rg;
            }
            throw new Exception("Cannot unmarshal type PaymentType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PaymentType)untypedValue;
            if (value == PaymentType.Rg)
            {
                serializer.Serialize(writer, "RG");
                return;
            }
            throw new Exception("Cannot marshal type PaymentType");
        }

        public static readonly PaymentTypeConverter Singleton = new PaymentTypeConverter();
    }

    internal class CountryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Country) || t == typeof(Country?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AO":
                    return Country.Ao;
                case "BE":
                    return Country.Be;
                case "CA":
                    return Country.Ca;
                case "CH":
                    return Country.Ch;
                case "CN":
                    return Country.Cn;
                case "CZ":
                    return Country.Cz;
                case "DE":
                    return Country.De;
                case "DK":
                    return Country.Dk;
                case "EE":
                    return Country.Ee;
                case "ES":
                    return Country.Es;
                case "FR":
                    return Country.Fr;
                case "HU":
                    return Country.Hu;
                case "ID":
                    return Country.Id;
                case "IE":
                    return Country.Ie;
                case "IT":
                    return Country.It;
                case "MT":
                    return Country.Mt;
                case "NL":
                    return Country.Nl;
                case "PL":
                    return Country.Pl;
                case "PT":
                    return Country.Pt;
                case "RO":
                    return Country.Ro;
                case "RU":
                    return Country.Ru;
                case "SE":
                    return Country.Se;
                case "SI":
                    return Country.Si;
                case "TN":
                    return Country.Tn;
                case "US":
                    return Country.Us;
            }
            throw new Exception("Cannot unmarshal type Country");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Country)untypedValue;
            switch (value)
            {
                case Country.Ao:
                    serializer.Serialize(writer, "AO");
                    return;
                case Country.Be:
                    serializer.Serialize(writer, "BE");
                    return;
                case Country.Ca:
                    serializer.Serialize(writer, "CA");
                    return;
                case Country.Ch:
                    serializer.Serialize(writer, "CH");
                    return;
                case Country.Cn:
                    serializer.Serialize(writer, "CN");
                    return;
                case Country.Cz:
                    serializer.Serialize(writer, "CZ");
                    return;
                case Country.De:
                    serializer.Serialize(writer, "DE");
                    return;
                case Country.Dk:
                    serializer.Serialize(writer, "DK");
                    return;
                case Country.Ee:
                    serializer.Serialize(writer, "EE");
                    return;
                case Country.Es:
                    serializer.Serialize(writer, "ES");
                    return;
                case Country.Fr:
                    serializer.Serialize(writer, "FR");
                    return;
                case Country.Hu:
                    serializer.Serialize(writer, "HU");
                    return;
                case Country.Id:
                    serializer.Serialize(writer, "ID");
                    return;
                case Country.Ie:
                    serializer.Serialize(writer, "IE");
                    return;
                case Country.It:
                    serializer.Serialize(writer, "IT");
                    return;
                case Country.Mt:
                    serializer.Serialize(writer, "MT");
                    return;
                case Country.Nl:
                    serializer.Serialize(writer, "NL");
                    return;
                case Country.Pl:
                    serializer.Serialize(writer, "PL");
                    return;
                case Country.Pt:
                    serializer.Serialize(writer, "PT");
                    return;
                case Country.Ro:
                    serializer.Serialize(writer, "RO");
                    return;
                case Country.Ru:
                    serializer.Serialize(writer, "RU");
                    return;
                case Country.Se:
                    serializer.Serialize(writer, "SE");
                    return;
                case Country.Si:
                    serializer.Serialize(writer, "SI");
                    return;
                case Country.Tn:
                    serializer.Serialize(writer, "TN");
                    return;
                case Country.Us:
                    serializer.Serialize(writer, "US");
                    return;
            }
            throw new Exception("Cannot marshal type Country");
        }

        public static readonly CountryConverter Singleton = new CountryConverter();
    }

    internal class CustomerTaxIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CustomerTaxId) || t == typeof(CustomerTaxId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new CustomerTaxId { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new CustomerTaxId { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type CustomerTaxId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CustomerTaxId)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type CustomerTaxId");
        }

        public static readonly CustomerTaxIdConverter Singleton = new CustomerTaxIdConverter();
    }

    internal class GroupingCategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GroupingCategory) || t == typeof(GroupingCategory?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "GA":
                    return GroupingCategory.Ga;
                case "GM":
                    return GroupingCategory.Gm;
                case "GR":
                    return GroupingCategory.Gr;
            }
            throw new Exception("Cannot unmarshal type GroupingCategory");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GroupingCategory)untypedValue;
            switch (value)
            {
                case GroupingCategory.Ga:
                    serializer.Serialize(writer, "GA");
                    return;
                case GroupingCategory.Gm:
                    serializer.Serialize(writer, "GM");
                    return;
                case GroupingCategory.Gr:
                    serializer.Serialize(writer, "GR");
                    return;
            }
            throw new Exception("Cannot marshal type GroupingCategory");
        }

        public static readonly GroupingCategoryConverter Singleton = new GroupingCategoryConverter();
    }
}
