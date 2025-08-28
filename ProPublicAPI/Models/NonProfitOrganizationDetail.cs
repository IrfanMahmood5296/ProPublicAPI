using Newtonsoft.Json;

namespace ProPublicAPI.Models
{
    public class FilingsWithDatum
    {
        [JsonProperty("tax_prd")]
        public int? TaxPrd { get; set; }

        [JsonProperty("tax_prd_yr")]
        public int? TaxPrdYr { get; set; }

        [JsonProperty("formtype")]
        public int? Formtype { get; set; }

        [JsonProperty("pdf_url")]
        public string? PdfUrl { get; set; }

        [JsonProperty("updated")]
        public DateTime? Updated { get; set; }

        [JsonProperty("totrevenue")]
        public object? Totrevenue { get; set; }

        [JsonProperty("totfuncexpns")]
        public object? Totfuncexpns { get; set; }

        [JsonProperty("totassetsend")]
        public object? Totassetsend { get; set; }

        [JsonProperty("totliabend")]
        public object? Totliabend { get; set; }

        [JsonProperty("pct_compnsatncurrofcr")]
        public double? PctCompnsatncurrofcr { get; set; }

        [JsonProperty("tax_pd")]
        public object? TaxPd { get; set; }

        [JsonProperty("subseccd")]
        public int? Subseccd { get; set; }

        [JsonProperty("unrelbusinccd")]
        public string? Unrelbusinccd { get; set; }

        [JsonProperty("initiationfees")]
        public int? Initiationfees { get; set; }

        [JsonProperty("grsrcptspublicuse")]
        public int? Grsrcptspublicuse { get; set; }

        [JsonProperty("grsincmembers")]
        public int? Grsincmembers { get; set; }

        [JsonProperty("grsincother")]
        public int? Grsincother { get; set; }

        [JsonProperty("totcntrbgfts")]
        public int? Totcntrbgfts { get; set; }

        [JsonProperty("totprgmrevnue")]
        public object? Totprgmrevnue { get; set; }

        [JsonProperty("invstmntinc")]
        public int? Invstmntinc { get; set; }

        [JsonProperty("txexmptbndsproceeds")]
        public int? Txexmptbndsproceeds { get; set; }

        [JsonProperty("royaltsinc")]
        public int? Royaltsinc { get; set; }

        [JsonProperty("grsrntsreal")]
        public int? Grsrntsreal { get; set; }

        [JsonProperty("grsrntsprsnl")]
        public int? Grsrntsprsnl { get; set; }

        [JsonProperty("rntlexpnsreal")]
        public int? Rntlexpnsreal { get; set; }

        [JsonProperty("rntlexpnsprsnl")]
        public int? Rntlexpnsprsnl { get; set; }

        [JsonProperty("rntlincreal")]
        public int? Rntlincreal { get; set; }

        [JsonProperty("rntlincprsnl")]
        public int? Rntlincprsnl { get; set; }

        [JsonProperty("netrntlinc")]
        public int? Netrntlinc { get; set; }

        [JsonProperty("grsalesecur")]
        public object? Grsalesecur { get; set; }

        [JsonProperty("grsalesothr")]
        public int? Grsalesothr { get; set; }

        [JsonProperty("cstbasisecur")]
        public object? Cstbasisecur { get; set; }

        [JsonProperty("cstbasisothr")]
        public int? Cstbasisothr { get; set; }

        [JsonProperty("gnlsecur")]
        public int? Gnlsecur { get; set; }

        [JsonProperty("gnlsothr")]
        public int? Gnlsothr { get; set; }

        [JsonProperty("netgnls")]
        public int? Netgnls { get; set; }

        [JsonProperty("grsincfndrsng")]
        public int? Grsincfndrsng { get; set; }

        [JsonProperty("lessdirfndrsng")]
        public int? Lessdirfndrsng { get; set; }

        [JsonProperty("netincfndrsng")]
        public int? Netincfndrsng { get; set; }

        [JsonProperty("grsincgaming")]
        public int? Grsincgaming { get; set; }

        [JsonProperty("lessdirgaming")]
        public int? Lessdirgaming { get; set; }

        [JsonProperty("netincgaming")]
        public int? Netincgaming { get; set; }

        [JsonProperty("grsalesinvent")]
        public int? Grsalesinvent { get; set; }

        [JsonProperty("lesscstofgoods")]
        public int? Lesscstofgoods { get; set; }

        [JsonProperty("netincsales")]
        public int? Netincsales { get; set; }

        [JsonProperty("miscrevtot11e")]
        public int? Miscrevtot11e { get; set; }

        [JsonProperty("compnsatncurrofcr")]
        public int? Compnsatncurrofcr { get; set; }

        [JsonProperty("othrsalwages")]
        public object? Othrsalwages { get; set; }

        [JsonProperty("payrolltx")]
        public int? Payrolltx { get; set; }

        [JsonProperty("profndraising")]
        public int? Profndraising { get; set; }

        [JsonProperty("txexmptbndsend")]
        public int? Txexmptbndsend { get; set; }

