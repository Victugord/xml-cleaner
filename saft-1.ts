export interface Saft1 {
    "?xml":    string;
    AuditFile: AuditFile;
}

export interface AuditFile {
    Header:               Header;
    MasterFiles:          MasterFiles;
    GeneralLedgerEntries: GeneralLedgerEntries;
    SourceDocuments:      SourceDocuments;
}

export interface GeneralLedgerEntries {
    NumberOfEntries: number;
    TotalDebit:      number;
    TotalCredit:     number;
    Journal?:        Journal[];
    Payment?:        Payment[];
}

export interface Journal {
    JournalID:    number;
    Description:  string;
    Transaction?: Transaction[];
}

export interface Transaction {
    TransactionID:     string;
    Period:            number;
    TransactionDate:   Date;
    SourceID:          SourceID;
    Description:       Description;
    DocArchivalNumber: number;
    TransactionType:   PaymentStatus;
    GLPostingDate:     Date;
    Lines:             Lines;
    SupplierID?:       number;
    CustomerID?:       number;
}

export enum Description {
    Amortizações = "Amortizações",
    ApuramentoDeIVA = "Apuramento de IVA",
    ApuramentoIVA = "Apuramento IVA",
    ApuramentoResultados = "Apuramento Resultados",
    DevLançManual = "Dev.Lanç.Manual",
    Devolução = "Devolução",
    DevoluçãoRequisição = "Devolução Requisição",
    EntradaEmStock = "Entrada em stock",
    Factura = "Factura",
    FacturaDIF = "Factura Dif.",
    FacturaSUB = "Factura SUB",
    Fatura = "Fatura",
    Imobilizado = "Imobilizado",
    LançamentosManuaisGFESUB = "Lançamentos Manuais GFE/SUB",
    LançamentosManuaisMOB = "Lançamentos Manuais MOB",
    Liquidação = "Liquidação",
    NotaDeCrédito = "Nota de Crédito",
    OperaçãoCOMCartãoCrédito = "Operação com cartão crédito",
    OperaçõesBancárias = "Operações bancárias",
    OperaçõesDiversas = "Operações diversas",
    ProcessamentoDeSalários = "Processamento de Salários",
    ProcessoMercadoria = "Processo Mercadoria",
    ProcessoObra = "Processo Obra",
    Recibo = "Recibo",
    Rectificações = "Rectificações",
    ReqInternaProdução = "Req. Interna Produção",
    RequisiçãoInterna = "Requisição Interna",
}

export interface Lines {
    DebitLine:  ItLine[];
    CreditLine: ItLine[];
}

export interface ItLine {
    RecordID:          number;
    AccountID:         number;
    SystemEntryDate:   Date;
    Description:       string;
    CreditAmount?:     number;
    SourceDocumentID?: string;
    DebitAmount?:      number;
}

export enum SourceID {
    Armazem = "Armazem",
    Estela = "Estela",
    Jdias = "JDIAS",
    MRibeiro = "MRibeiro",
    Producao = "Producao",
    SEC = "Sec",
    XAlmeida = "XAlmeida",
}

export enum PaymentStatus {
    A = "A",
    N = "N",
    R = "R",
}

export interface Payment {
    PaymentRefNo:    string;
    ATCUD:           number;
    Period:          number;
    TransactionID:   string;
    TransactionDate: Date;
    PaymentType:     PaymentType;
    DocumentStatus:  DocumentStatus;
    SourceID:        SourceID;
    SystemEntryDate: Date;
    CustomerID:      number;
    Line:            Line[];
    DocumentTotals:  DocumentTotals;
}

export interface DocumentStatus {
    PaymentStatus:     PaymentStatus;
    PaymentStatusDate: Date;
    SourceID:          SourceID;
    SourcePayment:     SourcePayment;
}

export enum SourcePayment {
    P = "P",
}

export interface DocumentTotals {
    TaxPayable: number;
    NetTotal:   number;
    GrossTotal: number;
    Settlement: Settlement;
}

export interface Settlement {
    SettlementAmount: number;
}

export interface Line {
    LineNumber:       number;
    SourceDocumentID: SourceDocumentID;
    SettlementAmount: number;
    CreditAmount:     number;
}

export interface SourceDocumentID {
    OriginatingON: string;
    InvoiceDate:   Date;
    Description:   Description;
}

export enum PaymentType {
    Rg = "RG",
}

export interface Header {
    AuditFileVersion:          string;
    CompanyID:                 string;
    TaxRegistrationNumber:     number;
    TaxAccountingBasis:        string;
    CompanyName:               string;
    BusinessName:              string;
    CompanyAddress:            CompanyAddress;
    FiscalYear:                number;
    StartDate:                 Date;
    EndDate:                   Date;
    CurrencyCode:              string;
    DateCreated:               Date;
    TaxEntity:                 string;
    ProductCompanyTaxID:       number;
    SoftwareCertificateNumber: number;
    ProductID:                 string;
    ProductVersion:            number;
    Telephone:                 number;
    Fax:                       number;
    Email:                     string;
    Website:                   string;
}

export interface CompanyAddress {
    AddressDetail: string;
    City:          string;
    PostalCode:    string;
    Region:        string;
    Country:       Country;
}

export enum Country {
    Ao = "AO",
    Be = "BE",
    CA = "CA",
    CN = "CN",
    Ch = "CH",
    Cz = "CZ",
    De = "DE",
    Dk = "DK",
    Ee = "EE",
    Es = "ES",
    Fr = "FR",
    Hu = "HU",
    ID = "ID",
    Ie = "IE",
    It = "IT",
    MT = "MT",
    Nl = "NL",
    Pl = "PL",
    Pt = "PT",
    Ro = "RO",
    Ru = "RU",
    SE = "SE",
    Si = "SI",
    Tn = "TN",
    Us = "US",
}

export interface MasterFiles {
    GeneralLedgerAccounts: GeneralLedgerAccounts;
    Customer:              Customer[];
    Supplier:              Customer[];
    TaxTable:              TaxTable;
}

export interface Customer {
    CustomerID?:          number;
    AccountID:            number;
    CustomerTaxID?:       number | string;
    CompanyName:          string;
    BillingAddress:       BillingAddress;
    SelfBillingIndicator: number;
    Telephone?:           number | string;
    Fax?:                 number | string;
    Website?:             string;
    Email?:               string;
    Contact?:             string;
    SupplierID?:          number;
    SupplierTaxID?:       number | string;
}

export interface BillingAddress {
    AddressDetail: string;
    City:          string;
    PostalCode:    number | string;
    Country:       Country;
}

export interface GeneralLedgerAccounts {
    TaxonomyReference: string;
    Account:           Account[];
}

export interface Account {
    AccountID:            number;
    AccountDescription:   string;
    OpeningDebitBalance:  number;
    OpeningCreditBalance: number;
    ClosingDebitBalance:  number;
    ClosingCreditBalance: number;
    GroupingCategory:     GroupingCategory;
    GroupingCode?:        number;
    TaxonomyCode?:        number;
}

export enum GroupingCategory {
    Ga = "GA",
    Gm = "GM",
    Gr = "GR",
}

export interface TaxTable {
    TaxTableEntry: TaxTableEntry[];
}

export interface TaxTableEntry {
    TaxType:          string;
    TaxCountryRegion: Country;
    TaxCode:          string;
    Description:      string;
    TaxPercentage:    number;
}

export interface SourceDocuments {
    Payments: GeneralLedgerEntries;
}
