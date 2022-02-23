import { Selector, t } from 'testcafe'
import { createRegExp } from '../../helpers/regExp-helper'
import randomString from '../../helpers/random-string'
import loadingHelper from '../../helpers/loading-helper'
import { scrollIntoView } from '../../helpers/element-helper'

class SupplierDetailsPage {
	activeToggle: Selector
	nameField: Selector
	currencySelector: Selector
	currencyOptions: Selector
	standardProductTypeCheckbox: Selector
	quoteProductTypeCheckbox: Selector
	purchaseOrderProductTypeCheckbox: Selector
	testerProductTypeCheckbox: Selector
	USCountryCheckbox: Selector
	CACountryCheckbox: Selector
	freightPOPToggle: Selector
	createButton: Selector
	mainCatgorySelector: Selector
	mainCategoryOptionsSelector: Selector
	subCategorySelector: Selector
	subCategoryOptionsSelector: Selector
	addCategoryButton: Selector

	constructor() {
		this.activeToggle = Selector('#Active').parent()
		this.nameField = Selector('#Name')
		this.currencySelector = Selector('#Currency')
		this.currencyOptions = this.currencySelector.find('option')
		this.standardProductTypeCheckbox = Selector('#Standard').parent()
		this.quoteProductTypeCheckbox = Selector('#Quote').parent()
		this.purchaseOrderProductTypeCheckbox = Selector(
			'#PurchaseOrder'
		).parent()
		this.testerProductTypeCheckbox = Selector('#Tester').parent()
		this.USCountryCheckbox = Selector('#US').parent()
		this.CACountryCheckbox = Selector('#CA').parent()
		this.freightPOPToggle = Selector('#SyncFreightPop').parent()
		this.createButton = Selector('button')
			.withText(createRegExp('create'))
			.withAttribute('type', 'submit')
		this.mainCatgorySelector = Selector('supplier-category-select-component')
			.find('select')
			.nth(0)
		this.mainCategoryOptionsSelector = this.mainCatgorySelector.find('option')
		this.subCategorySelector = Selector('supplier-category-select-component')
			.find('select')
			.nth(1)
		this.subCategoryOptionsSelector = this.subCategorySelector.find('option')
		this.addCategoryButton = Selector('button').withText(
			createRegExp('add category')
		)
	}

	async createDefaultSupplier() {
		const supplierName = `AutomationSupplier_${randomString(5)}`
		await t.typeText(this.nameField, supplierName)
		await t.click(this.currencySelector)
		await t.click(
			this.currencyOptions.withText(createRegExp('united states dollar'))
		)
		await t.click(this.standardProductTypeCheckbox)
		await await scrollIntoView('.form-control.ng-untouched.ng-pristine.ng-valid')
		// await t.click(this.USCountryCheckbox)
		await t.click(this.createButton)

		await loadingHelper.thisWait()

		return supplierName
	}

	//active, names, currency, product type, category
	async createSupplier(
		active: boolean,
		name: string,
		currency: string,
		productType: string[],
		mainCategory: string,
		subCategory: string
	) {
		if (active) {
			await t.click(this.activeToggle)
		}
		await t.typeText(this.nameField, name)
		await t.click(this.currencySelector)
		await t.click(this.currencyOptions.withText(createRegExp(currency)))
		await t.click(this.freightPOPToggle)
		if (productType.includes('Standard')) {
			await t.click(this.standardProductTypeCheckbox)
		}
		if (productType.includes('Quote')) {
			await t.click(this.quoteProductTypeCheckbox)
		}
		if (productType.includes('Purchase Order')) {
			await t.click(this.purchaseOrderProductTypeCheckbox)
		}
		if (productType.includes('Tester')) {
			await t.click(this.testerProductTypeCheckbox)
		}
		await await scrollIntoView('supplier-category-select-component')
		await t.click(this.addCategoryButton)
		await t.click(this.mainCatgorySelector)
		await t.click(
			this.mainCategoryOptionsSelector.withText(createRegExp(mainCategory))
		)
		await t.click(this.subCategorySelector)
		await t.click(
			this.subCategoryOptionsSelector.withText(createRegExp(subCategory))
		)

		await t.click(this.createButton)

		await loadingHelper.thisWait()
	}
}

export default new SupplierDetailsPage()