        [JsonProperty("secrdmrtgsend")]
        public int? Secrdmrtgsend { get; set; }

        [JsonProperty("unsecurednotesend")]
        public int? Unsecurednotesend { get; set; }

        [JsonProperty("retainedearnend")]
        public object? Retainedearnend { get; set; }

        [JsonProperty("totnetassetend")]
        public object? Totnetassetend { get; set; }

        [JsonProperty("nonpfrea")]
        public string? Nonpfrea { get; set; }

        [JsonProperty("gftgrntsrcvd170")]
        public int? Gftgrntsrcvd170 { get; set; }

        [JsonProperty("txrevnuelevied170")]
        public int? Txrevnuelevied170 { get; set; }

        [JsonProperty("srvcsval170")]
        public int? Srvcsval170 { get; set; }

        [JsonProperty("grsinc170")]
        public int? Grsinc170 { get; set; }

        [JsonProperty("grsrcptsrelated170")]
        public int? Grsrcptsrelated170 { get; set; }

        [JsonProperty("totgftgrntrcvd509")]
        public int? Totgftgrntrcvd509 { get; set; }

        [JsonProperty("grsrcptsadmissn509")]
        public object? Grsrcptsadmissn509 { get; set; }

        [JsonProperty("txrevnuelevied509")]
        public int? Txrevnuelevied509 { get; set; }

        [JsonProperty("srvcsval509")]
        public int? Srvcsval509 { get; set; }

        [JsonProperty("subtotsuppinc509")]
        public int? Subtotsuppinc509 { get; set; }

        [JsonProperty("totsupp509")]
        public object? Totsupp509 { get; set; }

        [JsonProperty("ein")]
        public int? Ein { get; set; }
    }

    public class FilingsWithoutDatum
    {
        [JsonProperty("tax_prd")]
        public int? TaxPrd { get; set; }

        [JsonProperty("tax_prd_yr")]
        public int? TaxPrdYr { get; set; }

        [JsonProperty("formtype")]
        public int? Formtype { get; set; }

        [JsonProperty("formtype_str")]
        public string? FormtypeStr { get; set; }

        [JsonProperty("pdf_url")]
        public string? PdfUrl { get; set; }
    }

    public class OrganizationInfo
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("ein")]
        public int? Ein { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("careofname")]
        public string? Careofname { get; set; }

        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("zipcode")]
        public string? Zipcode { get; set; }

        [JsonProperty("exemption_number")]
        public int? ExemptionNumber { get; set; }

        [JsonProperty("subsection_code")]
        public int? SubsectionCode { get; set; }

        [JsonProperty("affiliation_code")]
        public int? AffiliationCode { get; set; }

        [JsonProperty("classification_codes")]
        public string? ClassificationCodes { get; set; }

        [JsonProperty("ruling_date")]
        public string? RulingDate { get; set; }

        [JsonProperty("deductibility_code")]
        public int? DeductibilityCode { get; set; }

        [JsonProperty("foundation_code")]
        public int? FoundationCode { get; set; }

        [JsonProperty("activity_codes")]
        public string? ActivityCodes { get; set; }

        [JsonProperty("organization_code")]
        public int? OrganizationCode { get; set; }

        [JsonProperty("exempt_organization_status_code")]
        public int? ExemptOrganizationStatusCode { get; set; }

        [JsonProperty("tax_period")]
        public string? TaxPeriod { get; set; }

        [JsonProperty("asset_code")]
        public int? AssetCode { get; set; }

        [JsonProperty("income_code")]
        public int? IncomeCode { get; set; }

        [JsonProperty("filing_requirement_code")]
        public int? FilingRequirementCode { get; set; }

        [JsonProperty("pf_filing_requirement_code")]
        public int? PfFilingRequirementCode { get; set; }

        [JsonProperty("accounting_period")]
        public int? AccountingPeriod { get; set; }

        [JsonProperty("asset_amount")]
        public long? AssetAmount { get; set; }

        [JsonProperty("income_amount")]
        public long? IncomeAmount { get; set; }

        [JsonProperty("revenue_amount")]
        public long? RevenueAmount { get; set; }

        [JsonProperty("ntee_code")]
        public string? NteeCode { get; set; }

        [JsonProperty("sort_name")]
        public object? SortName { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("data_source")]
        public string? DataSource { get; set; }

        [JsonProperty("have_extracts")]
        public object? HaveExtracts { get; set; }

        [JsonProperty("have_pdfs")]
        public object? HavePdfs { get; set; }

        [JsonProperty("latest_object_id")]
        public string? LatestObjectId { get; set; }
    }

    public class NonProfitOrganizationDetail
    {
        [JsonProperty("organization")]
        public OrganizationInfo? Organization { get; set; }

        [JsonProperty("filings_with_data")]
        public List<FilingsWithDatum>? FilingsWithData { get; set; }

        [JsonProperty("filings_without_data")]
        public List<FilingsWithoutDatum>? FilingsWithoutData { get; set; }

        [JsonProperty("data_source")]
        public string? DataSource { get; set; }

        [JsonProperty("api_version")]
        public int? ApiVersion { get; set; }
    }

}
