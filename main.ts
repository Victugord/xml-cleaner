import fs from 'fs-extra'
import {XMLParser, XMLBuilder, XMLValidator, X2jOptionsOptional} from 'fast-xml-parser'

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

//loop all files in folder safts

const folder = 'safts';
const files = fs.readdirSync(folder);
for (const file of files) {
	// read file from safts folder
	const xml = fs.readFileSync('safts/'+file, 'latin1');

	let jsonObj = parser.parse(xml);

	// console.log({jsonObj});

// write file to safts-output folder

	fs.writeJsonSync('safts-output/'+file+'.json', jsonObj, {spaces: 0});
}




