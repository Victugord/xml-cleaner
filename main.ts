import fs from 'fs-extra'
import {XMLParser, XMLBuilder, XMLValidator, X2jOptionsOptional} from 'fast-xml-parser'
import {Saft1} from "./saft-1";
import {json} from "stream/consumers";

const alwaysArray = [
	"AuditFile.SourceDocuments.Payments.Payment.Line",
	"AuditFile.GeneralLedgerEntries.Journal.Transaction",
	"AuditFile.GeneralLedgerEntries.Journal.Transaction.Lines.DebitLine",
	"AuditFile.GeneralLedgerEntries.Journal.Transaction.Lines.CreditLine",

];
const options: X2jOptionsOptional = {
	ignoreAttributes: true,
	isArray: (name, jpath, isLeafNode, isAttribute) => {
		return alwaysArray.indexOf(jpath) !== -1;
	}
};
const parser = new XMLParser(options);
const builder = new XMLBuilder({ignoreAttributes: true});
//loop all files in folder safts

const folder = 'safts';
const files = fs.readdirSync(folder);
const multiplier = 1.71;
for (const file of files) {
	// read file from safts folder
	const xml = fs.readFileSync('safts/' + file, 'latin1');

	let jsonObj: Saft1 = parser.parse(xml);

	jsonObj.AuditFile.GeneralLedgerEntries.TotalCredit *= multiplier;
	jsonObj.AuditFile.GeneralLedgerEntries.TotalDebit *= multiplier;

	if (jsonObj.AuditFile.GeneralLedgerEntries.Journal) {
		jsonObj.AuditFile.GeneralLedgerEntries.Journal.forEach(journal => {
			journal.Transaction?.map(transaction => {
				transaction.Lines.DebitLine?.map(debitLine => {
					if (debitLine.DebitAmount) {
						debitLine.DebitAmount *= multiplier;
					}
				});
				transaction.Lines.CreditLine?.map(creditLine => {
					if (creditLine.CreditAmount) {
						creditLine.CreditAmount *= multiplier;
					}
				});

			});
		})

		if (jsonObj.AuditFile.GeneralLedgerEntries.Payment) {
			jsonObj.AuditFile.GeneralLedgerEntries.Payment.forEach(payment => {
				payment.Line?.map(line => {
					if (line.CreditAmount) {
						line.CreditAmount *= multiplier;
					}
				});

				payment.DocumentTotals.GrossTotal *= multiplier;
				payment.DocumentTotals.NetTotal *= multiplier;
				payment.DocumentTotals.Settlement.SettlementAmount *= multiplier;
			});
		}

		if (jsonObj.AuditFile.SourceDocuments.Payments.Payment) {
			jsonObj.AuditFile.SourceDocuments.Payments.Payment.forEach(payment => {
				payment?.Line.map(line => {
					line.CreditAmount *= multiplier;
					line.SettlementAmount *= multiplier;
				});

			})
		}

		jsonObj.AuditFile.SourceDocuments.Payments.TotalCredit *= multiplier;
		jsonObj.AuditFile.SourceDocuments.Payments.TotalDebit *= multiplier;


		if(jsonObj.AuditFile.SourceDocuments.Payments.Payment)
		{
			jsonObj.AuditFile.SourceDocuments.Payments.Payment.forEach(payment => {
				payment?.Line.map(line => {
					line.CreditAmount *= multiplier;
				});
			})
		}

		if (jsonObj.AuditFile.MasterFiles.GeneralLedgerAccounts.Account) {
			jsonObj.AuditFile.MasterFiles.GeneralLedgerAccounts.Account.forEach(account => {
				account.OpeningDebitBalance *= multiplier;
				account.OpeningCreditBalance *= multiplier;
				account.ClosingCreditBalance *= multiplier;
				account.ClosingDebitBalance *= multiplier;
			})
		}
	}


// write file to safts-output folder

	fs.writeJsonSync('safts-output/' + file + '.json', jsonObj, {spaces: 0});


	let xmlDataStr = builder.build(jsonObj);

	xmlDataStr = xmlDataStr.replace('<?xml></?xml>', '<?xml version="1.0" encoding="utf8"?>');

	fs.writeFileSync('safts-output/' + file + '.xml', xmlDataStr, {encoding: 'latin1'});

}




